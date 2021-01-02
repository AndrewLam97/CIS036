Public Class WebBrowser
    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        webBrowser1.Navigate(txtURL.Text)
    End Sub
End Class