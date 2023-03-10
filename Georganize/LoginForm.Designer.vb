<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LoginForm))
        UsernameBox = New TextBox()
        PasswordBox = New TextBox()
        SignInButton = New Button()
        SignUpButton = New Button()
        Timer1 = New Timer(components)
        LoadingLabel = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' UsernameBox
        ' 
        UsernameBox.Location = New Point(303, 169)
        UsernameBox.MaxLength = 30
        UsernameBox.Name = "UsernameBox"
        UsernameBox.Size = New Size(178, 23)
        UsernameBox.TabIndex = 0
        ' 
        ' PasswordBox
        ' 
        PasswordBox.Location = New Point(303, 211)
        PasswordBox.MaxLength = 20
        PasswordBox.Name = "PasswordBox"
        PasswordBox.Size = New Size(178, 23)
        PasswordBox.TabIndex = 1
        ' 
        ' SignInButton
        ' 
        SignInButton.BackColor = Color.Transparent
        SignInButton.FlatStyle = FlatStyle.Flat
        SignInButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        SignInButton.Location = New Point(406, 279)
        SignInButton.Name = "SignInButton"
        SignInButton.Size = New Size(86, 32)
        SignInButton.TabIndex = 2
        SignInButton.Text = "Sign-In"
        SignInButton.UseVisualStyleBackColor = False
        ' 
        ' SignUpButton
        ' 
        SignUpButton.BackColor = Color.Transparent
        SignUpButton.FlatStyle = FlatStyle.Flat
        SignUpButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        SignUpButton.Location = New Point(294, 279)
        SignUpButton.Name = "SignUpButton"
        SignUpButton.Size = New Size(84, 32)
        SignUpButton.TabIndex = 3
        SignUpButton.Text = "Sign-Up"
        SignUpButton.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 300
        ' 
        ' LoadingLabel
        ' 
        LoadingLabel.AutoSize = True
        LoadingLabel.BackColor = Color.Transparent
        LoadingLabel.ForeColor = SystemColors.ControlLightLight
        LoadingLabel.Location = New Point(372, 324)
        LoadingLabel.Name = "LoadingLabel"
        LoadingLabel.Size = New Size(0, 15)
        LoadingLabel.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("SimSun-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(260, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 50)
        Label1.TabIndex = 6
        Label1.Text = "Georganize"' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSlateBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(784, 411)
        Controls.Add(Label1)
        Controls.Add(LoadingLabel)
        Controls.Add(SignUpButton)
        Controls.Add(SignInButton)
        Controls.Add(PasswordBox)
        Controls.Add(UsernameBox)
        MaximumSize = New Size(800, 450)
        MinimumSize = New Size(800, 450)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameBox As TextBox
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents SignInButton As Button
    Friend WithEvents SignUpButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LoadingLabel As Label
    Friend WithEvents Label1 As Label
End Class
