import requests

# Test secure endpoint from within container
url = "http://0.0.0.0:8081/secure"

# Get fresh token from within container
print("Getting fresh token...")
token_url = "http://authentication-identity-server:8080/realms/realm_sv189/protocol/openid-connect/token"
token_data = {
    "grant_type": "password",
    "client_id": "flask-app",
    "client_secret": "abc123def456",
    "username": "sv01",
    "password": "password123"
}

token_response = requests.post(token_url, data=token_data)
if token_response.status_code == 200:
    token = token_response.json()['access_token']
    print("Token obtained successfully")

    headers = {"Authorization": f"Bearer {token}"}

    print("Testing /secure endpoint from container...")
    response = requests.get(url, headers=headers)

    print(f"Status: {response.status_code}")
    print(f"Response: {response.text}")
else:
    print(f"Failed to get token: {token_response.text}")
