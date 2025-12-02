@echo off
echo =============================================
echo DUKA Football Management System - Build Script
echo =============================================

echo Building DTO project...
if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" (
    "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" DTO\DTO.csproj /p:Configuration=Debug /p:Platform="Any CPU"
) else if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" (
    "%ProgramFiles(x86)%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" DTO\DTO.csproj /p:Configuration=Debug /p:Platform="Any CPU"
) else (
    echo MSBuild not found. Please ensure Visual Studio is installed.
    pause
    exit /b 1
)

echo Building DAL project...
if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" (
    "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" DAL\DAL.csproj /p:Configuration=Debug /p:Platform="Any CPU"
) else if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" (
    "%ProgramFiles(x86)%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" DAL\DAL.csproj /p:Configuration=Debug /p:Platform="Any CPU"
)

echo Building BUS project...
if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" (
    "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" BUS\BUS.csproj /p:Configuration=Debug /p:Platform="Any CPU"
) else if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" (
    "%ProgramFiles(x86)%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" BUS\BUS.csproj /p:Configuration=Debug /p:Platform="Any CPU"
)

echo Building GUI project...
if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" (
    "%ProgramFiles(x86)%\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe" GUI\GUI.csproj /p:Configuration=Debug /p:Platform="Any CPU"
) else if exist "%ProgramFiles(x86)%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" (
    "%ProgramFiles(x86)%\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" GUI\GUI.csproj /p:Configuration=Debug /p:Platform="Any CPU"
)

echo.
echo =============================================
echo Build completed!
echo Run GUI\bin\Debug\GUI.exe to start the application
echo =============================================
pause
