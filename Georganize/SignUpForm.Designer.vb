﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordBox1 = New System.Windows.Forms.TextBox()
        Me.PasswordBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GenderBox = New System.Windows.Forms.ComboBox()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ShowPassCheckbox = New System.Windows.Forms.CheckBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.PhoneBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProfilePicButton = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(68, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BackColor = System.Drawing.Color.MistyRose
        Me.UsernameTextBox.Location = New System.Drawing.Point(68, 140)
        Me.UsernameTextBox.MaxLength = 30
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(166, 23)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordBox1
        '
        Me.PasswordBox1.BackColor = System.Drawing.Color.MistyRose
        Me.PasswordBox1.Location = New System.Drawing.Point(68, 283)
        Me.PasswordBox1.MaxLength = 20
        Me.PasswordBox1.Name = "PasswordBox1"
        Me.PasswordBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox1.Size = New System.Drawing.Size(166, 23)
        Me.PasswordBox1.TabIndex = 5
        '
        'PasswordBox2
        '
        Me.PasswordBox2.BackColor = System.Drawing.Color.MistyRose
        Me.PasswordBox2.Location = New System.Drawing.Point(70, 368)
        Me.PasswordBox2.MaxLength = 20
        Me.PasswordBox2.Name = "PasswordBox2"
        Me.PasswordBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox2.Size = New System.Drawing.Size(166, 23)
        Me.PasswordBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(300, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Your Birthday"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(70, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(68, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(70, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Confirm Password"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(300, 140)
        Me.DateTimePicker1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(164, 23)
        Me.DateTimePicker1.TabIndex = 11
        Me.DateTimePicker1.Value = New Date(2023, 1, 22, 22, 3, 24, 0)
        '
        'GenderBox
        '
        Me.GenderBox.BackColor = System.Drawing.Color.MistyRose
        Me.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderBox.FormattingEnabled = True
        Me.GenderBox.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.GenderBox.Location = New System.Drawing.Point(70, 210)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(164, 23)
        Me.GenderBox.TabIndex = 12
        '
        'EmailBox
        '
        Me.EmailBox.BackColor = System.Drawing.Color.MistyRose
        Me.EmailBox.Location = New System.Drawing.Point(294, 283)
        Me.EmailBox.MaxLength = 30
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(166, 23)
        Me.EmailBox.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(300, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Email"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 180
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ShowPassCheckbox
        '
        Me.ShowPassCheckbox.AutoSize = True
        Me.ShowPassCheckbox.BackColor = System.Drawing.Color.Transparent
        Me.ShowPassCheckbox.ForeColor = System.Drawing.Color.Black
        Me.ShowPassCheckbox.Location = New System.Drawing.Point(70, 320)
        Me.ShowPassCheckbox.Name = "ShowPassCheckbox"
        Me.ShowPassCheckbox.Size = New System.Drawing.Size(126, 19)
        Me.ShowPassCheckbox.TabIndex = 19
        Me.ShowPassCheckbox.Text = "Show       Password"
        Me.ShowPassCheckbox.UseVisualStyleBackColor = False
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.Transparent
        Me.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitButton.Font = New System.Drawing.Font("Segoe UI Historic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SubmitButton.Location = New System.Drawing.Point(327, 411)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(166, 42)
        Me.SubmitButton.TabIndex = 20
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'PhoneBox
        '
        Me.PhoneBox.BackColor = System.Drawing.Color.MistyRose
        Me.PhoneBox.Location = New System.Drawing.Point(300, 210)
        Me.PhoneBox.MaxLength = 10
        Me.PhoneBox.Name = "PhoneBox"
        Me.PhoneBox.Size = New System.Drawing.Size(164, 23)
        Me.PhoneBox.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(300, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Phone number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Historic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(263, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(268, 34)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Sign-Up for Georganize"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(585, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 175)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'ProfilePicButton
        '
        Me.ProfilePicButton.BackColor = System.Drawing.Color.Transparent
        Me.ProfilePicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProfilePicButton.Font = New System.Drawing.Font("Segoe UI Historic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProfilePicButton.Location = New System.Drawing.Point(585, 307)
        Me.ProfilePicButton.Name = "ProfilePicButton"
        Me.ProfilePicButton.Size = New System.Drawing.Size(125, 37)
        Me.ProfilePicButton.TabIndex = 26
        Me.ProfilePicButton.Text = "Insert"
        Me.ProfilePicButton.UseVisualStyleBackColor = False
        '
        'SignUpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BackgroundImage = Global.Georganize.My.Resources.Resources.MSign2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 521)
        Me.Controls.Add(Me.ProfilePicButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PhoneBox)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.ShowPassCheckbox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.EmailBox)
        Me.Controls.Add(Me.GenderBox)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordBox2)
        Me.Controls.Add(Me.PasswordBox1)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(900, 590)
        Me.MinimumSize = New System.Drawing.Size(650, 500)
        Me.Name = "SignUpForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up Form"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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