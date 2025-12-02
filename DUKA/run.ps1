# DUKA Football Management System - Run Script
# This script ensures fresh build and runs the application

Write-Host "=== DUKA Application Launcher ===" -ForegroundColor Green
Write-Host "Stopping any existing GUI processes..." -ForegroundColor Yellow

# Stop any existing GUI processes
Get-Process -Name "GUI" -ErrorAction SilentlyContinue | Stop-Process -Force

Write-Host "Cleaning build directories..." -ForegroundColor Yellow

# Clean build directories
$binPath = "GUI\bin"
$objPath = "GUI\obj"

if (Test-Path $binPath) {
    Remove-Item -Recurse -Force $binPath
    Write-Host "Cleaned GUI\bin" -ForegroundColor Cyan
}

if (Test-Path $objPath) {
    Remove-Item -Recurse -Force $objPath
    Write-Host "Cleaned GUI\obj" -ForegroundColor Cyan
}

Write-Host "Attempting to build solution..." -ForegroundColor Yellow

# Try to build using MSBuild
$msbuildPath = "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe"
if (Test-Path $msbuildPath) {
    Write-Host "Using Visual Studio 2022 MSBuild..." -ForegroundColor Cyan
    & $msbuildPath "DUKA.sln" /p:Configuration=Debug /p:Platform="Any CPU" /verbosity:minimal
} else {
    Write-Host "MSBuild not found, trying dotnet CLI..." -ForegroundColor Yellow
    dotnet build DUKA.sln /p:Configuration=Debug --verbosity minimal
}

# Check if build was successful
$exePath = "GUI\bin\Debug\GUI.exe"
if (Test-Path $exePath) {
    Write-Host "Build successful! Starting application..." -ForegroundColor Green
    Write-Host "Executable: $exePath" -ForegroundColor Cyan
    Write-Host "Build Time: $(Get-Date -Format 'yyyy-MM-dd HH:mm:ss')" -ForegroundColor Cyan

    # Run the application
    Start-Process $exePath

    Write-Host "Application started!" -ForegroundColor Green
} else {
    Write-Host "Build failed or executable not found!" -ForegroundColor Red
    Write-Host "Checking for errors..." -ForegroundColor Yellow

    # Check if there are any .exe files in other locations
    $exeFiles = Get-ChildItem -Path "." -Filter "*.exe" -Recurse -ErrorAction SilentlyContinue
    if ($exeFiles.Count -gt 0) {
        Write-Host "Found executable files:" -ForegroundColor Cyan
        $exeFiles | ForEach-Object { Write-Host "  $($_.FullName)" -ForegroundColor White }
    } else {
        Write-Host "No executable files found in project directory." -ForegroundColor Red
    }
}

Write-Host "Press any key to exit..." -ForegroundColor Gray
$null = $host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
