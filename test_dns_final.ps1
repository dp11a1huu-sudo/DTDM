# Comprehensive DNS Test for DTDM Project
# Test DNS resolution from application container

Write-Host "DTDM DNS TEST SUITE" -ForegroundColor Cyan
Write-Host "===================" -ForegroundColor Cyan

Write-Host "`n1. Checking DNS Server Status..." -ForegroundColor Yellow
try {
    $dnsStatus = docker compose ps internal-dns-server --format "table {{.Name}}\t{{.Status}}"
    Write-Host "DNS Server Status:" -ForegroundColor Green
    Write-Host $dnsStatus
} catch {
    Write-Host "Failed to check DNS status: $($_.Exception.Message)" -ForegroundColor Red
}

Write-Host "`n2. Testing DNS Resolution from Application Container..." -ForegroundColor Yellow

$services = @(
    @{Name="app-backend.cloud.local"; Expected="10.10.10.20"},
    @{Name="minio.cloud.local"; Expected="10.10.10.30"},
    @{Name="keycloak.cloud.local"; Expected="10.10.10.40"},
    @{Name="web-frontend-server"; Expected="10.10.10.10"}
)

$passed = 0
$total = $services.Count

foreach ($service in $services) {
    Write-Host "`n  Testing $($service.Name)..." -ForegroundColor Gray

    try {
        # Test DNS resolution from application container
        $result = docker exec application-backend-server nslookup $service.Name internal-dns-server 2>&1

        if ($result -match $service.Expected) {
            Write-Host "    SUCCESS: $($service.Name) -> $($service.Expected)" -ForegroundColor Green
            $passed++
        } elseif ($result -match "NXDOMAIN") {
            Write-Host "    NXDOMAIN: Domain not found" -ForegroundColor Red
        } elseif ($result -match "connection timed out") {
            Write-Host "    TIMEOUT: Cannot reach DNS server" -ForegroundColor Red
        } else {
            Write-Host "    UNKNOWN: $($result)" -ForegroundColor Yellow
        }
    } catch {
        Write-Host "    ERROR: $($_.Exception.Message)" -ForegroundColor Red
    }
}

Write-Host "`nFINAL RESULTS: $passed/$total services resolved" -ForegroundColor $(if ($passed -eq $total) { "Green" } else { "Yellow" })

if ($passed -eq $total) {
    Write-Host "`nALL DNS TESTS PASSED!" -ForegroundColor Green
    Write-Host "Internal DNS server is working correctly for service discovery." -ForegroundColor Green
} elseif ($passed -gt 0) {
    Write-Host "`nPARTIAL SUCCESS: DNS working but some services not resolved." -ForegroundColor Yellow
} else {
    Write-Host "`nDNS NOT WORKING: Check DNS server configuration." -ForegroundColor Red
}

Write-Host "`nNext Steps:" -ForegroundColor Cyan
Write-Host "  - DNS serves internal container communication"
Write-Host "  - Applications use domain names instead of IP addresses"
Write-Host "  - External access still uses localhost ports"
Write-Host "  - Example: curl http://minio.cloud.local:9000 (from container)"
