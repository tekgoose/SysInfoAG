@echo off
@setlocal enableextensions
pushd "%~dp0"

Echo "Removing C:\Program Files\sysinfo\"
rmdir "C:\Program Files\sysinfo\" /s /q

Echo "Removing shortcut"
del "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\sysinfo.lnk"

echo Finished
popd
timeout 5
