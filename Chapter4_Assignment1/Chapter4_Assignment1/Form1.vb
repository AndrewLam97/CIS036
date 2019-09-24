Public Class frmMain
    Const _cCostPerNight As Decimal = 79D
    Dim decTotal As Decimal
    Dim intNumNights As Integer

    Private Sub BtnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        intNumNights = CInt(txtNumNights.Text)
        decTotal = _cCostPerNight * intNumNights

        lblCost.Text = decTotal.ToString("C2")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumNights.Clear()
        lblCost.Text = ""
        txtNumNights.Focus()
    End Sub
End Class
