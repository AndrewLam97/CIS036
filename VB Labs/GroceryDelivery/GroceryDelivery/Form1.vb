Public Class frmMain
    Dim strItem As String
    Dim strItemQuant As String
    Dim intItemQuant As Integer
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim strCancelClicked As String = ""
        Dim strNegativeError As String = "Negative entered."
        Dim strNonNumericError As String = "Enter a number instead."
        Dim strInputMessage As String = "Enter Quantity for: "

        strItem = InputBox("What item would you like to order?", "Order Form")
        strItemQuant = InputBox(strInputMessage & strItem, "Quantity")

        'lstItems.Items.Add(intItemQuant & " " & strItem)
        Do Until strItemQuant = strCancelClicked Or strItem = strCancelClicked
            If IsNumeric(strItemQuant) Then
                intItemQuant = CInt(strItemQuant)
                If intItemQuant > 0 Then
                    lstItems.Items.Add(intItemQuant & " " & strItem)
                Else
                    strInputMessage = strNegativeError
                    MsgBox(strInputMessage, MsgBoxStyle.RetryCancel, "Error")
                End If
            Else
                strInputMessage = strNonNumericError
                MsgBox(strInputMessage, MsgBoxStyle.RetryCancel, "Error")
            End If
            strItem = InputBox("What item would you like to order?", "Order Form")
            strInputMessage = "Enter Quantity for: "
            strItemQuant = InputBox(strInputMessage & strItem, "Quantity")
        Loop
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lstItems.Items.Remove(lstItems.SelectedItem)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lstItems.Items.Clear()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstItems.Items.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub
End Class
