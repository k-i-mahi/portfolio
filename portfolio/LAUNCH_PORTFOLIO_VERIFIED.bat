@echo off
echo ===============================================
echo    PORTFOLIO LAUNCH AND VERIFICATION SYSTEM
echo ===============================================
echo.

echo [1/6] Checking system requirements...
where dotnet >nul 2>&1
if %ERRORLEVEL% neq 0 (
    echo ? .NET Framework not found. Please install .NET Framework 4.8 or later.
    pause
    exit /b 1
) else (
    echo ? .NET Framework is available
)

echo.
echo [2/6] Checking project structure...
if exist "DefaultSimple.aspx" (
    echo ? Main ASPX file found
) else (
    echo ? DefaultSimple.aspx not found
    pause
    exit /b 1
)

if exist "DefaultSimple.aspx.cs" (
    echo ? Code-behind file found  
) else (
    echo ? DefaultSimple.aspx.cs not found
    pause
    exit /b 1
)

if exist "Web.config" (
    echo ? Web configuration file found
) else (
    echo ? Web.config not found
    pause
    exit /b 1
)

if exist "Styles\additional.css" (
    echo ? Additional CSS file found
) else (
    echo ? Styles\additional.css not found
    pause
    exit /b 1
)

echo.
echo [3/6] Building project...
dotnet build --configuration Release --verbosity quiet
if %ERRORLEVEL% neq 0 (
    echo ? Build failed. Checking MSBuild...
    msbuild /p:Configuration=Release /verbosity:minimal
    if %ERRORLEVEL% neq 0 (
        echo ? Project build failed. Please check for compilation errors.
        pause
        exit /b 1
    )
)
echo ? Project built successfully

echo.
echo [4/6] Checking IIS Express availability...
set "IIS_EXPRESS_PATH=%ProgramFiles%\IIS Express\iisexpress.exe"
if not exist "%IIS_EXPRESS_PATH%" (
    set "IIS_EXPRESS_PATH=%ProgramFiles(x86)%\IIS Express\iisexpress.exe"
)

if not exist "%IIS_EXPRESS_PATH%" (
    echo ? IIS Express not found. Installing through Visual Studio or standalone installer required.
    echo You can download from: https://www.microsoft.com/en-us/download/details.aspx?id=48264
    pause
    exit /b 1
) else (
    echo ? IIS Express found: %IIS_EXPRESS_PATH%
)

echo.
echo [5/6] Starting IIS Express server...
echo ?? Launching portfolio at http://localhost:8080/DefaultSimple.aspx
echo.
echo ================================
echo    PORTFOLIO IS NOW RUNNING!
echo ================================
echo.
echo ? Website URL: http://localhost:8080/DefaultSimple.aspx
echo ? Admin Panel: http://localhost:8080/Admin.aspx
echo.
echo Press Ctrl+C to stop the server
echo Browser should open automatically...
echo.

start http://localhost:8080/DefaultSimple.aspx

echo [6/6] Starting server...
"%IIS_EXPRESS_PATH%" /path:"%CD%" /port:8080 /clr:v4.0

echo.
echo Server has stopped.
pause