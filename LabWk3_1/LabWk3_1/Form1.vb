' Developer: Andrew Lam
' Date: 9-22-19
' Application Name: Fruity Fruits
' Assignment: 4
' Purpose:
'   This is a Windows Classic Desktop application that displays an order screen for two different fruits.
'   The user can choose either an apple or a mango.

Option Strict On

Public Class frmMain
    Const _cApplePrice As Decimal = 1D
    Const _cMangoPrice As Decimal = 2D

    Dim decTotal As Decimal
    Dim intAppleQuant As Integer
    Dim intMangoQuant As Integer

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click 'This handler shows the selection confirmation text, enables the exit button, and totals up the user's selections.
        intAppleQuant = CInt(txtAppleQuant.Text)
        intMangoQuant = CInt(txtMangoQuant.Text)

        decTotal = intAppleQuant * _cApplePrice + intMangoQuant * _cMangoPrice

        txtTotal.Text = decTotal.ToString("C2")

        btnCalculate.Enabled = False
        btnExit.Enabled = True
        MsgBox("Enjoy your fruit!")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'This handler closes the window upon the click event of the exit button.
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click 'This handler clears the text fields in the form and returns the focus to the first text entry
        txtAppleQuant.Clear()
        txtMangoQuant.Clear()
        txtTotal.Clear()
        txtAppleQuant.Focus()
        btnCalculate.Enabled = True
    End Sub
End Class
