Public Class Image
    Private Sub BtnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                picBox1.Image =
                    New Bitmap(OpenFileDialog1.FileName)
            Catch ex As ArgumentException
                MsgBox("Not an image")
            End Try
        End If
    End Sub
End Class