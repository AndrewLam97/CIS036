Imports System.Data.SqlClient

Public Class Inventory
    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InventoryDataSet)
        'Validate, Save, and Update InventoryDataSet

    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads data into the 'InventoryDataSet.Table' table.
        Me.TableTableAdapter.Fill(Me.InventoryDataSet.Table)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InventoryDataSet)
        'Validate, Save, and Update InventoryDataSet
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Search function implementation
        Try
            Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrew\Documents\School\PCC\CIS036\CIS036_Final_BusinessManagement\CIS036_Final_BusinessManagement\Inventory.mdf;Integrated Security=True")
            Dim command As New SqlCommand("SELECT * from Table where SKU = @SKU", con)
            Dim strSql As String = "SELECT * from Table where SKU = @SKU"
            Dim strPath As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andrew\Documents\School\PCC\CIS036\CIS036_Final_BusinessManagement\CIS036_Final_BusinessManagement\Inventory.mdf;Integrated Security=True"
            command.Parameters.Add("@SKU", SqlDbType.NVarChar).Value = InputBox("SKU Search")
            'Update SQL command to include SKU search string
            Dim adapter As New SqlDataAdapter(command)
            'Create new adapter with custom SQL command
            Dim invenTable As New DataTable
            'Create temporary table to hold search results
            adapter.Fill(invenTable)
            'Fill temp table with results
            MsgBox(invenTable.Rows(0)(1).ToString() & invenTable.Rows(0)(2).ToString())
            'Display search table results
        Catch ex As Exception

        End Try
        MsgBox("Microsoft Visual Studio 2019")
        'Fallback
    End Sub
End Class
