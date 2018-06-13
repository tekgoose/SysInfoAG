Add-Type -AssemblyName System.Windows.Forms
$Version = '1.2.1'
$AboutHelpText = "Software Tool provide by CLAC IT"
$AboutHelpEmail = "ServiceDesk@clac.ca"
$SysInfoIcon = [system.drawing.icon]::ExtractAssociatedIcon($PSHOME + '\powershell.exe')

function Create-MainForm {

    #### Create Form ###
    $Form = New-Object system.Windows.Forms.Form
    $Form.Icon = $SysInfoIcon
    $Form.Text = 'SysInfo'
    $Form.AutoSize = $True
    $Form.Height = 200
    $Form.FormBorderStyle = 'FixedDialog'
    $form.AutoSizeMode = "GrowAndShrink"
    $Form.BringToFront()
    
    #Creates MeauBar
    Create-MenuBar

    ## Create Textbox to display information in
    $textboxHeight = 170
    $outputBox = New-Object System.Windows.Forms.TextBox #creating the text box
    $outputBox.Height = "$textboxHeight"
    $outputBox.Width = 480
    $outputBox.BackColor = 'white'
    $outputBox.AutoSize = $True
    $outputBox.ReadOnly = $True
    $outputBox.TabStop = $false
    $outputBox.Location = New-Object System.Drawing.Size(3,24) 
    $outputBox.Font = 'Lucida Console, 9pt'
    $outputBox.Text = 'Loading...'
    $outputBox.MultiLine = $True #declaring the text box as multi-line
    $Form.Controls.Add($outputBox)  | Out-Null #activating the text box inside the primary window

    
    #Create Status Label
    # Textbox for server name
    $statusLabel = New-Object System.Windows.Forms.Label
    $statusLabel.Location = New-Object System.Drawing.Size(240,($textboxHeight + 31))
    $statusLabel.AutoSize = $true
    $statusLabel.Text = "Gathering local computer information"
    $Form.Controls.Add($statusLabel)


    ## Create Button Copy to Clipboard
    $Button = New-Object System.Windows.Forms.Button 
    $Button.Location = New-Object System.Drawing.Size(3,($textboxHeight + 27)) 
    $Button.AutoSize = $true
    $Button.Text = 'Copy to Clipboard'
    $Button.Add_Click({
            $statusLabel.Text = "Copied to Clipboard"
            $form.Refresh()
            ($ComputerInformation | Format-List | Out-String).trim() | clip
    }) 
    $Form.Controls.Add($Button) | Out-Null


    ## Create remote sysinfo Go button
    $goButton = New-Object System.Windows.Forms.Button 
    $goButton.Location = New-Object System.Drawing.Size(187,($textboxHeight + 55)) 
    $goButton.AutoSize = $true
    $goButton.Text = 'Go'
    $goButton.Visible = $false
    $goButton.Add_Click({
            $statusLabel.Text = "Gathering information from $($($RemoteSysinfoInputBox.Text).ToUpper())"
            if (Test-Connection -ComputerName $($RemoteSysinfoInputBox.Text) -Quiet -Count 1) {
                try {
                    $outputBox.Text = "$((Get-ComputerInfo -RemoteComputername $($RemoteSysinfoInputBox.Text)| Format-List | Out-String).trim())"
                } catch {
                    $outputBox.Text = "$($_.Exception.Message)"
                }
            } else {
                $outputBox.Text = "Computer Offline."
            }
            $statusLabel.Text = ""
    }) 
    $Form.Controls.Add($goButton) | Out-Null


     # Create remote sysinfo input field
    $RemoteSysinfoInputBox          = New-Object System.Windows.Forms.TextBox
    $RemoteSysinfoInputBox.Location = New-Object System.Drawing.Size(3,($textboxHeight + 57)) 
    $RemoteSysinfoInputBox.Size     = '181, 200'
    $RemoteSysinfoInputBox.Text     = ""
    $RemoteSysinfoInputBox.Visible = $false
    $form.Controls.Add($RemoteSysinfoInputBox)



    ## Create Email Button
        $emailButton = New-Object System.Windows.Forms.Button 
        $emailButton.Location = New-Object System.Drawing.Size(110,($textboxHeight + 27)) 
        $emailButton.AutoSize = $true
        $emailButton.Text = 'Email'
        $emailButton.Add_Click({
                $statusLabel.Text = "Opening Outlook..."
                $form.Refresh()
                $ol = New-Object -comObject Outlook.Application
                $mail = $ol.CreateItem(0)
                $mail.HTMLBody = "$($ComputerInformation | ConvertTo-Html -as List )"
                $mail.save()
                $inspector = $mail.GetInspector
                $inspector.Display()
                $statusLabel.Text = ""
                $form.Refresh()
        })
        $emailButton.Enabled = $False
        $Form.Controls.Add($emailButton) | Out-Null
    if (Test-Path 'C:\*\*Office*') { $emailButton.Enabled = $True}  #Enable button if office is installed
    


    #Create timer to load computer information once form has been created.
    $timer1 = New-Object System.Windows.Forms.Timer
    $timer1.Start()
    $timer1.Interval = 1
    $timer1.add_Tick({
        $outputBox.Text = "$((Get-ComputerInfo | Format-List | Out-String).trim())"
        $statusLabel.Text = ""
        $Form.Refresh()
        $timer1.Stop()
    })

    $Form.ShowDialog()
    $Form.Dispose()

}

