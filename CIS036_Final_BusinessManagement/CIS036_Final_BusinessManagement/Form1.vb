Public Class frmMain
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Employees.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Inventory.Show()
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        Employees.Show()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Inventory.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Authenticate()
    End Sub

    Private Sub Authenticate()
        Dim strUsername As String = txtUsername.Text
        Dim strPassword As String = txtPassword.Text
        Dim strLoginU As String = "Andrew"
        Dim strLoginP As String = "Lam"
        'Authenticate User Login
        If (strUsername = strLoginU And strPassword = strLoginP) Then
            btnEmployees.Visible = True
            btnInventory.Visible = True
            MsgBox("Logged in as: " & strLoginU)
            Me.Text = "Logged in as: " & strLoginU
            'Set frmMain window text to display current login information
            btnLogin.Enabled = False
        Else
            MsgBox("Incorrect Login Information", 5)
            txtPassword.Clear()
            txtUsername.Clear()
            txtUsername.Focus()
        End If
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Logout()
    End Sub

    Private Sub Logout()
        'Logout user and reset fields
        txtPassword.Clear()
        txtUsername.Clear()
        txtUsername.Focus()
        btnEmployees.Visible = False
        btnInventory.Visible = False
        btnLogin.Enabled = True
        MsgBox("Logged out")
        Me.Text = "Login"
    End Sub
End Class
