import requests
from jose import jwt
import json

# Test JWT verification
ISSUER = "http://authentication-identity-server:8080/realms/realm_sv189"
AUDIENCE = "flask-app"
JWKS_URL = f"{ISSUER}/protocol/openid-connect/certs"

print("Testing JWT verification...")

# Get token (simulate) - use internal network URL
token_url = "http://authentication-identity-server:8080/realms/realm_sv189/protocol/openid-connect/token"
token_data = {
    "grant_type": "password",
    "client_id": "flask-app",
    "client_secret": "abc123def456",
    "username": "sv01",
    "password": "password123"
}

print("Getting token...")
token_response = requests.post(token_url, data=token_data)
if token_response.status_code != 200:
    print(f"Failed to get token: {token_response.text}")
    exit(1)

token = token_response.json()['access_token']
print(f"Token obtained: {token[:50]}...")

# Get JWKS
print("Getting JWKS...")
jwks_response = requests.get(JWKS_URL)
if jwks_response.status_code != 200:
    print(f"Failed to get JWKS: {jwks_response.text}")
    exit(1)

jwks = jwks_response.json()
print(f"JWKS keys: {len(jwks['keys'])}")

# First, decode token without validation to see its content
print("Decoding token without validation to see claims...")
try:
        # Decode without signature verification first
        import base64
        header_b64, payload_b64, signature = token.split('.')
        # Add padding if needed
        payload_b64 += '=' * (4 - len(payload_b64) % 4)
        payload_json = base64.urlsafe_b64decode(payload_b64)
        payload_data = json.loads(payload_json)
        print("Token payload:")
        print(json.dumps(payload_data, indent=2))
        print(f"Audience in token: {payload_data.get('aud', 'NOT FOUND')}")
        print(f"Issuer in token: {payload_data.get('iss', 'NOT FOUND')}")

        # Decode header to see kid
        header_b64 += '=' * (4 - len(header_b64) % 4)
        header_json = base64.urlsafe_b64decode(header_b64)
        header_data = json.loads(header_json)
        print(f"Key ID (kid) in token: {header_data.get('kid', 'NOT FOUND')}")
    except Exception as e:
        print(f"Failed to decode payload: {e}")

# Try to decode token
print("\nAttempting to decode token with signature verification...")
try:
    payload = jwt.decode(token, jwks, algorithms=["RS256"], audience=AUDIENCE, issuer=ISSUER)
    print("SUCCESS! Token decoded:")
    print(json.dumps(payload, indent=2))
except Exception as e:
    print(f"JWT decode failed: {e}")

    # Try with different audience
    print("Trying with audience='account'...")
    try:
        payload = jwt.decode(token, jwks, algorithms=["RS256"], audience="account", issuer=ISSUER)
        print("SUCCESS with audience='account'! Token decoded:")
        print(json.dumps(payload, indent=2))
    except Exception as e2:
        print(f"Still failed with account: {e2}")

        # Try without audience validation
        print("Trying without audience validation...")
        try:
            payload = jwt.decode(token, jwks, algorithms=["RS256"], issuer=ISSUER)
            print("SUCCESS without audience! Token decoded:")
            print(json.dumps(payload, indent=2))
        except Exception as e3:
            print(f"Failed completely: {e3}")

            # Try without any validation
            print("Trying without any validation...")
            try:
                payload = jwt.decode(token, jwks, algorithms=["RS256"], options={"verify_aud": False, "verify_iss": False})
                print("SUCCESS without any validation! Token decoded:")
                print(json.dumps(payload, indent=2))
            except Exception as e4:
                print(f"Failed even without validation: {e4}")

                # Check if JWKS has the right key
                print(f"\nJWKS keys available: {[k['kid'] for k in jwks['keys']]}")
                print("This suggests the key ID in token doesn't match JWKS keys.")
