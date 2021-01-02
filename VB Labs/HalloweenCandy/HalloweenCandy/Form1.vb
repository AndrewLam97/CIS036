Public Class frmMain
    Const ReesesPeanutButterCup As Decimal = 0.75
    Const Snickers As Decimal = 0.5
    Const Twix As Decimal = 1.0
    Const KitKat As Decimal = 0.8
    Const Butterfinger As Decimal = 1.5
    Const CandyCorn As Decimal = 0.25

    Private intItemQuantity As Integer
    Private decSelectedPrice As Decimal
    Private decTotal As Decimal

    Private Sub CboCandyOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCandyOptions.SelectedIndexChanged
        Dim intCandyIndex As Integer = cboCandyOptions.SelectedIndex

        Select Case intCandyIndex
            Case 0
                decSelectedPrice = ReesesPeanutButterCup
            Case 1
                decSelectedPrice = Snickers
            Case 2
                decSelectedPrice = Twix
            Case 3
                decSelectedPrice = KitKat
            Case 4
                decSelectedPrice = Butterfinger
            Case 5
                decSelectedPrice = CandyCorn
        End Select
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
        cboCandyOptions.SelectedIndex = 0
    End Sub

    Private Function Calculator(ByVal intItemQuantity As Integer, ByVal decSelectedPrice As Decimal) As Decimal
        Try
            decTotal = decSelectedPrice * intItemQuantity
        Catch Exception As OverflowException
            MsgBox("Input too large")
        End Try

        Return decTotal
    End Function

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        If IsNumeric(txtQuantity.Text) Then
            intItemQuantity = CInt(txtQuantity.Text)
        Else
            MsgBox("Invalid Quantity Entered", , "Error")
            txtQuantity.Text = ""
            txtQuantity.Focus()
        End If

        decTotal = Calculator(intItemQuantity, decSelectedPrice)

        lblTotal.Text = decTotal.ToString("C2")
    End Sub

    Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub MnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lblTotal.Text = "$XX.XX"
        txtQuantity.Clear()
        cboCandyOptions.Focus()
    End Sub

    Private Sub MnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        About.Show()
    End Sub

    Private Sub BtnOpenBrowser_Click(sender As Object, e As EventArgs) Handles btnOpenBrowser.Click
        WebBrowser.Show()
    End Sub
End Class
