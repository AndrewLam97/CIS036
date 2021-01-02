Public Class Employees
    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeesDataSet)
        'Validate, Save, and Update EmployeesDataSet
    End Sub

    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads data into the 'EmployeesDataSet.Table' table.
        Me.TableTableAdapter.Fill(Me.EmployeesDataSet.Table)

    End Sub

    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                picBox.Image =
                    New Bitmap(OpenFileDialog1.FileName)
                'Load image from Dialog into picBox
            Catch ex As ArgumentException
                MsgBox("Not an image")
                'Catch exception when something other than an image is selected
            End Try
        End If
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        picBox.Image = Nothing
        'Clear picBox
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        picBox.Image = Nothing
        'Clear picBox
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        Dim strEmailURL As String = "www.gmail.com"
        Process.Start(strEmailURL)
        'Opens web browser window pointing to gmail
    End Sub
End Class