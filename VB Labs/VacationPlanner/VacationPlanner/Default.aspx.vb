Public Class _Default
    Inherits Page

    Const _cHawaii As Decimal = 792
    Const _cJapan As Decimal = 1318
    Const _cMexico As Decimal = 1084
    Const _cParis As Decimal = 626
    Const _cAdditionals As Decimal = 250

    Dim strEntered As String
    Dim intEntered As Integer
    Dim decSelectedPrice As Decimal = 0
    Dim decTotal As Decimal = 0

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        strEntered = txtGuests.Text
        strEntered.Trim()
        If IsNumeric(strEntered) Then
            intEntered = CInt(strEntered)
        Else
            MsgBox("Invalid Entry", , "Error")
            strEntered = ""
        End If

        decTotal = decSelectedPrice + ((intEntered - 2) * _cAdditionals)

        lblTotal.Text = decTotal.ToString("C2")

        Dim strMsg As String
        strMsg = "A reservation has been made for: " & "<br>" & intEntered & " individual(s)"
        lblMsg.Text = strMsg.ToUpper()
    End Sub

    Protected Sub radVacations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radVacations.SelectedIndexChanged
        Dim intVacationSelected As Integer = radVacations.SelectedIndex
        Select Case intVacationSelected
            Case 0
                decSelectedPrice = _cHawaii
                picMain.ImageUrl = "~/Resources/hawaii_vacation.jpg"
                picMain.Visible = True
            Case 1
                decSelectedPrice = _cJapan
                picMain.ImageUrl = "~/Resources/japan_vacation.jpg"
            Case 2
                decSelectedPrice = _cMexico
                picMain.ImageUrl = "~/Resources/cancunmexico_vacation.jpg"
            Case 3
                decSelectedPrice = _cParis
                picMain.ImageUrl = "~/Resources/paris_vacation.jpg"
        End Select

    End Sub

    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblTotal.Text = ""
        txtGuests.Text = ""
        lblMsg.Text = ""
        decTotal = 0
        intEntered = 0
    End Sub
End Class