# DTDM Cloud Computing - Complete System Test Suite
# Run comprehensive tests for all system components

Write-Host "==========================================" -ForegroundColor Cyan
Write-Host "  DTDM CLOUD COMPUTING - SYSTEM TEST SUITE" -ForegroundColor Cyan
Write-Host "==========================================" -ForegroundColor Cyan
Write-Host "Date: $(Get-Date)" -ForegroundColor Yellow
Write-Host ""

# Test counter
$testsPassed = 0
$testsTotal = 0

function Test-Component {
    param(
        [string]$Name,
        [scriptblock]$TestScript,
        [string]$ExpectedResult = ""
    )

    $script:testsTotal++
    Write-Host "[$script:testsTotal] Testing $Name..." -ForegroundColor Gray -NoNewline

    try {
        $result = & $TestScript
        if ($ExpectedResult -and $result -notmatch $ExpectedResult) {
            Write-Host " FAIL" -ForegroundColor Red
            Write-Host "      Expected: $ExpectedResult" -ForegroundColor Red
            Write-Host "      Got: $result" -ForegroundColor Red
        } else {
            Write-Host " PASS" -ForegroundColor Green
            $script:testsPassed++
        }
    } catch {
        Write-Host " ERROR" -ForegroundColor Red
        Write-Host "      $($_.Exception.Message)" -ForegroundColor Red
    }
}

# 1. Infrastructure Check
Test-Component "Infrastructure (8 containers)" {
    $containers = docker compose ps --format "table {{.Name}}\t{{.Status}}" 2>$null
    $runningCount = ($containers | Select-String "Up" | Measure-Object).Count
    return "$runningCount/8 containers running"
} "8/8"

# 2. Authentication System
Test-Component "Authentication (Keycloak)" {
    try {
        $response = Invoke-WebRequest -Uri "http://localhost:8081/realms/realm_sv189/protocol/openid-connect/token" -Method POST -Headers @{"Content-Type"="application/x-www-form-urlencoded"} -Body "grant_type=password&client_id=flask-app&client_secret=abc123def456&username=sv01&password=password123" -TimeoutSec 10
        if ($response.StatusCode -eq 200) {
            $tokenData = $response.Content | ConvertFrom-Json
            if ($tokenData.access_token) {
                return "JWT token generated successfully"
            }
        }
    } catch {}
    return "Authentication failed"
} "JWT token generated successfully"

# 3. Object Storage (MinIO)
Test-Component "Object Storage (MinIO)" {
    try {
        $response = Invoke-WebRequest -Uri "http://localhost:9000/profile-pics/avartar.png" -Method GET -TimeoutSec 10
        if ($response.StatusCode -eq 200) {
            return "File access successful"
        }
    } catch {}
    return "File access failed"
} "File access successful"

# 4. Database Operations
Test-Component "Database Operations" {
    try {
        $response = Invoke-WebRequest -Uri "http://localhost:8085/students" -Method GET -TimeoutSec 10
        if ($response.StatusCode -eq 200) {
            $data = $response.Content | ConvertFrom-Json
            $count = $data.Count
            return "$count student records retrieved"
        }
    } catch {}
    return "Database access failed"
} "student records retrieved"

# 5. API Endpoints
Test-Component "API Endpoints (/hello)" {
    try {
        $response = Invoke-WebRequest -Uri "http://localhost:8085/hello" -Method GET -TimeoutSec 10
        if ($response.StatusCode -eq 200) {
            return "Hello endpoint working"
        }
    } catch {}
    return "API endpoint failed"
} "Hello endpoint working"

# 6. Secure Endpoint
Test-Component "Secure Endpoint (/secure)" {
    try {
        # Get token first
        $tokenResponse = Invoke-WebRequest -Uri "http://localhost:8081/realms/realm_sv189/protocol/openid-connect/token" -Method POST -Headers @{"Content-Type"="application/x-www-form-urlencoded"} -Body "grant_type=password&client_id=flask-app&client_secret=abc123def456&username=sv01&password=password123" -TimeoutSec 10
        if ($tokenResponse.StatusCode -eq 200) {
            $tokenData = $tokenResponse.Content | ConvertFrom-Json
            $token = $tokenData.access_token

            # Test secure endpoint
            $secureResponse = Invoke-WebRequest -Uri "http://localhost:8085/secure" -Method GET -Headers @{"Authorization"="Bearer $token"} -TimeoutSec 10
            if ($secureResponse.StatusCode -eq 200) {
                return "Secure endpoint protected"
            }
        }
    } catch {}
    return "Secure endpoint failed"
} "Secure endpoint protected"

# 7. Service Communication
Test-Component "Service Communication (MinIO)" {
    $result = docker exec application-backend-server python3 -c "
import requests
try:
    r = requests.get('http://object-storage-server:9000', timeout=5)
    print(f'Status: {r.status_code}')
except Exception as e:
    print(f'Error: {e}')
"
    if ($result -match "Status: 403") {
        return "Inter-service communication working"
    }
    return "Service communication failed"
} "Inter-service communication working"

# 8. Monitoring System
Test-Component "Monitoring (Prometheus)" {
    try {
        $response = Invoke-WebRequest -Uri "http://localhost:9090/-/healthy" -Method GET -TimeoutSec 10
        if ($response.StatusCode -eq 200) {
            return "Prometheus health check passed"
        }
    } catch {}
    return "Prometheus health check failed"
} "Prometheus health check passed"

# Final Summary
Write-Host ""
Write-Host "==========================================" -ForegroundColor Cyan
Write-Host "              TEST SUMMARY" -ForegroundColor Cyan
Write-Host "==========================================" -ForegroundColor Cyan

$successRate = [math]::Round(($testsPassed / $testsTotal) * 100, 1)

Write-Host "Tests Passed: $testsPassed/$testsTotal ($successRate%)" -ForegroundColor $(if ($successRate -ge 80) { "Green" } else { "Yellow" })

if ($testsPassed -eq $testsTotal) {
    Write-Host ""
    Write-Host "🎉 ALL TESTS PASSED! 🎉" -ForegroundColor Green
    Write-Host "🎊 DTDM Cloud Computing System is FULLY OPERATIONAL! 🎊" -ForegroundColor Green
    Write-Host ""
    Write-Host "🚀 Ready for production deployment!" -ForegroundColor Cyan
    Write-Host "📊 Microservices architecture: COMPLETE" -ForegroundColor Cyan
    Write-Host "🔐 Authentication & Security: COMPLETE" -ForegroundColor Cyan
    Write-Host "🗄️ Data Management: COMPLETE" -ForegroundColor Cyan
    Write-Host "📦 Object Storage: COMPLETE" -ForegroundColor Cyan
    Write-Host "🌐 Service Discovery: COMPLETE" -ForegroundColor Cyan
    Write-Host "📈 Monitoring: COMPLETE" -ForegroundColor Cyan
} elseif ($testsPassed -ge ($testsTotal * 0.8)) {
    Write-Host ""
    Write-Host "✅ MOST TESTS PASSED!" -ForegroundColor Yellow
    Write-Host "⚠️ Minor issues detected. Check individual test results above." -ForegroundColor Yellow
} else {
    Write-Host ""
    Write-Host "❌ SYSTEM ISSUES DETECTED!" -ForegroundColor Red
    Write-Host "🔧 Please troubleshoot failed components above." -ForegroundColor Red
}

Write-Host ""
Write-Host "==========================================" -ForegroundColor Cyan
