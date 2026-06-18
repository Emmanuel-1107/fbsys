<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
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
        lblError = New Label()
        txtPassword = New TextBox()
        Panel2 = New Panel()
        btnForgotPassword = New Button()
        chkShowPassword = New CheckBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        btnLogin = New Button()
        Label2 = New Label()
        Label1 = New Label()
        txtUsername = New TextBox()
        returnFORM1 = New Button()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblError
        ' 
        lblError.AutoSize = True
        lblError.Location = New Point(58, 307)
        lblError.Name = "lblError"
        lblError.Size = New Size(103, 20)
        lblError.TabIndex = 6
        lblError.Text = "error message"
        lblError.Visible = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 15F)
        txtPassword.Location = New Point(176, 247)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(318, 41)
        txtPassword.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(btnForgotPassword)
        Panel2.Controls.Add(lblError)
        Panel2.Controls.Add(chkShowPassword)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(118, -16)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(429, 417)
        Panel2.TabIndex = 3
        ' 
        ' btnForgotPassword
        ' 
        btnForgotPassword.Location = New Point(272, 310)
        btnForgotPassword.Name = "btnForgotPassword"
        btnForgotPassword.Size = New Size(145, 29)
        btnForgotPassword.TabIndex = 34
        btnForgotPassword.Text = "Forgot Password?"
        btnForgotPassword.UseVisualStyleBackColor = True
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(244, 267)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(132, 24)
        chkShowPassword.TabIndex = 7
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.tugn1
        PictureBox1.Location = New Point(128, -13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(141, 175)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 17F)
        Label3.Location = New Point(219, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(232, 40)
        Label3.TabIndex = 5
        Label3.Text = "STUDENT LOGIN"
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 13F)
        btnLogin.Location = New Point(258, 331)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(143, 51)
        btnLogin.TabIndex = 4
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(176, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(176, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 20)
        Label1.TabIndex = 1
        Label1.Text = "Student Number"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 15F)
        txtUsername.Location = New Point(176, 172)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(318, 41)
        txtUsername.TabIndex = 0
        ' 
        ' returnFORM1
        ' 
        returnFORM1.Font = New Font("Segoe UI", 9F)
        returnFORM1.Location = New Point(567, 389)
        returnFORM1.Name = "returnFORM1"
        returnFORM1.Size = New Size(95, 37)
        returnFORM1.TabIndex = 7
        returnFORM1.Text = "RETURN"
        returnFORM1.UseVisualStyleBackColor = True
        ' 
        ' LoginForm1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(674, 438)
        Controls.Add(returnFORM1)
        Controls.Add(Label3)
        Controls.Add(btnLogin)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "LoginForm1"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblError As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents returnFORM1 As Button
    Friend WithEvents btnForgotPassword As Button

End Class
