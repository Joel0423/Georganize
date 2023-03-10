<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrolledEventsForm
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
        EnrolledEventsList = New ListBox()
        DeleteButton = New Button()
        Button1 = New Button()
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
        Label1.Location = New Point(207, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(397, 50)
        Label1.TabIndex = 14
        Label1.Text = "Enrolled Events"' 
        ' EnrolledEventsList
        ' 
        EnrolledEventsList.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EnrolledEventsList.FormattingEnabled = True
        EnrolledEventsList.ItemHeight = 21
        EnrolledEventsList.Location = New Point(207, 139)
        EnrolledEventsList.Name = "EnrolledEventsList"
        EnrolledEventsList.Size = New Size(397, 151)
        EnrolledEventsList.TabIndex = 15
        ' 
        ' DeleteButton
        ' 
        DeleteButton.BackColor = Color.Transparent
        DeleteButton.FlatStyle = FlatStyle.Flat
        DeleteButton.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DeleteButton.Location = New Point(419, 296)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(133, 37)
        DeleteButton.TabIndex = 16
        DeleteButton.Text = "Delete"
        DeleteButton.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(268, 296)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 37)
        Button1.TabIndex = 17
        Button1.Text = "Visit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' EnrolledEventsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.light
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(DeleteButton)
        Controls.Add(EnrolledEventsList)
        Controls.Add(Label1)
        Name = "EnrolledEventsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EnrolledEvents"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents EnrolledEventsList As ListBox
    Friend WithEvents DeleteButton As Button
    Friend WithEvents Button1 As Button
End Class
