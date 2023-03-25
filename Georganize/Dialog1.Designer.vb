<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
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
        TableLayoutPanel1 = New TableLayoutPanel()
        OK_Button = New Button()
        Cancel_Button = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        Label3 = New Label()
        RichTextBox1 = New RichTextBox()
        CardNOTextBox = New TextBox()
        CVVTextBox = New TextBox()
        ExpiryTextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CardPanel = New Panel()
        CardRadio = New RadioButton()
        UPIRadio = New RadioButton()
        UPIPanel = New Panel()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CardPanel.SuspendLayout()
        UPIPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(OK_Button, 0, 0)
        TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0)
        TableLayoutPanel1.Location = New Point(163, 361)
        TableLayoutPanel1.Margin = New Padding(4, 3, 4, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(170, 33)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.Location = New Point(4, 3)
        OK_Button.Margin = New Padding(4, 3, 4, 3)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(77, 27)
        OK_Button.TabIndex = 0
        OK_Button.Text = "Pay"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.Location = New Point(89, 3)
        Cancel_Button.Margin = New Padding(4, 3, 4, 3)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(77, 27)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Cancel"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.BackColor = Color.WhiteSmoke
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("SimSun-ExtB", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(97, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(285, 26)
        Label3.TabIndex = 17
        Label3.Text = "Enter Payment Details"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(361, 101)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(134, 179)
        RichTextBox1.TabIndex = 22
        RichTextBox1.Text = ""
        ' 
        ' CardNOTextBox
        ' 
        CardNOTextBox.Location = New Point(19, 50)
        CardNOTextBox.MaxLength = 16
        CardNOTextBox.Name = "CardNOTextBox"
        CardNOTextBox.Size = New Size(230, 23)
        CardNOTextBox.TabIndex = 1
        ' 
        ' CVVTextBox
        ' 
        CVVTextBox.Location = New Point(19, 121)
        CVVTextBox.MaxLength = 4
        CVVTextBox.Name = "CVVTextBox"
        CVVTextBox.Size = New Size(90, 23)
        CVVTextBox.TabIndex = 2
        ' 
        ' ExpiryTextBox
        ' 
        ExpiryTextBox.Location = New Point(19, 188)
        ExpiryTextBox.MaxLength = 5
        ExpiryTextBox.Name = "ExpiryTextBox"
        ExpiryTextBox.Size = New Size(91, 23)
        ExpiryTextBox.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.BackColor = Color.WhiteSmoke
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(19, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 25)
        Label1.TabIndex = 18
        Label1.Text = "Enter Card Number"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.BackColor = Color.WhiteSmoke
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(19, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 25)
        Label2.TabIndex = 19
        Label2.Text = "Enter CVV"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.FlatStyle = FlatStyle.Popup
        Label4.Font = New Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(19, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 25)
        Label4.TabIndex = 20
        Label4.Text = "Enter Expiry Date"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = Color.WhiteSmoke
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.FlatStyle = FlatStyle.Popup
        Label5.Font = New Font("Sitka Small", 9.749999F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(152, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 21)
        Label5.TabIndex = 21
        Label5.Text = "Format - MM/YY"
        ' 
        ' CardPanel
        ' 
        CardPanel.BackColor = Color.Transparent
        CardPanel.Controls.Add(Label1)
        CardPanel.Controls.Add(CardNOTextBox)
        CardPanel.Controls.Add(Label5)
        CardPanel.Controls.Add(Label2)
        CardPanel.Controls.Add(Label4)
        CardPanel.Controls.Add(ExpiryTextBox)
        CardPanel.Controls.Add(CVVTextBox)
        CardPanel.Location = New Point(12, 101)
        CardPanel.Name = "CardPanel"
        CardPanel.Size = New Size(343, 244)
        CardPanel.TabIndex = 23
        ' 
        ' CardRadio
        ' 
        CardRadio.AutoSize = True
        CardRadio.Checked = True
        CardRadio.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        CardRadio.Location = New Point(59, 73)
        CardRadio.Name = "CardRadio"
        CardRadio.Size = New Size(56, 22)
        CardRadio.TabIndex = 24
        CardRadio.TabStop = True
        CardRadio.Text = "Card"
        CardRadio.UseVisualStyleBackColor = True
        ' 
        ' UPIRadio
        ' 
        UPIRadio.AutoSize = True
        UPIRadio.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        UPIRadio.Location = New Point(122, 75)
        UPIRadio.Name = "UPIRadio"
        UPIRadio.Size = New Size(44, 20)
        UPIRadio.TabIndex = 25
        UPIRadio.Text = "UPI"
        UPIRadio.UseVisualStyleBackColor = True
        ' 
        ' UPIPanel
        ' 
        UPIPanel.BackColor = Color.Transparent
        UPIPanel.Controls.Add(Label7)
        UPIPanel.Controls.Add(Label6)
        UPIPanel.Controls.Add(PictureBox1)
        UPIPanel.Location = New Point(12, 101)
        UPIPanel.Name = "UPIPanel"
        UPIPanel.Size = New Size(343, 254)
        UPIPanel.TabIndex = 26
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.upi_1679663523675
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(76, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(186, 186)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.WhiteSmoke
        Label6.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(71, 192)
        Label6.Name = "Label6"
        Label6.Size = New Size(203, 19)
        Label6.TabIndex = 1
        Label6.Text = "UPI ID: georganize@okicici"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.WhiteSmoke
        Label7.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(71, 225)
        Label7.Name = "Label7"
        Label7.Size = New Size(206, 19)
        Label7.TabIndex = 2
        Label7.Text = "Please pay within 2 minutes"
        ' 
        ' Dialog1
        ' 
        AcceptButton = OK_Button
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.light
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = Cancel_Button
        ClientSize = New Size(503, 406)
        Controls.Add(UPIPanel)
        Controls.Add(UPIRadio)
        Controls.Add(CardRadio)
        Controls.Add(CardPanel)
        Controls.Add(RichTextBox1)
        Controls.Add(Label3)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Dialog1"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Payment Dialog"
        TableLayoutPanel1.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CardPanel.ResumeLayout(False)
        CardPanel.PerformLayout()
        UPIPanel.ResumeLayout(False)
        UPIPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ExpiryTextBox As TextBox
    Friend WithEvents CVVTextBox As TextBox
    Friend WithEvents CardNOTextBox As TextBox
    Friend WithEvents UPIPanel As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UPIRadio As RadioButton
    Friend WithEvents CardRadio As RadioButton
    Friend WithEvents CardPanel As Panel
End Class
