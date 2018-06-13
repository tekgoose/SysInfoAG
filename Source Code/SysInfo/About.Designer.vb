<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class About
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
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.VersionLabel1 = New System.Windows.Forms.Label()
        Me.VersionLabel2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxDescription.Location = New System.Drawing.Point(48, 27)
        Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(8, 4, 4, 4)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.Size = New System.Drawing.Size(236, 48)
        Me.TextBoxDescription.TabIndex = 2
        Me.TextBoxDescription.TabStop = False
        '
        'VersionLabel1
        '
        Me.VersionLabel1.AutoSize = True
        Me.VersionLabel1.Location = New System.Drawing.Point(44, 11)
        Me.VersionLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.VersionLabel1.Name = "VersionLabel1"
        Me.VersionLabel1.Size = New System.Drawing.Size(64, 17)
        Me.VersionLabel1.TabIndex = 3
        Me.VersionLabel1.Text = "Version: "
        '
        'VersionLabel2
        '
        Me.VersionLabel2.AutoSize = True
        Me.VersionLabel2.Location = New System.Drawing.Point(103, 11)
        Me.VersionLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.VersionLabel2.Name = "VersionLabel2"
        Me.VersionLabel2.Size = New System.Drawing.Size(0, 17)
        Me.VersionLabel2.TabIndex = 4
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 45)
        Me.Controls.Add(Me.VersionLabel2)
        Me.Controls.Add(Me.VersionLabel1)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.Padding = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents VersionLabel1 As Label
    Friend WithEvents VersionLabel2 As Label
End Class
