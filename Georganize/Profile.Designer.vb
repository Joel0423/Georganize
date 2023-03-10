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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.ProfilePictureBox = New System.Windows.Forms.PictureBox()
        Me.BirthdayLabel = New System.Windows.Forms.Label()
        Me.GenderLabel = New System.Windows.Forms.Label()
        Me.DeleteAccountButton = New System.Windows.Forms.Button()
        Me.EditProfileButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UsernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UsernameLabel.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel.Location = New System.Drawing.Point(180, 130)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(124, 34)
        Me.UsernameLabel.TabIndex = 7
        Me.UsernameLabel.Text = "Username"
        '
        'ProfilePictureBox
        '
        Me.ProfilePictureBox.ErrorImage = Global.Georganize.My.Resources.Resources.PPError
        Me.ProfilePictureBox.Location = New System.Drawing.Point(430, 135)
        Me.ProfilePictureBox.Name = "ProfilePictureBox"
        Me.ProfilePictureBox.Size = New System.Drawing.Size(125, 175)
        Me.ProfilePictureBox.TabIndex = 8
        Me.ProfilePictureBox.TabStop = False
        '
        'BirthdayLabel
        '
        Me.BirthdayLabel.AutoSize = True
        Me.BirthdayLabel.BackColor = System.Drawing.Color.Transparent
        Me.BirthdayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BirthdayLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BirthdayLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BirthdayLabel.ForeColor = System.Drawing.Color.Black
        Me.BirthdayLabel.Location = New System.Drawing.Point(180, 171)
        Me.BirthdayLabel.Name = "BirthdayLabel"
        Me.BirthdayLabel.Size = New System.Drawing.Size(87, 28)
        Me.BirthdayLabel.TabIndex = 9
        Me.BirthdayLabel.Text = "Birthday"
        '
        'GenderLabel
        '
        Me.GenderLabel.AutoSize = True
        Me.GenderLabel.BackColor = System.Drawing.Color.Transparent
        Me.GenderLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GenderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GenderLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GenderLabel.ForeColor = System.Drawing.Color.Black
        Me.GenderLabel.Location = New System.Drawing.Point(180, 208)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(75, 28)
        Me.GenderLabel.TabIndex = 10
        Me.GenderLabel.Text = "Gender"
        '
        'DeleteAccountButton
        '
        Me.DeleteAccountButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteAccountButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteAccountButton.Location = New System.Drawing.Point(404, 336)
        Me.DeleteAccountButton.Name = "DeleteAccountButton"
        Me.DeleteAccountButton.Size = New System.Drawing.Size(176, 32)
        Me.DeleteAccountButton.TabIndex = 11
        Me.DeleteAccountButton.Text = "Delete Account"
        Me.DeleteAccountButton.UseVisualStyleBackColor = False
        '
        'EditProfileButton
        '
        Me.EditProfileButton.BackColor = System.Drawing.Color.Transparent
        Me.EditProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditProfileButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EditProfileButton.Location = New System.Drawing.Point(102, 336)
        Me.EditProfileButton.Name = "EditProfileButton"
        Me.EditProfileButton.Size = New System.Drawing.Size(176, 32)
        Me.EditProfileButton.TabIndex = 12
        Me.EditProfileButton.Text = "Edit Profile"
        Me.EditProfileButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("SimSun-ExtB", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(134, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 50)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Your Profile"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmailLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EmailLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EmailLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmailLabel.ForeColor = System.Drawing.Color.Black
        Me.EmailLabel.Location = New System.Drawing.Point(180, 245)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(62, 28)
        Me.EmailLabel.TabIndex = 14
        Me.EmailLabel.Text = "Email"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.BackColor = System.Drawing.Color.Transparent
        Me.PhoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PhoneLabel.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PhoneLabel.ForeColor = System.Drawing.Color.Black
        Me.PhoneLabel.Location = New System.Drawing.Point(180, 286)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(67, 28)
        Me.PhoneLabel.TabIndex = 15
        Me.PhoneLabel.Text = "Phone"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(118, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(106, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Birthday"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(109, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(118, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 21)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(114, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 21)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Phone"
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(666, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PhoneLabel)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EditProfileButton)
        Me.Controls.Add(Me.DeleteAccountButton)
        Me.Controls.Add(Me.GenderLabel)
        Me.Controls.Add(Me.BirthdayLabel)
        Me.Controls.Add(Me.ProfilePictureBox)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Name = "Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile"
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
