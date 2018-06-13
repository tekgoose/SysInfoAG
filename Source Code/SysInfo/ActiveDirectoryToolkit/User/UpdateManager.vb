Public Class UpdateManager
    Dim UserSearch
    Dim adspath As String
    Dim manageradspath As String

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


    Function setadspath(path As String)
        adspath = path
        Return Nothing
    End Function

    Private Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click
        DirectorySearcher1.Filter = "(&(objectCategory=user)(name=" & UserListBox1.SelectedItem & "))"
        manageradspath = DirectorySearcher1.FindOne().Properties("distinguishedName")(0).ToString()
        ActiveDirectoryToolkit.setManager(manageradspath)
        Close()
    End Sub

    Private Sub UserListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UserListBox1.SelectedIndexChanged
        SelectButton.Enabled = True
        AcceptButton = SelectButton
    End Sub

    Private Sub UpdateManager_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        AcceptButton = SearchButton1
        UserSearchTextbox1.Clear()
        UserListBox1.Items.Clear()
        manageradspath = Nothing
    End Sub


End Class