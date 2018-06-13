<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dump_Logs
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EventLevel = New System.Windows.Forms.CheckedListBox()
        Me.DefaultButton1 = New System.Windows.Forms.Button()
        Me.DumpLogsButton = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Logged:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Any time", "Last hour", "Last 12 hours", "Last 24 hours", "Last 7 days", "Last 30 days", "Custom Range ..."})
        Me.ComboBox1.Location = New System.Drawing.Point(65, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'StartDate
        '
        Me.StartDate.Enabled = False
        Me.StartDate.Location = New System.Drawing.Point(86, 37)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(205, 20)
        Me.StartDate.TabIndex = 2
        Me.StartDate.Value = New Date(2016, 2, 1, 16, 24, 45, 0)
        '
        'EndDate
        '
        Me.EndDate.Enabled = False
        Me.EndDate.Location = New System.Drawing.Point(86, 67)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(205, 20)
        Me.EndDate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Start Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "End Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Event Level:"
        '
        'EventLevel
        '
        Me.EventLevel.CheckOnClick = True
        Me.EventLevel.FormattingEnabled = True
        Me.EventLevel.Items.AddRange(New Object() {"Critical", "Warning", "Error", "Information", "Verbose"})
        Me.EventLevel.Location = New System.Drawing.Point(86, 106)
        Me.EventLevel.MultiColumn = True
        Me.EventLevel.Name = "EventLevel"
        Me.EventLevel.Size = New System.Drawing.Size(287, 49)
        Me.EventLevel.TabIndex = 7
        '
        'DefaultButton1
        '
        Me.DefaultButton1.Location = New System.Drawing.Point(17, 365)
        Me.DefaultButton1.Name = "DefaultButton1"
        Me.DefaultButton1.Size = New System.Drawing.Size(114, 23)
        Me.DefaultButton1.TabIndex = 10
        Me.DefaultButton1.Text = "Default Settings"
        Me.DefaultButton1.UseVisualStyleBackColor = True
        '
        'DumpLogsButton
        '
        Me.DumpLogsButton.Location = New System.Drawing.Point(260, 365)
        Me.DumpLogsButton.Name = "DumpLogsButton"
        Me.DumpLogsButton.Size = New System.Drawing.Size(114, 23)
        Me.DumpLogsButton.TabIndex = 11
        Me.DumpLogsButton.Text = "Dump Logs"
        Me.DumpLogsButton.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Location = New System.Drawing.Point(96, 178)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(277, 168)
        Me.TreeView1.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(19, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(355, 3)
        Me.Label7.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Select Logs"
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'Dump_Logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 404)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.DumpLogsButton)
        Me.Controls.Add(Me.DefaultButton1)
        Me.Controls.Add(Me.EventLevel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Dump_Logs"
        Me.Text = "Dump Logs"
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EventLevel As CheckedListBox
    Friend WithEvents DefaultButton1 As Button
    Friend WithEvents DumpLogsButton As Button
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
