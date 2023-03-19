<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invitations
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
        EnrolledEvents = New ComboBox()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        InviteButton = New Button()
        SystemUsers = New CheckedListBox()
        Label4 = New Label()
        Label5 = New Label()
        SearchBox = New TextBox()
        SearchByBox = New ComboBox()
        SearchButton = New Button()
        SuspendLayout()
        ' 
        ' EnrolledEvents
        ' 
        EnrolledEvents.FormattingEnabled = True
        EnrolledEvents.Location = New Point(118, 177)
        EnrolledEvents.Name = "EnrolledEvents"
        EnrolledEvents.Size = New Size(240, 23)
        EnrolledEvents.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(118, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 26)
        Label3.TabIndex = 17
        Label3.Text = "Event"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(423, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 26)
        Label1.TabIndex = 19
        Label1.Text = "Users"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("SimSun-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(211, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(347, 50)
        Label2.TabIndex = 20
        Label2.Text = "Invite Others"' 
        ' InviteButton
        ' 
        InviteButton.BackColor = Color.Transparent
        InviteButton.FlatStyle = FlatStyle.Flat
        InviteButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        InviteButton.Location = New Point(423, 331)
        InviteButton.Name = "InviteButton"
        InviteButton.Size = New Size(162, 37)
        InviteButton.TabIndex = 21
        InviteButton.Text = "Send Invitation(s)"
        InviteButton.UseVisualStyleBackColor = False
        ' 
        ' SystemUsers
        ' 
        SystemUsers.CheckOnClick = True
        SystemUsers.FormattingEnabled = True
        SystemUsers.Location = New Point(423, 177)
        SystemUsers.Name = "SystemUsers"
        SystemUsers.Size = New Size(211, 148)
        SystemUsers.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.FlatStyle = FlatStyle.Popup
        Label4.Font = New Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(118, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(207, 26)
        Label4.TabIndex = 23
        Label4.Text = "Search For User"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.WhiteSmoke
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.FlatStyle = FlatStyle.Popup
        Label5.Font = New Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(118, 258)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 26)
        Label5.TabIndex = 24
        Label5.Text = "Search By-"' 
        ' SearchBox
        ' 
        SearchBox.Location = New Point(118, 232)
        SearchBox.Name = "SearchBox"
        SearchBox.Size = New Size(240, 23)
        SearchBox.TabIndex = 25
        ' 
        ' SearchByBox
        ' 
        SearchByBox.FormattingEnabled = True
        SearchByBox.Location = New Point(118, 287)
        SearchByBox.Name = "SearchByBox"
        SearchByBox.Size = New Size(240, 23)
        SearchByBox.TabIndex = 26
        ' 
        ' SearchButton
        ' 
        SearchButton.BackColor = Color.Transparent
        SearchButton.FlatStyle = FlatStyle.Flat
        SearchButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        SearchButton.Location = New Point(118, 331)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(162, 37)
        SearchButton.TabIndex = 27
        SearchButton.Text = "Search"
        SearchButton.UseVisualStyleBackColor = False
        ' 
        ' Invitations
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.light1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(SearchButton)
        Controls.Add(SearchByBox)
        Controls.Add(SearchBox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(SystemUsers)
        Controls.Add(InviteButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(EnrolledEvents)
        Name = "Invitations"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Invitations"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EnrolledEvents As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InviteButton As Button
    Friend WithEvents SystemUsers As CheckedListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents SearchByBox As ComboBox
    Friend WithEvents SearchButton As Button
End Class
