' CIS036 Midterm
' PCC Sandwiches
' Andrew Lam
' 10/17/19
Public Class frmMain
    'set prices for each sandwich
    Const pbjPrice As Decimal = 1.5
    Const hamburgerPrice As Decimal = 4.0
    Const veggiePrice As Decimal = 3.5
    Const cheesePrice As Decimal = 2.0

    Dim strItem As String
    Dim strItemQuant As String
    Dim intItemQuant As Integer
    Dim decTotal As Decimal

    Dim strTemp As String
    Dim intTemp As Integer
    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        'initialize strings for input box
        Dim strCancelClicked As String = ""
        Dim strNegativeError As String = "Negative entered."
        Dim strNonNumericError As String = "Enter a number instead."
        Dim strInputMessage As String = "Enter Quantity for: "

        strItem = InputBox("Which sandwich is being ordered?", "Order Form") 'asks user for which sandwich
        strItemQuant = InputBox(strInputMessage & strItem & " sandwiches", "Quantity") 'asks user for quantity of selected sandwich

        Do Until strItemQuant = strCancelClicked Or strItem = strCancelClicked 'loop until input box user exits
            If IsNumeric(strItemQuant) Then 'check quantity is an int
                intItemQuant = CInt(strItemQuant)
                If intItemQuant > 0 Then 'check quantity is positive
                    lstCart.Items.Add(intItemQuant & " " & strItem) 'add item to cart
                    Select Case strItem 'increase decTotal based on selected item and quantity
                        Case "pbj"
                            decTotal += pbjPrice * intItemQuant
                        Case "hamburger"
                            decTotal += hamburgerPrice * intItemQuant
                        Case "veggie"
                            decTotal += veggiePrice * intItemQuant
                        Case "cheese"
                            decTotal += cheesePrice * intItemQuant
                    End Select
                Else
                    strInputMessage = strNegativeError 'error message
                    MsgBox(strInputMessage, MsgBoxStyle.RetryCancel, "Error")
                End If
            Else
                strInputMessage = strNonNumericError 'error message
                MsgBox(strInputMessage, MsgBoxStyle.RetryCancel, "Error")
            End If

            strTemp = strItem
            intTemp = intItemQuant

            lblTotal.Text = decTotal.ToString("C2") 'set total text to decTotal formatted as currency with precision 2
            btnUndo.Enabled = True 'enable undo button

            strItem = InputBox("What item would you like to order?", "Order Form")
            strInputMessage = "Enter Quantity for: "
            strItemQuant = InputBox(strInputMessage & strItem, "Quantity")
        Loop
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        lstCart.Items.RemoveAt(lstCart.Items.Count - 1) 'remove last item
        Select Case strTemp 'decrease total price by last item * quantity
            Case "pbj"
                decTotal -= pbjPrice * intTemp
            Case "hamburger"
                decTotal -= hamburgerPrice * intTemp
            Case "veggie"
                decTotal -= veggiePrice * intTemp
            Case "cheese"
                decTotal -= cheesePrice * intTemp
        End Select

        lblTotal.Text = decTotal.ToString("C2") 'update total price 
        btnUndo.Enabled = False 'disable undo button
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        decTotal = 0 'set decTotal var to 0
        lblTotal.Text = "$XX.XX" 'reset lblTotal's text
        lstCart.Items.Clear() 'clear listbox
        btnOrder.Focus() 'set focus to order button
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show() 'show about form
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close() 'close app
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close() 'close app
    End Sub
End Class
