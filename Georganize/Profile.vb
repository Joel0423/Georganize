Imports System.Data.SqlClient
Public Class Profile
    Private Sqlcmd As New SqlCommand
    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        ProfileFormReload()
    End Sub

    Public Sub ProfileFormReload()
        Sqlcmd.Connection = Sqlcon
        Sqlcmd.Parameters.AddWithValue("user", LoggedInUser)
        Sqlcmd.CommandText = "select username, dob, gender, email, phoneno, photodir from users where userid = @user"
        Dim Sqldr As SqlDataReader
        Sqldr = Sqlcmd.ExecuteReader
        Sqlcmd.Parameters.Clear()
        Sqldr.Read()
        UsernameLabel.Text = Sqldr("username")
        BirthdayLabel.Text = Sqldr("dob")
        GenderLabel.Text = Sqldr("gender")
        PhoneLabel.Text = Sqldr("phoneno")
        EmailLabel.Text = Sqldr("email")

        If IsDBNull(Sqldr("photodir")) Then
            ' here it is fine if its background image or image
            ProfilePictureBox.Image = Georganize.My.Resources.DefaultPic
        Else
            ProfilePictureBox.ImageLocation = Sqldr("photodir")
        End If
        Sqldr.Close()
    End Sub

    Private Sub EditProfileButton_Click(sender As Object, e As EventArgs) Handles EditProfileButton.Click
        EditProfileForm.Show()
        Me.Hide()
    End Sub

    Private Sub Profile_CLose() Handles Me.Closed
        HomeForm.Show()
    End Sub
End Class