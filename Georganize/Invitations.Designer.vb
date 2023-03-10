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
        SuspendLayout()
        ' 
        ' EnrolledEvents
        ' 
        EnrolledEvents.FormattingEnabled = True
        EnrolledEvents.Location = New Point(118, 206)
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
        Label3.Location = New Point(118, 177)
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
        SystemUsers.FormattingEnabled = True
        SystemUsers.Location = New Point(423, 177)
        SystemUsers.Name = "SystemUsers"
        SystemUsers.Size = New Size(211, 148)
        SystemUsers.TabIndex = 22
        ' 
        ' Invitations
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.light1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(SystemUsers)
        Controls.Add(InviteButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(EnrolledEvents)
        Name = "Invitations"
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
End Class
