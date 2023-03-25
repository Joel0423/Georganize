<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEventForm
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
        PrivateCodeLabel = New Label()
        VenueNameBox = New TextBox()
        VenueNameLabel = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        EventAddressBox = New RichTextBox()
        EventDescriptionBox = New RichTextBox()
        EventNameLabel = New Label()
        EventDateBox = New DateTimePicker()
        EventStartTimeBox = New DateTimePicker()
        EventEndTimeBox = New DateTimePicker()
        TimeFormatCheckBox = New CheckBox()
        SubmitButton = New Button()
        AgeResLabel = New TextBox()
        Label1 = New Label()
        VisCombo = New ComboBox()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PrivateCodeLabel
        ' 
        PrivateCodeLabel.AutoSize = True
        PrivateCodeLabel.BackColor = Color.WhiteSmoke
        PrivateCodeLabel.BorderStyle = BorderStyle.Fixed3D
        PrivateCodeLabel.FlatStyle = FlatStyle.Popup
        PrivateCodeLabel.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        PrivateCodeLabel.ForeColor = Color.Black
        PrivateCodeLabel.Location = New Point(12, 27)
        PrivateCodeLabel.Name = "PrivateCodeLabel"
        PrivateCodeLabel.Size = New Size(55, 21)
        PrivateCodeLabel.TabIndex = 41
        PrivateCodeLabel.Text = "Code"
        PrivateCodeLabel.Visible = False
        ' 
        ' VenueNameBox
        ' 
        VenueNameBox.BackColor = Color.AntiqueWhite
        VenueNameBox.Location = New Point(475, 303)
        VenueNameBox.Name = "VenueNameBox"
        VenueNameBox.ReadOnly = True
        VenueNameBox.Size = New Size(239, 23)
        VenueNameBox.TabIndex = 39
        ' 
        ' VenueNameLabel
        ' 
        VenueNameLabel.AutoSize = True
        VenueNameLabel.BackColor = Color.WhiteSmoke
        VenueNameLabel.BorderStyle = BorderStyle.Fixed3D
        VenueNameLabel.FlatStyle = FlatStyle.Popup
        VenueNameLabel.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        VenueNameLabel.ForeColor = Color.Black
        VenueNameLabel.Location = New Point(475, 279)
        VenueNameLabel.Name = "VenueNameLabel"
        VenueNameLabel.Size = New Size(66, 21)
        VenueNameLabel.TabIndex = 38
        VenueNameLabel.Text = "Venue"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.FlatStyle = FlatStyle.Popup
        Label4.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(692, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 21)
        Label4.TabIndex = 34
        Label4.Text = "End Time :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(475, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 21)
        Label3.TabIndex = 33
        Label3.Text = "Start Time :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(475, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 21)
        Label2.TabIndex = 32
        Label2.Text = "Date :"
        ' 
        ' EventAddressBox
        ' 
        EventAddressBox.BackColor = Color.AntiqueWhite
        EventAddressBox.Location = New Point(3, 353)
        EventAddressBox.MaxLength = 300
        EventAddressBox.Name = "EventAddressBox"
        EventAddressBox.Size = New Size(439, 92)
        EventAddressBox.TabIndex = 31
        EventAddressBox.TabStop = False
        EventAddressBox.Text = ""
        ' 
        ' EventDescriptionBox
        ' 
        EventDescriptionBox.BackColor = Color.AntiqueWhite
        EventDescriptionBox.BorderStyle = BorderStyle.FixedSingle
        EventDescriptionBox.Location = New Point(3, 146)
        EventDescriptionBox.MaxLength = 1000
        EventDescriptionBox.Name = "EventDescriptionBox"
        EventDescriptionBox.Size = New Size(439, 181)
        EventDescriptionBox.TabIndex = 30
        EventDescriptionBox.Text = ""
        ' 
        ' EventNameLabel
        ' 
        EventNameLabel.BackColor = Color.WhiteSmoke
        EventNameLabel.BorderStyle = BorderStyle.Fixed3D
        EventNameLabel.FlatStyle = FlatStyle.Popup
        EventNameLabel.Font = New Font("SimSun-ExtB", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        EventNameLabel.ForeColor = Color.Black
        EventNameLabel.Location = New Point(228, 5)
        EventNameLabel.Name = "EventNameLabel"
        EventNameLabel.Size = New Size(460, 50)
        EventNameLabel.TabIndex = 27
        EventNameLabel.Text = "event name"
        EventNameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' EventDateBox
        ' 
        EventDateBox.Anchor = AnchorStyles.Right
        EventDateBox.CustomFormat = ""
        EventDateBox.Location = New Point(475, 170)
        EventDateBox.Name = "EventDateBox"
        EventDateBox.Size = New Size(221, 23)
        EventDateBox.TabIndex = 43
        ' 
        ' EventStartTimeBox
        ' 
        EventStartTimeBox.Anchor = AnchorStyles.Right
        EventStartTimeBox.CustomFormat = "  HH      '|'   mm         '|'   ss"
        EventStartTimeBox.Format = DateTimePickerFormat.Custom
        EventStartTimeBox.Location = New Point(475, 236)
        EventStartTimeBox.Name = "EventStartTimeBox"
        EventStartTimeBox.ShowUpDown = True
        EventStartTimeBox.Size = New Size(150, 23)
        EventStartTimeBox.TabIndex = 44
        EventStartTimeBox.Value = New DateTime(2023, 2, 5, 16, 0, 0, 0)
        ' 
        ' EventEndTimeBox
        ' 
        EventEndTimeBox.Anchor = AnchorStyles.Right
        EventEndTimeBox.CustomFormat = "  HH      '|'   mm         '|'   ss"
        EventEndTimeBox.Format = DateTimePickerFormat.Custom
        EventEndTimeBox.Location = New Point(692, 236)
        EventEndTimeBox.Name = "EventEndTimeBox"
        EventEndTimeBox.ShowUpDown = True
        EventEndTimeBox.Size = New Size(150, 23)
        EventEndTimeBox.TabIndex = 45
        EventEndTimeBox.Value = New DateTime(2023, 2, 5, 18, 0, 0, 0)
        ' 
        ' TimeFormatCheckBox
        ' 
        TimeFormatCheckBox.Anchor = AnchorStyles.Right
        TimeFormatCheckBox.AutoSize = True
        TimeFormatCheckBox.BackColor = Color.Transparent
        TimeFormatCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TimeFormatCheckBox.ForeColor = SystemColors.ControlText
        TimeFormatCheckBox.Location = New Point(733, 170)
        TimeFormatCheckBox.Name = "TimeFormatCheckBox"
        TimeFormatCheckBox.Size = New Size(109, 19)
        TimeFormatCheckBox.TabIndex = 46
        TimeFormatCheckBox.Text = "12 Hour Format"
        TimeFormatCheckBox.UseVisualStyleBackColor = False
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SubmitButton.BackColor = Color.WhiteSmoke
        SubmitButton.FlatStyle = FlatStyle.Flat
        SubmitButton.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        SubmitButton.Location = New Point(475, 399)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(168, 46)
        SubmitButton.TabIndex = 47
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = False
        ' 
        ' AgeResLabel
        ' 
        AgeResLabel.BackColor = Color.AntiqueWhite
        AgeResLabel.Location = New Point(475, 370)
        AgeResLabel.Name = "AgeResLabel"
        AgeResLabel.Size = New Size(94, 23)
        AgeResLabel.TabIndex = 48
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(475, 346)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 21)
        Label1.TabIndex = 49
        Label1.Text = "Age Restriction"
        ' 
        ' VisCombo
        ' 
        VisCombo.FormattingEnabled = True
        VisCombo.Items.AddRange(New Object() {"Private", "Public"})
        VisCombo.Location = New Point(754, 347)
        VisCombo.Name = "VisCombo"
        VisCombo.Size = New Size(121, 23)
        VisCombo.TabIndex = 50
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' EditEventForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background_ge7e7fa96f_1920
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(902, 476)
        Controls.Add(VisCombo)
        Controls.Add(Label1)
        Controls.Add(AgeResLabel)
        Controls.Add(SubmitButton)
        Controls.Add(TimeFormatCheckBox)
        Controls.Add(EventEndTimeBox)
        Controls.Add(EventStartTimeBox)
        Controls.Add(EventDateBox)
        Controls.Add(PrivateCodeLabel)
        Controls.Add(VenueNameBox)
        Controls.Add(VenueNameLabel)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(EventAddressBox)
        Controls.Add(EventDescriptionBox)
        Controls.Add(EventNameLabel)
        MaximizeBox = False
        MinimizeBox = False
        Name = "EditEventForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EditEventForm"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PrivateCodeLabel As Label
    Friend WithEvents VenueNameBox As TextBox
    Friend WithEvents VenueNameLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EventAddressBox As RichTextBox
    Friend WithEvents EventDescriptionBox As RichTextBox
    Friend WithEvents EventNameLabel As Label
    Friend WithEvents EventDateBox As DateTimePicker
    Friend WithEvents EventStartTimeBox As DateTimePicker
    Friend WithEvents EventEndTimeBox As DateTimePicker
    Friend WithEvents TimeFormatCheckBox As CheckBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents AgeResLabel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents VisCombo As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