function Create-MenuBar {
    # Main Menu Bar
    $menuMain = New-Object System.Windows.Forms.MenuStrip
    $menuMain.Location = New-Object System.Drawing.Size(0,0)
    $Form.Controls.Add($menuMain) | Out-Null
 
    # Menu File
    $menuFile = New-Object System.Windows.Forms.ToolStripMenuItem
    $menuFile.Text = 'File'
    $menuMain.Items.Add($menuFile) | Out-Null
  
    # Menu File / Copy All
    $menuCopyAll = New-Object System.Windows.Forms.ToolStripMenuItem
    $menuCopyAll.Text      = '&Copy All'
    $menuCopyAll.ShortcutKeys = 'Control,Alt, C'
    $menuCopyAll.Add_Click({
            $statusLabel.Text = "Copied to Clipboard"
            $form.Refresh()
            $(($ComputerInformation | Format-List | Out-String).trim() | clip)
    })
    $menuFile.DropDownItems.Add($menuCopyAll) | Out-Null

    # Menu File / Email
    $menuEmail = New-Object System.Windows.Forms.ToolStripMenuItem
    $menuEmail.Text      = '&Email'
    $menuEmail.ShortcutKeys = 'Control, E'
    $menuEmail.Enabled = $false
    $menuEmail.Add_Click({
             $statusLabel.Text = "Opening Outlook..."
                $form.Refresh()
                $ol = New-Object -comObject Outlook.Application
                $mail = $ol.CreateItem(0)
                $mail.HTMLBody = "$($ComputerInformation | ConvertTo-Html -as List )"
                $mail.save()
                $inspector = $mail.GetInspector
                $inspector.Display()
                $statusLabel.Text = ""
                $form.Refresh()
    })
    try { if (Test-Path 'C:\*\*Office*') {$menuEmail.Enabled = $True} } catch { $menuEmail.Enabled = $false }
    $menuFile.DropDownItems.Add($menuEmail) | Out-Null

    # Menu File / Quit
    $menuQuit = New-Object System.Windows.Forms.ToolStripMenuItem
    $menuQuit.Text      = '&Quit'
    $menuQuit.ShortcutKeys = 'Control, Q'
    $menuQuit.Add_Click({ $Form.Close() }) 
    $menuFile.DropDownItems.Add($menuQuit) | Out-Null

    # Menu Tools
    $menuTools = New-Object System.Windows.Forms.ToolStripMenuItem
    $menuTools.Text = 'Tools'
    $menuMain.Items.Add($menuTools) | Out-Null



    # Menu Tools / Active Directory Search
    $menuActiveDirectorySearch = New-Object System.Windows.Forms.ToolStripMenuItem
    $menuActiveDirectorySearch.Text      = '&Active Directory Search'
    $menuActiveDirectorySearch.ShortcutKeys = 'Control, F'
    $menuActiveDirectorySearch.Add_Click({Create-ActiveDirectorySearchForm})
    $menuTools.DropDownItems.Add($menuActiveDirectorySearch) | Out-Null



    # Menu Tools / Check Dell Warranty
    $menuWarranty = New-Object System.Windows.Forms.ToolStripMenuItem
    $menuWarranty.Text      = '&Check Dell Warranty'
    $menuWarranty.Enabled = $True
    $menuWarranty.ShortcutKeys = 'Control, D'
    $menuWarranty.Add_Click({
                    $statusLabel.Text = "Getting Dell Warranty..."
                    Get-DellWarranty -serial "$($ComputerInformation.ServiceTag)"
                    $statusLabel.Text = ""
                    })
    $menuTools.DropDownItems.Add($menuWarranty) | Out-Null



    # Menu Tools / Remote SysInfo Mode
    $menuWarranty = New-Object System.Windows.Forms.ToolStripMenuItem
    $menuWarranty.Text      = "&Remote SysInfo Mode"
    $menuWarranty.ShortcutKeys = 'Control, R'
    $menuWarranty.Add_Click({
        if (($goButton.Visible) -eq $false) {
            #Enable Remote SysInfo
            $goButton.Visible = $True
            $Form.ForeColor = "Blue"
            $Form.Text = "Remote SysInfo"
            $RemoteSysinfoInputBox.Visible = $True
            $remotesysinfoInputBox.Focus()
            $Form.AcceptButton  = $goButton
            $outputBox.Text = 'Type in a remote computer name or IP below and press Go.'
        } else {
            #Disable Remote SysInfo
            $goButton.Visible = $false
            $Form.ForeColor = "Black"
            $Form.Text = "SysInfo"
            $RemoteSysinfoInputBox.Visible = $false
            $Button.Focus()
            $outputBox.Text = 'Loading...'
            $statusLabel.Text = "Gathering computer information"
            New-Variable -Name ComputerInformation -Value $LocalComputerInformation -Scope Global -Force
            $outputBox.Text = "$(($LocalComputerInformation | Format-List | Out-String).Trim())"
            $statusLabel.Text = ""
        }
    })
    $menuTools.DropDownItems.Add($menuWarranty) | Out-Null






    # Menu Help
    $menuHelp = New-Object System.Windows.Forms.ToolStripMenuItem
    $menuHelp.Text      = '&Help'
    $menuHelp.ShortcutKeys = 'Control, H'
    $menuMain.Items.Add($menuHelp) | Out-Null

    # Menu Help / About
    $menuAbout = New-Object System.Windows.Forms.ToolStripMenuItem
    $menuAbout.Image     = [System.Drawing.SystemIcons]::Information
    $menuAbout.Text      = 'About SysInfo'
    $menuAbout.Add_Click({New-AboutMenu})
    $menuHelp.DropDownItems.Add($menuAbout) | Out-Null

}

