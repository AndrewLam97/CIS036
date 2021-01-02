Public Module GlobalVar
    Public intNums() As Integer = {0}
    Public intNumSize As Integer = 0
End Module


Public Class frmMain

    ' Public Shared intNums() As Integer = {0}

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strInputMessage As String = "Enter integer: "
        Dim strEntered As String
        Dim intEntered As Integer

        strEntered = InputBox(strInputMessage, "Enter Integer: ")

        If IsNumeric(strEntered) Then
            intEntered = CInt(strEntered)
            lstNumbers.Items.Add(intEntered)

            If intNumSize = 0 Then
                intNums(intNumSize) = intEntered
                intNumSize += 1
            Else
                ReDim Preserve intNums(intNumSize)
                intNums(intNumSize) = intEntered
                intNumSize += 1
            End If
        Else
            MsgBox("Invalid Entry", , "Error")
            strEntered = ""
            btnAdd.Focus()
        End If
    End Sub

    Private Sub BtnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Array.Sort(intNums)
        lstNumbers.Items.Clear()
        For Each intNum In intNums
            lstNumbers.Items.Add(intNum)
        Next
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstNumbers.Items.Clear()
        ReDim intNums(0)
        intNumSize = 0
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub MnuWrite_Click(sender As Object, e As EventArgs) Handles mnuWrite.Click
        Write.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub
End Class
