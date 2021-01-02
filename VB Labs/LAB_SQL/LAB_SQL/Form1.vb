Public Class frmMain
    Private Sub CoffeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CoffeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CoffeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Coffee_LabDataSet11)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Coffee_LabDataSet11.Coffees' table. You can move, or remove it, as needed.
        Me.CoffeesTableAdapter.Fill(Me.Coffee_LabDataSet11.Coffees)

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Process.Start("www.google.com")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
