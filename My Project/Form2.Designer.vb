<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        txtUsername = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        CmbSubject = New ComboBox()
        Label3 = New Label()
        cmbInstructor = New ComboBox()
        Label4 = New Label()
        cmbSemester = New ComboBox()
        Label5 = New Label()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        txtComments = New TextBox()
        Label8 = New Label()
        grpInstructorRating = New GroupBox()
        RadioButton9 = New RadioButton()
        RadioButton10 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton8 = New RadioButton()
        RadioButton7 = New RadioButton()
        grpSubjectRating = New GroupBox()
        lblCharCount = New Label()
        btnSubmit = New Button()
        Label9 = New Label()
        btnBack = New Button()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        grpInstructorRating.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 15F)
        txtUsername.Location = New Point(12, 102)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Text here.."
        txtUsername.Size = New Size(300, 41)
        txtUsername.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F)
        Label1.Location = New Point(12, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 20)
        Label1.TabIndex = 1
        Label1.Text = "Username (OPTIONAL)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        Label2.Location = New Point(73, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 46)
        Label2.TabIndex = 2
        Label2.Text = "TUGN"
        ' 
        ' CmbSubject
        ' 
        CmbSubject.Font = New Font("Segoe UI", 12F)
        CmbSubject.FormattingEnabled = True
        CmbSubject.Items.AddRange(New Object() {"IPROGLAB", "IPROGLEC", "DISSTRU1", "DBMGTLAB", "DBMGTLEC", "GEFILDIS", "GEPEFITE", "REMMCRAT", "NSTPROG2", "GEPANIPI", "GEPURPCO"})
        CmbSubject.Location = New Point(12, 182)
        CmbSubject.Name = "CmbSubject"
        CmbSubject.Size = New Size(300, 36)
        CmbSubject.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 20)
        Label3.TabIndex = 4
        Label3.Text = "Subject"
        ' 
        ' cmbInstructor
        ' 
        cmbInstructor.Font = New Font("Segoe UI", 12F)
        cmbInstructor.FormattingEnabled = True
        cmbInstructor.Items.AddRange(New Object() {"Mr. Jovel Advincula", "Mrs. Sheila Marie Matias", "Mr. Al Santiago", "Ms. Kathleen Dimaano", "Mrs. Charlene Ronda", " Mr. Louie Cris Rivera", "Mr. Ranilo Pardito", "Mr. Jonathan Torzar"})
        cmbInstructor.Location = New Point(12, 254)
        cmbInstructor.Name = "cmbInstructor"
        cmbInstructor.Size = New Size(300, 36)
        cmbInstructor.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 20)
        Label4.TabIndex = 6
        Label4.Text = "Instructor"
        ' 
        ' cmbSemester
        ' 
        cmbSemester.Font = New Font("Segoe UI", 12F)
        cmbSemester.FormattingEnabled = True
        cmbSemester.Items.AddRange(New Object() {"1", "2"})
        cmbSemester.Location = New Point(12, 325)
        cmbSemester.Name = "cmbSemester"
        cmbSemester.Size = New Size(300, 36)
        cmbSemester.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 650)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 20)
        Label5.TabIndex = 8
        Label5.Text = "Semester"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 10F)
        RadioButton2.Location = New Point(327, 184)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(40, 27)
        RadioButton2.TabIndex = 9
        RadioButton2.Text = "1"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(364, 185)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(38, 24)
        RadioButton1.TabIndex = 10
        RadioButton1.Text = "2"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(406, 186)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(38, 24)
        RadioButton3.TabIndex = 11
        RadioButton3.Text = "3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(444, 186)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(38, 24)
        RadioButton4.TabIndex = 12
        RadioButton4.Text = "4"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(482, 186)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(38, 24)
        RadioButton5.TabIndex = 13
        RadioButton5.Text = "5"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' txtComments
        ' 
        txtComments.Font = New Font("Segoe UI", 15F)
        txtComments.Location = New Point(12, 394)
        txtComments.MaxLength = 2000
        txtComments.Multiline = True
        txtComments.Name = "txtComments"
        txtComments.PlaceholderText = "Text here.."
        txtComments.Size = New Size(300, 43)
        txtComments.TabIndex = 21
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 371)
        Label8.Name = "Label8"
        Label8.Size = New Size(158, 20)
        Label8.TabIndex = 22
        Label8.Text = "Comment (OPTIONAL)"
        ' 
        ' grpInstructorRating
        ' 
        grpInstructorRating.Controls.Add(RadioButton9)
        grpInstructorRating.Controls.Add(RadioButton10)
        grpInstructorRating.Controls.Add(RadioButton6)
        grpInstructorRating.Controls.Add(RadioButton8)
        grpInstructorRating.Controls.Add(RadioButton7)
        grpInstructorRating.Location = New Point(318, 254)
        grpInstructorRating.Name = "grpInstructorRating"
        grpInstructorRating.Size = New Size(210, 53)
        grpInstructorRating.TabIndex = 23
        grpInstructorRating.TabStop = False
        grpInstructorRating.Text = "Rate Instructor"
        ' 
        ' RadioButton9
        ' 
        RadioButton9.AccessibleName = "instructorRating"
        RadioButton9.AutoSize = True
        RadioButton9.Location = New Point(124, 23)
        RadioButton9.Name = "RadioButton9"
        RadioButton9.Size = New Size(38, 24)
        RadioButton9.TabIndex = 27
        RadioButton9.Text = "4"
        RadioButton9.UseVisualStyleBackColor = True
        ' 
        ' RadioButton10
        ' 
        RadioButton10.AccessibleName = "instructorRating"
        RadioButton10.AutoSize = True
        RadioButton10.Location = New Point(164, 23)
        RadioButton10.Name = "RadioButton10"
        RadioButton10.Size = New Size(38, 24)
        RadioButton10.TabIndex = 28
        RadioButton10.Text = "5"
        RadioButton10.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AccessibleName = "instructorRating"
        RadioButton6.AutoSize = True
        RadioButton6.Location = New Point(7, 23)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(38, 24)
        RadioButton6.TabIndex = 24
        RadioButton6.Text = "1"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton8
        ' 
        RadioButton8.AccessibleName = "instructorRating"
        RadioButton8.AutoSize = True
        RadioButton8.Location = New Point(86, 23)
        RadioButton8.Name = "RadioButton8"
        RadioButton8.Size = New Size(38, 24)
        RadioButton8.TabIndex = 26
        RadioButton8.Text = "3"
        RadioButton8.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AccessibleName = "instructorRating"
        RadioButton7.AutoSize = True
        RadioButton7.Location = New Point(45, 23)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(38, 24)
        RadioButton7.TabIndex = 25
        RadioButton7.Text = "2"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' grpSubjectRating
        ' 
        grpSubjectRating.Location = New Point(318, 159)
        grpSubjectRating.Name = "grpSubjectRating"
        grpSubjectRating.Size = New Size(210, 59)
        grpSubjectRating.TabIndex = 24
        grpSubjectRating.TabStop = False
        grpSubjectRating.Text = "Rate Subject"
        ' 
        ' lblCharCount
        ' 
        lblCharCount.AutoSize = True
        lblCharCount.Font = New Font("Segoe UI", 7F)
        lblCharCount.Location = New Point(12, 440)
        lblCharCount.Name = "lblCharCount"
        lblCharCount.Size = New Size(145, 15)
        lblCharCount.TabIndex = 25
        lblCharCount.Text = "Character Counter: 0/2000"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Segoe UI", 13F)
        btnSubmit.Location = New Point(23, 472)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(134, 53)
        btnSubmit.TabIndex = 26
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 7F)
        Label9.Location = New Point(534, 268)
        Label9.Name = "Label9"
        Label9.Size = New Size(223, 90)
        Label9.TabIndex = 28
        Label9.Text = "Rate the Instructor based on their overall " & vbCrLf & "performance such as effectiveness, " & vbCrLf & "fairness, attitude, uses of materials " & vbCrLf & "and knowledge." & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Segoe UI", 13F)
        btnBack.Location = New Point(623, 472)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(134, 53)
        btnBack.TabIndex = 29
        btnBack.Text = "Return"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.tugn1
        PictureBox1.Location = New Point(-5, -18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 130)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 7F)
        Label6.Location = New Point(534, 159)
        Label6.Name = "Label6"
        Label6.Size = New Size(238, 90)
        Label6.TabIndex = 31
        Label6.Text = resources.GetString("Label6.Text")
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 302)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 20)
        Label7.TabIndex = 32
        Label7.Text = "Semester"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(789, 545)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(btnBack)
        Controls.Add(Label9)
        Controls.Add(btnSubmit)
        Controls.Add(lblCharCount)
        Controls.Add(Label8)
        Controls.Add(txtComments)
        Controls.Add(RadioButton5)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton1)
        Controls.Add(RadioButton2)
        Controls.Add(Label5)
        Controls.Add(cmbSemester)
        Controls.Add(Label4)
        Controls.Add(cmbInstructor)
        Controls.Add(Label3)
        Controls.Add(CmbSubject)
        Controls.Add(Label1)
        Controls.Add(txtUsername)
        Controls.Add(grpInstructorRating)
        Controls.Add(grpSubjectRating)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        grpInstructorRating.ResumeLayout(False)
        grpInstructorRating.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CmbSubject As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbInstructor As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents txtComments As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents grpInstructorRating As GroupBox
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents grpSubjectRating As GroupBox
    Friend WithEvents lblCharCount As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
