# Script tự động convert logo sang base64 và thêm vào Resources.resx
# Sử dụng: Đặt file logo vào thư mục GUI với tên DUKA_Logo.png, sau đó chạy script này

$logoPath = Join-Path $PSScriptRoot "DUKA_Logo.png"
$resxPath = Join-Path $PSScriptRoot "Properties\Resources.resx"

Write-Host "Script tự động thêm logo vào Resources.resx" -ForegroundColor Green
Write-Host "=============================================" -ForegroundColor Green
Write-Host ""

# Kiểm tra file logo có tồn tại không
if (-not (Test-Path $logoPath)) {
    Write-Host "LỖI: Không tìm thấy file logo tại: $logoPath" -ForegroundColor Red
    Write-Host "Vui lòng đặt file logo vào thư mục GUI với tên: DUKA_Logo.png" -ForegroundColor Yellow
    Write-Host ""
    Write-Host "Hoặc nhập đường dẫn file logo:" -ForegroundColor Yellow
    $logoPath = Read-Host "Đường dẫn file logo"
    
    if (-not (Test-Path $logoPath)) {
        Write-Host "LỖI: File không tồn tại!" -ForegroundColor Red
        Read-Host "Nhấn Enter để thoát"
        exit 1
    }
}

Write-Host "Đã tìm thấy file logo: $logoPath" -ForegroundColor Green

# Kiểm tra file Resources.resx có tồn tại không
if (-not (Test-Path $resxPath)) {
    Write-Host "LỖI: Không tìm thấy file Resources.resx tại: $resxPath" -ForegroundColor Red
    Read-Host "Nhấn Enter để thoát"
    exit 1
}

Write-Host "Đã tìm thấy file Resources.resx: $resxPath" -ForegroundColor Green

# Đọc file logo và convert sang base64
Write-Host "Đang chuyển đổi hình ảnh sang base64..." -ForegroundColor Yellow
try {
    $imageBytes = [System.IO.File]::ReadAllBytes($logoPath)
    $base64String = [System.Convert]::ToBase64String($imageBytes)
    Write-Host "Đã chuyển đổi thành công! Độ dài base64: $($base64String.Length) ký tự" -ForegroundColor Green
} catch {
    Write-Host "LỖI: Không thể đọc file logo: $_" -ForegroundColor Red
    Read-Host "Nhấn Enter để thoát"
    exit 1
}

# Đọc file Resources.resx
Write-Host "Đang đọc file Resources.resx..." -ForegroundColor Yellow
$resxContent = Get-Content $resxPath -Raw -Encoding UTF8

# Kiểm tra xem DUKA_Logo đã tồn tại chưa
if ($resxContent -match '<data name="DUKA_Logo"') {
    Write-Host "CẢNH BÁO: DUKA_Logo đã tồn tại trong Resources.resx" -ForegroundColor Yellow
    $response = Read-Host "Bạn có muốn thay thế? (Y/N)"
    if ($response -ne "Y" -and $response -ne "y") {
        Write-Host "Đã hủy." -ForegroundColor Yellow
        Read-Host "Nhấn Enter để thoát"
        exit 0
    }
    # Xóa entry cũ (có thể có nhiều dòng)
    $resxContent = $resxContent -replace '(?s)<data name="DUKA_Logo".*?</data>\s*', ''
}

# Xóa entry "Image" rỗng nếu có
$resxContent = $resxContent -replace '(?s)<data name="Image".*?</data>\s*', ''

# Tìm vị trí để thêm entry mới (trước </root>)
$insertPattern = '</root>'
$newEntry = @"
  <data name="DUKA_Logo" type="System.Drawing.Bitmap, System.Drawing" mimetype="application/x-microsoft.net.object.bytearray.base64">
    <value>$base64String</value>
  </data>
$insertPattern
"@

# Thêm entry mới
$resxContent = $resxContent -replace '</root>', $newEntry

# Ghi lại file
Write-Host "Đang ghi file Resources.resx..." -ForegroundColor Yellow
try {
    # Backup file cũ
    $backupPath = $resxPath + ".backup"
    Copy-Item $resxPath $backupPath -Force
    Write-Host "Đã tạo backup: $backupPath" -ForegroundColor Cyan
    
    # Ghi file mới
    $resxContent | Set-Content $resxPath -Encoding UTF8 -NoNewline
    Write-Host "Đã ghi file thành công!" -ForegroundColor Green
} catch {
    Write-Host "LỖI: Không thể ghi file: $_" -ForegroundColor Red
    # Khôi phục từ backup nếu có
    if (Test-Path $backupPath) {
        Copy-Item $backupPath $resxPath -Force
        Write-Host "Đã khôi phục file từ backup" -ForegroundColor Yellow
    }
    Read-Host "Nhấn Enter để thoát"
    exit 1
}

Write-Host ""
Write-Host "═══════════════════════════════════════════════════════════════" -ForegroundColor Green
Write-Host "THÀNH CÔNG! Logo đã được thêm vào Resources.resx" -ForegroundColor Green
Write-Host "═══════════════════════════════════════════════════════════════" -ForegroundColor Green
Write-Host ""
Write-Host "BƯỚC TIẾP THEO:" -ForegroundColor Yellow
Write-Host "1. Mở Visual Studio" -ForegroundColor White
Write-Host "2. Build -> Rebuild Solution (Ctrl+Shift+B)" -ForegroundColor White
Write-Host "3. Logo sẽ tự động hiển thị trong LoginForm" -ForegroundColor White
Write-Host ""
Write-Host "LƯU Ý: Nếu có lỗi, file backup đã được lưu tại:" -ForegroundColor Cyan
Write-Host "  $backupPath" -ForegroundColor Cyan
Write-Host ""
Read-Host "Nhấn Enter để thoát"

