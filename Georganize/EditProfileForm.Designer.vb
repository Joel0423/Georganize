<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditProfileForm
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
        Label1 = New Label()
        UsernameTextBox = New TextBox()
        PasswordBox1 = New TextBox()
        PasswordBox2 = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        EmailBox = New TextBox()
        Label9 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        ShowPassCheckbox = New CheckBox()
        PhoneBox = New TextBox()
        Label6 = New Label()
        SubmitButton = New Button()
        ProfilePicBox = New PictureBox()
        ProfilePicButton = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        Label3 = New Label()
        GenderBox = New ComboBox()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ProfilePicBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(18, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.BackColor = Color.MistyRose
        UsernameTextBox.Location = New Point(18, 94)
        UsernameTextBox.MaxLength = 30
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(166, 23)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordBox1
        ' 
        PasswordBox1.BackColor = Color.MistyRose
        PasswordBox1.Location = New Point(18, 250)
        PasswordBox1.MaxLength = 20
        PasswordBox1.Name = "PasswordBox1"
        PasswordBox1.PasswordChar = "*"c
        PasswordBox1.Size = New Size(166, 23)
        PasswordBox1.TabIndex = 5
        ' 
        ' PasswordBox2
        ' 
        PasswordBox2.BackColor = Color.MistyRose
        PasswordBox2.Location = New Point(18, 314)
        PasswordBox2.MaxLength = 20
        PasswordBox2.Name = "PasswordBox2"
        PasswordBox2.PasswordChar = "*"c
        PasswordBox2.Size = New Size(166, 23)
        PasswordBox2.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(255, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 7
        Label2.Text = "Birthday"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(18, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 15)
        Label4.TabIndex = 9
        Label4.Text = "Change password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(18, 296)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 15)
        Label5.TabIndex = 10
        Label5.Text = "Re-enter password"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(255, 94)
        DateTimePicker1.MinDate = New DateTime(1900, 1, 1, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(164, 23)
        DateTimePicker1.TabIndex = 11
        DateTimePicker1.Value = New DateTime(2023, 1, 22, 22, 3, 24, 0)
        ' 
        ' EmailBox
        ' 
        EmailBox.BackColor = Color.MistyRose
        EmailBox.Location = New Point(257, 250)
        EmailBox.MaxLength = 30
        EmailBox.Name = "EmailBox"
        EmailBox.Size = New Size(164, 23)
        EmailBox.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = SystemColors.ControlText
        Label9.Location = New Point(257, 232)
        Label9.Name = "Label9"
        Label9.Size = New Size(36, 15)
        Label9.TabIndex = 17
        Label9.Text = "Email"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.BlinkRate = 180
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ShowPassCheckbox
        ' 
        ShowPassCheckbox.AutoSize = True
        ShowPassCheckbox.BackColor = Color.Transparent
        ShowPassCheckbox.ForeColor = SystemColors.ControlText
        ShowPassCheckbox.Location = New Point(18, 343)
        ShowPassCheckbox.Name = "ShowPassCheckbox"
        ShowPassCheckbox.Size = New Size(108, 19)
        ShowPassCheckbox.TabIndex = 19
        ShowPassCheckbox.Text = "Show Password"
        ShowPassCheckbox.UseVisualStyleBackColor = False
        ' 
        ' PhoneBox
        ' 
        PhoneBox.BackColor = Color.MistyRose
        PhoneBox.Location = New Point(255, 171)
        PhoneBox.MaxLength = 10
        PhoneBox.Name = "PhoneBox"
        PhoneBox.Size = New Size(166, 23)
        PhoneBox.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(255, 153)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 15)
        Label6.TabIndex = 23
        Label6.Text = "Phone number"
        ' 
        ' SubmitButton
        ' 
        SubmitButton.BackColor = Color.WhiteSmoke
        SubmitButton.FlatStyle = FlatStyle.Flat
        SubmitButton.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        SubmitButton.Location = New Point(255, 343)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(166, 42)
        SubmitButton.TabIndex = 24
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = False
        ' 
        ' ProfilePicBox
        ' 
        ProfilePicBox.ErrorImage = My.Resources.Resources.DefaultPic
        ProfilePicBox.Location = New Point(510, 76)
        ProfilePicBox.Name = "ProfilePicBox"
        ProfilePicBox.Size = New Size(125, 175)
        ProfilePicBox.TabIndex = 25
        ProfilePicBox.TabStop = False
        ' 
        ' ProfilePicButton
        ' 
        ProfilePicButton.BackColor = Color.WhiteSmoke
        ProfilePicButton.FlatStyle = FlatStyle.Flat
        ProfilePicButton.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        ProfilePicButton.Location = New Point(510, 273)
        ProfilePicButton.Name = "ProfilePicButton"
        ProfilePicButton.Size = New Size(125, 38)
        ProfilePicButton.TabIndex = 26
        ProfilePicButton.Text = "Edit"
        ProfilePicButton.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(18, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 8
        Label3.Text = "Gender"
        ' 
        ' GenderBox
        ' 
        GenderBox.BackColor = Color.MistyRose
        GenderBox.DropDownStyle = ComboBoxStyle.DropDownList
        GenderBox.FormattingEnabled = True
        GenderBox.Items.AddRange(New Object() {"Male", "Female", "Others"})
        GenderBox.Location = New Point(18, 171)
        GenderBox.Name = "GenderBox"
        GenderBox.Size = New Size(164, 23)
        GenderBox.TabIndex = 12
        ' 
        ' EditProfileForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.InactiveCaption
        BackgroundImage = My.Resources.Resources.MSign3
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(659, 411)
        Controls.Add(ProfilePicButton)
        Controls.Add(ProfilePicBox)
        Controls.Add(SubmitButton)
        Controls.Add(Label6)
        Controls.Add(PhoneBox)
        Controls.Add(ShowPassCheckbox)
        Controls.Add(Label9)
        Controls.Add(EmailBox)
        Controls.Add(GenderBox)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PasswordBox2)
        Controls.Add(PasswordBox1)
        Controls.Add(UsernameTextBox)
        Controls.Add(Label1)
        MaximizeBox = False
        MaximumSize = New Size(675, 450)
        MinimizeBox = False
        MinimumSize = New Size(675, 450)
        Name = "EditProfileForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Edit Profile"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ProfilePicBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordBox1 As TextBox
    Friend WithEvents PasswordBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ShowPassCheckbox As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PhoneBox As TextBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ProfilePicButton As Button
    Friend WithEvents ProfilePicBox As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GenderBox As ComboBox
    Friend WithEvents Label3 As Label
End Class
