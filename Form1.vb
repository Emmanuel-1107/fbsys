Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Student Feedback System"

        ' Temporary DLL connection test — remove after confirmed working
        Try
            Dim total As Integer = GetTotalResponses()
            MessageBox.Show("C++ connected! Total responses: " & total)
        Catch ex As Exception
            MessageBox.Show("DLL Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGiveFeedback_Click(sender As Object, e As EventArgs) Handles btnGiveFeedback.Click
        Dim feedbackForm As New Form2()
        feedbackForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Dim loginForm As New Form3()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGiveFeedback.Click

    End Sub
End Class