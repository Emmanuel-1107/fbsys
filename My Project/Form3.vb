Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin123" Then
            Dim dashboard As New Form4()
            dashboard.Show()
            Me.Hide()
        Else
            lblError.Text = "Invalid username or password."
            lblError.Visible = True
        End If
    End Sub

    Private Sub lblError_Click(sender As Object, e As EventArgs) Handles lblError.Click

    End Sub
End Class
