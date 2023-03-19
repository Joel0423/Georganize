<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Profile))
        UsernameLabel = New Label()
        ProfilePictureBox = New PictureBox()
        BirthdayLabel = New Label()
        GenderLabel = New Label()
        DeleteAccountButton = New Button()
        EditProfileButton = New Button()
        Label1 = New Label()
        EmailLabel = New Label()
        PhoneLabel = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        CType(ProfilePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = Color.Transparent
        UsernameLabel.BorderStyle = BorderStyle.Fixed3D
        UsernameLabel.FlatStyle = FlatStyle.Popup
        UsernameLabel.Font = New Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameLabel.ForeColor = Color.Black
        UsernameLabel.Location = New Point(180, 130)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(124, 34)
        UsernameLabel.TabIndex = 7
        UsernameLabel.Text = "Username"' 
        ' ProfilePictureBox
        ' 
        ProfilePictureBox.ErrorImage = My.Resources.Resources.DefaultPic
        ProfilePictureBox.Location = New Point(430, 135)
        ProfilePictureBox.Name = "ProfilePictureBox"
        ProfilePictureBox.Size = New Size(125, 175)
        ProfilePictureBox.TabIndex = 8
        ProfilePictureBox.TabStop = False
        ' 
        ' BirthdayLabel
        ' 
        BirthdayLabel.AutoSize = True
        BirthdayLabel.BackColor = Color.Transparent
        BirthdayLabel.BorderStyle = BorderStyle.Fixed3D
        BirthdayLabel.FlatStyle = FlatStyle.Popup
        BirthdayLabel.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        BirthdayLabel.ForeColor = Color.Black
        BirthdayLabel.Location = New Point(180, 171)
        BirthdayLabel.Name = "BirthdayLabel"
        BirthdayLabel.Size = New Size(87, 28)
        BirthdayLabel.TabIndex = 9
        BirthdayLabel.Text = "Birthday"' 
        ' GenderLabel
        ' 
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = Color.Transparent
        GenderLabel.BorderStyle = BorderStyle.Fixed3D
        GenderLabel.FlatStyle = FlatStyle.Popup
        GenderLabel.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        GenderLabel.ForeColor = Color.Black
        GenderLabel.Location = New Point(180, 208)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New Size(75, 28)
        GenderLabel.TabIndex = 10
        GenderLabel.Text = "Gender"' 
        ' DeleteAccountButton
        ' 
        DeleteAccountButton.BackColor = Color.Transparent
        DeleteAccountButton.FlatStyle = FlatStyle.Flat
        DeleteAccountButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DeleteAccountButton.Location = New Point(404, 336)
        DeleteAccountButton.Name = "DeleteAccountButton"
        DeleteAccountButton.Size = New Size(176, 32)
        DeleteAccountButton.TabIndex = 11
        DeleteAccountButton.Text = "Delete Account"
        DeleteAccountButton.UseVisualStyleBackColor = False
        ' 
        ' EditProfileButton
        ' 
        EditProfileButton.BackColor = Color.Transparent
        EditProfileButton.FlatStyle = FlatStyle.Flat
        EditProfileButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        EditProfileButton.Location = New Point(102, 336)
        EditProfileButton.Name = "EditProfileButton"
        EditProfileButton.Size = New Size(176, 32)
        EditProfileButton.TabIndex = 12
        EditProfileButton.Text = "Edit Profile"
        EditProfileButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("SimSun-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(134, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(322, 50)
        Label1.TabIndex = 13
        Label1.Text = "Your Profile"' 
        ' EmailLabel
        ' 
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = Color.Transparent
        EmailLabel.BorderStyle = BorderStyle.Fixed3D
        EmailLabel.FlatStyle = FlatStyle.Popup
        EmailLabel.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        EmailLabel.ForeColor = Color.Black
        EmailLabel.Location = New Point(180, 245)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New Size(62, 28)
        EmailLabel.TabIndex = 14
        EmailLabel.Text = "Email"' 
        ' PhoneLabel
        ' 
        PhoneLabel.AutoSize = True
        PhoneLabel.BackColor = Color.Transparent
        PhoneLabel.BorderStyle = BorderStyle.Fixed3D
        PhoneLabel.FlatStyle = FlatStyle.Popup
        PhoneLabel.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        PhoneLabel.ForeColor = Color.Black
        PhoneLabel.Location = New Point(180, 286)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New Size(67, 28)
        PhoneLabel.TabIndex = 15
        PhoneLabel.Text = "Phone"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(118, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 21)
        Label2.TabIndex = 16
        Label2.Text = "Name"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(106, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 21)
        Label3.TabIndex = 17
        Label3.Text = "Birthday"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(109, 207)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 21)
        Label4.TabIndex = 18
        Label4.Text = "Gender"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(118, 245)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 21)
        Label5.TabIndex = 19
        Label5.Text = "Email"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(114, 285)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 21)
        Label6.TabIndex = 20
        Label6.Text = "Phone"' 
        ' Profile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(666, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PhoneLabel)
        Controls.Add(EmailLabel)
        Controls.Add(Label1)
        Controls.Add(EditProfileButton)
        Controls.Add(DeleteAccountButton)
        Controls.Add(GenderLabel)
        Controls.Add(BirthdayLabel)
        Controls.Add(ProfilePictureBox)
        Controls.Add(UsernameLabel)
        Name = "Profile"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Profile"
        CType(ProfilePictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameLabel As Label
    Friend WithEvents ProfilePictureBox As PictureBox
    Friend WithEvents BirthdayLabel As Label
    Friend WithEvents GenderLabel As Label
    Friend WithEvents DeleteAccountButton As Button
    Friend WithEvents EditProfileButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents PhoneLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
