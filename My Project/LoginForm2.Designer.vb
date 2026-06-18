<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm2
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
        returnFORM1 = New Button()
        lblError = New Label()
        Label3 = New Label()
        btnLogin = New Button()
        txtUsername = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        txtPassword = New TextBox()
        Panel2 = New Panel()
        Label4 = New Label()
        TextBox1 = New TextBox()
        chkShowPassword = New CheckBox()
        PictureBox1 = New PictureBox()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' returnFORM1
        ' 
        returnFORM1.Font = New Font("Segoe UI", 9F)
        returnFORM1.Location = New Point(576, 455)
        returnFORM1.Name = "returnFORM1"
        returnFORM1.Size = New Size(95, 37)
        returnFORM1.TabIndex = 16
        returnFORM1.Text = "RETURN"
        returnFORM1.UseVisualStyleBackColor = True
        ' 
        ' lblError
        ' 
        lblError.AutoSize = True
        lblError.Location = New Point(58, 389)
        lblError.Name = "lblError"
        lblError.Size = New Size(103, 20)
        lblError.TabIndex = 15
        lblError.Text = "error message"
        lblError.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 17F)
        Label3.Location = New Point(69, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(289, 40)
        Label3.TabIndex = 14
        Label3.Text = "CHANGE PASSWORD"
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 13F)
        btnLogin.Location = New Point(128, 420)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(143, 51)
        btnLogin.TabIndex = 13
        btnLogin.Text = "Enter"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 15F)
        txtUsername.Location = New Point(58, 343)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(318, 41)
        txtUsername.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(58, 320)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 20)
        Label2.TabIndex = 11
        Label2.Text = "Confirm Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 253)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 20)
        Label1.TabIndex = 9
        Label1.Text = "Enter Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 15F)
        txtPassword.Location = New Point(58, 276)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(318, 41)
        txtPassword.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(chkShowPassword)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(lblError)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(122, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(429, 490)
        Panel2.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(58, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 34
        Label4.Text = "Student ID"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 15F)
        TextBox1.Location = New Point(58, 207)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(318, 41)
        TextBox1.TabIndex = 35
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(266, 391)
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
        ' LoginForm2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(694, 517)
        Controls.Add(returnFORM1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm2"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "LoginForm2"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents returnFORM1 As Button
    Friend WithEvents lblError As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox

End Class
