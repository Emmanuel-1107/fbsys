Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCharCount.Text = "Character Counter: 0/2000"
    End Sub

    Private Sub txtComments_TextChanged(sender As Object, e As EventArgs) Handles txtComments.TextChanged
        Dim count As Integer = txtComments.Text.Length
        lblCharCount.Text = "Character Counter: " & count & "/2000"
        If count > 2000 Then
            lblCharCount.ForeColor = Color.Red
        Else
            lblCharCount.ForeColor = Color.Gray
        End If
    End Sub

    Private Function GetSubjectRating() As Integer
        If RadioButton2.Checked Then Return 1
        If RadioButton1.Checked Then Return 2
        If RadioButton3.Checked Then Return 3
        If RadioButton4.Checked Then Return 4
        If RadioButton5.Checked Then Return 5
        Return 0
    End Function

    Private Function GetInstructorRating() As Integer
        If RadioButton6.Checked Then Return 1
        If RadioButton7.Checked Then Return 2
        If RadioButton8.Checked Then Return 3
        If RadioButton9.Checked Then Return 4
        If RadioButton10.Checked Then Return 5
        Return 0
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If CmbSubject.SelectedIndex < 0 Then
            MessageBox.Show("Please select a subject.")
            Exit Sub
        End If
        If cmbInstructor.SelectedIndex < 0 Then
            MessageBox.Show("Please select an instructor.")
            Exit Sub
        End If
        If cmbSemester.SelectedIndex < 0 Then
            MessageBox.Show("Please select a semester.")
            Exit Sub
        End If

        Dim subjectRating As Integer = GetSubjectRating()
        If subjectRating = 0 Then
            MessageBox.Show("Please rate the subject.")
            Exit Sub
        End If

        Dim instructorRating As Integer = GetInstructorRating()
        If instructorRating = 0 Then
            MessageBox.Show("Please rate the instructor.")
            Exit Sub
        End If

        Dim subjectCode As String = CmbSubject.SelectedItem.ToString()

        ' Check if student already submitted for this subject
        If HasAlreadySubmitted(LoginForm1.LoggedInStudentID, subjectCode) Then
            MessageBox.Show("You have already submitted feedback for " & subjectCode & ".")
            Exit Sub
        End If

        Dim success As Boolean = SubmitFeedback(
            LoginForm1.LoggedInStudentID,
            subjectCode,
            cmbInstructor.SelectedItem.ToString(),
            cmbSemester.SelectedItem.ToString(),
            subjectRating,
            instructorRating,
            txtComments.Text.Trim(),
            "anonymous_hash"
        )

        If success Then
            ' Record the submission so student can't submit again
            RecordSubmission(LoginForm1.LoggedInStudentID, subjectCode)
            MessageBox.Show("Feedback submitted successfully!")
        Else
            MessageBox.Show("Submission failed.")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim loginForm As New LoginForm1()
        loginForm.Show()
        Me.Close()
    End Sub

End Class