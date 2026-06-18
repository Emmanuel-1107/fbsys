Public Class Form1

    Private Sub btnGiveFeedback_Click(sender As Object, e As EventArgs) Handles btnGiveFeedback.Click
        Dim feedbackForm As New LoginForm1
        feedbackForm.Show()
        Hide()
    End Sub

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Dim loginForm As New Form3()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGiveFeedback.Click

    End Sub

    Private Sub btnGiveFeedback_BackColorChanged(sender As Object, e As EventArgs) Handles btnGiveFeedback.BackColorChanged

    End Sub
End Class