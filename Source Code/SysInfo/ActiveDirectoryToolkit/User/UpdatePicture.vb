Imports System.DirectoryServices
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class UpdatePicture
    Dim adspath As String
    Dim cropX As Integer
    Dim cropY As Integer
    Dim cropWidth As Integer
    Dim cropHeight As Integer

    Dim oCropX As Integer
    Dim oCropY As Integer
    Dim cropBitmap As Bitmap

    Public cropPen As Pen
    Public cropPenSize As Integer = 2 '2
    Public cropDashStyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Solid
    Public cropPenColor As Color = Color.Black
    Dim tmppoint As Point


    Private Sub UpdatePicture_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim user As New DirectoryEntry(adspath.ToString())

        Try
            Dim thumbnailphoto As Byte() = user.Properties("thumbnailphoto").Value
            Dim ms As MemoryStream = New MemoryStream(thumbnailphoto)
            PictureBox1.Image = Image.FromStream(ms)
            PreviewPictureBox.Image = Image.FromStream(ms)
        Catch
            PictureBox1.Image = Nothing

        End Try


    End Sub

    Function setadspath(path As String)
        adspath = path
        Return Nothing
    End Function

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        PictureBox1.Image = Nothing
        PreviewPictureBox.Image = Nothing

    End Sub

    Private Sub AppleButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        Dim user As New DirectoryEntry(adspath.ToString())

        If PictureBox1.Image Is Nothing Then
            user.Properties("thumbnailphoto").Clear()
            Try
                user.CommitChanges()
                MsgBox("Picture successfully removed")
            Catch ex As Exception
                MsgBox("ERROR: " & ex.ToString())
            End Try
        Else
            Dim ms As New IO.MemoryStream

            If Path.GetExtension(OpenFileDialog1.FileName).ToUpper() Like ".JPG" Then
                PreviewPictureBox.Image.Save(ms, Imaging.ImageFormat.Jpeg)
            ElseIf Path.GetExtension(OpenFileDialog1.FileName).ToUpper() Like ".PNG" Then
                PreviewPictureBox.Image.Save(ms, Imaging.ImageFormat.Png)
            ElseIf Path.GetExtension(OpenFileDialog1.FileName).ToUpper() Like ".BMP" Then
                PreviewPictureBox.Image.Save(ms, Imaging.ImageFormat.Bmp)
            ElseIf Path.GetExtension(OpenFileDialog1.FileName).ToUpper() Like ".ICO" Then
                PreviewPictureBox.Image.Save(ms, Imaging.ImageFormat.Png)
            ElseIf Path.GetExtension(OpenFileDialog1.FileName).ToUpper() Like ".GIF" Then
                PreviewPictureBox.Image.Save(ms, Imaging.ImageFormat.Gif)
            Else
                PreviewPictureBox.Image.Save(ms, Imaging.ImageFormat.Jpeg)
            End If
            Console.Write(Path.GetExtension(OpenFileDialog1.FileName))

            user.Properties("thumbnailphoto").Value = ms.GetBuffer()
            Try
                user.CommitChanges()
                MsgBox("Picture successfully applied")
            Catch ex As Exception
                MsgBox("ERROR: " & ex.ToString())
            End Try
        End If

        ActiveDirectoryToolkit.ClearLabels()
        ActiveDirectoryToolkit.GetInformation(adspath.ToString())

    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click

        OpenFileDialog1.Title = "Select Picture"
        OpenFileDialog1.Filter = "Image Files |*.JPG;*.PNG;*.BMP;*.ICO;*.GIF"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName.ToString())
        End If

    End Sub

    Private Sub UpdatePicture_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Try

            If PictureBox1.Image Is Nothing Then Exit Sub

            If e.Button = Windows.Forms.MouseButtons.Left Then

                PictureBox1.Refresh()
                cropWidth = e.X - cropX
                cropHeight = cropWidth
                PictureBox1.CreateGraphics.DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight)

            End If
            ' GC.Collect()

        Catch exc As Exception

            If Err.Number = 5 Then Exit Sub
        End Try
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Try

            If e.Button = MouseButtons.Left Then

                'If (e.X >= cropX And e.X <= cropX + cropWidth And e.Y >= cropY And e.Y <= cropY + cropHeight) Then

                'Else
                cropX = e.X
                    cropY = e.Y

                    cropPen = New Pen(cropPenColor, cropPenSize)
                    cropPen.DashStyle = DashStyle.DashDotDot
                    Cursor = Cursors.Cross
                'End If

            End If
                PictureBox1.Refresh()
        Catch exc As Exception
        End Try
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        Try
            Cursor = Cursors.Default
            Try

                If cropWidth < 1 Then
                    Exit Sub
                End If

                Dim rect As Rectangle = New Rectangle(cropX, cropY, cropWidth, cropHeight)
                Dim bit As Bitmap = New Bitmap(PictureBox1.Image, PictureBox1.Width, PictureBox1.Height)

                cropBitmap = New Bitmap(cropWidth, cropHeight)
                Dim g As Graphics = Graphics.FromImage(cropBitmap)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
                g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel)
                PreviewPictureBox.Image = cropBitmap

            Catch exc As Exception
            End Try
        Catch exc As Exception
        End Try
    End Sub



End Class