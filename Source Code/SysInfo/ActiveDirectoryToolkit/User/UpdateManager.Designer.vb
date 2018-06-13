<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SearchButton1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserListBox1 = New System.Windows.Forms.ListBox()
        Me.UserSearchTextbox1 = New System.Windows.Forms.TextBox()
        Me.SelectButton = New System.Windows.Forms.Button()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.SuspendLayout()
        '
        'SearchButton1
        '
        Me.SearchButton1.Location = New System.Drawing.Point(250, 5)
        Me.SearchButton1.Name = "SearchButton1"
        Me.SearchButton1.Size = New System.Drawing.Size(56, 22)
        Me.SearchButton1.TabIndex = 8
        Me.SearchButton1.Text = "Search"
        Me.SearchButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Search"
        '
        'UserListBox1
        '
        Me.UserListBox1.FormattingEnabled = True
        Me.UserListBox1.Location = New System.Drawing.Point(7, 33)
        Me.UserListBox1.Name = "UserListBox1"
        Me.UserListBox1.Size = New System.Drawing.Size(300, 186)
        Me.UserListBox1.TabIndex = 6
        '
        'UserSearchTextbox1
        '
        Me.UserSearchTextbox1.Location = New System.Drawing.Point(51, 7)
        Me.UserSearchTextbox1.Name = "UserSearchTextbox1"
        Me.UserSearchTextbox1.Size = New System.Drawing.Size(193, 20)
        Me.UserSearchTextbox1.TabIndex = 5
        '
        'SelectButton
        '
        Me.SelectButton.Enabled = False
        Me.SelectButton.Location = New System.Drawing.Point(6, 219)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(301, 23)
        Me.SelectButton.TabIndex = 9
        Me.SelectButton.Text = "Select"
        Me.SelectButton.UseVisualStyleBackColor = True
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'UpdateManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 247)
        Me.Controls.Add(Me.SelectButton)
        Me.Controls.Add(Me.SearchButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserListBox1)
        Me.Controls.Add(Me.UserSearchTextbox1)
        Me.Name = "UpdateManager"
        Me.Text = "UpdateManager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchButton1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UserListBox1 As ListBox
    Friend WithEvents UserSearchTextbox1 As TextBox
    Friend WithEvents SelectButton As Button
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
End Class