function Get-DellWarranty { 
    Param
    (
        [Parameter(Mandatory=$false)]
        $serial
    )

    $results = new-object psobject


    if ($serial -ne $null -and $serial.Length -ne '7') {
        #Invalid servicetag.  Most likely a VM
        Add-Member -InputObject $results -MemberType NoteProperty -name Status -value 'No ServiceTag' -Force -PassThru |
        Add-Member -MemberType NoteProperty -name DaysLeft -value '' -PassThru |
        Add-Member -MemberType NoteProperty -name ComputerName -value "$($ComputerInformation.'Computer Name')" -PassThru |
        Add-Member -MemberType NoteProperty -name ServiceTag -value $serial -PassThru |
        Add-Member -MemberType NoteProperty -name Model -value '' -PassThru |
        Add-Member -MemberType NoteProperty -name ShipDate -value '' -PassThru |
        Add-Member -MemberType NoteProperty -name StartDate -value '' -PassThru |
        Add-Member -MemberType NoteProperty -name EndDate -value '' -PassThru |
        Add-Member -MemberType NoteProperty -name ServiceLevel -value '' -PassThru |
        Add-Member -MemberType NoteProperty -name Type -value ''
    } else {

        $service = New-WebServiceProxy -Uri http://xserv.dell.com/services/assetservice.asmx?WSDL
        $guid    = [guid]::NewGuid()
        $info    = $service.GetAssetInformation($guid,'check_warranty.ps1',$serial)

        Add-Member -InputObject $results -MemberType NoteProperty -name Status -value 'Online' -Force -PassThru |
        Add-Member -MemberType NoteProperty -name DaysLeft -value $info[0].Entitlements[0].DaysLeft -PassThru |
        Add-Member -MemberType NoteProperty -name ComputerName -value "$($ComputerInformation.'Computer Name')" -PassThru |
        Add-Member -MemberType NoteProperty -name ServiceTag -value $info[0].AssetHeaderData.ServiceTag -PassThru |
        Add-Member -MemberType NoteProperty -name Model -value $info[0].AssetHeaderData.SystemModel -PassThru |
        Add-Member -MemberType NoteProperty -name ShipDate -value $info[0].AssetHeaderData.SystemShipDate.ToShortDateString() -PassThru |
        Add-Member -MemberType NoteProperty -name StartDate -value $info[0].Entitlements[0].StartDate.ToShortDateString() -PassThru |
        Add-Member -MemberType NoteProperty -name EndDate -value $info[0].Entitlements[0].EndDate.ToShortDateString() -PassThru |
        Add-Member -MemberType NoteProperty -name ServiceLevel -value $info[0].Entitlements[0].ServiceLevelDescription.ToString() -PassThru |
        Add-Member -MemberType NoteProperty -name Type -value $info[0].AssetHeaderData.SystemType
                
    }

    Add-Type -AssemblyName System.Windows.Forms
    $WarrantyForm = New-Object system.Windows.Forms.Form
    $WarrantyForm.Icon = [system.drawing.icon]::ExtractAssociatedIcon($PSHOME + '\powershell.exe')
    $WarrantyForm.Text = 'Check Dell Warranty'
    $WarrantyForm.AutoSize = $True
    $WarrantyForm.Height = 135
    $WarrantyForm.FormBorderStyle = 'FixedDialog'
    $WarrantyForm.BringToFront()

    ## Create Textbox
    $textboxHeight = 135
    $WarrantyoutputBox = New-Object System.Windows.Forms.TextBox #creating the text box
    $WarrantyoutputBox.Height = "$textboxHeight"
    $WarrantyoutputBox.Width = 300
    $WarrantyoutputBox.AutoSize = $True
    $WarrantyoutputBox.ReadOnly = $True
    $WarrantyoutputBox.TabStop = $false
    $WarrantyoutputBox.Location = New-Object System.Drawing.Size(3,3) 
    $WarrantyoutputBox.Font = 'Lucida Console, 9pt'
    $WarrantyoutputBox.Text = "$(($results | Format-List | Out-String).trim())"
    $WarrantyoutputBox.BorderStyle = 'none'
    $WarrantyoutputBox.MultiLine = $True
    $WarrantyForm.Controls.Add($WarrantyoutputBox)
    $WarrantyForm.ShowDialog()
            
}

