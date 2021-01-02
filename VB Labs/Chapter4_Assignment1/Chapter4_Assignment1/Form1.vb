Public Class frmMain
    Const _cCostPerNightStandard As Decimal = 79D
    Const _cCostPerNightDeluxe As Decimal = 99D
    Dim decTotal As Decimal
    Dim intNumNights As Integer
    Dim decCostPerNight As Decimal

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPrice.Text = "only " & decCostPerNight.ToString("C2") & " per night"
    End Sub
    Private Sub BtnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        intNumNights = CInt(txtNumNights.Text)
        decTotal = decCostPerNight * intNumNights

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

    Private Sub RadDeluxe_CheckedChanged(sender As Object, e As EventArgs) Handles radDeluxe.CheckedChanged
        lblPrice.Visible = True
        lblPrice.Text = "only " & _cCostPerNightDeluxe.ToString("C2") & " per night"
        decCostPerNight = _cCostPerNightDeluxe
        MsgBox("Enter number of nights", 64, "Attention")
    End Sub

    Private Sub RadStandard_CheckedChanged(sender As Object, e As EventArgs) Handles radStandard.CheckedChanged
        lblPrice.Visible = True
        lblPrice.Text = "only " & _cCostPerNightStandard.ToString("C2") & " per night"
        decCostPerNight = _cCostPerNightStandard
    End Sub

End Class
