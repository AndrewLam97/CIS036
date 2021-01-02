Public Class frmMain
    Dim decTotal As Decimal
    Dim decSubTotal As Decimal
    Dim decTax As Decimal
    Const _cTax As Decimal = 1.125

    Private Sub PricesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PricesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PricesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PricesDBDataSet)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PricesDBDataSet.Prices' table. You can move, or remove it, as needed.
        Me.PricesTableAdapter.Fill(Me.PricesDBDataSet.Prices)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        decSubTotal += CDec(PriceTextBox.Text)
        lblSubTotal.Text = decSubTotal.ToString("C2")

        decTax = decSubTotal * 0.125
        lblTax.Text = decTax.ToString("C2")

        decTotal = decSubTotal * _cTax
        lblTotal.Text = decTotal.ToString("C2")
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        decTotal = 0
        decSubTotal = 0
        decTax = 0
        lblSubTotal.Text = ""
        lblTax.Text = ""
        lblTotal.Text = ""
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim strSql As String = "SELECT * FROM Prices"
        Dim strPath As String = "Provider = Microsoft.JET.OLEDB.4.0 ;" & "Data Source = C:\Users\alam58\Desktop\VB Labs\GroceryDB\GroceryDB\PricesDB.mdb"
        Dim odaPrices As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datValue As New DataTable

        Dim intCount As Integer
        Dim decSum As Decimal

        odaPrices.Fill(datValue)
        odaPrices.Dispose()

        For intCount = 0 To datValue.Rows.Count - 1
            decSum += Convert.ToDecimal(datValue.Rows(intCount)("Price"))
        Next
        lblSum.Text = decSum.ToString("C2")
    End Sub
End Class
