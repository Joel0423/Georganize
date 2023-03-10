<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EventCreationForm
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
        Me.components = New System.ComponentModel.Container()
        Me.EventNameBox = New System.Windows.Forms.TextBox()
        Me.EventAddressBox = New System.Windows.Forms.RichTextBox()
        Me.BookVenueCheckBox = New System.Windows.Forms.CheckBox()
        Me.VenueComboBox = New System.Windows.Forms.ComboBox()
        Me.GeoLoadBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeoLoadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EventDescriptionBox = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EventModeBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EventDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EventStartTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EventEndTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TimeFormatCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EventVisibilityComboBox = New System.Windows.Forms.ComboBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.AgeCheckBox = New System.Windows.Forms.CheckBox()
        Me.AgeBox = New System.Windows.Forms.TextBox()
        Me.GeoLoadBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeoLoadBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SecretCode = New System.Windows.Forms.Label()
        CType(Me.GeoLoadBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeoLoadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeoLoadBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeoLoadBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EventNameBox
        '
        Me.EventNameBox.BackColor = System.Drawing.Color.AntiqueWhite
        Me.EventNameBox.Location = New System.Drawing.Point(82, 108)
        Me.EventNameBox.MaxLength = 25
        Me.EventNameBox.Name = "EventNameBox"
        Me.EventNameBox.Size = New System.Drawing.Size(165, 23)
        Me.EventNameBox.TabIndex = 1
        '
        'EventAddressBox
        '
        Me.EventAddressBox.BackColor = System.Drawing.Color.AntiqueWhite
        Me.EventAddressBox.Location = New System.Drawing.Point(82, 300)
        Me.EventAddressBox.MaxLength = 300
        Me.EventAddressBox.Name = "EventAddressBox"
        Me.EventAddressBox.Size = New System.Drawing.Size(294, 84)
        Me.EventAddressBox.TabIndex = 4
        Me.EventAddressBox.TabStop = False
        Me.EventAddressBox.Text = ""
        '
        'BookVenueCheckBox
        '
        Me.BookVenueCheckBox.AutoSize = True
        Me.BookVenueCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.BookVenueCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BookVenueCheckBox.Location = New System.Drawing.Point(493, 323)
        Me.BookVenueCheckBox.Name = "BookVenueCheckBox"
        Me.BookVenueCheckBox.Size = New System.Drawing.Size(150, 19)
        Me.BookVenueCheckBox.TabIndex = 5
        Me.BookVenueCheckBox.Text = "Book Georganize Venue"
        Me.BookVenueCheckBox.UseVisualStyleBackColor = False
        '
        'VenueComboBox
        '
        Me.VenueComboBox.BackColor = System.Drawing.Color.AntiqueWhite
        Me.VenueComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VenueComboBox.FormattingEnabled = True
        Me.VenueComboBox.Location = New System.Drawing.Point(493, 348)
        Me.VenueComboBox.Name = "VenueComboBox"
        Me.VenueComboBox.Size = New System.Drawing.Size(150, 23)
        Me.VenueComboBox.TabIndex = 6
        Me.VenueComboBox.Visible = False
        '
        'GeoLoadBindingSource3
        '
        Me.GeoLoadBindingSource3.DataSource = GetType(Georganize.GeoLoad)
        '
        'GeoLoadBindingSource
        '
        Me.GeoLoadBindingSource.DataSource = GetType(Georganize.GeoLoad)
        '
        'EventDescriptionBox
        '
        Me.EventDescriptionBox.BackColor = System.Drawing.Color.AntiqueWhite
        Me.EventDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EventDescriptionBox.Location = New System.Drawing.Point(82, 165)
        Me.EventDescriptionBox.MaxLength = 1000
        Me.EventDescriptionBox.Name = "EventDescriptionBox"
        Me.EventDescriptionBox.Size = New System.Drawing.Size(294, 89)
        Me.EventDescriptionBox.TabIndex = 7
        Me.EventDescriptionBox.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(82, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Event Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(82, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Description"
        '
        'EventModeBox
        '
        Me.EventModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EventModeBox.FormattingEnabled = True
        Me.EventModeBox.Items.AddRange(New Object() {"In-Person", "Online"})
        Me.EventModeBox.Location = New System.Drawing.Point(493, 280)
        Me.EventModeBox.Name = "EventModeBox"
        Me.EventModeBox.Size = New System.Drawing.Size(150, 23)
        Me.EventModeBox.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(493, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Event Mode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(82, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Event Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(493, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Event Date"
        '
        'EventDatePicker
        '
        Me.EventDatePicker.CustomFormat = ""
        Me.EventDatePicker.Location = New System.Drawing.Point(493, 117)
        Me.EventDatePicker.Name = "EventDatePicker"
        Me.EventDatePicker.Size = New System.Drawing.Size(221, 23)
        Me.EventDatePicker.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(493, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Start Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(669, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "End Time"
        '
        'EventStartTimePicker
        '
        Me.EventStartTimePicker.CustomFormat = "  HH      '|'   mm         '|'   ss"
        Me.EventStartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EventStartTimePicker.Location = New System.Drawing.Point(493, 178)
        Me.EventStartTimePicker.Name = "EventStartTimePicker"
        Me.EventStartTimePicker.ShowUpDown = True
        Me.EventStartTimePicker.Size = New System.Drawing.Size(150, 23)
        Me.EventStartTimePicker.TabIndex = 18
        Me.EventStartTimePicker.Value = New Date(2023, 2, 5, 16, 0, 0, 0)
        '
        'EventEndTimePicker
        '
        Me.EventEndTimePicker.CustomFormat = "  HH      '|'   mm         '|'   ss"
        Me.EventEndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EventEndTimePicker.Location = New System.Drawing.Point(669, 178)
        Me.EventEndTimePicker.Name = "EventEndTimePicker"
        Me.EventEndTimePicker.ShowUpDown = True
        Me.EventEndTimePicker.Size = New System.Drawing.Size(150, 23)
        Me.EventEndTimePicker.TabIndex = 19
        Me.EventEndTimePicker.Value = New Date(2023, 2, 5, 18, 0, 0, 0)
        '
        'TimeFormatCheckBox
        '
        Me.TimeFormatCheckBox.AutoSize = True
        Me.TimeFormatCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.TimeFormatCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TimeFormatCheckBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TimeFormatCheckBox.Location = New System.Drawing.Point(731, 122)
        Me.TimeFormatCheckBox.Name = "TimeFormatCheckBox"
        Me.TimeFormatCheckBox.Size = New System.Drawing.Size(109, 19)
        Me.TimeFormatCheckBox.TabIndex = 20
        Me.TimeFormatCheckBox.Text = "12 Hour Format"
        Me.TimeFormatCheckBox.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(493, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Hours | Minutes | Seconds"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(669, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Hours | Minutes | Seconds"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(669, 257)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Event Visibility"
        '
        'EventVisibilityComboBox
        '
        Me.EventVisibilityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EventVisibilityComboBox.FormattingEnabled = True
        Me.EventVisibilityComboBox.Items.AddRange(New Object() {"Public", "Private"})
        Me.EventVisibilityComboBox.Location = New System.Drawing.Point(669, 280)
        Me.EventVisibilityComboBox.Name = "EventVisibilityComboBox"
        Me.EventVisibilityComboBox.Size = New System.Drawing.Size(106, 23)
        Me.EventVisibilityComboBox.TabIndex = 24
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.Transparent
        Me.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitButton.Font = New System.Drawing.Font("Segoe UI Historic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SubmitButton.Location = New System.Drawing.Point(82, 429)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(168, 46)
        Me.SubmitButton.TabIndex = 25
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 180
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AgeCheckBox
        '
        Me.AgeCheckBox.AutoSize = True
        Me.AgeCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.AgeCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.AgeCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AgeCheckBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AgeCheckBox.Location = New System.Drawing.Point(669, 323)
        Me.AgeCheckBox.Name = "AgeCheckBox"
        Me.AgeCheckBox.Size = New System.Drawing.Size(106, 19)
        Me.AgeCheckBox.TabIndex = 26
        Me.AgeCheckBox.Text = "Age Restriction"
        Me.AgeCheckBox.UseVisualStyleBackColor = False
        '
        'AgeBox
        '
        Me.AgeBox.BackColor = System.Drawing.Color.AntiqueWhite
        Me.AgeBox.Location = New System.Drawing.Point(669, 348)
        Me.AgeBox.MaxLength = 2
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.Size = New System.Drawing.Size(106, 23)
        Me.AgeBox.TabIndex = 27
        Me.AgeBox.Text = "18"
        Me.AgeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AgeBox.Visible = False
        '
        'GeoLoadBindingSource1
        '
        Me.GeoLoadBindingSource1.DataSource = GetType(Georganize.GeoLoad)
        '
        'GeoLoadBindingSource2
        '
        Me.GeoLoadBindingSource2.DataSource = GetType(Georganize.GeoLoad)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Historic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(326, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(203, 34)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Create new event"
        '
        'SecretCode
        '
        Me.SecretCode.AutoSize = True
        Me.SecretCode.BackColor = System.Drawing.Color.Transparent
        Me.SecretCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SecretCode.Location = New System.Drawing.Point(781, 280)
        Me.SecretCode.Name = "SecretCode"
        Me.SecretCode.Size = New System.Drawing.Size(35, 17)
        Me.SecretCode.TabIndex = 29
        Me.SecretCode.Text = "code"
        '
        'EventCreationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.Georganize.My.Resources.Resources.MSign3
        Me.ClientSize = New System.Drawing.Size(884, 511)
        Me.Controls.Add(Me.SecretCode)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AgeBox)
        Me.Controls.Add(Me.AgeCheckBox)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.EventVisibilityComboBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TimeFormatCheckBox)
        Me.Controls.Add(Me.EventEndTimePicker)
        Me.Controls.Add(Me.EventStartTimePicker)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EventDatePicker)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EventModeBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EventDescriptionBox)
        Me.Controls.Add(Me.VenueComboBox)
        Me.Controls.Add(Me.BookVenueCheckBox)
        Me.Controls.Add(Me.EventAddressBox)
        Me.Controls.Add(Me.EventNameBox)
        Me.DoubleBuffered = True
        Me.MaximumSize = New System.Drawing.Size(1300, 700)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "EventCreationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Event Creation Form"
        CType(Me.GeoLoadBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeoLoadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeoLoadBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeoLoadBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EventNameBox As TextBox
    Friend WithEvents EventAddressBox As RichTextBox
    Friend WithEvents BookVenueCheckBox As CheckBox
    Friend WithEvents VenueComboBox As ComboBox
    Friend WithEvents EventDescriptionBox As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EventModeBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents EventDatePicker As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EventStartTimePicker As DateTimePicker
    Friend WithEvents EventEndTimePicker As DateTimePicker
    Friend WithEvents TimeFormatCheckBox As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents EventVisibilityComboBox As ComboBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents AgeCheckBox As CheckBox
    Friend WithEvents AgeBox As TextBox
    Friend WithEvents GeoLoadBindingSource As BindingSource
    Friend WithEvents GeoLoadBindingSource1 As BindingSource
    Friend WithEvents GeoLoadBindingSource2 As BindingSource
    Friend WithEvents GeoLoadBindingSource3 As BindingSource
    Friend WithEvents Label11 As Label
    Friend WithEvents SecretCode As Label
End Class