function Get-ComputerInfo {
    [CmdletBinding()]
    Param
    (
        [Parameter(Mandatory=$false)]
        $RemoteComputername
    )

    Begin
    {
    }
    Process
    {


        $parms = @{}
        if ($RemoteComputername) {$parms.Add("Computername", $RemoteComputername)}


        $results = New-Object PSObject

       

        $Win32_bios = Get-WmiObject -Class Win32_bios @parms
        $OperatingSystem = Get-WmiObject -class Win32_OperatingSystem @parms
        $computerSystem = Get-WmiObject -class Win32_ComputerSystem @parms
        $ComputerProcessor = get-wmiobject -class Win32_Processor @parms
        $ComputerProcess = Get-WmiObject -class win32_process @parms -EA "Stop"
        $computerMemory = Get-WMIObject -class Win32_PhysicalMemory @parms
        $computerNetwork = get-wmiobject win32_networkadapterconfiguration @parms

        ##Operating System
        Add-Member -InputObject $results -MemberType NoteProperty -Name 'Operating System' -Value $($OperatingSystem.Caption)

        ##Computer name
        Add-Member -InputObject $results -MemberType NoteProperty -Name 'Computer Name' -Value "$($computerSystem.Name)"
 
        ##IP Address
        $IPs = @() # Creates a string array called IPs to store all the IP Address in.
        $IPAddresses = ($computerNetwork | Where-object {$_.IPAddress-ne $null})
        $IPAddresses | Foreach-Object {
            $IPs += $_.IPAddress[0]
        }
        Add-Member -InputObject $results -MemberType NoteProperty -Name IPv4Address -Value "$IPs"


        ##ServiceTag and Manufacturer
        Add-Member -InputObject $results -MemberType NoteProperty -Name ServiceTag -Value $($Win32_bios.serialNumber)
        Add-Member -InputObject $results -MemberType NoteProperty -Name Manufacturer -Value $($Win32_bios.Manufacturer)

        ##Model
        Add-Member -InputObject $results -MemberType NoteProperty -Name Model -Value $($computerSystem.Model)

        ##Processor
        $processor = (($ComputerProcessor).Name)
        Add-Member -InputObject $results -MemberType NoteProperty -Name 'Processor' -Value $($processor.Replace('     ',' ')).Replace('    ',' ')

        ##OS Architecture 
        Add-Member -InputObject $results -MemberType NoteProperty -Name 'OSArchitecture' -Value $($OperatingSystem.OSArchitecture)

        ##Ram
        $totalRam = ($computerMemory | Measure-Object -Property capacity -Sum) | Select-Object @{N='TotalRam'; E={[math]::round(($_.Sum / 1GB),2)}}
        Add-Member -InputObject $results -MemberType NoteProperty -Name 'Total Ram' -Value "$($totalRam.TotalRam) GB"


        ##LastBoot
        Add-Member -InputObject $results -MemberType NoteProperty -Name 'LastBootUpTime' -Value (($OperatingSystem | Select-Object @{LABEL='LastBootUpTime';EXPRESSION={$_.ConverttoDateTime($_.lastbootuptime)}}).lastbootuptime)


        ##Current User
        $LoggedOnusername = @()
        try 
        { 
            if ($ComputerProcess) 
            {     
                $ComputerProcess | Foreach-Object {$_.GetOwner().User} |  
                Where-Object {$_ -ne "NETWORK SERVICE" -and $_ -ne "LOCAL SERVICE" -and $_ -ne "SYSTEM"} | 
                Sort-Object -Unique | 
                ForEach-Object {
                $LoggedOnusername += $_
                            
                }
            }#If 
        } 
        catch 
        { 
            $LoggedOnusername = ""
        } 
                
        Add-Member -InputObject $results -MemberType NoteProperty -Name 'Current User' -Value "$LoggedOnusername"


        if (!$RemoteComputername) {
            New-Variable -Name LocalComputerInformation -Value $results -Scope Global -Force
        } 
        New-Variable -Name ComputerInformation -Value $results -Scope Global -Force
        return $results
        
    }
    End
    {
    }
}

