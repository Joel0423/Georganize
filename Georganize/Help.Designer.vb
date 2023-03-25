<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        HelpBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' HelpBox
        ' 
        HelpBox.BackColor = Color.SeaShell
        HelpBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        HelpBox.Location = New Point(199, 82)
        HelpBox.Multiline = True
        HelpBox.Name = "HelpBox"
        HelpBox.ReadOnly = True
        HelpBox.ScrollBars = ScrollBars.Vertical
        HelpBox.Size = New Size(420, 269)
        HelpBox.TabIndex = 1
        HelpBox.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("SimSun-ExtB", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(344, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 50)
        Label1.TabIndex = 0
        Label1.Text = "Help"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("SimSun-ExtB", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(12, 346)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 29)
        Label2.TabIndex = 2
        Label2.Text = "Contact Us:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.FlatStyle = FlatStyle.Popup
        Label4.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(12, 386)
        Label4.Name = "Label4"
        Label4.Size = New Size(330, 21)
        Label4.TabIndex = 4
        Label4.Text = "Email: helpdesk@georganize.in"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("SimSun-ExtB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(12, 420)
        Label3.Name = "Label3"
        Label3.Size = New Size(253, 21)
        Label3.TabIndex = 5
        Label3.Text = "Phone: +91 80672 18000"
        ' 
        ' Help
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.light
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(HelpBox)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Help"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Help"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HelpBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
