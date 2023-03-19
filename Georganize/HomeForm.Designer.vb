<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(HomeForm))
        CreateEventButton = New Button()
        ProfileButton = New Button()
        EnrolledEventsButton = New Button()
        HelpButton = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        CodeBox = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        ManageEventsButton = New Button()
        PublicEventsList = New ListView()
        EventName = New ColumnHeader()
        EventDate = New ColumnHeader()
        InviteButton = New Button()
        InvitationsBox = New CheckedListBox()
        SuspendLayout()
        ' 
        ' CreateEventButton
        ' 
        CreateEventButton.BackColor = Color.FloralWhite
        CreateEventButton.FlatStyle = FlatStyle.Flat
        CreateEventButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CreateEventButton.Location = New Point(26, 78)
        CreateEventButton.Name = "CreateEventButton"
        CreateEventButton.Size = New Size(116, 37)
        CreateEventButton.TabIndex = 1
        CreateEventButton.Text = "Create Event"
        CreateEventButton.UseVisualStyleBackColor = False
        ' 
        ' ProfileButton
        ' 
        ProfileButton.BackColor = Color.FloralWhite
        ProfileButton.FlatStyle = FlatStyle.Flat
        ProfileButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ProfileButton.Location = New Point(161, 78)
        ProfileButton.Name = "ProfileButton"
        ProfileButton.Size = New Size(116, 37)
        ProfileButton.TabIndex = 2
        ProfileButton.Text = "Profile"
        ProfileButton.UseVisualStyleBackColor = False
        ' 
        ' EnrolledEventsButton
        ' 
        EnrolledEventsButton.BackColor = Color.FloralWhite
        EnrolledEventsButton.FlatStyle = FlatStyle.Flat
        EnrolledEventsButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        EnrolledEventsButton.Location = New Point(300, 78)
        EnrolledEventsButton.Name = "EnrolledEventsButton"
        EnrolledEventsButton.Size = New Size(141, 37)
        EnrolledEventsButton.TabIndex = 3
        EnrolledEventsButton.Text = "Enrolled Events"
        EnrolledEventsButton.UseVisualStyleBackColor = False
        ' 
        ' HelpButton
        ' 
        HelpButton.BackColor = Color.FloralWhite
        HelpButton.FlatStyle = FlatStyle.Flat
        HelpButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        HelpButton.Location = New Point(463, 78)
        HelpButton.Name = "HelpButton"
        HelpButton.Size = New Size(141, 37)
        HelpButton.TabIndex = 4
        HelpButton.Text = "Help"
        HelpButton.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(46, 335)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 37)
        Button2.TabIndex = 6
        Button2.Text = "Accept"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(145, 335)
        Button3.Name = "Button3"
        Button3.Size = New Size(87, 37)
        Button3.TabIndex = 7
        Button3.Text = "Reject"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("SimSun-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(258, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 50)
        Label1.TabIndex = 8
        Label1.Text = "Georganize"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(122, 188)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 26)
        Label2.TabIndex = 9
        Label2.Text = "Invitations"' 
        ' CodeBox
        ' 
        CodeBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CodeBox.Location = New Point(245, 408)
        CodeBox.MaxLength = 20
        CodeBox.Name = "CodeBox"
        CodeBox.PasswordChar = "*"c
        CodeBox.PlaceholderText = "Private event code"
        CodeBox.Size = New Size(178, 29)
        CodeBox.TabIndex = 11
        CodeBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(429, 406)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 31)
        Button1.TabIndex = 12
        Button1.Text = "Join"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(509, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(181, 26)
        Label3.TabIndex = 16
        Label3.Text = "Public Events"' 
        ' ManageEventsButton
        ' 
        ManageEventsButton.BackColor = Color.FloralWhite
        ManageEventsButton.FlatStyle = FlatStyle.Flat
        ManageEventsButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ManageEventsButton.Location = New Point(625, 78)
        ManageEventsButton.Name = "ManageEventsButton"
        ManageEventsButton.Size = New Size(145, 37)
        ManageEventsButton.TabIndex = 17
        ManageEventsButton.Text = "Manage Events"
        ManageEventsButton.UseVisualStyleBackColor = False
        ' 
        ' PublicEventsList
        ' 
        PublicEventsList.Alignment = ListViewAlignment.Left
        PublicEventsList.Columns.AddRange(New ColumnHeader() {EventName, EventDate})
        PublicEventsList.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        PublicEventsList.HeaderStyle = ColumnHeaderStyle.Nonclickable
        PublicEventsList.Location = New Point(442, 217)
        PublicEventsList.MultiSelect = False
        PublicEventsList.Name = "PublicEventsList"
        PublicEventsList.Size = New Size(313, 154)
        PublicEventsList.TabIndex = 13
        PublicEventsList.UseCompatibleStateImageBehavior = False
        PublicEventsList.View = View.Details
        ' 
        ' EventName
        ' 
        EventName.Text = "Name"
        EventName.Width = 195
        ' 
        ' EventDate
        ' 
        EventDate.Text = "Date"
        EventDate.Width = 100
        ' 
        ' InviteButton
        ' 
        InviteButton.BackColor = Color.Transparent
        InviteButton.FlatStyle = FlatStyle.Flat
        InviteButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        InviteButton.Location = New Point(251, 335)
        InviteButton.Name = "InviteButton"
        InviteButton.Size = New Size(95, 37)
        InviteButton.TabIndex = 18
        InviteButton.Text = "Invite"
        InviteButton.UseVisualStyleBackColor = False
        ' 
        ' InvitationsBox
        ' 
        InvitationsBox.CheckOnClick = True
        InvitationsBox.FormattingEnabled = True
        InvitationsBox.Location = New Point(46, 217)
        InvitationsBox.Name = "InvitationsBox"
        InvitationsBox.Size = New Size(300, 112)
        InvitationsBox.TabIndex = 19
        ' 
        ' HomeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 509)
        Controls.Add(InvitationsBox)
        Controls.Add(InviteButton)
        Controls.Add(PublicEventsList)
        Controls.Add(ManageEventsButton)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(CodeBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(HelpButton)
        Controls.Add(EnrolledEventsButton)
        Controls.Add(ProfileButton)
        Controls.Add(CreateEventButton)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "HomeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents CreateEventButton As Button
    Friend WithEvents ProfileButton As Button
    Friend WithEvents EnrolledEventsButton As Button
    Friend WithEvents HelpButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CodeBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ManageEventsButton As Button
    Friend WithEvents PublicEventsList As ListView
    Friend WithEvents InviteButton As Button
    Friend WithEvents InvitationsBox As CheckedListBox
    Friend WithEvents EventName As ColumnHeader
    Friend WithEvents EventDate As ColumnHeader
End Class
