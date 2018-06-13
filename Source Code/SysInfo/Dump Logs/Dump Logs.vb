Imports System.Diagnostics.Eventing.Reader
Imports System.Globalization

Public Class Dump_Logs


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Custom Range ..." Then
            StartDate.Enabled = True
            EndDate.Enabled = True
        Else
            StartDate.Enabled = False
            EndDate.Enabled = False
        End If

        If ComboBox1.Text = "Any time" Then
            StartDate.Value = Date.Today.AddYears(-100)
            EndDate.Value = Date.Today()
        End If

        If ComboBox1.Text = "Last hour" Then
            StartDate.Value = Date.Today.AddHours(-1)
            EndDate.Value = Date.Today()
        End If

        If ComboBox1.Text = "Last 12 hours" Then
            StartDate.Value = Date.Today.AddHours(-12)
            EndDate.Value = Date.Today()
        End If

        If ComboBox1.Text = "Last 24 hours" Then
            StartDate.Value = Date.Today.AddHours(-24)
            EndDate.Value = Date.Today()
        End If

        If ComboBox1.Text = "Last 7 days" Then
            StartDate.Value = Date.Today.AddDays(-7)
            EndDate.Value = Date.Today()
        End If

        If ComboBox1.Text = "Last 30 days" Then
            StartDate.Value = Date.Today.AddDays(-30)
            EndDate.Value = Date.Today()
        End If

    End Sub

    Private Sub Dump_Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Text = "Dump Logs - " & Main.Computername
        TreeView1.Nodes.Clear()
        UpdateTreeview()
        EventLog1.MachineName = Main.Computername

        DefaultButton1.PerformClick()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DefaultButton1.Click
        ComboBox1.Text = "Last 30 days"

        EventLevel.SetItemChecked(0, 1) 'Critical
        EventLevel.SetItemChecked(1, 1) 'Warning
        EventLevel.SetItemChecked(2, 1) 'Error
        EventLevel.SetItemChecked(3, 1) 'Information
        EventLevel.SetItemChecked(4, 0) 'Verbose

        TreeView1.TopNode.Checked = True
        For Each node In TreeView1.Nodes
            CheckChildNodes(node)
        Next

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
        UpdateTreeview()

    End Sub

    Function UpdateTreeview()
        TreeView1.Nodes.Add("Select All")
        Dim logsession = New EventLogSession(Main.Computername)

        For Each provider In logsession.GetLogNames()
            TreeView1.TopNode.Nodes.Add(provider.ToString())
        Next
        TreeView1.ExpandAll()
        Return Nothing
    End Function

    Public Sub CheckChildNodes(ByVal iNode As TreeNode)
        Try
            UnCheckParentNodes(iNode)
            For Each sNode As TreeNode In iNode.Nodes
                sNode.Checked = iNode.Checked
                CheckChildNodes(sNode)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Sub UnCheckParentNodes(ByVal iNode As TreeNode)
        Try
            If iNode.Checked = False AndAlso iNode.Parent IsNot Nothing Then
                iNode.Parent.Checked = False
                UnCheckParentNodes(iNode.Parent)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tvwDataCategory_AfterCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCheck
        If eventArgs.Action = TreeViewAction.ByKeyboard Or eventArgs.Action = TreeViewAction.ByMouse Then
            CheckChildNodes(eventArgs.Node)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DumpLogsButton.Click
        SaveFileDialog1.AddExtension = "evtx"
        SaveFileDialog1.ShowDialog()

        Dim logsession = New EventLogSession(Main.Computername)

        logsession.ExportLogAndMessages("Application", PathType.LogName, "*", "c:\test\Application.evtx", True, CultureInfo.CurrentCulture)

    End Sub
End Class