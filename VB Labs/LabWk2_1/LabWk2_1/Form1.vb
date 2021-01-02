' Developer: Andrew Lam
' Date: 9-11-19
' Application Name: Virtual Reality Headsets
' Purpose:
'   This is a Windows Classic Desktop applicationthat displays an order screen for two types of virtual reality headsets.
'   The user can choose either a crown VR headset Or earbud VR headset.

Public Class frmMain
    Private Sub BtnCrown_Click(sender As Object, e As EventArgs) Handles btnCrown.Click 'This handler changes the visible property of the crown image to true and that of the earbud to false. It also enables the exit button.
        picCrown.Visible = True
        picEarbud.Visible = False
        btnExit.Enabled = True
    End Sub

    Private Sub BtnEarbud_Click(sender As Object, e As EventArgs) Handles btnEarbud.Click 'This handler changes the visible property of the earbud image to true and that of the crown to false. It also enables the exit button.
        picCrown.Visible = False
        picEarbud.Visible = True
        btnExit.Enabled = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'This handler closes the window upon the click event of the exit button.
        Me.Close()
    End Sub
End Class