function New-AboutMenu {
    # About Form Objects
    $aboutForm          = New-Object System.Windows.Forms.Form
    $aboutFormExit      = New-Object System.Windows.Forms.Button
    $aboutFormImage     = New-Object System.Windows.Forms.PictureBox
    $aboutFormNameLabel = New-Object System.Windows.Forms.Label
    $aboutFormText      = New-Object System.Windows.Forms.Label

    # About Form
    $aboutForm.AcceptButton  = $aboutFormExit
    $aboutForm.CancelButton  = $aboutFormExit
    $aboutForm.Size          = '300, 160'
    $aboutForm.ControlBox    = $false
    $aboutForm.ShowInTaskBar = $false
    $aboutForm.StartPosition = 'CenterParent'
    $aboutForm.Text          = 'About SysInfo'
    $aboutForm.FormBorderStyle = 'FixedDialog'
    $aboutForm.Add_Load($aboutForm_Load)

    # About PictureBox
    $aboutFormImage.Image    = $SysInfoIcon
    $aboutFormImage.Location = '35, 15'
    $aboutFormImage.Size     = '32, 32'
    $aboutFormImage.SizeMode = 'StretchImage'
    $aboutForm.Controls.Add($aboutFormImage)

    # About Name Label
    $aboutFormNameLabel.Font     = New-Object Drawing.Font('Microsoft Sans Serif', 9, [System.Drawing.FontStyle]::Bold)
    $aboutFormNameLabel.Location = '80, 20'
    $aboutFormNameLabel.AutoSize = $True
    $aboutFormNameLabel.Text     = 'SysInfo'
    $aboutForm.Controls.Add($aboutFormNameLabel)

    # About Text Label
    $aboutFormText.Location = '80, 40'
    $aboutFormText.AutoSize = $True
    $aboutFormText.Text     = "Version {0} `n`r{1} `n`rDesigned by Justin Kropp `n`{2}" -f $Version, $AboutHelpText, $AboutHelpEmail
    $aboutForm.Controls.Add($aboutFormText)

    # About Exit Button
    $aboutFormExit.Location = '120, 100'
    $aboutFormExit.Text     = 'OK'
    $aboutForm.Controls.Add($aboutFormExit)

    $aboutForm.ShowDialog()
}

