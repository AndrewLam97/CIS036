' Developer: Andrew Lam
' Date: 9-26-19
' Application Name: Fruity Fruits
' Assignment: 5_2
' Purpose:
'   This is a Windows Classic Desktop application that displays an order screen for two different fruits.
'   The user can choose either an apple or a mango.

Option Strict On

Public Class frmMain
    Const _cApplePrice As Decimal = 1D
    Const _cMangoPrice As Decimal = 2D

    Dim decTotal As Decimal
    Dim intFruitQuant As Integer
    Dim decSelectedPrice As Decimal

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click 'This handler shows the selection confirmation text, enables the exit button, and totals up the user's selections.
        If txtFruitQuant.Text = Nothing Then 'Alerts the user that the quantity text box is empty and requires user input to proceed
            MsgBox("Please enter a quantity", MsgBoxStyle.Exclamation, "Quantity Error")
        Else
            intFruitQuant = Convert.ToInt32(txtFruitQuant.Text)

            decTotal = intFruitQuant * decSelectedPrice

            txtTotal.Text = decTotal.ToString("C2")

            txtFruitQuant.Enabled = False
            btnCalculate.Enabled = False
            btnExit.Enabled = True
            MsgBox("Enjoy your fruit!")
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'This handler closes the window upon the click event of the exit button.
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click 'This handler clears the text fields in the form and returns the focus to the first text entry
        txtFruitQuant.Clear()
        txtFruitQuant.Enabled = True
        txtTotal.Clear()
        txtFruitQuant.Focus()
        btnCalculate.Enabled = True
    End Sub

    Private Sub RadApple_CheckedChanged(sender As Object, e As EventArgs) Handles radApple.CheckedChanged 'Changes price variable depending on selected radio button
        If radApple.Checked Then
            decSelectedPrice = _cApplePrice
        ElseIf radMango.Checked Then
            decSelectedPrice = _cMangoPrice
        End If

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFruitQuant.Focus()
    End Sub
End Class
