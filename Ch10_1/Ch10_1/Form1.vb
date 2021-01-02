Public Class frmMain
    Private Sub CarsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CarsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CarsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CarDataSet)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarDataSet.Cars' table. You can move, or remove it, as needed.
        Me.CarsTableAdapter.Fill(Me.CarDataSet.Cars)

    End Sub
End Class
