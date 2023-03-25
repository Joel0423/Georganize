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
        components = New ComponentModel.Container()
        EventNameBox = New TextBox()
        EventAddressBox = New RichTextBox()
        BookVenueCheckBox = New CheckBox()
        VenueComboBox = New ComboBox()
        EventDescriptionBox = New RichTextBox()
        Label1 = New Label()
        Label2 = New Label()
        EventModeBox = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        EventDatePicker = New DateTimePicker()
        Label6 = New Label()
        Label7 = New Label()
        EventStartTimePicker = New DateTimePicker()
        EventEndTimePicker = New DateTimePicker()
        TimeFormatCheckBox = New CheckBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        EventVisibilityComboBox = New ComboBox()
        SubmitButton = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        AgeCheckBox = New CheckBox()
        AgeBox = New TextBox()
        Label11 = New Label()
        SecretCode = New Label()
        EStart = New ColumnHeader()
        EEnd = New ColumnHeader()
        ListView1 = New ListView()
        Label12 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' EventNameBox
        ' 
        EventNameBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        EventNameBox.BackColor = Color.AntiqueWhite
        EventNameBox.Location = New Point(82, 108)
        EventNameBox.MaxLength = 25
        EventNameBox.Name = "EventNameBox"
        EventNameBox.Size = New Size(165, 23)
        EventNameBox.TabIndex = 1
        ' 
        ' EventAddressBox
        ' 
        EventAddressBox.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        EventAddressBox.BackColor = Color.AntiqueWhite
        EventAddressBox.Location = New Point(82, 300)
        EventAddressBox.MaxLength = 300
        EventAddressBox.Name = "EventAddressBox"
        EventAddressBox.Size = New Size(294, 84)
        EventAddressBox.TabIndex = 4
        EventAddressBox.TabStop = False
        EventAddressBox.Text = ""
        ' 
        ' BookVenueCheckBox
        ' 
        BookVenueCheckBox.Anchor = AnchorStyles.Right
        BookVenueCheckBox.AutoSize = True
        BookVenueCheckBox.BackColor = Color.WhiteSmoke
        BookVenueCheckBox.FlatAppearance.BorderColor = Color.Black
        BookVenueCheckBox.Location = New Point(493, 323)
        BookVenueCheckBox.Name = "BookVenueCheckBox"
        BookVenueCheckBox.Size = New Size(150, 19)
        BookVenueCheckBox.TabIndex = 5
        BookVenueCheckBox.Text = "Book Georganize Venue"
        BookVenueCheckBox.UseVisualStyleBackColor = False
        ' 
        ' VenueComboBox
        ' 
        VenueComboBox.Anchor = AnchorStyles.Right
        VenueComboBox.BackColor = Color.AntiqueWhite
        VenueComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        VenueComboBox.FormattingEnabled = True
        VenueComboBox.Location = New Point(493, 348)
        VenueComboBox.Name = "VenueComboBox"
        VenueComboBox.Size = New Size(150, 23)
        VenueComboBox.TabIndex = 6
        VenueComboBox.Visible = False
        ' 
        ' EventDescriptionBox
        ' 
        EventDescriptionBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        EventDescriptionBox.BackColor = Color.AntiqueWhite
        EventDescriptionBox.BorderStyle = BorderStyle.FixedSingle
        EventDescriptionBox.Location = New Point(82, 165)
        EventDescriptionBox.MaxLength = 1000
        EventDescriptionBox.Name = "EventDescriptionBox"
        EventDescriptionBox.Size = New Size(294, 89)
        EventDescriptionBox.TabIndex = 7
        EventDescriptionBox.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Location = New Point(82, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 17)
        Label1.TabIndex = 8
        Label1.Text = "Event Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(82, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 17)
        Label2.TabIndex = 9
        Label2.Text = "Description"
        ' 
        ' EventModeBox
        ' 
        EventModeBox.Anchor = AnchorStyles.Right
        EventModeBox.DropDownStyle = ComboBoxStyle.DropDownList
        EventModeBox.FormattingEnabled = True
        EventModeBox.Items.AddRange(New Object() {"In-Person", "Online"})
        EventModeBox.Location = New Point(493, 280)
        EventModeBox.Name = "EventModeBox"
        EventModeBox.Size = New Size(150, 23)
        EventModeBox.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Location = New Point(493, 257)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 17)
        Label3.TabIndex = 11
        Label3.Text = "Event Mode"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Location = New Point(82, 280)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 17)
        Label4.TabIndex = 12
        Label4.Text = "Event Address"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.WhiteSmoke
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Location = New Point(493, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 17)
        Label5.TabIndex = 13
        Label5.Text = "Event Date"
        ' 
        ' EventDatePicker
        ' 
        EventDatePicker.Anchor = AnchorStyles.Right
        EventDatePicker.CustomFormat = ""
        EventDatePicker.Location = New Point(493, 117)
        EventDatePicker.Name = "EventDatePicker"
        EventDatePicker.Size = New Size(221, 23)
        EventDatePicker.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.WhiteSmoke
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Location = New Point(493, 160)
        Label6.Name = "Label6"
        Label6.Size = New Size(62, 17)
        Label6.TabIndex = 15
        Label6.Text = "Start Time"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Right
        Label7.AutoSize = True
        Label7.BackColor = Color.WhiteSmoke
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Location = New Point(669, 160)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 17)
        Label7.TabIndex = 16
        Label7.Text = "End Time"
        ' 
        ' EventStartTimePicker
        ' 
        EventStartTimePicker.Anchor = AnchorStyles.Right
        EventStartTimePicker.CustomFormat = "  HH      '|'   mm         '|'   ss"
        EventStartTimePicker.Format = DateTimePickerFormat.Custom
        EventStartTimePicker.Location = New Point(493, 178)
        EventStartTimePicker.Name = "EventStartTimePicker"
        EventStartTimePicker.ShowUpDown = True
        EventStartTimePicker.Size = New Size(150, 23)
        EventStartTimePicker.TabIndex = 18
        EventStartTimePicker.Value = New DateTime(2023, 2, 5, 16, 0, 0, 0)
        ' 
        ' EventEndTimePicker
        ' 
        EventEndTimePicker.Anchor = AnchorStyles.Right
        EventEndTimePicker.CustomFormat = "  HH      '|'   mm         '|'   ss"
        EventEndTimePicker.Format = DateTimePickerFormat.Custom
        EventEndTimePicker.Location = New Point(669, 178)
        EventEndTimePicker.Name = "EventEndTimePicker"
        EventEndTimePicker.ShowUpDown = True
        EventEndTimePicker.Size = New Size(150, 23)
        EventEndTimePicker.TabIndex = 19
        EventEndTimePicker.Value = New DateTime(2023, 2, 5, 18, 0, 0, 0)
        ' 
        ' TimeFormatCheckBox
        ' 
        TimeFormatCheckBox.Anchor = AnchorStyles.Right
        TimeFormatCheckBox.AutoSize = True
        TimeFormatCheckBox.BackColor = Color.Transparent
        TimeFormatCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TimeFormatCheckBox.ForeColor = SystemColors.ControlText
        TimeFormatCheckBox.Location = New Point(731, 122)
        TimeFormatCheckBox.Name = "TimeFormatCheckBox"
        TimeFormatCheckBox.Size = New Size(109, 19)
        TimeFormatCheckBox.TabIndex = 20
        TimeFormatCheckBox.Text = "12 Hour Format"
        TimeFormatCheckBox.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BackColor = Color.WhiteSmoke
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Location = New Point(493, 204)
        Label8.Name = "Label8"
        Label8.Size = New Size(146, 17)
        Label8.TabIndex = 21
        Label8.Text = "Hours | Minutes | Seconds"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Right
        Label9.AutoSize = True
        Label9.BackColor = Color.WhiteSmoke
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.Location = New Point(669, 204)
        Label9.Name = "Label9"
        Label9.Size = New Size(146, 17)
        Label9.TabIndex = 22
        Label9.Text = "Hours | Minutes | Seconds"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Right
        Label10.AutoSize = True
        Label10.BackColor = Color.WhiteSmoke
        Label10.BorderStyle = BorderStyle.FixedSingle
        Label10.Location = New Point(669, 257)
        Label10.Name = "Label10"
        Label10.Size = New Size(85, 17)
        Label10.TabIndex = 23
        Label10.Text = "Event Visibility"
        ' 
        ' EventVisibilityComboBox
        ' 
        EventVisibilityComboBox.Anchor = AnchorStyles.Right
        EventVisibilityComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        EventVisibilityComboBox.FormattingEnabled = True
        EventVisibilityComboBox.Items.AddRange(New Object() {"Public", "Private"})
        EventVisibilityComboBox.Location = New Point(669, 280)
        EventVisibilityComboBox.Name = "EventVisibilityComboBox"
        EventVisibilityComboBox.Size = New Size(106, 23)
        EventVisibilityComboBox.TabIndex = 24
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SubmitButton.BackColor = Color.WhiteSmoke
        SubmitButton.FlatStyle = FlatStyle.Flat
        SubmitButton.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        SubmitButton.Location = New Point(82, 453)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(168, 46)
        SubmitButton.TabIndex = 25
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.BlinkRate = 180
        ErrorProvider1.ContainerControl = Me
        ' 
        ' AgeCheckBox
        ' 
        AgeCheckBox.Anchor = AnchorStyles.Right
        AgeCheckBox.AutoSize = True
        AgeCheckBox.BackColor = Color.WhiteSmoke
        AgeCheckBox.FlatAppearance.BorderColor = Color.Red
        AgeCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        AgeCheckBox.ForeColor = SystemColors.ControlText
        AgeCheckBox.Location = New Point(669, 323)
        AgeCheckBox.Name = "AgeCheckBox"
        AgeCheckBox.Size = New Size(106, 19)
        AgeCheckBox.TabIndex = 26
        AgeCheckBox.Text = "Age Restriction"
        AgeCheckBox.UseVisualStyleBackColor = False
        ' 
        ' AgeBox
        ' 
        AgeBox.Anchor = AnchorStyles.Right
        AgeBox.BackColor = Color.AntiqueWhite
        AgeBox.Location = New Point(669, 348)
        AgeBox.MaxLength = 2
        AgeBox.Name = "AgeBox"
        AgeBox.Size = New Size(106, 23)
        AgeBox.TabIndex = 27
        AgeBox.Text = "18"
        AgeBox.TextAlign = HorizontalAlignment.Center
        AgeBox.Visible = False
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.BackColor = Color.WhiteSmoke
        Label11.BorderStyle = BorderStyle.Fixed3D
        Label11.Font = New Font("Segoe UI Historic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(326, 19)
        Label11.Name = "Label11"
        Label11.Size = New Size(203, 34)
        Label11.TabIndex = 28
        Label11.Text = "Create new event"
        ' 
        ' SecretCode
        ' 
        SecretCode.Anchor = AnchorStyles.Right
        SecretCode.AutoSize = True
        SecretCode.BackColor = Color.Transparent
        SecretCode.BorderStyle = BorderStyle.FixedSingle
        SecretCode.Location = New Point(781, 280)
        SecretCode.Name = "SecretCode"
        SecretCode.Size = New Size(35, 17)
        SecretCode.TabIndex = 29
        SecretCode.Text = "code"
        ' 
        ' EStart
        ' 
        EStart.Tag = ""
        EStart.Text = "Start"
        EStart.Width = 100
        ' 
        ' EEnd
        ' 
        EEnd.Tag = "99"
        EEnd.Text = "End"
        EEnd.Width = 100
        ' 
        ' ListView1
        ' 
        ListView1.Anchor = AnchorStyles.Right
        ListView1.Columns.AddRange(New ColumnHeader() {EStart, EEnd})
        ListView1.Location = New Point(613, 402)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(206, 97)
        ListView1.TabIndex = 31
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ListView1.Visible = False
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Right
        Label12.AutoSize = True
        Label12.BackColor = Color.WhiteSmoke
        Label12.BorderStyle = BorderStyle.FixedSingle
        Label12.Location = New Point(613, 382)
        Label12.Name = "Label12"
        Label12.Size = New Size(162, 17)
        Label12.TabIndex = 32
        Label12.Text = "Booked timings at this venue"
        ' 
        ' EventCreationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackgroundImage = My.Resources.Resources.MSign3
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(884, 511)
        Controls.Add(Label12)
        Controls.Add(ListView1)
        Controls.Add(SecretCode)
        Controls.Add(Label11)
        Controls.Add(AgeBox)
        Controls.Add(AgeCheckBox)
        Controls.Add(SubmitButton)
        Controls.Add(EventVisibilityComboBox)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(TimeFormatCheckBox)
        Controls.Add(EventEndTimePicker)
        Controls.Add(EventStartTimePicker)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(EventDatePicker)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(EventModeBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(EventDescriptionBox)
        Controls.Add(VenueComboBox)
        Controls.Add(BookVenueCheckBox)
        Controls.Add(EventAddressBox)
        Controls.Add(EventNameBox)
        DoubleBuffered = True
        MaximizeBox = False
        MinimumSize = New Size(800, 500)
        Name = "EventCreationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = " Event Creation Form"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents ListView1 As ListView
    Friend WithEvents EStart As ColumnHeader
    Friend WithEvents EEnd As ColumnHeader
    Friend WithEvents Label12 As Label
End Class
