$appName = "C:\Program Files\SysInfo\SysInfo.exe"
$arguments = ''
$wshshell = new-object -comobject wscript.shell
$volEnv = $wshShell.environment("volatile")
$qlf = "C:\ProgramData\Microsoft\Windows\Start Menu\Programs"
$shortCut = $wshShell.CreateShortCut("$qlf\SysInfo.lnk")
$shortCut.TargetPath = $appName
$shortCut.Description = "Lanch $appName"
$shortCut.WorkingDirectory = "C:\Program Files\SysInfo\"
$shortCut.WindowStyle = 1
$shortCut.HotKey = "CTRL+ALT+I"
$shortCut.Arguments = $arguments
$shortCut.Save()

Write-Output "Created shortcut."


