Public Class frmMain
    Private Sub Tmr1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        If pic1.Visible = True Then
            pic1.Visible = False
        Else
            pic1.Visible = True
        End If
    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If tmr1.Enabled = False Then
            tmr1.Enabled = True
        End If
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If tmr1.Enabled = True Then
            tmr1.Enabled = False
        End If
    End Sub

    Private Sub MovieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovieToolStripMenuItem.Click
        OpenFile.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
