Public Class LoginForm2

    Private Sub LoginForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.PasswordChar = "*"
        txtUsername.PasswordChar = "*"
        lblError.Visible = False
    End Sub

    ' Show/hide password
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.PasswordChar = Nothing
            txtUsername.PasswordChar = Nothing
        Else
            txtPassword.PasswordChar = "*"
            txtUsername.PasswordChar = "*"
        End If
    End Sub

    ' Change password button
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Validate Student ID
        If String.IsNullOrEmpty(TextBox1.Text.Trim()) Then
            lblError.Text = "Please enter your Student ID."
            lblError.ForeColor = Color.Red
            lblError.Visible = True
            Exit Sub
        End If

        ' Validate new password
        If String.IsNullOrEmpty(txtPassword.Text) Then
            lblError.Text = "Please enter your new password."
            lblError.ForeColor = Color.Red
            lblError.Visible = True
            Exit Sub
        End If

        ' Validate confirm password
        If String.IsNullOrEmpty(txtUsername.Text) Then
            lblError.Text = "Please confirm your new password."
            lblError.ForeColor = Color.Red
            lblError.Visible = True
            Exit Sub
        End If

        ' Check minimum length
        If txtPassword.Text.Trim().Length < 6 Then
            lblError.Text = "Password must be at least 6 characters."
            lblError.ForeColor = Color.Red
            lblError.Visible = True
            Exit Sub
        End If

        ' Check if passwords match
        If txtPassword.Text.Trim() <> txtUsername.Text.Trim() Then
            lblError.Text = "Passwords do not match."
            lblError.ForeColor = Color.Red
            lblError.Visible = True
            Exit Sub
        End If

        ' Change password
        Dim success As Boolean = ChangeStudentPassword(
            TextBox1.Text.Trim(),
            txtPassword.Text.Trim()
        )

        If success Then
            MessageBox.Show("Password changed successfully! Please login again.")
            Dim loginForm As New LoginForm1()
            loginForm.Show()
            Me.Close()
        Else
            lblError.Text = "Student ID not found. Please try again."
            lblError.ForeColor = Color.Red
            lblError.Visible = True
        End If
    End Sub

    ' Return button
    Private Sub returnFORM1_Click(sender As Object, e As EventArgs) Handles returnFORM1.Click
        Dim loginForm As New LoginForm1()
        loginForm.Show()
        Me.Close()
    End Sub

End Class