function Create-ActiveDirectorySearchForm {

    # Active Directory Search Form  
    $ActiveDirectorySearchForm            = New-Object System.Windows.Forms.Form
    $ActiveDirectorySearchForm.AutoSize = $true
    $ActiveDirectorySearchForm.AutoSizeMode = "GrowAndShrink"
    $ActiveDirectorySearchForm.ShowInTaskBar = $false
    $ActiveDirectorySearchForm.StartPosition = 'CenterParent'
    $ActiveDirectorySearchForm.Text          = 'Active Directory Search'
    $ActiveDirectorySearchForm.FormBorderStyle = 'FixedDialog'
    $ActiveDirectorySearchForm.Add_Load($aboutForm_Load)


     # Active Directory Search Computer Name Textbox
    $ActiveDirectoryComputerSearchTextbox         = New-Object System.Windows.Forms.TextBox
    $ActiveDirectoryComputerSearchTextbox.Location = '140, 10'
    $ActiveDirectoryComputerSearchTextbox.Size     = '150, 20'
    $ActiveDirectoryComputerSearchTextbox.Text     = ""
    $ActiveDirectorySearchForm.Controls.Add($ActiveDirectoryComputerSearchTextbox)

    # Active Directory Search Computer Name Label
    $ActiveDirectorySearchComputerLabel           = New-Object System.Windows.Forms.Label
    $ActiveDirectorySearchComputerLabel.Location = '0, 13'
    $ActiveDirectorySearchComputerLabel.Size     = '150, 20'
    $ActiveDirectorySearchComputerLabel.Text     = "Computer Search"
    $ActiveDirectorySearchForm.Controls.Add($ActiveDirectorySearchComputerLabel)

    # Active Directory Search Computer button
    $ActiveDirectorySearchComputerButton      = New-Object System.Windows.Forms.Button
    $ActiveDirectorySearchComputerButton.Location = '300, 9'
    $ActiveDirectorySearchComputerButton.Text     = 'Search'
    $ActiveDirectorySearchComputerButton.Add_Click({
        try {
            if ($($ActiveDirectoryComputerSearchTextbox.Text) -like "") { $Filter = "(&(ObjectCategory=computer)(name=*))" } else {
                $Filter = "(&(ObjectCategory=computer)(name=*$($ActiveDirectoryComputerSearchTextbox.Text)*))"
            }
            $Searcher = New-Object System.DirectoryServices.DirectorySearcher($Filter)
            $Searcher.Findall().properties | ForEach-Object {
                New-Object PSObject -Property $_
            } | select Name,OperatingSystem, operatingsystemservicepack, operatingsystemversion, whenchanged, whencreated, lastlogontimestamp | Out-GridView
        } catch {
            $wshell = New-Object -ComObject Wscript.Shell
            $wshell.Popup("$($_.Exception.Message)",0,"Error",0x1)
        }
    })
    $ActiveDirectorySearchForm.Controls.Add($ActiveDirectorySearchComputerButton)



    # Active Directory Search User Textbox
    $ActiveDirectoryUserTextbox         = New-Object System.Windows.Forms.TextBox
    $ActiveDirectoryUserTextbox.Location = '140, 40'
    $ActiveDirectoryUserTextbox.Size     = '150, 20'
    $ActiveDirectoryUserTextbox.Text     = ""
    $ActiveDirectorySearchForm.Controls.Add($ActiveDirectoryUserTextbox)

    # Active Directory Search UserLabel
    $ActiveDirectorySearchUserLabel           = New-Object System.Windows.Forms.Label
    $ActiveDirectorySearchUserLabel.Location = '0, 43'
    $ActiveDirectorySearchUserLabel.Size     = '150, 20'
    $ActiveDirectorySearchUserLabel.Text     = "User Search"
    $ActiveDirectorySearchForm.Controls.Add($ActiveDirectorySearchUserLabel)

    # Active Directory Search User button
    $ActiveDirectorySearchUserButton      = New-Object System.Windows.Forms.Button
    $ActiveDirectorySearchUserButton.Location = '300, 39'
    $ActiveDirectorySearchUserButton.Text     = 'Search'
    $ActiveDirectorySearchUserButton.Add_Click({
        try {
            if ($($ActiveDirectoryUserTextbox.Text) -like "") { $Filter = "(&(ObjectCategory=user)(name=*))" } else {
                $Filter = "(&(ObjectCategory=user)(name=*$($ActiveDirectoryUserTextbox.Text)*))"
            }
            $Searcher = New-Object System.DirectoryServices.DirectorySearcher($Filter)
            $Searcher.Findall().properties | ForEach-Object {
                New-Object PSObject -Property $_
            } | select Name, initials, samaccountname, pwdlastset, badpwdcount, whenchanged, whencreated | Out-GridView
                # Took out memberof
        } catch {
            $wshell = New-Object -ComObject Wscript.Shell
            $wshell.Popup("$($_.Exception.Message)",0,"Error",0x1)
        }
    })
    $ActiveDirectorySearchForm.Controls.Add($ActiveDirectorySearchUserButton)




    $ActiveDirectorySearchForm.ShowDialog()
}


Create-MainForm #Runs the Create-MainForm function.

