<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHome
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
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        UserList = New CheckedListBox()
        EventList = New CheckedListBox()
        UserDelete = New Button()
        UserUpdate = New Button()
        FetchUserEvents = New Button()
        EventDelete = New Button()
        EventUpdate = New Button()
        SystemLogs = New ListBox()
        Label4 = New Label()
        AllEventButton = New Button()
        EventLabel = New Label()
        AddVenueButton = New Button()
        RemoveVenueButton = New Button()
        VenueListBox = New ListView()
        VID = New ColumnHeader()
        VenueName = New ColumnHeader()
        VenueAddress = New ColumnHeader()
        VenueNameBox = New TextBox()
        VenueAddressBox = New RichTextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("SimSun-ExtB", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(447, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(175, 31)
        Label2.TabIndex = 8
        Label2.Text = "Admin Home"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Sitka Banner", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(51, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 49)
        Label1.TabIndex = 9
        Label1.Text = "Users"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("Sitka Banner", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(424, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 49)
        Label3.TabIndex = 10
        Label3.Text = "Events"' 
        ' UserList
        ' 
        UserList.CheckOnClick = True
        UserList.FormattingEnabled = True
        UserList.Location = New Point(51, 162)
        UserList.Name = "UserList"
        UserList.Size = New Size(300, 238)
        UserList.TabIndex = 11
        ' 
        ' EventList
        ' 
        EventList.CheckOnClick = True
        EventList.FormattingEnabled = True
        EventList.Location = New Point(424, 162)
        EventList.Name = "EventList"
        EventList.Size = New Size(300, 238)
        EventList.TabIndex = 12
        ' 
        ' UserDelete
        ' 
        UserDelete.BackColor = Color.Transparent
        UserDelete.FlatStyle = FlatStyle.Flat
        UserDelete.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        UserDelete.Location = New Point(51, 406)
        UserDelete.Name = "UserDelete"
        UserDelete.Size = New Size(63, 37)
        UserDelete.TabIndex = 13
        UserDelete.Text = "Delete"
        UserDelete.UseVisualStyleBackColor = False
        ' 
        ' UserUpdate
        ' 
        UserUpdate.BackColor = Color.Transparent
        UserUpdate.FlatStyle = FlatStyle.Flat
        UserUpdate.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        UserUpdate.Location = New Point(120, 406)
        UserUpdate.Name = "UserUpdate"
        UserUpdate.Size = New Size(68, 37)
        UserUpdate.TabIndex = 14
        UserUpdate.Text = "Update"
        UserUpdate.UseVisualStyleBackColor = False
        ' 
        ' FetchUserEvents
        ' 
        FetchUserEvents.BackColor = Color.Transparent
        FetchUserEvents.FlatStyle = FlatStyle.Flat
        FetchUserEvents.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        FetchUserEvents.Location = New Point(194, 406)
        FetchUserEvents.Name = "FetchUserEvents"
        FetchUserEvents.Size = New Size(157, 37)
        FetchUserEvents.TabIndex = 15
        FetchUserEvents.Text = "Fetch User Events"
        FetchUserEvents.UseVisualStyleBackColor = False
        ' 
        ' EventDelete
        ' 
        EventDelete.BackColor = Color.Transparent
        EventDelete.FlatStyle = FlatStyle.Flat
        EventDelete.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        EventDelete.Location = New Point(424, 406)
        EventDelete.Name = "EventDelete"
        EventDelete.Size = New Size(63, 37)
        EventDelete.TabIndex = 16
        EventDelete.Text = "Delete"
        EventDelete.UseVisualStyleBackColor = False
        ' 
        ' EventUpdate
        ' 
        EventUpdate.BackColor = Color.Transparent
        EventUpdate.FlatStyle = FlatStyle.Flat
        EventUpdate.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        EventUpdate.Location = New Point(493, 406)
        EventUpdate.Name = "EventUpdate"
        EventUpdate.Size = New Size(68, 37)
        EventUpdate.TabIndex = 17
        EventUpdate.Text = "Update"
        EventUpdate.UseVisualStyleBackColor = False
        ' 
        ' SystemLogs
        ' 
        SystemLogs.FormattingEnabled = True
        SystemLogs.ItemHeight = 15
        SystemLogs.Location = New Point(786, 162)
        SystemLogs.Name = "SystemLogs"
        SystemLogs.Size = New Size(310, 244)
        SystemLogs.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.FlatStyle = FlatStyle.Popup
        Label4.Font = New Font("Sitka Banner", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(786, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(185, 49)
        Label4.TabIndex = 19
        Label4.Text = "System Logs"' 
        ' AllEventButton
        ' 
        AllEventButton.BackColor = Color.Transparent
        AllEventButton.FlatStyle = FlatStyle.Flat
        AllEventButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        AllEventButton.Location = New Point(567, 406)
        AllEventButton.Name = "AllEventButton"
        AllEventButton.Size = New Size(157, 37)
        AllEventButton.TabIndex = 20
        AllEventButton.Text = "All Events"
        AllEventButton.UseVisualStyleBackColor = False
        ' 
        ' EventLabel
        ' 
        EventLabel.AutoSize = True
        EventLabel.BackColor = Color.Transparent
        EventLabel.BorderStyle = BorderStyle.Fixed3D
        EventLabel.FlatStyle = FlatStyle.Popup
        EventLabel.Font = New Font("Sitka Banner", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point)
        EventLabel.ForeColor = Color.Black
        EventLabel.Location = New Point(555, 129)
        EventLabel.Name = "EventLabel"
        EventLabel.Size = New Size(52, 30)
        EventLabel.TabIndex = 21
        EventLabel.Text = "temp"' 
        ' AddVenueButton
        ' 
        AddVenueButton.BackColor = Color.Transparent
        AddVenueButton.FlatStyle = FlatStyle.Flat
        AddVenueButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        AddVenueButton.Location = New Point(51, 717)
        AddVenueButton.Name = "AddVenueButton"
        AddVenueButton.Size = New Size(63, 37)
        AddVenueButton.TabIndex = 23
        AddVenueButton.Text = "Add"
        AddVenueButton.UseVisualStyleBackColor = False
        ' 
        ' RemoveVenueButton
        ' 
        RemoveVenueButton.BackColor = Color.Transparent
        RemoveVenueButton.FlatStyle = FlatStyle.Flat
        RemoveVenueButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RemoveVenueButton.Location = New Point(267, 717)
        RemoveVenueButton.Name = "RemoveVenueButton"
        RemoveVenueButton.Size = New Size(94, 37)
        RemoveVenueButton.TabIndex = 24
        RemoveVenueButton.Text = "Remove"
        RemoveVenueButton.UseVisualStyleBackColor = False
        ' 
        ' VenueListBox
        ' 
        VenueListBox.CheckBoxes = True
        VenueListBox.Columns.AddRange(New ColumnHeader() {VID, VenueName, VenueAddress})
        VenueListBox.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        VenueListBox.FullRowSelect = True
        VenueListBox.Location = New Point(439, 516)
        VenueListBox.Name = "VenueListBox"
        VenueListBox.Size = New Size(673, 238)
        VenueListBox.TabIndex = 25
        VenueListBox.UseCompatibleStateImageBehavior = False
        VenueListBox.View = View.Details
        ' 
        ' VID
        ' 
        VID.Text = "Venue ID"
        VID.Width = 80
        ' 
        ' VenueName
        ' 
        VenueName.Text = "Venue"
        VenueName.Width = 220
        ' 
        ' VenueAddress
        ' 
        VenueAddress.Text = "Address"
        VenueAddress.Width = 1200
        ' 
        ' VenueNameBox
        ' 
        VenueNameBox.Location = New Point(51, 516)
        VenueNameBox.MaxLength = 50
        VenueNameBox.Name = "VenueNameBox"
        VenueNameBox.Size = New Size(310, 23)
        VenueNameBox.TabIndex = 26
        ' 
        ' VenueAddressBox
        ' 
        VenueAddressBox.Location = New Point(51, 586)
        VenueAddressBox.MaxLength = 300
        VenueAddressBox.Name = "VenueAddressBox"
        VenueAddressBox.Size = New Size(310, 110)
        VenueAddressBox.TabIndex = 27
        VenueAddressBox.Text = ""' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.FlatStyle = FlatStyle.Popup
        Label5.Font = New Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(439, 472)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 41)
        Label5.TabIndex = 28
        Label5.Text = "Venues"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.FlatStyle = FlatStyle.Popup
        Label6.Font = New Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(79, 472)
        Label6.Name = "Label6"
        Label6.Size = New Size(150, 41)
        Label6.TabIndex = 29
        Label6.Text = "Enter Name"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.FlatStyle = FlatStyle.Popup
        Label7.Font = New Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(79, 542)
        Label7.Name = "Label7"
        Label7.Size = New Size(175, 41)
        Label7.TabIndex = 30
        Label7.Text = "Enter Address"' 
        ' AdminHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackgroundImage = My.Resources.Resources.light
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1141, 637)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(VenueAddressBox)
        Controls.Add(VenueNameBox)
        Controls.Add(VenueListBox)
        Controls.Add(RemoveVenueButton)
        Controls.Add(AddVenueButton)
        Controls.Add(EventLabel)
        Controls.Add(AllEventButton)
        Controls.Add(Label4)
        Controls.Add(SystemLogs)
        Controls.Add(EventUpdate)
        Controls.Add(EventDelete)
        Controls.Add(FetchUserEvents)
        Controls.Add(UserUpdate)
        Controls.Add(UserDelete)
        Controls.Add(EventList)
        Controls.Add(UserList)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "AdminHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminHome"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UserList As CheckedListBox
    Friend WithEvents EventList As CheckedListBox
    Friend WithEvents UserDelete As Button
    Friend WithEvents UserUpdate As Button
    Friend WithEvents FetchUserEvents As Button
    Friend WithEvents EventDelete As Button
    Friend WithEvents EventUpdate As Button
    Friend WithEvents SystemLogs As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AllEventButton As Button
    Friend WithEvents EventLabel As Label
    Friend WithEvents AddVenueButton As Button
    Friend WithEvents RemoveVenueButton As Button
    Friend WithEvents VenueListBox As ListView
    Friend WithEvents VenueName As ColumnHeader
    Friend WithEvents VenueAddress As ColumnHeader
    Friend WithEvents VenueNameBox As TextBox
    Friend WithEvents VenueAddressBox As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents VID As ColumnHeader
End Class
