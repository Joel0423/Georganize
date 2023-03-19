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
        DeleteEventButton.Location = New Point(258, 295)
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
        CreatedEventsList.Location = New Point(202, 128)
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
        CheckBox1.Location = New Point(425, 295)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(142, 26)
        CheckBox1.TabIndex = 21
        CheckBox1.Text = "Discussion Board"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' ManageEvents
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.light1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(CheckBox1)
        Controls.Add(DeleteEventButton)
        Controls.Add(CreatedEventsList)
        Controls.Add(Label1)
        Name = "ManageEvents"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manage Events"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteEventButton As Button
    Friend WithEvents CreatedEventsList As ListBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
