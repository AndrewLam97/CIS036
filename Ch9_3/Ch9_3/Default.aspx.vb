Public Class _Default
    Inherits Page

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strName As String
        Dim strTime As String
        Dim datCal As Date = calDate.SelectedDate

        If (datCal > Date.Now) Then
            Try
                strName = txtName.Text
                strTime = lstTimes.SelectedValue
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class