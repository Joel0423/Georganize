Imports System.Data.SqlClient

Public Class LoginForm

    Private Sqlcmd As New SqlCommand

    Private Sub LoginFormReturn(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        ' For when user returns to login form, example- through a logout button
        UsernameBox.Text = ""
        PasswordBox.Text = ""

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GeoOpen()
        UsernameBox.PlaceholderText = "Username"
        PasswordBox.PlaceholderText = "Password"
        PasswordBox.PasswordChar = "*"

        Sqlcmd.Connection = Sqlcon
    End Sub

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        If UsernameBox.Text = Nothing Or PasswordBox.Text = Nothing Then
            MessageBox.Show("Enter your Username and Password", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            CheckDatabase()
        End If
    End Sub

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignUpButton.Click
        SignUpForm.Show()
    End Sub

    Private Sub CheckAdmin()
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Parameters.AddWithValue("UserP", UsernameBox.Text)
        Sqlcmd.Parameters.AddWithValue("PassP", PasswordBox.Text)
        Sqlcmd.CommandText = "SELECT adminid,username,password FROM admin WHERE username=@UserP AND password=@PassP"

        If Sqlcmd.ExecuteScalar = Nothing Then
            MessageBox.Show("Entered Username or Password is incorrect", "Incorrect Details", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            ' stores the currently loggedin users userid as string
            ' LoggedInUser is declared in the module GeoLoad
            LoggedInUser = Sqlcmd.ExecuteScalar.ToString
            Sqlcmd.Parameters.Clear()

            Me.Hide()
            AdminHome.Show()
        End If
        'allows user to try to enter username/password multiple times
        Sqlcmd.Parameters.Clear()
    End Sub

    Private Sub CheckDatabase()
        ' Checks database to see if entered username and password is correct
        Sqlcmd.Parameters.AddWithValue("UserP", UsernameBox.Text)
        Sqlcmd.Parameters.AddWithValue("PassP", PasswordBox.Text)
        Sqlcmd.CommandText = "SELECT userid,username,password FROM users WHERE username=@UserP AND password=@PassP"

        If Sqlcmd.ExecuteScalar = Nothing Then
            CheckAdmin()

        Else

            ' stores the currently loggedin users userid as string
            ' LoggedInUser is declared in the module GeoLoad
            LoggedInUser = Sqlcmd.ExecuteScalar.ToString
            Sqlcmd.Parameters.AddWithValue("loggd", LoggedInUser)
            Sqlcmd.CommandText = "select dob from users where userid=@loggd"
            LoggedInUserDOB = Sqlcmd.ExecuteScalar
            FindAge()
            CloseForm()
        End If
        'allows user to try to enter username/password multiple times
        Sqlcmd.Parameters.Clear()
    End Sub

    Private Sub CloseForm()
        ' Me.Close will kill the application, with Me.Hide Georganize will still run in background as long as LoginForm is not closed
        ' you cannot build the app without closing all instaces of Geo
        ' HomeForm will close LoginForm when it is closed
        Sqlcmd.Parameters.Clear()
        Me.Hide()
        HomeForm.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If UsernameBox.Text = "admin" And PasswordBox.Text = "adm1n" Then
            AdminHome.Show()
        Else
            MessageBox.Show("Invalid credentials for admin.")
        End If
    End Sub
End Class
