Public Class OpenSave
    Public Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        ' Dim objOpenFileDialog As New OpenFileDialog
        'Dim objRichTextBox As New RichTextBox
        With OpenFileDialog1
            .Title = "Open File"
            .Filter = "Rich Text Files | *.rtf"
            .FileName = ""
            .CheckFileExists = vbTrue
        End With

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If
    End Sub

    Public Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim objSaveFileDialog As New SaveFileDialog
        'Dim objRichTextBox As New RichTextBox

        With SaveFileDialog1
            .Title = "Save File"
            .Filter = "Rich Text Files | *rtf"
            .DefaultExt = ".rtf"
            .OverwritePrompt = True
        End With

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class