Public Class Write
    Sub WriteToFile()

        Dim strFileName As String = "numbers.txt"

        Try
            Dim objWriter As New IO.StreamWriter(strFileName)

            For Each intNum In intNums
                If IO.File.Exists(strFileName) Then
                    objWriter.WriteLine(intNum)
                Else
                    MsgBox("The file is not available. Restart the program when the file is available",, "Error")
                End If
            Next
            MsgBox("Your numbers have been written to numbers.txt")
            objWriter.Close()

        Catch ex As Exception
            MsgBox("No device available...Program Aborted", , "Error")
            Application.Exit()

        End Try

    End Sub
    Private Sub BtnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        'Dim objReader As New IO.StreamReader
        'If IO.File.Exists("numbers.txt") = True Then
        '   objReader = IO.File.OpenText("numbers.txt")
        '   objReader.ReadLine()
        'Dim objWriter As New IO.StreamWriter("numbers.txt")

        'For Each intnum In intNums
        '    If IO.File.Exists("numbers.txt") Then
        '        objWriter.WriteLine(intnum)
        '    Else
        '        MsgBox("The file is not available. Restart the program when the file is available",, "Error")
        '    End If
        'Next
        'MsgBox("Your numbers have been written to numbers.txt")
        'objWriter.Close()
        WriteToFile()
    End Sub

    Private Sub BtnAddMask_Click(sender As Object, e As EventArgs) Handles btnAddMask.Click
        Dim strEntered As String
        Dim intEntered As Integer

        strEntered = txt5digit.Text

        If txt5digit.MaskFull = False Then
            MsgBox("Enter a 5 digit number", , "Error")
            txt5digit.Clear()
            txt5digit.Focus()

        ElseIf IsNumeric(strEntered) Then
            intEntered = CInt(strEntered)

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
        End If
        txt5digit.Text = ""
        txt5digit.Focus()
    End Sub
End Class