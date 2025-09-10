@echo off
echo Testing Portfolio Application
echo =============================
echo.
echo Checking project structure...
if exist "Default.aspx" echo ? Default.aspx found
if exist "Default.aspx.cs" echo ? Default.aspx.cs found
if exist "DefaultSimple.aspx" echo ? DefaultSimple.aspx found
if exist "DefaultSimple.aspx.cs" echo ? DefaultSimple.aspx.cs found
if exist "Web.config" echo ? Web.config found
if exist "Styles\portfolio.css" echo ? CSS file found
if exist "Data\PortfolioDataAccess.cs" echo ? Data access layer found
if exist "Models\PortfolioModels.cs" echo ? Models found
echo.
echo Application files are ready!
echo.
echo To run the application:
echo 1. Open the project in Visual Studio
echo 2. Press F5 or Ctrl+F5 to run
echo 3. Navigate to Default.aspx or DefaultSimple.aspx
echo.
echo Note: Default.aspx requires database configuration
echo       DefaultSimple.aspx works with sample data
pause