Public Class OpenFile
    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        With OpenFileDialog1
            .Title = "Media File Browser"
            .Filter = "Media Files (*.wmv;*.mp4 | *.wmv;*.mp4"
            .FileName = ""
            .CheckFileExists = True
        End With

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            AxWindowsMediaPlayer1.URL =
                OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub
End Class