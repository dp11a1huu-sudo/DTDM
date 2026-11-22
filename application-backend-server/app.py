from flask import Flask, jsonify, request
import mysql.connector
import time, requests, os, json
from jose import jwt

ISSUER = os.getenv("OIDC_ISSUER", "http://authentication-identity-server:8080/realms/master")
# Issuer thực tế ghi trong token: Keycloak phát hành theo URL mà client truy cập
# (ở đây client lấy token qua http://localhost:8081 nên iss = localhost:8081).
ISSUER_EXPECTED = os.getenv("OIDC_ISSUER_EXPECTED", ISSUER)
AUDIENCE = os.getenv("OIDC_AUDIENCE", "myapp")
JWKS_URL = f"{ISSUER}/protocol/openid-connect/certs"
JWKS = None; _TS = 0
DB_NAME = os.getenv("DB_NAME", "studentdb")
DISABLE_DB = os.getenv("DISABLE_DB", "0")
BASE_DIR = os.path.dirname(os.path.abspath(__file__))
DB_HOST = os.getenv("DB_HOST", "relational-database-server")
DB_ENGINE = os.getenv("DB_ENGINE", "mysql")
DB_USER = os.getenv("DB_USER", "sa")
DB_PASSWORD = os.getenv("DB_PASSWORD", "")
DB_PORT = os.getenv("DB_PORT", "")
DB_DRIVER = os.getenv("DB_DRIVER", "ODBC Driver 18 for SQL Server")
DB_INSTANCE = os.getenv("DB_INSTANCE", "")
PORT = int(os.getenv("PORT", "8081"))

def get_jwks():
    global JWKS, _TS
    now = time.time()
    # Force refresh every time for debugging (remove cache)
    # if not JWKS or now - _TS > 600:
    JWKS = requests.get(JWKS_URL, timeout=5).json()
    _TS = now
    return JWKS

def connect_db():
    for i in range(20):
        try:
            if DB_ENGINE == "mssql":
                import pyodbc
                server = DB_HOST
                if DB_INSTANCE:
                    server = f"{server}\\{DB_INSTANCE}"
                if DB_PORT:
                    server = f"{server},{DB_PORT}"
                if DB_USER and DB_PASSWORD:
                    conn_str = f"DRIVER={{{DB_DRIVER}}};SERVER={server};DATABASE={DB_NAME};UID={DB_USER};PWD={DB_PASSWORD};TrustServerCertificate=yes"
                else:
                    conn_str = f"DRIVER={{{DB_DRIVER}}};SERVER={server};DATABASE={DB_NAME};Trusted_Connection=yes;TrustServerCertificate=yes"
                db = pyodbc.connect(conn_str)
                return db
            else:
                db = mysql.connector.connect(
                    host=DB_HOST,
                    user="root",
                    password="root",
                    database=DB_NAME
                )
                return db
        except Exception as e:
            print(" Waiting for database...", e)
            time.sleep(3)
    raise Exception(" Cannot connect to database")

db = None

app = Flask(__name__)

@app.get("/hello")
def hello():
    return jsonify(message="Hello from Backend!")

@app.get("/secure")
def secure():
    auth = request.headers.get("Authorization", "")
    if not auth.startswith("Bearer "):
        return jsonify(error="Missing Bearer token"), 401
    token = auth.split(" ", 1)[1]
    try:
        # Kiểm tra thật: verify chữ ký RS256 bằng JWKS + audience + issuer
        payload = jwt.decode(token, get_jwks(), algorithms=["RS256"], audience=AUDIENCE, issuer=ISSUER_EXPECTED)
        return jsonify(message="Secure resource OK", preferred_username=payload.get("preferred_username"))

    except Exception as e:
        return jsonify(error=f"Token validation failed: {str(e)}"), 401

@app.get("/student")
def student_from_file():
    with open(os.path.join(BASE_DIR, "students.json"), "r", encoding="utf-8") as f:
        return jsonify(json.load(f))

@app.get("/students")
def student_from_db():
    global db
    if DISABLE_DB == "1":
        return jsonify(error="Database disabled"), 503
    if db is None:
        db = connect_db()
    if DB_ENGINE == "mssql":
        cur = db.cursor()
        cur.execute("SELECT * FROM students")
        cols = [d[0] for d in cur.description]
        rows = cur.fetchall()
        data = [dict(zip(cols, row)) for row in rows]
        cur.close()
        return jsonify(data)
    else:
        cur = db.cursor(dictionary=True)
        cur.execute("SELECT * FROM students")
        data = cur.fetchall()
        cur.close()
        return jsonify(data)

if __name__ == "__main__":
    app.run(host="0.0.0.0", port=PORT, debug=True)
