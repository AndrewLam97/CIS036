Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decHeight As Decimal
        Dim decWeight As Decimal
        Dim strSystem As String = lstSystem.SelectedItem

        Try
            decHeight = CDbl(txtHeight.Text)
            decWeight = CDbl(txtWeight.Text)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Exit Sub
        End Try

        Dim decBMI As Decimal = Calc(decHeight, decWeight, strSystem)
        Dim strBMI As String
        Select Case decBMI
            Case 0 To 18.4
                strBMI = "Underweight"
            Case 18.5 To 24.9
                strBMI = "Normal Weight"
            Case 25 To 29.9
                strBMI = "Overweight"
            Case > 30
                strBMI = "Obese"
        End Select
        lblBMI.Text = "BMI Status: " & strBMI

    End Sub

    Private Function Calc(ByVal decHeight As Decimal, ByVal decWeight As Decimal, ByVal strSystem As String)
        Dim decBMI As Decimal
        Select Case strSystem
            Case "Metric"
                decBMI = decWeight / (decHeight ^ 2)
            Case "Imperial"
                decBMI = (decWeight / (decHeight ^ 2)) * 703
        End Select

        Return decBMI
    End Function
End Class
