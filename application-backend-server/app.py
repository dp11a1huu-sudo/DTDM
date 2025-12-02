from flask import Flask, jsonify, request
import mysql.connector
import time, requests, os, json 
from jose import jwt

ISSUER = os.getenv("OIDC_ISSUER", "http://authentication-identity-server:8080/realms/master")
AUDIENCE = os.getenv("OIDC_AUDIENCE", "myapp")
JWKS_URL = f"{ISSUER}/protocol/openid-connect/certs"
JWKS = None; _TS = 0

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
            db = mysql.connector.connect(
                host="relational-database-server",
                user="root",
                password="root",
                database="minicloud"   # FIXED DB NAME
            )
            print("✔ Database connected")
            return db
        except Exception as e:
            print(" Waiting for database...", e)
            time.sleep(3)
    raise Exception(" Cannot connect to database")

db = connect_db()

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
        # For debugging - skip signature verification completely
        # payload = jwt.decode(token, get_jwks(), algorithms=["RS256"], audience=AUDIENCE, issuer=ISSUER)
        # return jsonify(message="Secure resource OK", preferred_username=payload.get("preferred_username"))

        # TEMPORARY: Skip all validation for testing - BUILD TIME: 2025-11-27
        import base64
        header_b64, payload_b64, signature = token.split('.')
        payload_b64 += '=' * (4 - len(payload_b64) % 4)
        payload_json = base64.urlsafe_b64decode(payload_b64)
        payload = json.loads(payload_json)

        # Basic checks
        if payload.get("aud") == AUDIENCE:
            return jsonify(message="Secure resource OK (DEBUG MODE - UPDATED)", preferred_username=payload.get("preferred_username"))
        else:
            return jsonify(error=f"Invalid audience: {payload.get('aud')}"), 401

    except Exception as e:
        return jsonify(error=f"Token decode failed: {str(e)}"), 401

@app.get("/student")
def student_from_file():
    with open("students.json", "r", encoding="utf-8") as f:
        return jsonify(json.load(f))

@app.get("/students")
def student_from_db():
    cur = db.cursor(dictionary=True)
    cur.execute("SELECT * FROM students")
    data = cur.fetchall()
    cur.close()
    return jsonify(data)

if __name__ == "__main__":
    app.run(host="0.0.0.0", port=8081, debug=True)

