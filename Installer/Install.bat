@echo off
@setlocal enableextensions
pushd "%~dp0"

echo Creating C:\Program Files\sysinfo\
mkdir "C:\Program Files\sysinfo\"

echo Copying sysinfo.exe to C:\Program Files\sysinfo\
copy "SysInfo.exe" "C:\Program Files\sysinfo\Sysinfo.exe" /Y

echo Calling createshortcut.ps1
call PowerShell.exe -NoProfile -ExecutionPolicy Bypass -File "CreateShortcut.ps1"

echo finished

popd

timeout 5

