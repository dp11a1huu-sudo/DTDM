function Get-KeycloakToken {
    param(
        [string]$RealmId = "realm_sv189",
        [string]$ClientId = "flask-app",
        [string]$ClientSecret = "abc123def456",
        [string]$Username = "sv01",
        [string]$Password = "password123"
    )

    $uri = "http://localhost:8081/realms/$RealmId/protocol/openid-connect/token"
    $body = "grant_type=password&client_id=$ClientId&client_secret=$ClientSecret&username=$Username&password=$Password"

    try {
        $response = Invoke-WebRequest -Uri $uri -Method POST -Headers @{"Content-Type"="application/x-www-form-urlencoded"} -Body $body
        $tokenData = $response.Content | ConvertFrom-Json
        return $tokenData.access_token
    }
    catch {
        Write-Error "Failed to get token: $($_.Exception.Message)"
        return $null
    }
}

# Usage example:
# $token = Get-KeycloakToken
# Write-Host "Token: $token"
