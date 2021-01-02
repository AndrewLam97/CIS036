Public Class frmMain
    Const _cPrice1 As Decimal = 249D
    Const _cPrice2 As Decimal = 219D
    Const _cPrice3 As Decimal = 199D
    Const _cPrice4 As Decimal = 169D

    Dim intGuests As Integer

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        intGuests = CInt(txtGroupSize.Text)

        Select Case intGuests
            Case Is > 99
                MsgBox("Too many guests!", 48, "Error")
            Case Is < 0
                MsgBox("Too few guests!", 48, "Error")
            Case 1 To 8
                lblTotal.Text = (intGuests * _cPrice1).ToString("C2")
            Case 9 To 12
                lblTotal.Text = (intGuests * _cPrice2).ToString("C2")
            Case 13 To 24
                lblTotal.Text = (intGuests * _cPrice3).ToString("C2")
            Case 25 To 99
                lblTotal.Text = (intGuests * _cPrice4).ToString("C2")
        End Select
    End Sub

End Class
