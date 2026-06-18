Public Class Form4

    Private isLoading As Boolean = True

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wclbl.Text = "Welcome, Admin"
        isLoading = True
        LoadFilterOptions()
        isLoading = False
        LoadFeedbackData()
        LoadAnalytics()
    End Sub

    Private Sub LoadFilterOptions()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("All")
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.SelectedIndex = 0

        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("All")
        ComboBox2.Items.Add("IPROGLAB")
        ComboBox2.Items.Add("IPROGLEC")
        ComboBox2.Items.Add("DISSTRU1")
        ComboBox2.Items.Add("DBMGTLAB")
        ComboBox2.Items.Add("DBMGTLEC")
        ComboBox2.Items.Add("GEFILDIS")
        ComboBox2.Items.Add("GEPEFITE")
        ComboBox2.Items.Add("REMMCRAT")
        ComboBox2.Items.Add("NSTPROG2")
        ComboBox2.Items.Add("GEPANIPI")
        ComboBox2.Items.Add("GEPURPCO")
        ComboBox2.SelectedIndex = 0

        ComboBox3.Items.Clear()
        ComboBox3.Items.Add("All")
        ComboBox3.Items.Add("Mr. Jovel Advincula")
        ComboBox3.Items.Add("Mrs. Sheila Marie Matias")
        ComboBox3.Items.Add("Mr. Al Santiago")
        ComboBox3.Items.Add("Ms. Kathleen Dimaano")
        ComboBox3.Items.Add("Mrs. Charlene Ronda")
        ComboBox3.Items.Add("Mr. Louie Cris Rivera")
        ComboBox3.Items.Add("Mr. Ranilo Pardito")
        ComboBox3.Items.Add("Mr. Jonathan Torzar")
        ComboBox3.SelectedIndex = 0
    End Sub

    Private Sub LoadFeedbackData()
        dgvFeedbacks.Rows.Clear()
        dgvFeedbacks.Columns.Clear()

        dgvFeedbacks.Columns.Add("colID", "ID")
        dgvFeedbacks.Columns.Add("colUsername", "Username")
        dgvFeedbacks.Columns.Add("colSubject", "Subject")
        dgvFeedbacks.Columns.Add("colInstructor", "Instructor")
        dgvFeedbacks.Columns.Add("colSemester", "Semester")
        dgvFeedbacks.Columns.Add("colSubRating", "Subject Rating")
        dgvFeedbacks.Columns.Add("colInsRating", "Instructor Rating")
        dgvFeedbacks.Columns.Add("colComments", "Comments")
        dgvFeedbacks.Columns.Add("colDate", "Date")

        Dim raw As String = PtrToString(GetAllFeedback())


        If String.IsNullOrEmpty(raw) Then
            totalResponses.Text = "Total Responses: 0"
            Exit Sub
        End If

        Dim rows As String() = raw.Split("||")
        For Each row As String In rows
            If String.IsNullOrEmpty(row) Then Continue For
            Dim cols As String() = row.Split("|~|", StringSplitOptions.None)
            If cols.Length >= 9 Then
                dgvFeedbacks.Rows.Add(
                    cols(0), cols(1), cols(2), cols(3),
                    cols(4), cols(5), cols(6), cols(7), cols(8)
                )
            End If
        Next
        totalResponses.Text = "Total Responses: " & dgvFeedbacks.Rows.Count
    End Sub

    Private Sub ApplyFilter()
        If isLoading Then Exit Sub
        If ComboBox1.SelectedItem Is Nothing OrElse
           ComboBox2.SelectedItem Is Nothing OrElse
           ComboBox3.SelectedItem Is Nothing Then Exit Sub

        dgvFeedbacks.Rows.Clear()
        dgvFeedbacks.Columns.Clear()

        dgvFeedbacks.Columns.Add("colID", "ID")
        dgvFeedbacks.Columns.Add("colUsername", "Username")
        dgvFeedbacks.Columns.Add("colSubject", "Subject")
        dgvFeedbacks.Columns.Add("colInstructor", "Instructor")
        dgvFeedbacks.Columns.Add("colSemester", "Semester")
        dgvFeedbacks.Columns.Add("colSubRating", "Subject Rating")
        dgvFeedbacks.Columns.Add("colInsRating", "Instructor Rating")
        dgvFeedbacks.Columns.Add("colComments", "Comments")
        dgvFeedbacks.Columns.Add("colDate", "Date")

        Dim semester As String = If(ComboBox1.SelectedItem.ToString() = "All", "", ComboBox1.SelectedItem.ToString())
        Dim subject As String = If(ComboBox2.SelectedItem.ToString() = "All", "", ComboBox2.SelectedItem.ToString())
        Dim instructor As String = If(ComboBox3.SelectedItem.ToString() = "All", "", ComboBox3.SelectedItem.ToString())

        Dim raw As String = PtrToString(GetFilteredFeedback(semester, subject, instructor))
        If String.IsNullOrEmpty(raw) Then
            totalResponses.Text = "Total Responses: 0"
            Exit Sub
        End If

        Dim rows As String() = raw.Split("||")
        For Each row As String In rows
            If String.IsNullOrEmpty(row) Then Continue For
            Dim cols As String() = row.Split("|~|", StringSplitOptions.None)
            If cols.Length >= 9 Then
                dgvFeedbacks.Rows.Add(
                    cols(0), cols(1), cols(2), cols(3),
                    cols(4), cols(5), cols(6), cols(7), cols(8)
                )
            End If
        Next
        totalResponses.Text = "Total Responses: " & dgvFeedbacks.Rows.Count
    End Sub

    Private Sub LoadAnalytics()
        Dim total As Integer = GetTotalResponses()
        Dim subAvg As Double = Math.Round(GetAverageSubjectRating(""), 2)
        Dim insAvg As Double = Math.Round(GetAverageInstructorRating(""), 2)
        totalResponses.Text = "Total Responses: " & total
        Label1.Text = "Subject AVG Rating: " & subAvg & " / 5"
        Label2.Text = "Instructor AVG Rating: " & insAvg & " / 5"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ApplyFilter()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ApplyFilter()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ApplyFilter()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        isLoading = True
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        isLoading = False
        LoadFeedbackData()
        LoadAnalytics()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "CSV Files (*.csv)|*.csv"
        saveDialog.FileName = "feedback_export.csv"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            Dim success As Boolean = ExportCSV(saveDialog.FileName)
            If success Then
                MessageBox.Show("Exported successfully to:" & Environment.NewLine & saveDialog.FileName)
            Else
                MessageBox.Show("Export failed.")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to logout?",
            "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Dim loginForm As New Form3()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

End Class