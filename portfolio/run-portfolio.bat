@echo off
echo.
echo ========================================
echo   Khadimul Islam Mahi - Portfolio
echo ========================================
echo.
echo Starting ASP.NET Portfolio Website...
echo.

REM Check if Visual Studio is installed
if exist "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe" (
    echo Opening in Visual Studio 2022 Community...
    "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe" portfolio.csproj
) else if exist "C:\Program Files\Microsoft Visual Studio\2022\Professional\Common7\IDE\devenv.exe" (
    echo Opening in Visual Studio 2022 Professional...
    "C:\Program Files\Microsoft Visual Studio\2022\Professional\Common7\IDE\devenv.exe" portfolio.csproj
) else if exist "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe" (
    echo Opening in Visual Studio 2019 Community...
    "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe" portfolio.csproj
) else (
    echo Visual Studio not found in default locations.
    echo Please open portfolio.csproj manually in Visual Studio.
    echo Then press F5 to run the project.
)

echo.
echo Instructions:
echo 1. Once Visual Studio opens, press F5 to run
echo 2. The portfolio will open in your web browser
echo 3. Add your profile.jpg to Images folder
echo.
pause