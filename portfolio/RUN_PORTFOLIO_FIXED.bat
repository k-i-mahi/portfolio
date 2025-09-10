@echo off
cls
echo ========================================
echo      PORTFOLIO LAUNCH - FIXED VERSION
echo ========================================
echo.
echo Starting Khadimul Islam Mahi's Portfolio...
echo.

REM Check if IIS Express is available
where iisexpress >nul 2>nul
if %ERRORLEVEL% EQU 0 (
    echo ? IIS Express found. Starting server...
    echo.
    echo ?? Portfolio will be available at:
    echo    http://localhost:8080/DefaultSimple.aspx
    echo.
    echo ?? Features Available:
    echo    • Dynamic theme switching (light/dark)
    echo    • Interactive animations and effects
    echo    • Responsive design for all devices
    echo    • Live Codeforces API integration
    echo    • Contact form functionality
    echo    • Admin panel at /Admin.aspx
    echo.
    echo ?? Portfolio Statistics:
    echo    • 5? CodeChef Rating: 2019
    echo    • 2500+ Problems Solved
    echo    • CSES 193 Problems Completed
    echo    • Hardware Projects & Kaggle Competitions
    echo.
    echo ? Press Ctrl+C to stop the server
    echo ========================================
    echo.
    
    REM Start IIS Express
    iisexpress /path:"%~dp0" /port:8080
) else (
    echo ? IIS Express not found in PATH
    echo.
    echo ?? Alternative Solutions:
    echo    1. Install IIS Express from Microsoft
    echo    2. Use Visual Studio to run the project
    echo    3. Deploy to IIS Server
    echo.
    echo ?? Project Files Ready:
    echo    • DefaultSimple.aspx (Main Page)
    echo    • Admin.aspx (Admin Panel)
    echo    • All CSS/JS files included
    echo    • Database ready for LocalDB
    echo.
)

echo.
echo Press any key to exit...
pause >nul