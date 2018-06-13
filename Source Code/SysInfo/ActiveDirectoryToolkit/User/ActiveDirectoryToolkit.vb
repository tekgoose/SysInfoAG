Imports System.DirectoryServices
Imports System.IO

Public Class ActiveDirectoryToolkit

    Dim UserSearch
    Dim adspath As String

    Private Sub ActiveDirectoryLookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearLabels()
    End Sub

    Function ClearLabels()
        NameLabel.Text = Nothing
        FirstNameLabel.Text = Nothing
        LastNameLabel.Text = Nothing
        InitialsLabel.Text = Nothing
        DescriptionLabel.Text = Nothing
        OfficeLabel.Text = Nothing
        TelephoneNameLabel.Text = Nothing
        EmailLabel.Text = Nothing
        JobTitleLabel.Text = Nothing
        DepartmentLabel.Text = Nothing
        CompanyLabel.Text = Nothing
        ManagerLabel.Text = Nothing
        MemberOfDataGridView1.Rows.Clear()
        AttributeDataGridView.Rows.Clear()
        Return Nothing
    End Function

    Function SetReadOnly(switch As Boolean)

        FirstNameLabel.ReadOnly = switch
        LastNameLabel.ReadOnly = switch
        InitialsLabel.ReadOnly = switch
        DescriptionLabel.ReadOnly = switch
        OfficeLabel.ReadOnly = switch
        EmailLabel.ReadOnly = switch
        JobTitleLabel.ReadOnly = switch
        DepartmentLabel.ReadOnly = switch
        CompanyLabel.ReadOnly = switch
        TelephoneNameLabel.ReadOnly = switch

        If switch Like True Then
            UpdatePictureButton.Enabled = False
            ChangeManagerButton.Enabled = False
            UpdateButton.Enabled = False
        Else
            UpdatePictureButton.Enabled = True
            ChangeManagerButton.Enabled = True
            UpdateButton.Enabled = True
        End If

        Return Nothing
    End Function

    Private Sub SearchButton1_Click(sender As Object, e As EventArgs) Handles SearchButton1.Click
        UserListBox1.Items.Clear()
        If UserSearchTextbox1.Text Like Nothing Then
            DirectorySearcher1.Filter = "(&(objectCategory=user)(name=*))"
        Else
            DirectorySearcher1.Filter = "(&(objectCategory=user)(name=*" & UserSearchTextbox1.Text & "*))"
        End If
        UserSearch = DirectorySearcher1.FindAll()
        For Each item In UserSearch
            UserListBox1.Items.Add(item.Properties("name")(0).ToString)
        Next
    End Sub

    Private Sub UserListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserListBox1.SelectedIndexChanged
        ClearLabels()

        ' Get user path
        DirectorySearcher1.Filter = "(&(objectCategory=user)(name=" & UserListBox1.SelectedItem & "))"
        adspath = DirectorySearcher1.FindOne().Properties("adspath")(0).ToString()

        GetInformation(adspath)
        UpdateAccessLevel(adspath)

    End Sub

    Function GetInformation(path As String)
        Dim user As New DirectoryEntry(path.ToString())

        ' Update thumbnailphoto
        Try
            Dim thumbnailphoto As Byte() = user.Properties("thumbnailphoto")(0)
            Dim ms As MemoryStream = New MemoryStream(thumbnailphoto)
            PictureBox1.Image = Image.FromStream(ms)
        Catch
            PictureBox1.Image = Nothing
        End Try

        ' Update full name
        Try
            NameLabel.Text = user.Properties("name")(0).ToString()
        Catch
        End Try

        ' Update first name
        Try
            FirstNameLabel.Text = user.Properties("givenName")(0).ToString()
        Catch
        End Try

        ' Update Initials name
        Try
            InitialsLabel.Text = user.Properties("Initials")(0).ToString()
        Catch
        End Try

        ' Update Last name
        Try
            LastNameLabel.Text = user.Properties("sn")(0).ToString()
        Catch
        End Try

        ' Update Description name
        Try
            DescriptionLabel.Text = user.Properties("Description")(0).ToString()
        Catch
        End Try

        ' Update Office name
        Try
            OfficeLabel.Text = user.Properties("physicalDeliveryOfficeName")(0).ToString()
        Catch
        End Try

        ' Update Email name
        Try
            EmailLabel.Text = user.Properties("mail")(0).ToString()
            EmailButton.Enabled = True
        Catch
            EmailButton.Enabled = False
        End Try

        ' Update Telephone name
        Try
            TelephoneNameLabel.Text = user.Properties("telephoneNumber")(0).ToString()
        Catch
        End Try

        ' Update Job Title name
        Try
            JobTitleLabel.Text = user.Properties("title")(0).ToString()
        Catch
        End Try

        ' Update Department name
        Try
            DepartmentLabel.Text = user.Properties("department")(0).ToString()
        Catch
        End Try

        ' Update Company
        Try
            CompanyLabel.Text = user.Properties("company")(0).ToString()
        Catch
        End Try

        ' Update Manager name
        Try
            ManagerLabel.Text = user.Properties("manager")(0).ToString()
        Catch
        End Try

        ' Update memberof
        For Each item In user.Properties("memberof")
            DirectorySearcher1.Filter = "(distinguishedName=" & item.ToString() & ")"
            Dim group = DirectorySearcher1.FindOne()
            Dim groupType
            If group.Properties("groupType")(0) > 0 Then
                groupType = "Distribution Group"
            Else
                groupType = "Security Group"
            End If
            MemberOfDataGridView1.Rows.Add(group.Properties("name")(0).ToString(), groupType)
        Next

        ' Update attribute
        For Each item In user.Properties().PropertyNames()
            AttributeDataGridView.Rows.Add(item.ToString(), user.Properties(item.ToString())(0).ToString())
        Next

        Return Nothing
    End Function

    Function SetInformation(path As String)
        Dim user As New DirectoryEntry(path.ToString())

        Try
            ' Set First Name
            If FirstNameLabel.Text Like "" Then
                user.Properties("givenname").Clear()
            Else
                user.Properties("givenname").Value = FirstNameLabel.Text.ToString()
            End If


            ' Set Initials
            If InitialsLabel.Text Like "" Then
                user.Properties("Initials").Clear()
            Else
                user.Properties("Initials").Value = InitialsLabel.Text.ToString()
            End If


            ' Set Last Name
            If LastNameLabel.Text Like "" Then
                user.Properties("sn").Clear()
            Else
                user.Properties("sn").Value = LastNameLabel.Text.ToString()
            End If


            ' Set Description Name
            If DescriptionLabel.Text Like "" Then
                user.Properties("Description").Clear()
            Else
                user.Properties("Description").Value = DescriptionLabel.Text.ToString()
            End If


            ' Set Office Name
            If OfficeLabel.Text Like "" Then
                user.Properties("physicalDeliveryOfficeName").Clear()
            Else
                user.Properties("physicalDeliveryOfficeName").Value = OfficeLabel.Text.ToString()
            End If


            ' Set Email
            If EmailLabel.Text Like "" Then
                user.Properties("mail").Clear()
            Else
                user.Properties("mail").Value = EmailLabel.Text.ToString()
            End If


            ' Set telephoneNumber
            If TelephoneNameLabel.Text Like "" Then
                user.Properties("telephoneNumber").Clear()
            Else
                user.Properties("telephoneNumber").Value = TelephoneNameLabel.Text.ToString()
            End If


            ' Set title
            If JobTitleLabel.Text Like "" Then
                user.Properties("title").Clear()
            Else
                user.Properties("title").Value = JobTitleLabel.Text.ToString()
            End If


            ' Set department
            If DepartmentLabel.Text Like "" Then
                user.Properties("department").Clear()
            Else
                user.Properties("department").Value = DepartmentLabel.Text.ToString()
            End If


            ' Set company
            If CompanyLabel.Text Like "" Then
                user.Properties("company").Clear()
            Else
                user.Properties("company").Value = CompanyLabel.Text.ToString()
            End If

            ' Set Manager
            If ManagerLabel.Text Like "" Then
                user.Properties("manager").Clear()
            Else
                user.Properties("manager").Value = ManagerLabel.Text.ToString()
            End If

            user.CommitChanges()
            MsgBox("Updates applied successfully")

        Catch ex As Exception
            MsgBox("ERROR: " & ex.ToString())

        End Try


        Return Nothing
    End Function

    Function UpdateAccessLevel(path As String)
        Dim user As New DirectoryEntry(path.ToString())

        SetReadOnly(False)

        Return Nothing
    End Function

    Private Sub EmailButton_Click(sender As Object, e As EventArgs) Handles EmailButton.Click
        Dim proc As New System.Diagnostics.Process()
        proc.StartInfo.FileName = "mailto:" & EmailLabel.Text
        proc.Start()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        SetInformation(adspath)
    End Sub

    Private Sub UpdatePictureButton_Click(sender As Object, e As EventArgs) Handles UpdatePictureButton.Click
        UpdatePicture.setadspath(adspath)
        UpdatePicture.ShowDialog()
    End Sub

    Private Sub ChangeManagerButton_Click(sender As Object, e As EventArgs) Handles ChangeManagerButton.Click
        UpdateManager.setadspath(adspath)
        UpdateManager.ShowDialog()
    End Sub

    Function setManager(manger As String)
        ManagerLabel.Text = manger
        Return Nothing
    End Function

End Class