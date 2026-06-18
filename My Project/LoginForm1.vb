Public Class LoginForm1

    ' Store logged in student ID to pass to Form2
    Public Shared LoggedInStudentID As String = ""

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"
        lblError.Visible = False
    End Sub

    ' Show/hide password checkbox
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = Nothing
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(txtUsername.Text.Trim()) Then
            lblError.Text = "Please enter your Student ID."
            lblError.ForeColor = Color.Red
            lblError.Visible = True
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtPassword.Text) Then
            lblError.Text = "Please enter your password."
            lblError.ForeColor = Color.Red
            lblError.Visible = True
            Exit Sub
        End If

        Dim success As Boolean = StudentLogin(
            txtUsername.Text.Trim(),
            txtPassword.Text
        )

        If success Then
            LoggedInStudentID = txtUsername.Text.Trim()
            lblError.Visible = False
            Dim feedbackForm As New Form2()
            feedbackForm.Show()
            Me.Hide()
        Else
            lblError.Text = "Invalid Student ID or password."
            lblError.ForeColor = Color.Red
            lblError.Visible = True
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnLogin_Click(sender, e)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles returnFORM1.Click
        Dim splash As New Form1
        splash.Show()
        Close()
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Dim changePass As New LoginForm2()
        changePass.Show()
        Me.Hide()
    End Sub

End Class