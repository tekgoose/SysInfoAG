
Imports SysInfo.com.dell.xserv

Public Class Warranty
    Dim SupportedManufacturer As String() = {"Dell Inc."}
    Dim Supported As Boolean


    Private Sub Warranty_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        DataGridView1.Rows.Clear()
        InputBox1.Clear()
        Supported = False
        ManufacturerLabel2.Text = Main.Manufacturer

        For Each Manufacturer As String In SupportedManufacturer
            If Manufacturer.Contains(Main.Manufacturer) Then
                Supported = True
            End If
        Next

        If Supported Then
            SupportLabel1.Text = "Warranty Lookup Supported"
            InputBox1.Text = Main.SerialNumber
            LookupButton1.PerformClick()
        Else
            SupportLabel1.Text = "Warranty Lookup Unsupported"
        End If

    End Sub


    Function GetDellWarranty(servicetag As String)
        Dim myGuid As Guid = Guid.NewGuid()  'create a new GUID
        Dim applicationName As String = "AssetService" 'anything will work here

        Dim oAssetServiceProxy As New AssetService
        Dim oData = oAssetServiceProxy.GetAssetInformation(myGuid, applicationName, servicetag) 'call the service


        ModelLabel1.Text = ""
        ShipDateLabel1.Text = ""
        For Each iData In oData
            ModelLabel1.Text = "System Model : " + iData.AssetHeaderData.SystemModel
            ShipDateLabel1.Text = "System Ship Date : " + iData.AssetHeaderData.SystemShipDate
            For Each item In iData.Entitlements
                If item.ServiceLevelDescription IsNot Nothing Then
                    DataGridView1.Rows.Add(item.ServiceLevelDescription.ToString, item.DaysLeft.ToString, servicetag, item.StartDate.ToLongDateString, item.EndDate.ToLongDateString)
                End If
            Next

        Next
        Return Nothing
    End Function

    Private Sub LookupButton1_Click(sender As Object, e As EventArgs) Handles LookupButton1.Click
        DataGridView1.Rows.Clear()
        GetDellWarranty(InputBox1.Text)
    End Sub

    Private Sub Warranty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Warranty Information - " & Main.Computername
    End Sub
End Class