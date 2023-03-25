Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class EditProfileForm
    Dim DateChanged As Boolean
    Private Sqlcmd As New SqlCommand
    Dim emp As Image = New Bitmap(125, 175)

    Private Sub EditProfileForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Sqlcmd.Connection = Sqlcon
        DateTimePicker1.MaxDate = Date.Today
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"

        Dim Sqldr As SqlDataReader
        Sqlcmd.Parameters.AddWithValue("LoggedinP", LoggedInUser)
        Sqlcmd.CommandText = "select * from users where userid = @LoggedinP"
        Sqldr = Sqlcmd.ExecuteReader
        Sqldr.Read()

        UsernameTextBox.Text = Sqldr.GetValue(1)
        DateTimePicker1.Value = Sqldr.GetValue(2)
        GenderBox.SelectedItem = Sqldr.GetString(3)
        PhoneBox.Text = Sqldr.GetValue(4)
        EmailBox.Text = Sqldr.GetValue(5)
        PasswordBox1.Text = Sqldr.GetValue(6)
        PasswordBox2.Text = Sqldr.GetValue(6)

        If IsDBNull(Sqldr("photodir")) Then
            'Must be background image
            ProfilePicBox.BackgroundImage = Georganize.My.Resources.DefaultPic
        Else
            ProfilePicBox.ImageLocation = Sqldr("photodir")
        End If

        Sqldr.Close()
        Sqlcmd.Parameters.Clear()
    End Sub

    Private Sub EditProfileForm_CLose() Handles MyBase.Closed
        Profile.Show()
    End Sub

    ' Username validation
    Private Sub UsernameTextBox_Validation(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged, UsernameTextBox.LostFocus
        Dim username As String = UsernameTextBox.Text

        If username.Trim = Nothing Then
            ErrorProvider1.SetError(UsernameTextBox, "please create a username")
        ElseIf Regex.IsMatch(username, "[^a-zA-Z0-9-_ ]") Then
            ErrorProvider1.SetError(UsernameTextBox, "usernames can only contain letters, numbers, dashes, whitespace and underscore")
        ElseIf username.Length < 4 Then
            ErrorProvider1.SetError(UsernameTextBox, "enter atleast 4 characters")
        Else
            'empty string removes error provider
            ErrorProvider1.SetError(UsernameTextBox, "")
        End If


    End Sub

    ' gender validation
    Private Sub GenderBox_Validation(sender As Object, e As EventArgs) Handles GenderBox.SelectedIndexChanged
        If GenderBox.SelectedIndex = -1 Then
            ErrorProvider1.SetError(GenderBox, "please select a gender")
        Else
            ErrorProvider1.SetError(GenderBox, "")
        End If
    End Sub

    ' Phone no. validation
    Private Sub PhoneBox_Validation(sender As Object, e As EventArgs) Handles PhoneBox.TextChanged, PhoneBox.LostFocus
        Dim phoneno As String = PhoneBox.Text

        If phoneno.Trim = Nothing Then
            ErrorProvider1.SetError(PhoneBox, "please enter your phone number")
        ElseIf Regex.IsMatch(phoneno, "[^0-9]") Then
            ErrorProvider1.SetError(PhoneBox, "Only numbers are allowed")
        ElseIf PhoneBox.TextLength < 10 Then
            ErrorProvider1.SetError(PhoneBox, "enter a valid phone number")
        Else
            ErrorProvider1.SetError(PhoneBox, "")
        End If
    End Sub

    ' Email validation
    Private Sub EmailBox_Validation(sender As Object, e As EventArgs) Handles EmailBox.TextChanged, EmailBox.LostFocus
        Dim email As String = EmailBox.Text

        If email.Trim = Nothing Then
            ErrorProvider1.SetError(EmailBox, "please enter your email-id")
        ElseIf Not Regex.IsMatch(email, "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)+(.[a-z]{2,4})$") Then
            ErrorProvider1.SetError(EmailBox, "enter a valid email-id")
        Else
            ErrorProvider1.SetError(EmailBox, "")
        End If
    End Sub

    ' Password validation
    Private Sub PasswordBox1_Validation(sender As Object, e As EventArgs) Handles PasswordBox1.TextChanged, PasswordBox1.LostFocus
        Dim password As String = PasswordBox1.Text

        If password.Trim = Nothing Then
            ErrorProvider1.SetError(PasswordBox1, "please create a password")
        ElseIf Not Regex.IsMatch(password, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$") Then
            ErrorProvider1.SetError(PasswordBox1, "Minimum eight characters, one upper case letter, one lower case letter, one number and one special character")
        Else
            ErrorProvider1.SetError(PasswordBox1, "")
        End If
    End Sub

    Private Sub PasswordBox2_Validation(sender As Object, e As EventArgs) Handles PasswordBox2.TextChanged, PasswordBox2.LostFocus

        If PasswordBox2.Text.Trim = Nothing Then
            ErrorProvider1.SetError(PasswordBox2, "please re-enter the password")
        ElseIf PasswordBox1.Text <> PasswordBox2.Text Then
            ErrorProvider1.SetError(PasswordBox2, "password does not match")
        Else
            ErrorProvider1.SetError(PasswordBox2, "")
        End If

    End Sub

    ' Show password user is entering with a checkbox
    Private Sub ShowPassCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassCheckbox.CheckedChanged
        If ShowPassCheckbox.Checked Then
            ' PasswordChar = "0" will set 0 as password char, 12345 will be seen as 00000
            ' ChrW will convert to character '0' which removes PasswordChar functionality
            PasswordBox1.PasswordChar = ChrW(0)
            PasswordBox2.PasswordChar = ChrW(0)
        Else
            PasswordBox1.PasswordChar = "*"
            PasswordBox2.PasswordChar = "*"
        End If
    End Sub

    Private Function CheckErrors() As Boolean
        Dim s As String = ErrorProvider1.GetError(UsernameTextBox) & ErrorProvider1.GetError(GenderBox) & ErrorProvider1.GetError(PasswordBox1) & ErrorProvider1.GetError(PasswordBox2) & ErrorProvider1.GetError(DateTimePicker1) & ErrorProvider1.GetError(PhoneBox) & ErrorProvider1.GetError(EmailBox)
        If s.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        If Not CheckEmpty() Or CheckErrors() Then
            MessageBox.Show("please enter all the details correctly", "Form not filled correctly", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not CheckDatabase() Then
            MessageBox.Show("Username/Phone number/Email is already used by another user.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            SubmitForm()
        End If
    End Sub

    Private Function CheckEmpty() As Boolean
        ' checks if any controls are empty when submit button is clicked
        Dim bool As Boolean = True

        If UsernameTextBox.Text.Trim = Nothing Then
            ErrorProvider1.SetError(UsernameTextBox, "please create a username")
            bool = False
        End If
        If GenderBox.SelectedIndex = -1 Then
            ErrorProvider1.SetError(GenderBox, "please select a gender")
            bool = False
        End If
        If PhoneBox.Text.Trim = Nothing Then
            ErrorProvider1.SetError(PhoneBox, "please enter your phone number")
            bool = False
        End If
        If EmailBox.Text.Trim = Nothing Then
            ErrorProvider1.SetError(EmailBox, "please enter your email-id")
            bool = False
        End If
        If PasswordBox1.Text.Trim = Nothing Then
            ErrorProvider1.SetError(PasswordBox1, "please create a password")
            bool = False
        End If
        If PasswordBox2.Text.Trim = Nothing Then
            ErrorProvider1.SetError(PasswordBox2, "please re-enter the password")
            bool = False
        End If

        Return bool
    End Function

    Private Function CheckDatabase() As Boolean
        Dim Sqldr As SqlDataReader
        ' used to check if user has entered an already existing username, email or phone number
        Dim bool As Boolean = True
        Sqlcmd.Parameters.AddWithValue("LoggedinP", LoggedInUser)
        Sqlcmd.CommandText = "select username,phoneno,email from users where userid <> @LoggedinP"
        Sqldr = Sqlcmd.ExecuteReader

        Do While Sqldr.Read
            Dim temp As String
            temp = Sqldr.GetString("username") 'Name of column in users table

            If temp = UsernameTextBox.Text Then
                bool = False
                ErrorProvider1.SetError(UsernameTextBox, "Username is already taken")
            End If

            temp = Sqldr.GetValue("phoneno") 'Name of column in users table
            If temp = Val(PhoneBox.Text) Then
                bool = False
                ErrorProvider1.SetError(PhoneBox, "Phone number is already taken")
            End If
            temp = Sqldr.GetString("email") 'Name of column in users table
            If temp = EmailBox.Text Then
                bool = False
                ErrorProvider1.SetError(EmailBox, "Email-ID is already taken")
            End If
        Loop
        Sqlcmd.Parameters.Clear()
        Sqldr.Close()
        Return bool
    End Function

    Private Sub SubmitForm()
        ' enters details into database
        Sqlcmd.Parameters.AddWithValue("UsernameP", UsernameTextBox.Text)
        Sqlcmd.Parameters.AddWithValue("DOBP", DateTimePicker1.Value)
        Sqlcmd.Parameters.AddWithValue("GenderP", GenderBox.Text)
        Sqlcmd.Parameters.AddWithValue("PhonenoP", Val(PhoneBox.Text))
        Sqlcmd.Parameters.AddWithValue("EmailP", EmailBox.Text)
        Sqlcmd.Parameters.AddWithValue("PasswordP", PasswordBox1.Text)
        Sqlcmd.Parameters.AddWithValue("LoggedinP", LoggedInUser)

        If ProfilePicBox.Image IsNot Nothing Then
            emp.Save(ProfilePicDirectory & "\" & LoggedInUser & ".jpg", Imaging.ImageFormat.Jpeg)
            Sqlcmd.Parameters.AddWithValue("profilepicP", ProfilePicDirectory & "\" & LoggedInUser & ".jpg")
            Sqlcmd.CommandText = "update users set username = @UsernameP,dob=@DOBP,gender=@GenderP,phoneno=@PhonenoP,email=@EmailP,password=@PasswordP,photodir = @profilepicP where userid = @LoggedinP"
            Sqlcmd.ExecuteNonQuery()
        Else
            Sqlcmd.CommandText = "update users set username = @UsernameP,dob=@DOBP,gender=@GenderP,phoneno=@PhonenoP,email=@EmailP,password=@PasswordP where userid = @LoggedinP"
            Sqlcmd.ExecuteNonQuery()
        End If

        MessageBox.Show("Your profile has been updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Sqlcmd.Parameters.Clear()
        Me.Close()

        Profile.ProfileFormReload()
        Profile.Show()
    End Sub

    Private Sub ProfilePicButton_Click(sender As Object, e As EventArgs) Handles ProfilePicButton.Click
        OpenFileDialog1.InitialDirectory = InitialDirectoryString
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim s As String = OpenFileDialog1.FileName
            Dim img As Image = Image.FromFile(s)

            Dim graphicsHandle As Graphics = Graphics.FromImage(emp)
            graphicsHandle.InterpolationMode = InterpolationMode.Low
            graphicsHandle.DrawImage(img, 0, 0, 125, 175)

            ProfilePicBox.Image = emp
        End If

    End Sub
End Class