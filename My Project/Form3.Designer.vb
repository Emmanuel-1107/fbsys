<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Panel2 = New Panel()
        CheckBox1 = New CheckBox()
        lblError = New Label()
        Label3 = New Label()
        btnLogin = New Button()
        Label2 = New Label()
        txtPassword = New TextBox()
        Label1 = New Label()
        txtUsername = New TextBox()
        returnFORM2 = New Button()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(CheckBox1)
        Panel2.Controls.Add(lblError)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtUsername)
        Panel2.Location = New Point(165, 128)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(429, 320)
        Panel2.TabIndex = 2
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(273, 213)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(132, 24)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' lblError
        ' 
        lblError.AutoSize = True
        lblError.Location = New Point(58, 213)
        lblError.Name = "lblError"
        lblError.Size = New Size(103, 20)
        lblError.TabIndex = 6
        lblError.Text = "error message"
        lblError.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 17.0F)
        Label3.Location = New Point(117, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(205, 40)
        Label3.TabIndex = 5
        Label3.Text = "ADMIN LOGIN"
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 13.0F)
        btnLogin.Location = New Point(140, 253)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(143, 51)
        btnLogin.TabIndex = 4
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(58, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 15.0F)
        txtPassword.Location = New Point(58, 169)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(318, 41)
        txtPassword.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 15.0F)
        txtUsername.Location = New Point(58, 94)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(318, 41)
        txtUsername.TabIndex = 0
        ' 
        ' returnFORM2
        ' 
        returnFORM2.Font = New Font("Segoe UI", 11.0F)
        returnFORM2.Location = New Point(659, 483)
        returnFORM2.Name = "returnFORM2"
        returnFORM2.Size = New Size(117, 52)
        returnFORM2.TabIndex = 3
        returnFORM2.Text = "RETURN"
        returnFORM2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 20.0F, FontStyle.Bold)
        Label4.Location = New Point(359, 51)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 46)
        Label4.TabIndex = 31
        Label4.Text = "TUGN"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.tugn1
        PictureBox1.Location = New Point(242, -6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(141, 175)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 32
        PictureBox1.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(788, 547)
        Controls.Add(Label4)
        Controls.Add(returnFORM2)
        Controls.Add(Panel2)
        Controls.Add(PictureBox1)
        Name = "Form3"
        Text = "Form3"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblError As Label
    Friend WithEvents returnFORM2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
