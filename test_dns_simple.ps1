# Simple DNS Test Script
# DTDM Cloud Computing Project

Write-Host "TESTING INTERNAL DNS SERVER" -ForegroundColor Cyan
Write-Host "===========================" -ForegroundColor Cyan

$services = @(
    @{Name="web-frontend-server"; Expected="10.10.10.10"},
    @{Name="app-backend.cloud.local"; Expected="10.10.10.20"},
    @{Name="minio.cloud.local"; Expected="10.10.10.30"},
    @{Name="keycloak.cloud.local"; Expected="10.10.10.40"}
)

$dnsServer = "127.0.0.1"
$passed = 0
$total = $services.Count

foreach ($service in $services) {
    Write-Host "`nTesting: $($service.Name)" -ForegroundColor Yellow

    try {
        $dnsResult = Resolve-DnsName -Name $service.Name -Server $dnsServer -Type A -ErrorAction Stop
        $resolvedIP = $dnsResult.IPAddress
        $expectedIP = $service.Expected

        if ($resolvedIP -eq $expectedIP) {
            Write-Host "  SUCCESS: $($service.Name) -> $resolvedIP" -ForegroundColor Green
            $passed++
        } else {
            Write-Host "  MISMATCH: Expected $expectedIP, got $resolvedIP" -ForegroundColor Red
        }
    }
    catch {
        Write-Host "  FAILED: $($service.Name) - $($_.Exception.Message)" -ForegroundColor Red
    }
}

Write-Host "`nSUMMARY: $passed/$total services resolved correctly" -ForegroundColor $(if ($passed -eq $total) { "Green" } else { "Yellow" })

if ($passed -eq $total) {
    Write-Host "ALL DNS TESTS PASSED!" -ForegroundColor Green
} else {
    Write-Host "Some DNS tests failed. Check configuration." -ForegroundColor Yellow
}
