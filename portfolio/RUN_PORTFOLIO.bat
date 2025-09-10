@echo off
echo.
echo ========================================
echo    KHADIMUL ISLAM MAHI - PORTFOLIO
echo ========================================
echo.
echo Starting Portfolio Application...
echo.

REM Change to the portfolio directory
cd /d "%~dp0"

REM Check if Visual Studio is available
where devenv >nul 2>&1
if %ERRORLEVEL% EQU 0 (
    echo Opening in Visual Studio...
    start "" devenv portfolio.sln
    goto :end
)

REM Check if dotnet CLI is available
where dotnet >nul 2>&1
if %ERRORLEVEL% EQU 0 (
    echo Building with .NET CLI...
    dotnet build
    if %ERRORLEVEL% EQU 0 (
        echo.
        echo Build successful! 
        echo Starting application...
        echo.
        echo Portfolio will be available at:
        echo   Main Site: http://localhost:XXXX/DefaultSimple.aspx
        echo   Admin Panel: http://localhost:XXXX/Admin.aspx
        echo.
        dotnet run
    ) else (
        echo Build failed! Please check the errors above.
        pause
    )
    goto :end
)

REM Check if IIS Express is available
where iisexpress >nul 2>&1
if %ERRORLEVEL% EQU 0 (
    echo Starting with IIS Express...
    iisexpress /path:"%cd%" /port:8080
    goto :end
)

echo.
echo ERROR: No suitable development environment found!
echo.
echo Please install one of the following:
echo   1. Visual Studio 2019 or later
echo   2. .NET Framework 4.8 SDK
echo   3. IIS Express
echo.
pause

:end
echo.
echo Portfolio application started successfully!
echo Press any key to exit...
pause >nul