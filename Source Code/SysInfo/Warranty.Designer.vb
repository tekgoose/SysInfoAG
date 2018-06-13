<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Warranty
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
        Me.ManufacturerLabel1 = New System.Windows.Forms.Label()
        Me.ManufacturerLabel2 = New System.Windows.Forms.Label()
        Me.SupportLabel1 = New System.Windows.Forms.Label()
        Me.InputBox1 = New System.Windows.Forms.TextBox()
        Me.LookupButton1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ServiceLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaysLeft = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelLabel1 = New System.Windows.Forms.Label()
        Me.ShipDateLabel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ManufacturerLabel1
        '
        Me.ManufacturerLabel1.AutoSize = True
        Me.ManufacturerLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.ManufacturerLabel1.Location = New System.Drawing.Point(13, 13)
        Me.ManufacturerLabel1.Name = "ManufacturerLabel1"
        Me.ManufacturerLabel1.Size = New System.Drawing.Size(91, 16)
        Me.ManufacturerLabel1.TabIndex = 0
        Me.ManufacturerLabel1.Text = "Manufacturer: "
        '
        'ManufacturerLabel2
        '
        Me.ManufacturerLabel2.AutoSize = True
        Me.ManufacturerLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.ManufacturerLabel2.Location = New System.Drawing.Point(96, 13)
        Me.ManufacturerLabel2.Name = "ManufacturerLabel2"
        Me.ManufacturerLabel2.Size = New System.Drawing.Size(0, 16)
        Me.ManufacturerLabel2.TabIndex = 1
        '
        'SupportLabel1
        '
        Me.SupportLabel1.AutoSize = True
        Me.SupportLabel1.Location = New System.Drawing.Point(13, 30)
        Me.SupportLabel1.Name = "SupportLabel1"
        Me.SupportLabel1.Size = New System.Drawing.Size(0, 13)
        Me.SupportLabel1.TabIndex = 2
        '
        'InputBox1
        '
        Me.InputBox1.Location = New System.Drawing.Point(453, 23)
        Me.InputBox1.Name = "InputBox1"
        Me.InputBox1.Size = New System.Drawing.Size(190, 20)
        Me.InputBox1.TabIndex = 3
        '
        'LookupButton1
        '
        Me.LookupButton1.Location = New System.Drawing.Point(649, 21)
        Me.LookupButton1.Name = "LookupButton1"
        Me.LookupButton1.Size = New System.Drawing.Size(75, 23)
        Me.LookupButton1.TabIndex = 4
        Me.LookupButton1.Text = "Lookup"
        Me.LookupButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Dell ServiceTag"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceLevel, Me.DaysLeft, Me.ServiceTag, Me.StartDate, Me.EndDate})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 101)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(706, 256)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 6
        '
        'ServiceLevel
        '
        Me.ServiceLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ServiceLevel.HeaderText = "ServiceLevel"
        Me.ServiceLevel.Name = "ServiceLevel"
        Me.ServiceLevel.ReadOnly = True
        Me.ServiceLevel.Width = 94
        '
        'DaysLeft
        '
        Me.DaysLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DaysLeft.HeaderText = "DaysLeft"
        Me.DaysLeft.Name = "DaysLeft"
        Me.DaysLeft.ReadOnly = True
        Me.DaysLeft.Width = 74
        '
        'ServiceTag
        '
        Me.ServiceTag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ServiceTag.HeaderText = "ServiceTag"
        Me.ServiceTag.Name = "ServiceTag"
        Me.ServiceTag.ReadOnly = True
        Me.ServiceTag.Width = 87
        '
        'StartDate
        '
        Me.StartDate.HeaderText = "StartDate"
        Me.StartDate.Name = "StartDate"
        Me.StartDate.ReadOnly = True
        '
        'EndDate
        '
        Me.EndDate.HeaderText = "EndDate"
        Me.EndDate.Name = "EndDate"
        Me.EndDate.ReadOnly = True
        '
        'ModelLabel1
        '
        Me.ModelLabel1.AutoSize = True
        Me.ModelLabel1.Location = New System.Drawing.Point(15, 63)
        Me.ModelLabel1.Name = "ModelLabel1"
        Me.ModelLabel1.Size = New System.Drawing.Size(0, 13)
        Me.ModelLabel1.TabIndex = 7
        '
        'ShipDateLabel1
        '
        Me.ShipDateLabel1.AutoSize = True
        Me.ShipDateLabel1.Location = New System.Drawing.Point(16, 80)
        Me.ShipDateLabel1.Name = "ShipDateLabel1"
        Me.ShipDateLabel1.Size = New System.Drawing.Size(0, 13)
        Me.ShipDateLabel1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(16, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(705, 2)
        Me.Label2.TabIndex = 9
        '
        'Warranty
        '
        Me.AcceptButton = Me.LookupButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 366)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShipDateLabel1)
        Me.Controls.Add(Me.ModelLabel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LookupButton1)
        Me.Controls.Add(Me.InputBox1)
        Me.Controls.Add(Me.SupportLabel1)
        Me.Controls.Add(Me.ManufacturerLabel2)
        Me.Controls.Add(Me.ManufacturerLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Warranty"
        Me.Text = "Warranty Information"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ManufacturerLabel1 As Label
    Friend WithEvents ManufacturerLabel2 As Label
    Friend WithEvents SupportLabel1 As Label
    Friend WithEvents InputBox1 As TextBox
    Friend WithEvents LookupButton1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ModelLabel1 As Label
    Friend WithEvents ShipDateLabel1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ServiceLevel As DataGridViewTextBoxColumn
    Friend WithEvents DaysLeft As DataGridViewTextBoxColumn
    Friend WithEvents ServiceTag As DataGridViewTextBoxColumn
    Friend WithEvents StartDate As DataGridViewTextBoxColumn
    Friend WithEvents EndDate As DataGridViewTextBoxColumn
End Class
