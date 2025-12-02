# Test DNS Resolution cho Internal DNS Server
# DTDM Cloud Computing Project

Write-Host "🧪 TESTING INTERNAL DNS SERVER" -ForegroundColor Cyan
Write-Host "=================================" -ForegroundColor Cyan

$services = @(
    @{Name="web-frontend-server"; Expected="10.10.10.10"},
    @{Name="app-backend.cloud.local"; Expected="10.10.10.20"},
    @{Name="minio.cloud.local"; Expected="10.10.10.30"},
    @{Name="keycloak.cloud.local"; Expected="10.10.10.40"}
)

$dnsServer = "127.0.0.1"
$results = @()

foreach ($service in $services) {
    Write-Host "`n🔍 Testing: $($service.Name)" -ForegroundColor Yellow

    try {
        # Test DNS resolution
        $dnsResult = Resolve-DnsName -Name $service.Name -Server $dnsServer -Type A -ErrorAction Stop

        $resolvedIP = $dnsResult.IPAddress
        $expectedIP = $service.Expected

        if ($resolvedIP -eq $expectedIP) {
            Write-Host "  ✅ SUCCESS: $($service.Name) → $resolvedIP" -ForegroundColor Green
            $results += @{Service=$service.Name; Status="PASS"; IP=$resolvedIP}
        } else {
            Write-Host "  ❌ MISMATCH: Expected $expectedIP, got $resolvedIP" -ForegroundColor Red
            $results += @{Service=$service.Name; Status="MISMATCH"; IP=$resolvedIP}
        }
    }
    catch {
        Write-Host "  ❌ FAILED: $($service.Name) - $($_.Exception.Message)" -ForegroundColor Red
        $results += @{Service=$service.Name; Status="FAILED"; IP="N/A"}
    }
}

# Summary
Write-Host "`n📊 DNS TEST SUMMARY" -ForegroundColor Cyan
Write-Host "===================" -ForegroundColor Cyan

$passed = ($results | Where-Object { $_.Status -eq "PASS" }).Count
$total = $results.Count

Write-Host "Passed: $passed/$total services" -ForegroundColor $(if ($passed -eq $total) { "Green" } else { "Yellow" })

foreach ($result in $results) {
    $color = switch ($result.Status) {
        "PASS" { "Green" }
        "MISMATCH" { "Yellow" }
        "FAILED" { "Red" }
    }
    Write-Host "  $($result.Service): $($result.Status) ($($result.IP))" -ForegroundColor $color
}

if ($passed -eq $total) {
    Write-Host "`n🎉 ALL DNS TESTS PASSED! Internal DNS server is working correctly." -ForegroundColor Green
} else {
    Write-Host "`n⚠️  Some DNS tests failed. Check DNS server configuration." -ForegroundColor Yellow
}

Write-Host "`nTips:" -ForegroundColor Cyan
Write-Host "  - DNS server runs on port 1053 (not standard port 53)"
Write-Host "  - Test with: nslookup app-backend.cloud.local 127.0.0.1"
Write-Host "  - Check logs: docker compose logs internal-dns-server"
