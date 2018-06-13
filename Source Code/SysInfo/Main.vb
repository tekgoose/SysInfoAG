Imports System.ComponentModel
Imports System.Management
Imports System.Text.RegularExpressions

Public Class Main
    Public Manufacturer As String
    Public SerialNumber As String
    Public OperatingSystem As String
    Public OSArchitecture As String
    Public Computername As String
    Public LastBootUpTime As DateTime
    Public Model As String
    Public Processor As String
    Public IPv4Address As String
    Public TotalRam As Int64
    Public CurrentUser As String

    Private Sub Main_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        ComputerInformationTextbox.Text = "Loading..."
    End Sub

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown


        BackgroundUpdateInformation.RunWorkerAsync(".")
        BackgroundGetDomainComputerNames.RunWorkerAsync()

    End Sub

    Private Sub BackgroundGetDomainComputerNames_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundGetDomainComputerNames.DoWork
        Try
            DirectorySearcher1.Filter = "(&(objectCategory=computer))"
            DirectorySearcher1.PropertiesToLoad.Add("name")
            Dim updateTxtBoxDel As UpdateTextBoxBoxAutoCompleteDelegate = New UpdateTextBoxBoxAutoCompleteDelegate(AddressOf UpdateTextBoxAutoComplete)

            Dim computernames As New AutoCompleteStringCollection
            For Each item In DirectorySearcher1.FindAll()
                computernames.Add(item.Properties("name")(0).ToString)
            Next
            Invoke(updateTxtBoxDel, computernames)
        Catch
        End Try
    End Sub

    Delegate Sub UpdateTextBoxBoxAutoCompleteDelegate(ByVal computernames As AutoCompleteStringCollection)
    Public Sub UpdateTextBoxAutoComplete(ByVal computernames As AutoCompleteStringCollection)
        TextBox1.AutoCompleteCustomSource = computernames
    End Sub

    Private Sub BackgroundUpdateInformation_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundUpdateInformation.DoWork
        Dim strComputer = DirectCast(e.Argument, String)
        Try
            Dim objWMI = GetObject("winmgmts:\\" & strComputer & "\root\cimv2")
            Dim objOS As Object = objWMI.ExecQuery("Select * from Win32_OperatingSystem")
            Dim objCS As Object = objWMI.ExecQuery("SELECT * FROM Win32_ComputerSystem")
            Dim objPR As Object = objWMI.ExecQuery("SELECT * FROM Win32_Processor")
            Dim objNAC As Object = objWMI.ExecQuery("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True")
            Dim objBIOS As Object = objWMI.ExecQuery("SELECT * FROM Win32_BIOS")
            Dim objWP As Object = objWMI.ExecQuery("SELECT * from Win32_Process Where Name='explorer.exe'")


            Dim UpdateInformationTextboxDel As UpdateInformationTextboxDelegate = New UpdateInformationTextboxDelegate(AddressOf UpdateInformationTextbox)
            Invoke(UpdateInformationTextboxDel, objWMI, objOS, objCS, objPR, objNAC, objBIOS, objWP)



            Catch ex As Exception
            MessageBox.Show("Access Denied." & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            StatusLabel1.Text = ""
            TextBox1.Text = ""
        End Try
    End Sub



    Delegate Sub UpdateInformationTextboxDelegate(ByVal objWMI As Object,
                                                  ByVal objOS As Object,
                                                  ByVal objCS As Object,
                                                  ByVal objPR As Object,
                                                  ByVal objNAC As Object,
                                                  ByVal objBIOS As Object,
                                                  ByVal objWP As Object)

    Public Sub UpdateInformationTextbox(ByVal objWMI As Object,
                                                  ByVal objOS As Object,
                                                  ByVal objCS As Object,
                                                  ByVal objPR As Object,
                                                  ByVal objNAC As Object,
                                                  ByVal objBIOS As Object,
                                                  ByVal objWP As Object)



        For Each objItem In objOS
            OperatingSystem = objItem.Caption.ToString
            OSArchitecture = objItem.OSArchitecture.ToString
            LastBootUpTime = ManagementDateTimeConverter.ToDateTime(objItem.LastBootUpTime)
        Next

            For Each objItem In objCS
            Model = objItem.Model.ToString
            TotalRam = objItem.TotalPhysicalMemory
            Computername = objItem.Name.ToString
        Next

            For Each objItem In objPR
            Processor = objItem.Name.ToString
        Next

            IPv4Address = ""
            Dim count = 0
        For Each objItem In objNAC
            If count = 0 Then
                IPv4Address += (objItem.IPAddress)(0)
            Else
                IPv4Address += ", " & (objItem.IPAddress)(0)
            End If
            count = count + 1
        Next

        For Each objItem In objBIOS

            Manufacturer = objItem.Manufacturer.ToString
            SerialNumber = objItem.SerialNumber.ToString
        Next

        Dim CurrentUser = ""
        count = 0
        For Each objItem In objWP
                Dim strNameOfUser As Object = Nothing
                Dim properties = objItem.GetOwner(strNameOfUser)

                If count = 0 Then
                    CurrentUser += strNameOfUser.ToString
                Else
                    CurrentUser += ", " & strNameOfUser.ToString
                End If
                count = count + 1

            Next



            ComputerInformationTextbox.ResetText()
            ComputerInformationTextbox.AppendText("Operating System     : " & OperatingSystem & Environment.NewLine)
            ComputerInformationTextbox.AppendText("Computer Name        : " & Computername & Environment.NewLine)
        ComputerInformationTextbox.AppendText("IP Address           : " & IPv4Address & Environment.NewLine)
        If SerialNumber.Length Like 7 Then
            ComputerInformationTextbox.AppendText("Service Tag          : " & SerialNumber & Environment.NewLine)
            ComputerInformationTextbox.AppendText("Express Service Code : " & Base64toDec(SerialNumber) & Environment.NewLine)
        Else
            ComputerInformationTextbox.AppendText("Serial Number        : " & SerialNumber & Environment.NewLine)
        End If
        ComputerInformationTextbox.AppendText("Manufacturer         : " & Manufacturer & Environment.NewLine)
            ComputerInformationTextbox.AppendText("Model                : " & Model & Environment.NewLine)
            ComputerInformationTextbox.AppendText("Processor            : " & Processor & Environment.NewLine)
            ComputerInformationTextbox.AppendText("OS Architecture      : " & OSArchitecture & Environment.NewLine)
            ComputerInformationTextbox.AppendText("Total Ram            : " & Math.Round(TotalRam / (1024 * 1024 * 1024)) & " GB" & Environment.NewLine)
            ComputerInformationTextbox.AppendText("Last Bootup Time     : " & LastBootUpTime.ToShortDateString & " " & LastBootUpTime.ToLongTimeString & Environment.NewLine)
            ComputerInformationTextbox.AppendText("Current User         : " & CurrentUser)
            StatusLabel1.Text = ""
            TextBox1.Text = ""



    End Sub


    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        ComputerInformationTextbox.SelectAll()
        ComputerInformationTextbox.Copy()
        StatusLabel1.Text = "Copied to clipboard"
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        If Not TextBox1.Text Like "" Then

            Try
                If My.Computer.Network.Ping(Trim(TextBox1.Text)) Then
                    StatusLabel1.Text = "Getting information from " & TextBox1.Text

                    BackgroundUpdateInformation.RunWorkerAsync(Trim(TextBox1.Text))

                Else
                    MessageBox.Show(TextBox1.Text & " is offline.", "Unreachable", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

                End If
            Catch
                MessageBox.Show(TextBox1.Text & " is offline.", "Unreachable", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End Try
        End If


    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Close()
    End Sub


    Private Sub AboutSysInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSysInfoToolStripMenuItem.Click
        About.ShowDialog()
    End Sub


    Private Sub EmailButton_Click(sender As Object, e As EventArgs) Handles EmailButton.Click

        Dim proc As New System.Diagnostics.Process()
        proc.StartInfo.FileName = "mailto:?body=" & Regex.Replace(ComputerInformationTextbox.Text, "\r\n?|\n", "%0A")
        proc.Start()
    End Sub

    Private Sub CheckDellWarrantyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckDellWarrantyToolStripMenuItem.Click
        Warranty.ShowDialog()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub

    Private Sub ActiveDirectoryLookupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActiveDirectoryLookupToolStripMenuItem.Click
        ActiveDirectoryToolkit.ShowDialog()
    End Sub



    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripDumpLogs.Click
        Dump_Logs.ShowDialog()
    End Sub

    Private Sub OpenInEventViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenInEventViewerToolStripMenuItem.Click
        Process.Start("eventvwr.exe", " " & Computername)
        StatusLabel1.Text = "Opening event viewer..."
    End Sub

    Function Base64toDec(arg As String) As Long
        Const Chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim rev = arg.ToUpper().Reverse()
        Dim result As Long = 0
        Dim pos As Integer = 0
        For Each c In rev
            result += Chars.IndexOf(c) * CLng(Math.Pow(36, pos))
            pos += 1
        Next
        Return result
    End Function

End Class
