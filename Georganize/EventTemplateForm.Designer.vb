<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventTemplateForm
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
        EventNameLabel = New Label()
        OrganizerNameLabel = New Label()
        Label1 = New Label()
        EventDescriptionBox = New RichTextBox()
        EventAddressBox = New RichTextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        EventDateBox = New TextBox()
        EventStartTimeBox = New TextBox()
        EventEndTimeBox = New TextBox()
        VenueNameLabel = New Label()
        VenueNameBox = New TextBox()
        VisibilityLabel = New Label()
        PrivateCodeLabel = New Label()
        AgeResLabel = New Label()
        Label5 = New Label()
        EventJoinButton = New Button()
        SuspendLayout()
        ' 
        ' EventNameLabel
        ' 
        EventNameLabel.BackColor = Color.Transparent
        EventNameLabel.BorderStyle = BorderStyle.Fixed3D
        EventNameLabel.FlatStyle = FlatStyle.Popup
        EventNameLabel.Font = New Font("SimSun-ExtB", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        EventNameLabel.ForeColor = Color.Black
        EventNameLabel.Location = New Point(264, 7)
        EventNameLabel.Name = "EventNameLabel"
        EventNameLabel.Size = New Size(511, 50)
        EventNameLabel.TabIndex = 9
        EventNameLabel.Text = "event name"' 
        ' OrganizerNameLabel
        ' 
        OrganizerNameLabel.AutoSize = True
        OrganizerNameLabel.BackColor = Color.Transparent
        OrganizerNameLabel.BorderStyle = BorderStyle.Fixed3D
        OrganizerNameLabel.FlatStyle = FlatStyle.Popup
        OrganizerNameLabel.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        OrganizerNameLabel.ForeColor = Color.Black
        OrganizerNameLabel.Location = New Point(214, 110)
        OrganizerNameLabel.Name = "OrganizerNameLabel"
        OrganizerNameLabel.Size = New Size(95, 27)
        OrganizerNameLabel.TabIndex = 10
        OrganizerNameLabel.Text = "org name"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(72, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 27)
        Label1.TabIndex = 11
        Label1.Text = "Organized By :"' 
        ' EventDescriptionBox
        ' 
        EventDescriptionBox.BackColor = Color.AntiqueWhite
        EventDescriptionBox.BorderStyle = BorderStyle.FixedSingle
        EventDescriptionBox.Location = New Point(72, 150)
        EventDescriptionBox.MaxLength = 1000
        EventDescriptionBox.Name = "EventDescriptionBox"
        EventDescriptionBox.ReadOnly = True
        EventDescriptionBox.Size = New Size(439, 181)
        EventDescriptionBox.TabIndex = 12
        EventDescriptionBox.Text = ""' 
        ' EventAddressBox
        ' 
        EventAddressBox.BackColor = Color.AntiqueWhite
        EventAddressBox.Location = New Point(72, 357)
        EventAddressBox.MaxLength = 300
        EventAddressBox.Name = "EventAddressBox"
        EventAddressBox.ReadOnly = True
        EventAddressBox.Size = New Size(439, 92)
        EventAddressBox.TabIndex = 13
        EventAddressBox.TabStop = False
        EventAddressBox.Text = ""' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(544, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 21)
        Label2.TabIndex = 15
        Label2.Text = "Date :"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(544, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 21)
        Label3.TabIndex = 16
        Label3.Text = "Start Time :"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.FlatStyle = FlatStyle.Popup
        Label4.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(761, 216)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 21)
        Label4.TabIndex = 17
        Label4.Text = "End Time :"' 
        ' EventDateBox
        ' 
        EventDateBox.BackColor = Color.AntiqueWhite
        EventDateBox.Location = New Point(544, 174)
        EventDateBox.Name = "EventDateBox"
        EventDateBox.ReadOnly = True
        EventDateBox.Size = New Size(166, 23)
        EventDateBox.TabIndex = 18
        EventDateBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' EventStartTimeBox
        ' 
        EventStartTimeBox.BackColor = Color.AntiqueWhite
        EventStartTimeBox.Location = New Point(544, 240)
        EventStartTimeBox.Name = "EventStartTimeBox"
        EventStartTimeBox.ReadOnly = True
        EventStartTimeBox.Size = New Size(166, 23)
        EventStartTimeBox.TabIndex = 19
        EventStartTimeBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' EventEndTimeBox
        ' 
        EventEndTimeBox.BackColor = Color.AntiqueWhite
        EventEndTimeBox.Location = New Point(761, 240)
        EventEndTimeBox.Name = "EventEndTimeBox"
        EventEndTimeBox.ReadOnly = True
        EventEndTimeBox.Size = New Size(166, 23)
        EventEndTimeBox.TabIndex = 20
        EventEndTimeBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' VenueNameLabel
        ' 
        VenueNameLabel.AutoSize = True
        VenueNameLabel.BackColor = Color.Transparent
        VenueNameLabel.BorderStyle = BorderStyle.Fixed3D
        VenueNameLabel.FlatStyle = FlatStyle.Popup
        VenueNameLabel.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        VenueNameLabel.ForeColor = Color.Black
        VenueNameLabel.Location = New Point(544, 283)
        VenueNameLabel.Name = "VenueNameLabel"
        VenueNameLabel.Size = New Size(66, 21)
        VenueNameLabel.TabIndex = 21
        VenueNameLabel.Text = "Venue"' 
        ' VenueNameBox
        ' 
        VenueNameBox.BackColor = Color.AntiqueWhite
        VenueNameBox.Location = New Point(544, 307)
        VenueNameBox.Name = "VenueNameBox"
        VenueNameBox.ReadOnly = True
        VenueNameBox.Size = New Size(239, 23)
        VenueNameBox.TabIndex = 22
        ' 
        ' VisibilityLabel
        ' 
        VisibilityLabel.AutoSize = True
        VisibilityLabel.BackColor = Color.Transparent
        VisibilityLabel.BorderStyle = BorderStyle.Fixed3D
        VisibilityLabel.FlatStyle = FlatStyle.Popup
        VisibilityLabel.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        VisibilityLabel.ForeColor = Color.Black
        VisibilityLabel.Location = New Point(93, 12)
        VisibilityLabel.Name = "VisibilityLabel"
        VisibilityLabel.Size = New Size(44, 21)
        VisibilityLabel.TabIndex = 23
        VisibilityLabel.Text = "vis"
        VisibilityLabel.Visible = False
        ' 
        ' PrivateCodeLabel
        ' 
        PrivateCodeLabel.AutoSize = True
        PrivateCodeLabel.BackColor = Color.Transparent
        PrivateCodeLabel.BorderStyle = BorderStyle.Fixed3D
        PrivateCodeLabel.FlatStyle = FlatStyle.Popup
        PrivateCodeLabel.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        PrivateCodeLabel.ForeColor = Color.Black
        PrivateCodeLabel.Location = New Point(12, 20)
        PrivateCodeLabel.Name = "PrivateCodeLabel"
        PrivateCodeLabel.Size = New Size(55, 21)
        PrivateCodeLabel.TabIndex = 24
        PrivateCodeLabel.Text = "Code"
        PrivateCodeLabel.Visible = False
        ' 
        ' AgeResLabel
        ' 
        AgeResLabel.AutoSize = True
        AgeResLabel.BackColor = Color.Transparent
        AgeResLabel.BorderStyle = BorderStyle.Fixed3D
        AgeResLabel.FlatStyle = FlatStyle.Popup
        AgeResLabel.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        AgeResLabel.ForeColor = Color.Black
        AgeResLabel.Location = New Point(544, 357)
        AgeResLabel.Name = "AgeResLabel"
        AgeResLabel.Size = New Size(143, 21)
        AgeResLabel.TabIndex = 26
        AgeResLabel.Text = "Minimum Age:"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(414, 605)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 15)
        Label5.TabIndex = 27
        Label5.Text = "label for padding"
        Label5.Visible = False
        ' 
        ' EventJoinButton
        ' 
        EventJoinButton.BackColor = Color.Transparent
        EventJoinButton.FlatStyle = FlatStyle.Flat
        EventJoinButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        EventJoinButton.Location = New Point(544, 409)
        EventJoinButton.Name = "EventJoinButton"
        EventJoinButton.Size = New Size(157, 40)
        EventJoinButton.TabIndex = 28
        EventJoinButton.Text = "Join"
        EventJoinButton.UseVisualStyleBackColor = False
        ' 
        ' EventTemplateForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackgroundImage = My.Resources.Resources.light
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1002, 485)
        Controls.Add(EventJoinButton)
        Controls.Add(Label5)
        Controls.Add(AgeResLabel)
        Controls.Add(PrivateCodeLabel)
        Controls.Add(VisibilityLabel)
        Controls.Add(VenueNameBox)
        Controls.Add(VenueNameLabel)
        Controls.Add(EventEndTimeBox)
        Controls.Add(EventStartTimeBox)
        Controls.Add(EventDateBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(EventAddressBox)
        Controls.Add(EventDescriptionBox)
        Controls.Add(Label1)
        Controls.Add(OrganizerNameLabel)
        Controls.Add(EventNameLabel)
        Name = "EventTemplateForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Event Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EventNameLabel As Label
    Friend WithEvents OrganizerNameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EventDescriptionBox As RichTextBox
    Friend WithEvents EventAddressBox As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EventDateBox As TextBox
    Friend WithEvents EventStartTimeBox As TextBox
    Friend WithEvents EventEndTimeBox As TextBox
    Friend WithEvents VenueNameLabel As Label
    Friend WithEvents VenueNameBox As TextBox
    Friend WithEvents VisibilityLabel As Label
    Friend WithEvents PrivateCodeLabel As Label
    Friend WithEvents AgeResLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents EventJoinButton As Button
End Class
