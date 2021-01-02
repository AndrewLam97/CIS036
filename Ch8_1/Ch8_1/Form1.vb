Public Class frmMain
    Dim decSavings(11) As Decimal
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objReader As New IO.StreamReader("savings.txt")
        Dim strSaving As String = objReader.ReadLine()
        'strSaving = objReader.ReadLine()
        Dim index As Integer = 0
        Do Until strSaving Is Nothing
            decSavings(index) = strSaving
            index += 1
            strSaving = objReader.ReadLine()
            'strSaving = objReader.ReadLine()
        Loop
    End Sub

    Private Sub cboMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonths.SelectedIndexChanged
        Dim intSelected As Integer = cboMonths.SelectedIndex
        lblMonth.Text = "The electric savings for " & cboMonths.Items(intSelected) & ": " & decSavings(intSelected).ToString("C2")
        btnStatistics.Visible = True
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        Dim decTotal As Decimal
        Dim index As Integer
        Dim intMaxIndex As Integer
        Dim intMaxDec As Decimal
        For index = 0 To decSavings.Length() - 1
            decTotal += decSavings(index)
            If decSavings(index) > intMaxDec Then
                intMaxDec = decSavings(index)
                intMaxIndex = index
            End If
        Next
        lblAvg.Visible = True
        lblAvg.Text = "The average monthly savings: " & (decTotal / 12).ToString("C2")
        lblMost.Visible = True
        lblMost.Text = cboMonths.Items(intMaxIndex) & " had the most significant monthly savings"
    End Sub
End Class
