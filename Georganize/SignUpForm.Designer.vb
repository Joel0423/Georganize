<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        UsernameTextBox = New TextBox()
        PasswordBox1 = New TextBox()
        PasswordBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        GenderBox = New ComboBox()
        EmailBox = New TextBox()
        Label9 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        ShowPassCheckbox = New CheckBox()
        SubmitButton = New Button()
        PhoneBox = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        PictureBox1 = New PictureBox()
        ProfilePicButton = New Button()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(68, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.BackColor = Color.MistyRose
        UsernameTextBox.Location = New Point(68, 140)
        UsernameTextBox.MaxLength = 30
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(166, 23)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordBox1
        ' 
        PasswordBox1.BackColor = Color.MistyRose
        PasswordBox1.Location = New Point(68, 283)
        PasswordBox1.MaxLength = 20
        PasswordBox1.Name = "PasswordBox1"
        PasswordBox1.PasswordChar = "*"c
        PasswordBox1.Size = New Size(166, 23)
        PasswordBox1.TabIndex = 5
        ' 
        ' PasswordBox2
        ' 
        PasswordBox2.BackColor = Color.MistyRose
        PasswordBox2.Location = New Point(70, 368)
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
        Label2.Location = New Point(300, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 15)
        Label2.TabIndex = 7
        Label2.Text = "Your Birthday"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(70, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 8
        Label3.Text = "Gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(68, 265)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 9
        Label4.Text = "Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(70, 350)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 15)
        Label5.TabIndex = 10
        Label5.Text = "Confirm Password"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(300, 140)
        DateTimePicker1.MinDate = New DateTime(1900, 1, 1, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(164, 23)
        DateTimePicker1.TabIndex = 11
        DateTimePicker1.Value = New DateTime(2023, 1, 22, 22, 3, 24, 0)
        ' 
        ' GenderBox
        ' 
        GenderBox.BackColor = Color.MistyRose
        GenderBox.DropDownStyle = ComboBoxStyle.DropDownList
        GenderBox.FormattingEnabled = True
        GenderBox.Items.AddRange(New Object() {"Male", "Female", "Others"})
        GenderBox.Location = New Point(70, 210)
        GenderBox.Name = "GenderBox"
        GenderBox.Size = New Size(164, 23)
        GenderBox.TabIndex = 12
        ' 
        ' EmailBox
        ' 
        EmailBox.BackColor = Color.MistyRose
        EmailBox.Location = New Point(294, 283)
        EmailBox.MaxLength = 30
        EmailBox.Name = "EmailBox"
        EmailBox.Size = New Size(166, 23)
        EmailBox.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(300, 265)
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
        ShowPassCheckbox.ForeColor = Color.Black
        ShowPassCheckbox.Location = New Point(70, 320)
        ShowPassCheckbox.Name = "ShowPassCheckbox"
        ShowPassCheckbox.Size = New Size(126, 19)
        ShowPassCheckbox.TabIndex = 19
        ShowPassCheckbox.Text = "Show       Password"
        ShowPassCheckbox.UseVisualStyleBackColor = False
        ' 
        ' SubmitButton
        ' 
        SubmitButton.BackColor = Color.Transparent
        SubmitButton.FlatStyle = FlatStyle.Flat
        SubmitButton.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        SubmitButton.Location = New Point(327, 411)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(166, 42)
        SubmitButton.TabIndex = 20
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = False
        ' 
        ' PhoneBox
        ' 
        PhoneBox.BackColor = Color.MistyRose
        PhoneBox.Location = New Point(300, 210)
        PhoneBox.MaxLength = 10
        PhoneBox.Name = "PhoneBox"
        PhoneBox.Size = New Size(164, 23)
        PhoneBox.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(300, 192)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 15)
        Label6.TabIndex = 23
        Label6.Text = "Phone number"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Font = New Font("Segoe UI Historic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(263, 24)
        Label7.Name = "Label7"
        Label7.Size = New Size(268, 34)
        Label7.TabIndex = 24
        Label7.Text = "Sign-Up for Georganize"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(585, 122)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 175)
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' ProfilePicButton
        ' 
        ProfilePicButton.BackColor = Color.Transparent
        ProfilePicButton.FlatStyle = FlatStyle.Flat
        ProfilePicButton.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        ProfilePicButton.Location = New Point(585, 307)
        ProfilePicButton.Name = "ProfilePicButton"
        ProfilePicButton.Size = New Size(125, 37)
        ProfilePicButton.TabIndex = 26
        ProfilePicButton.Text = "Insert"
        ProfilePicButton.UseVisualStyleBackColor = False
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.InactiveCaption
        BackgroundImage = My.Resources.Resources.MSign2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(784, 521)
        Controls.Add(ProfilePicButton)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(PhoneBox)
        Controls.Add(SubmitButton)
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
        MaximumSize = New Size(900, 590)
        MinimumSize = New Size(650, 500)
        Name = "SignUpForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign Up Form"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordBox1 As TextBox
    Friend WithEvents PasswordBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GenderBox As ComboBox
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ShowPassCheckbox As CheckBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents PhoneBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ProfilePicButton As Button
End Class
