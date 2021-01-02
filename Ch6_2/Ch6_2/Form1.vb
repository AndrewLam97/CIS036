Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblTotal As Double
        Dim dblSpeeds(9) As Double
        Dim i As Integer

        For i = 0 To 9
            Dim inputStr As String = InputBox("Enter Internet Speed")
            If (inputStr = "") Then
                Exit Sub
            Else
                lstSpeeds.Items.Add(Decimal.Parse(inputStr))
            End If
        Next

        For Each speeds In lstSpeeds.Items
            dblTotal += speeds
        Next

        lblAvg.Text = "Average Internet Speed: " & (dblTotal / 10.0).ToString("F") & "Mbps"
    End Sub
End Class
