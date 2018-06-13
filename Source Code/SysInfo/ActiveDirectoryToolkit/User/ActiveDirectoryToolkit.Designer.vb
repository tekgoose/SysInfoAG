<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActiveDirectoryToolkit
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.UserLookup = New System.Windows.Forms.TabPage()
        Me.UpdatePictureButton = New System.Windows.Forms.Button()
        Me.UserGeneralTabControl = New System.Windows.Forms.TabControl()
        Me.GeneralTabPage = New System.Windows.Forms.TabPage()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ChangeManagerButton = New System.Windows.Forms.Button()
        Me.ManagerLabel = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CompanyLabel = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DepartmentLabel = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.JobTitleLabel = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.EmailButton = New System.Windows.Forms.Button()
        Me.EmailLabel = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TelephoneNameLabel = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OfficeLabel = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.RichTextBox()
        Me.DescriptionLabel = New System.Windows.Forms.RichTextBox()
        Me.LastNameLabel = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InitialsLabel = New System.Windows.Forms.RichTextBox()
        Me.MemberOfTabPage = New System.Windows.Forms.TabPage()
        Me.MemberOfDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttributeViewerTabPage = New System.Windows.Forms.TabPage()
        Me.AttributeDataGridView = New System.Windows.Forms.DataGridView()
        Me.Attribute = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameLabel = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SearchButton1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserListBox1 = New System.Windows.Forms.ListBox()
        Me.UserSearchTextbox1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AccessLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1.SuspendLayout()
        Me.UserLookup.SuspendLayout()
        Me.UserGeneralTabControl.SuspendLayout()
        Me.GeneralTabPage.SuspendLayout()
        Me.MemberOfTabPage.SuspendLayout()
        CType(Me.MemberOfDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AttributeViewerTabPage.SuspendLayout()
        CType(Me.AttributeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.UserLookup)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(749, 488)
        Me.TabControl1.TabIndex = 0
        '
        'UserLookup
        '
        Me.UserLookup.BackColor = System.Drawing.Color.Transparent
        Me.UserLookup.Controls.Add(Me.UpdatePictureButton)
        Me.UserLookup.Controls.Add(Me.UserGeneralTabControl)
        Me.UserLookup.Controls.Add(Me.NameLabel)
        Me.UserLookup.Controls.Add(Me.PictureBox1)
        Me.UserLookup.Controls.Add(Me.SearchButton1)
        Me.UserLookup.Controls.Add(Me.Label1)
        Me.UserLookup.Controls.Add(Me.UserListBox1)
        Me.UserLookup.Controls.Add(Me.UserSearchTextbox1)
        Me.UserLookup.Location = New System.Drawing.Point(4, 22)
        Me.UserLookup.Name = "UserLookup"
        Me.UserLookup.Padding = New System.Windows.Forms.Padding(3)
        Me.UserLookup.Size = New System.Drawing.Size(741, 462)
        Me.UserLookup.TabIndex = 0
        Me.UserLookup.Text = "User Lookup"
        '
        'UpdatePictureButton
        '
        Me.UpdatePictureButton.Enabled = False
        Me.UpdatePictureButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatePictureButton.Location = New System.Drawing.Point(257, 102)
        Me.UpdatePictureButton.Name = "UpdatePictureButton"
        Me.UpdatePictureButton.Size = New System.Drawing.Size(98, 19)
        Me.UpdatePictureButton.TabIndex = 17
        Me.UpdatePictureButton.Text = "Update Picture"
        Me.UpdatePictureButton.UseVisualStyleBackColor = True
        '
        'UserGeneralTabControl
        '
        Me.UserGeneralTabControl.Controls.Add(Me.GeneralTabPage)
        Me.UserGeneralTabControl.Controls.Add(Me.MemberOfTabPage)
        Me.UserGeneralTabControl.Controls.Add(Me.AttributeViewerTabPage)
        Me.UserGeneralTabControl.Location = New System.Drawing.Point(258, 128)
        Me.UserGeneralTabControl.Name = "UserGeneralTabControl"
        Me.UserGeneralTabControl.SelectedIndex = 0
        Me.UserGeneralTabControl.Size = New System.Drawing.Size(477, 328)
        Me.UserGeneralTabControl.TabIndex = 16
        '
        'GeneralTabPage
        '
        Me.GeneralTabPage.Controls.Add(Me.UpdateButton)
        Me.GeneralTabPage.Controls.Add(Me.ChangeManagerButton)
        Me.GeneralTabPage.Controls.Add(Me.ManagerLabel)
        Me.GeneralTabPage.Controls.Add(Me.Label12)
        Me.GeneralTabPage.Controls.Add(Me.CompanyLabel)
        Me.GeneralTabPage.Controls.Add(Me.Label11)
        Me.GeneralTabPage.Controls.Add(Me.DepartmentLabel)
        Me.GeneralTabPage.Controls.Add(Me.Label10)
        Me.GeneralTabPage.Controls.Add(Me.JobTitleLabel)
        Me.GeneralTabPage.Controls.Add(Me.Label9)
        Me.GeneralTabPage.Controls.Add(Me.EmailButton)
        Me.GeneralTabPage.Controls.Add(Me.EmailLabel)
        Me.GeneralTabPage.Controls.Add(Me.Label8)
        Me.GeneralTabPage.Controls.Add(Me.TelephoneNameLabel)
        Me.GeneralTabPage.Controls.Add(Me.Label7)
        Me.GeneralTabPage.Controls.Add(Me.OfficeLabel)
        Me.GeneralTabPage.Controls.Add(Me.Label6)
        Me.GeneralTabPage.Controls.Add(Me.Label2)
        Me.GeneralTabPage.Controls.Add(Me.Label5)
        Me.GeneralTabPage.Controls.Add(Me.FirstNameLabel)
        Me.GeneralTabPage.Controls.Add(Me.DescriptionLabel)
        Me.GeneralTabPage.Controls.Add(Me.LastNameLabel)
        Me.GeneralTabPage.Controls.Add(Me.Label4)
        Me.GeneralTabPage.Controls.Add(Me.Label3)
        Me.GeneralTabPage.Controls.Add(Me.InitialsLabel)
        Me.GeneralTabPage.Location = New System.Drawing.Point(4, 22)
        Me.GeneralTabPage.Name = "GeneralTabPage"
        Me.GeneralTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.GeneralTabPage.Size = New System.Drawing.Size(469, 302)
        Me.GeneralTabPage.TabIndex = 0
        Me.GeneralTabPage.Text = "General"
        Me.GeneralTabPage.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Enabled = False
        Me.UpdateButton.Location = New System.Drawing.Point(388, 273)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 32
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ChangeManagerButton
        '
        Me.ChangeManagerButton.Enabled = False
        Me.ChangeManagerButton.Location = New System.Drawing.Point(388, 212)
        Me.ChangeManagerButton.Name = "ChangeManagerButton"
        Me.ChangeManagerButton.Size = New System.Drawing.Size(75, 20)
        Me.ChangeManagerButton.TabIndex = 31
        Me.ChangeManagerButton.Text = "Change"
        Me.ChangeManagerButton.UseVisualStyleBackColor = True
        '
        'ManagerLabel
        '
        Me.ManagerLabel.BackColor = System.Drawing.SystemColors.Window
        Me.ManagerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ManagerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManagerLabel.Location = New System.Drawing.Point(69, 212)
        Me.ManagerLabel.Multiline = False
        Me.ManagerLabel.Name = "ManagerLabel"
        Me.ManagerLabel.ReadOnly = True
        Me.ManagerLabel.Size = New System.Drawing.Size(317, 20)
        Me.ManagerLabel.TabIndex = 29
        Me.ManagerLabel.Text = "Manager"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 216)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Manager:"
        '
        'CompanyLabel
        '
        Me.CompanyLabel.BackColor = System.Drawing.SystemColors.Window
        Me.CompanyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CompanyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyLabel.Location = New System.Drawing.Point(69, 181)
        Me.CompanyLabel.Multiline = False
        Me.CompanyLabel.Name = "CompanyLabel"
        Me.CompanyLabel.ReadOnly = True
        Me.CompanyLabel.Size = New System.Drawing.Size(165, 20)
        Me.CompanyLabel.TabIndex = 27
        Me.CompanyLabel.Text = "Company"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Company:"
        '
        'DepartmentLabel
        '
        Me.DepartmentLabel.BackColor = System.Drawing.SystemColors.Window
        Me.DepartmentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DepartmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentLabel.Location = New System.Drawing.Point(307, 150)
        Me.DepartmentLabel.Multiline = False
        Me.DepartmentLabel.Name = "DepartmentLabel"
        Me.DepartmentLabel.ReadOnly = True
        Me.DepartmentLabel.Size = New System.Drawing.Size(156, 20)
        Me.DepartmentLabel.TabIndex = 25
        Me.DepartmentLabel.Text = "Department"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(241, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Department:"
        '
        'JobTitleLabel
        '
        Me.JobTitleLabel.BackColor = System.Drawing.SystemColors.Window
        Me.JobTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.JobTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobTitleLabel.Location = New System.Drawing.Point(69, 150)
        Me.JobTitleLabel.Multiline = False
        Me.JobTitleLabel.Name = "JobTitleLabel"
        Me.JobTitleLabel.ReadOnly = True
        Me.JobTitleLabel.Size = New System.Drawing.Size(165, 20)
        Me.JobTitleLabel.TabIndex = 23
        Me.JobTitleLabel.Text = "Job Title"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Job Title:"
        '
        'EmailButton
        '
        Me.EmailButton.Enabled = False
        Me.EmailButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailButton.Location = New System.Drawing.Point(7, 273)
        Me.EmailButton.Name = "EmailButton"
        Me.EmailButton.Size = New System.Drawing.Size(73, 23)
        Me.EmailButton.TabIndex = 22
        Me.EmailButton.Text = "Email"
        Me.EmailButton.UseVisualStyleBackColor = True
        '
        'EmailLabel
        '
        Me.EmailLabel.BackColor = System.Drawing.SystemColors.Window
        Me.EmailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel.Location = New System.Drawing.Point(307, 119)
        Me.EmailLabel.Multiline = False
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.ReadOnly = True
        Me.EmailLabel.Size = New System.Drawing.Size(156, 20)
        Me.EmailLabel.TabIndex = 20
        Me.EmailLabel.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(241, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Email:"
        '
        'TelephoneNameLabel
        '
        Me.TelephoneNameLabel.BackColor = System.Drawing.SystemColors.Window
        Me.TelephoneNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TelephoneNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelephoneNameLabel.Location = New System.Drawing.Point(344, 181)
        Me.TelephoneNameLabel.Multiline = False
        Me.TelephoneNameLabel.Name = "TelephoneNameLabel"
        Me.TelephoneNameLabel.ReadOnly = True
        Me.TelephoneNameLabel.Size = New System.Drawing.Size(119, 20)
        Me.TelephoneNameLabel.TabIndex = 18
        Me.TelephoneNameLabel.Text = "Telephone Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(240, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Telephone Number:"
        '
        'OfficeLabel
        '
        Me.OfficeLabel.BackColor = System.Drawing.SystemColors.Window
        Me.OfficeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OfficeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfficeLabel.Location = New System.Drawing.Point(69, 120)
        Me.OfficeLabel.Multiline = False
        Me.OfficeLabel.Name = "OfficeLabel"
        Me.OfficeLabel.ReadOnly = True
        Me.OfficeLabel.Size = New System.Drawing.Size(165, 20)
        Me.OfficeLabel.TabIndex = 16
        Me.OfficeLabel.Text = "Office"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Office:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "First name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Description:"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.BackColor = System.Drawing.SystemColors.Window
        Me.FirstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameLabel.Location = New System.Drawing.Point(69, 7)
        Me.FirstNameLabel.Multiline = False
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.ReadOnly = True
        Me.FirstNameLabel.Size = New System.Drawing.Size(165, 20)
        Me.FirstNameLabel.TabIndex = 8
        Me.FirstNameLabel.Text = "FirstName"
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.BackColor = System.Drawing.SystemColors.Window
        Me.DescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLabel.Location = New System.Drawing.Point(69, 59)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.ReadOnly = True
        Me.DescriptionLabel.Size = New System.Drawing.Size(394, 48)
        Me.DescriptionLabel.TabIndex = 14
        Me.DescriptionLabel.Text = "Description"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.BackColor = System.Drawing.SystemColors.Window
        Me.LastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameLabel.Location = New System.Drawing.Point(69, 33)
        Me.LastNameLabel.Multiline = False
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.ReadOnly = True
        Me.LastNameLabel.Size = New System.Drawing.Size(165, 20)
        Me.LastNameLabel.TabIndex = 10
        Me.LastNameLabel.Text = "LastName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Initials:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Last name:"
        '
        'InitialsLabel
        '
        Me.InitialsLabel.BackColor = System.Drawing.SystemColors.Window
        Me.InitialsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InitialsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InitialsLabel.Location = New System.Drawing.Point(281, 8)
        Me.InitialsLabel.Multiline = False
        Me.InitialsLabel.Name = "InitialsLabel"
        Me.InitialsLabel.ReadOnly = True
        Me.InitialsLabel.Size = New System.Drawing.Size(182, 20)
        Me.InitialsLabel.TabIndex = 12
        Me.InitialsLabel.Text = "Initials"
        '
        'MemberOfTabPage
        '
        Me.MemberOfTabPage.Controls.Add(Me.MemberOfDataGridView1)
        Me.MemberOfTabPage.Location = New System.Drawing.Point(4, 22)
        Me.MemberOfTabPage.Name = "MemberOfTabPage"
        Me.MemberOfTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MemberOfTabPage.Size = New System.Drawing.Size(469, 302)
        Me.MemberOfTabPage.TabIndex = 1
        Me.MemberOfTabPage.Text = "Member Of"
        Me.MemberOfTabPage.UseVisualStyleBackColor = True
        '
        'MemberOfDataGridView1
        '
        Me.MemberOfDataGridView1.AllowUserToAddRows = False
        Me.MemberOfDataGridView1.AllowUserToDeleteRows = False
        Me.MemberOfDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MemberOfDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CN, Me.Type})
        Me.MemberOfDataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.MemberOfDataGridView1.Name = "MemberOfDataGridView1"
        Me.MemberOfDataGridView1.ReadOnly = True
        Me.MemberOfDataGridView1.Size = New System.Drawing.Size(469, 278)
        Me.MemberOfDataGridView1.TabIndex = 0
        '
        'CN
        '
        Me.CN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CN.HeaderText = "CN"
        Me.CN.Name = "CN"
        Me.CN.ReadOnly = True
        '
        'Type
        '
        Me.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'AttributeViewerTabPage
        '
        Me.AttributeViewerTabPage.Controls.Add(Me.AttributeDataGridView)
        Me.AttributeViewerTabPage.Location = New System.Drawing.Point(4, 22)
        Me.AttributeViewerTabPage.Name = "AttributeViewerTabPage"
        Me.AttributeViewerTabPage.Size = New System.Drawing.Size(469, 302)
        Me.AttributeViewerTabPage.TabIndex = 2
        Me.AttributeViewerTabPage.Text = "Attribute Viewer"
        Me.AttributeViewerTabPage.UseVisualStyleBackColor = True
        '
        'AttributeDataGridView
        '
        Me.AttributeDataGridView.AllowUserToAddRows = False
        Me.AttributeDataGridView.AllowUserToDeleteRows = False
        Me.AttributeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AttributeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Attribute, Me.Value})
        Me.AttributeDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.AttributeDataGridView.Name = "AttributeDataGridView"
        Me.AttributeDataGridView.ReadOnly = True
        Me.AttributeDataGridView.Size = New System.Drawing.Size(469, 273)
        Me.AttributeDataGridView.TabIndex = 0
        '
        'Attribute
        '
        Me.Attribute.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Attribute.HeaderText = "Attribute"
        Me.Attribute.Name = "Attribute"
        Me.Attribute.ReadOnly = True
        '
        'Value
        '
        Me.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Value.HeaderText = "Value"
        Me.Value.Name = "Value"
        Me.Value.ReadOnly = True
        '
        'NameLabel
        '
        Me.NameLabel.BackColor = System.Drawing.SystemColors.Menu
        Me.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(360, 9)
        Me.NameLabel.Multiline = False
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.ReadOnly = True
        Me.NameLabel.Size = New System.Drawing.Size(354, 36)
        Me.NameLabel.TabIndex = 7
        Me.NameLabel.Text = "NameLabel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(258, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'SearchButton1
        '
        Me.SearchButton1.Location = New System.Drawing.Point(196, 4)
        Me.SearchButton1.Name = "SearchButton1"
        Me.SearchButton1.Size = New System.Drawing.Size(56, 23)
        Me.SearchButton1.TabIndex = 4
        Me.SearchButton1.Text = "Search"
        Me.SearchButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search"
        '
        'UserListBox1
        '
        Me.UserListBox1.FormattingEnabled = True
        Me.UserListBox1.Location = New System.Drawing.Point(6, 32)
        Me.UserListBox1.Name = "UserListBox1"
        Me.UserListBox1.Size = New System.Drawing.Size(246, 420)
        Me.UserListBox1.TabIndex = 2
        '
        'UserSearchTextbox1
        '
        Me.UserSearchTextbox1.Location = New System.Drawing.Point(53, 6)
        Me.UserSearchTextbox1.Name = "UserSearchTextbox1"
        Me.UserSearchTextbox1.Size = New System.Drawing.Size(137, 20)
        Me.UserSearchTextbox1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(741, 462)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Computer Lookup"
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel, Me.AccessLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 496)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(759, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'AccessLabel
        '
        Me.AccessLabel.Name = "AccessLabel"
        Me.AccessLabel.Size = New System.Drawing.Size(0, 17)
        '
        'ActiveDirectoryToolkit
        '
        Me.AcceptButton = Me.SearchButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 518)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ActiveDirectoryToolkit"
        Me.Text = "Active Directory Toolkit"
        Me.TabControl1.ResumeLayout(False)
        Me.UserLookup.ResumeLayout(False)
        Me.UserLookup.PerformLayout()
        Me.UserGeneralTabControl.ResumeLayout(False)
        Me.GeneralTabPage.ResumeLayout(False)
        Me.GeneralTabPage.PerformLayout()
        Me.MemberOfTabPage.ResumeLayout(False)
        CType(Me.MemberOfDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AttributeViewerTabPage.ResumeLayout(False)
        CType(Me.AttributeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents UserLookup As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents UserSearchTextbox1 As TextBox
    Friend WithEvents SearchButton1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UserListBox1 As ListBox
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NameLabel As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstNameLabel As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LastNameLabel As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents InitialsLabel As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DescriptionLabel As RichTextBox
    Friend WithEvents UserGeneralTabControl As TabControl
    Friend WithEvents GeneralTabPage As TabPage
    Friend WithEvents MemberOfTabPage As TabPage
    Friend WithEvents OfficeLabel As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EmailLabel As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TelephoneNameLabel As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CompanyLabel As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DepartmentLabel As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents JobTitleLabel As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents EmailButton As Button
    Friend WithEvents ManagerLabel As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents MemberOfDataGridView1 As DataGridView
    Friend WithEvents AttributeViewerTabPage As TabPage
    Friend WithEvents CN As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents AttributeDataGridView As DataGridView
    Friend WithEvents Attribute As DataGridViewTextBoxColumn
    Friend WithEvents Value As DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents AccessLabel As ToolStripStatusLabel
    Friend WithEvents UpdateButton As Button
    Friend WithEvents ChangeManagerButton As Button
    Friend WithEvents UpdatePictureButton As Button
End Class
