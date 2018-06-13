<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActiveDirectoryLookupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckDellWarrantyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDumpLogs = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenInEventViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutSysInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputerInformationTextbox = New System.Windows.Forms.RichTextBox()
        Me.EmailButton = New System.Windows.Forms.Button()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.BackgroundGetDomainComputerNames = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundUpdateInformation = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(601, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        Me.SettingsToolStripMenuItem.Visible = False
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActiveDirectoryLookupToolStripMenuItem, Me.CheckDellWarrantyToolStripMenuItem, Me.LogsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ActiveDirectoryLookupToolStripMenuItem
        '
        Me.ActiveDirectoryLookupToolStripMenuItem.Enabled = False
        Me.ActiveDirectoryLookupToolStripMenuItem.Name = "ActiveDirectoryLookupToolStripMenuItem"
        Me.ActiveDirectoryLookupToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ActiveDirectoryLookupToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.ActiveDirectoryLookupToolStripMenuItem.Text = "Active Directory Toolkit"
        Me.ActiveDirectoryLookupToolStripMenuItem.Visible = False
        '
        'CheckDellWarrantyToolStripMenuItem
        '
        Me.CheckDellWarrantyToolStripMenuItem.Enabled = False
        Me.CheckDellWarrantyToolStripMenuItem.Name = "CheckDellWarrantyToolStripMenuItem"
        Me.CheckDellWarrantyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.CheckDellWarrantyToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.CheckDellWarrantyToolStripMenuItem.Text = "Computer Warranty"
        Me.CheckDellWarrantyToolStripMenuItem.Visible = False
        '
        'LogsToolStripMenuItem
        '
        Me.LogsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDumpLogs, Me.OpenInEventViewerToolStripMenuItem})
        Me.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        Me.LogsToolStripMenuItem.Size = New System.Drawing.Size(239, 22)
        Me.LogsToolStripMenuItem.Text = "Logs"
        '
        'ToolStripDumpLogs
        '
        Me.ToolStripDumpLogs.Enabled = False
        Me.ToolStripDumpLogs.Name = "ToolStripDumpLogs"
        Me.ToolStripDumpLogs.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ToolStripDumpLogs.Size = New System.Drawing.Size(226, 22)
        Me.ToolStripDumpLogs.Text = "Dump Logs"
        Me.ToolStripDumpLogs.Visible = False
        '
        'OpenInEventViewerToolStripMenuItem
        '
        Me.OpenInEventViewerToolStripMenuItem.Name = "OpenInEventViewerToolStripMenuItem"
        Me.OpenInEventViewerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.OpenInEventViewerToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.OpenInEventViewerToolStripMenuItem.Text = "Open in Event Viewer"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutSysInfoToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutSysInfoToolStripMenuItem
        '
        Me.AboutSysInfoToolStripMenuItem.Name = "AboutSysInfoToolStripMenuItem"
        Me.AboutSysInfoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutSysInfoToolStripMenuItem.Text = "About SysInfo"
        '
        'ComputerInformationTextbox
        '
        Me.ComputerInformationTextbox.BackColor = System.Drawing.SystemColors.Window
        Me.ComputerInformationTextbox.Font = New System.Drawing.Font("Lucida Console", 10.0!)
        Me.ComputerInformationTextbox.Location = New System.Drawing.Point(4, 27)
        Me.ComputerInformationTextbox.MinimumSize = New System.Drawing.Size(100, 100)
        Me.ComputerInformationTextbox.Name = "ComputerInformationTextbox"
        Me.ComputerInformationTextbox.ReadOnly = True
        Me.ComputerInformationTextbox.Size = New System.Drawing.Size(593, 198)
        Me.ComputerInformationTextbox.TabIndex = 1
        Me.ComputerInformationTextbox.Text = ""
        '
        'EmailButton
        '
        Me.EmailButton.AutoSize = True
        Me.EmailButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.EmailButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.EmailButton.Location = New System.Drawing.Point(123, 231)
        Me.EmailButton.Name = "EmailButton"
        Me.EmailButton.Size = New System.Drawing.Size(49, 25)
        Me.EmailButton.TabIndex = 2
        Me.EmailButton.Text = "Email"
        Me.EmailButton.UseVisualStyleBackColor = True
        '
        'CopyButton
        '
        Me.CopyButton.AutoSize = True
        Me.CopyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CopyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CopyButton.Location = New System.Drawing.Point(4, 231)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(113, 25)
        Me.CopyButton.TabIndex = 3
        Me.CopyButton.Text = "Copy to Clipboard"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 262)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(601, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel1
        '
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.Location = New System.Drawing.Point(304, 235)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 5
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(517, 233)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(75, 23)
        Me.GoButton.TabIndex = 6
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Computer name / IP"
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'BackgroundGetDomainComputerNames
        '
        '
        'BackgroundUpdateInformation
        '
        '
        'Main
        '
        Me.AcceptButton = Me.GoButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 284)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CopyButton)
        Me.Controls.Add(Me.EmailButton)
        Me.Controls.Add(Me.ComputerInformationTextbox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "SysInfo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutSysInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckDellWarrantyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComputerInformationTextbox As RichTextBox
    Friend WithEvents EmailButton As Button
    Friend WithEvents CopyButton As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GoButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActiveDirectoryLookupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDumpLogs As ToolStripMenuItem
    Friend WithEvents OpenInEventViewerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundGetDomainComputerNames As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundUpdateInformation As System.ComponentModel.BackgroundWorker
End Class
