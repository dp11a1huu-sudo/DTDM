# Script tu dong them logo DUKA_logo.jpg vao Resources.resx
# Su dung: Dat file DUKA_logo.jpg vao thu muc GUI, sau do chay script nay

$logoPath = Join-Path $PSScriptRoot "DUKA_logo.jpg"
$resxPath = Join-Path $PSScriptRoot "Properties\Resources.resx"

Write-Host "Script them logo DUKA_logo.jpg vao Resources.resx" -ForegroundColor Green
Write-Host "=================================================" -ForegroundColor Green
Write-Host ""

# Kiem tra file logo co ton tai khong
if (-not (Test-Path $logoPath)) {
    Write-Host "LOI: Khong tim thay file logo tai: $logoPath" -ForegroundColor Red
    Write-Host "Vui long dat file DUKA_logo.jpg vao thu muc GUI" -ForegroundColor Yellow
    Read-Host "Nhan Enter de thoat"
    exit 1
}

Write-Host "Da tim thay file logo: $logoPath" -ForegroundColor Green

# Doc file logo va convert sang base64
Write-Host "Dang chuyen doi hinh anh sang base64..." -ForegroundColor Yellow
$imageBytes = [System.IO.File]::ReadAllBytes($logoPath)
$base64String = [System.Convert]::ToBase64String($imageBytes)
Write-Host "Da chuyen doi thanh cong! Do dai: $($base64String.Length) ky tu" -ForegroundColor Green

# Doc file Resources.resx
Write-Host "Dang doc file Resources.resx..." -ForegroundColor Yellow
$resxContent = Get-Content $resxPath -Raw -Encoding UTF8

# Xoa entry DUKA_Logo cu neu co
if ($resxContent -match '<data name="DUKA_Logo"') {
    Write-Host "Dang xoa entry DUKA_Logo cu..." -ForegroundColor Yellow
    $resxContent = $resxContent -replace '(?s)<data name="DUKA_Logo".*?</data>\s*', ''
}

# Xoa entry "Image" rong neu co
$resxContent = $resxContent -replace '(?s)<data name="Image".*?</data>\s*', ''

# Them entry moi truoc </root>
$newEntry = @"
  <data name="DUKA_Logo" type="System.Drawing.Bitmap, System.Drawing" mimetype="application/x-microsoft.net.object.bytearray.base64">
    <value>$base64String</value>
  </data>
</root>
"@

$resxContent = $resxContent -replace '</root>', $newEntry

# Backup va ghi file
$backupPath = $resxPath + ".backup"
Copy-Item $resxPath $backupPath -Force
Write-Host "Da tao backup: $backupPath" -ForegroundColor Cyan

Write-Host "Dang ghi file Resources.resx..." -ForegroundColor Yellow
$resxContent | Set-Content $resxPath -Encoding UTF8

Write-Host ""
Write-Host "THANH CONG! Logo da duoc them vao Resources.resx" -ForegroundColor Green
Write-Host ""
Write-Host "BUOC TIEP THEO:" -ForegroundColor Yellow
Write-Host "1. Mo Visual Studio" -ForegroundColor White
Write-Host "2. Build -> Rebuild Solution (Ctrl+Shift+B)" -ForegroundColor White
Write-Host "3. Logo se hien thi trong tat ca cac form" -ForegroundColor White
Write-Host ""
Read-Host "Nhan Enter de thoat"
