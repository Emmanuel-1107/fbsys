<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        wclbl = New Label()
        PictureBox1 = New PictureBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        btnRefresh = New Button()
        dgvFeedbacks = New DataGridView()
        totalResponses = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvFeedbacks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' wclbl
        ' 
        wclbl.AutoSize = True
        wclbl.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        wclbl.Location = New Point(108, 36)
        wclbl.Name = "wclbl"
        wclbl.Size = New Size(274, 46)
        wclbl.TabIndex = 1
        wclbl.Text = "Welcome, Admin"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.tugn1
        PictureBox1.Location = New Point(0, -9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(130, 163)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(152, 148)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(164, 28)
        ComboBox1.TabIndex = 3
        ComboBox1.Text = "SEMESTER"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(372, 148)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(164, 28)
        ComboBox2.TabIndex = 7
        ComboBox2.Text = "SUBJECT"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(606, 148)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(164, 28)
        ComboBox3.TabIndex = 8
        ComboBox3.Text = "INSTRUCTOR"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Font = New Font("Segoe UI", 10F)
        btnRefresh.Location = New Point(643, 524)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(127, 53)
        btnRefresh.TabIndex = 9
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' dgvFeedbacks
        ' 
        dgvFeedbacks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFeedbacks.Location = New Point(152, 206)
        dgvFeedbacks.Name = "dgvFeedbacks"
        dgvFeedbacks.RowHeadersWidth = 51
        dgvFeedbacks.Size = New Size(618, 296)
        dgvFeedbacks.TabIndex = 10
        ' 
        ' totalResponses
        ' 
        totalResponses.AutoSize = True
        totalResponses.Location = New Point(152, 525)
        totalResponses.Name = "totalResponses"
        totalResponses.Size = New Size(130, 20)
        totalResponses.TabIndex = 11
        totalResponses.Text = "Total Responses: 0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(152, 557)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 20)
        Label1.TabIndex = 12
        Label1.Text = "Subject AVG Rating: 0.0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(152, 590)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 20)
        Label2.TabIndex = 13
        Label2.Text = "Instructor AVG Rating: 0.0"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10F)
        Button1.Location = New Point(352, 528)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 50)
        Button1.TabIndex = 14
        Button1.Text = "Export to CSV"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.Location = New Point(824, 24)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 59)
        Button2.TabIndex = 15
        Button2.Text = "LOGOUT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(974, 651)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(totalResponses)
        Controls.Add(dgvFeedbacks)
        Controls.Add(btnRefresh)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(wclbl)
        Controls.Add(PictureBox1)
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvFeedbacks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents wclbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvFeedbacks As DataGridView
    Friend WithEvents totalResponses As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
