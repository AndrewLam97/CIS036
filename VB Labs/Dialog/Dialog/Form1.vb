Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        Dim objColorDialog As New ColorDialog
        If objColorDialog.ShowDialog = DialogResult.OK Then
            Me.BackColor = objColorDialog.Color
        End If
    End Sub

    Private Sub OpenSaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenSaveToolStripMenuItem1.Click
        OpenSave.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        Image.Show()
    End Sub
End Class