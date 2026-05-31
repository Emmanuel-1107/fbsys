<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnGiveFeedback = New Button()
        btnAdminLogin = New Button()
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        title = New Label()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGiveFeedback
        ' 
        btnGiveFeedback.BackColor = SystemColors.ControlLight
        btnGiveFeedback.Font = New Font("Segoe UI", 20F)
        btnGiveFeedback.ForeColor = SystemColors.ActiveCaptionText
        btnGiveFeedback.Location = New Point(34, 35)
        btnGiveFeedback.Name = "btnGiveFeedback"
        btnGiveFeedback.Size = New Size(382, 82)
        btnGiveFeedback.TabIndex = 1
        btnGiveFeedback.Text = "FEEDBACK"
        btnGiveFeedback.UseVisualStyleBackColor = False
        ' 
        ' btnAdminLogin
        ' 
        btnAdminLogin.BackColor = SystemColors.ControlLight
        btnAdminLogin.Font = New Font("Segoe UI", 20F)
        btnAdminLogin.ForeColor = SystemColors.ActiveCaptionText
        btnAdminLogin.Location = New Point(34, 153)
        btnAdminLogin.Name = "btnAdminLogin"
        btnAdminLogin.Size = New Size(382, 82)
        btnAdminLogin.TabIndex = 2
        btnAdminLogin.Text = "ADMIN "
        btnAdminLogin.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.MenuBar
        GroupBox1.Controls.Add(btnGiveFeedback)
        GroupBox1.Controls.Add(btnAdminLogin)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.ForeColor = SystemColors.ActiveBorder
        GroupBox1.Location = New Point(164, 203)
        GroupBox1.Margin = New Padding(10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(457, 282)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = My.Resources.Resources.tugn_smol
        PictureBox1.Location = New Point(261, -59)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 348)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' title
        ' 
        title.AutoSize = True
        title.Font = New Font("FSP DEMO - Greycliff CF", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        title.Location = New Point(383, 69)
        title.Name = "title"
        title.Size = New Size(156, 69)
        title.TabIndex = 6
        title.Text = "TUGN"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(788, 547)
        Controls.Add(GroupBox1)
        Controls.Add(title)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnGiveFeedback As Button
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents title As Label

End Class
