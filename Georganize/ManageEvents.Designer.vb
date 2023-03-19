<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageEvents
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
        Label1 = New Label()
        DeleteEventButton = New Button()
        CreatedEventsList = New ListBox()
        CheckBox1 = New CheckBox()
        AttendeesListBox = New ListBox()
        Label2 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        AgeBox = New TextBox()
        NameBox = New TextBox()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("SimSun-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(220, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(472, 50)
        Label1.TabIndex = 7
        Label1.Text = "Manage Your Events"' 
        ' DeleteEventButton
        ' 
        DeleteEventButton.BackColor = Color.Transparent
        DeleteEventButton.FlatStyle = FlatStyle.Flat
        DeleteEventButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DeleteEventButton.Location = New Point(55, 252)
        DeleteEventButton.Name = "DeleteEventButton"
        DeleteEventButton.Size = New Size(133, 37)
        DeleteEventButton.TabIndex = 20
        DeleteEventButton.Text = "Delete"
        DeleteEventButton.UseVisualStyleBackColor = False
        ' 
        ' CreatedEventsList
        ' 
        CreatedEventsList.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CreatedEventsList.FormattingEnabled = True
        CreatedEventsList.ItemHeight = 21
        CreatedEventsList.Location = New Point(55, 95)
        CreatedEventsList.Name = "CreatedEventsList"
        CreatedEventsList.Size = New Size(397, 151)
        CreatedEventsList.TabIndex = 18
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.FlatStyle = FlatStyle.Flat
        CheckBox1.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(310, 263)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(142, 26)
        CheckBox1.TabIndex = 21
        CheckBox1.Text = "Discussion Board"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' AttendeesListBox
        ' 
        AttendeesListBox.FormattingEnabled = True
        AttendeesListBox.ItemHeight = 15
        AttendeesListBox.Location = New Point(542, 124)
        AttendeesListBox.Name = "AttendeesListBox"
        AttendeesListBox.Size = New Size(164, 259)
        AttendeesListBox.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(563, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 26)
        Label2.TabIndex = 23
        Label2.Text = "Attendees"' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(570, 389)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 49)
        Button1.TabIndex = 24
        Button1.Text = "Show User Details"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(AgeBox)
        Panel1.Controls.Add(NameBox)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(30, 315)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(447, 164)
        Panel1.TabIndex = 25
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(197, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 21)
        Label4.TabIndex = 4
        Label4.Text = "Age"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(197, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 21)
        Label3.TabIndex = 3
        Label3.Text = "Name"' 
        ' AgeBox
        ' 
        AgeBox.Location = New Point(190, 100)
        AgeBox.Name = "AgeBox"
        AgeBox.ReadOnly = True
        AgeBox.Size = New Size(100, 23)
        AgeBox.TabIndex = 2
        AgeBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' NameBox
        ' 
        NameBox.Location = New Point(190, 45)
        NameBox.Name = "NameBox"
        NameBox.ReadOnly = True
        NameBox.Size = New Size(171, 23)
        NameBox.TabIndex = 1
        NameBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.ErrorImage = My.Resources.Resources.DefaultPic
        PictureBox1.Location = New Point(14, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 140)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ManageEvents
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.light1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 481)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(AttendeesListBox)
        Controls.Add(CheckBox1)
        Controls.Add(DeleteEventButton)
        Controls.Add(CreatedEventsList)
        Controls.Add(Label1)
        Name = "ManageEvents"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manage Events"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteEventButton As Button
    Friend WithEvents CreatedEventsList As ListBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents AttendeesListBox As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AgeBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
