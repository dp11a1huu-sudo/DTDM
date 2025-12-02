import requests
from jose import jwt
import json
import base64

# Simple debug script
ISSUER = "http://authentication-identity-server:8080/realms/realm_sv189"
AUDIENCE = "account"
JWKS_URL = f"{ISSUER}/protocol/openid-connect/certs"

print("Simple JWT debug...")

# Get token
token_url = "http://authentication-identity-server:8080/realms/realm_sv189/protocol/openid-connect/token"
token_data = {
    "grant_type": "password",
    "client_id": "flask-app",
    "client_secret": "abc123def456",
    "username": "sv01",
    "password": "password123"
}

token_response = requests.post(token_url, data=token_data)
token = token_response.json()['access_token']

# Get JWKS
jwks_response = requests.get(JWKS_URL)
jwks = jwks_response.json()

# Decode header to get kid
header_b64 = token.split('.')[0]
header_b64 += '=' * (4 - len(header_b64) % 4)
header_data = json.loads(base64.urlsafe_b64decode(header_b64))
token_kid = header_data['kid']

print(f"Token kid: {token_kid}")
print(f"JWKS kids: {[k['kid'] for k in jwks['keys']]}")

# Try decode
try:
    payload = jwt.decode(token, jwks, algorithms=["RS256"], audience=AUDIENCE, issuer=ISSUER)
    print("SUCCESS!")
except Exception as e:
    print(f"Failed: {e}")
    try:
        payload = jwt.decode(token, jwks, algorithms=["RS256"], options={"verify_aud": False, "verify_iss": False})
        print("SUCCESS without validation!")
    except Exception as e2:
        print(f"Still failed: {e2}")
