Imports System.Data.SqlClient

Public Class Invitations
    Dim Sqlcmd As New SqlCommand
    Dim Sqldr As SqlDataReader
    Private Sub Invitations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnrolledEvents.Items.Clear()
        Sqlcmd.Connection = Sqlcon
        Sqlcmd.Parameters.AddWithValue("userr", LoggedInUser)
        Sqlcmd.CommandText = "select name from events, enrollments where enrollments.userid = @userr and enrollments.eventid = events.eventid;"
        Sqldr = Sqlcmd.ExecuteReader()
        Do While Sqldr.Read()
            EnrolledEvents.Items.Add(Sqldr(0).ToString())
        Loop
        Sqldr.Close()
        Sqlcmd.Parameters.Clear()

        Sqlcmd.Parameters.AddWithValue("userr", LoggedInUser)
        Sqlcmd.CommandText = "select username from users where userid != @userr;"
        Sqldr = Sqlcmd.ExecuteReader
        Do While Sqldr.Read()
            SystemUsers.Items.Add(Sqldr(0).ToString())
        Loop
        Sqlcmd.Parameters.Clear()
        Sqldr.Close()
    End Sub

    Private Sub InviteButton_Click(sender As Object, e As EventArgs) Handles InviteButton.Click
        If EnrolledEvents.SelectedItem = Nothing Then
            MessageBox.Show("No invitations sent.")
        Else
            Dim evid As Integer
            Dim uid As Integer
            Sqlcmd.Parameters.AddWithValue("ename", EnrolledEvents.SelectedItem)
            Sqlcmd.CommandText = "select eventid from events where name = @ename;"
            evid = Convert.ToInt16(Sqlcmd.ExecuteScalar())
            Sqlcmd.Parameters.Clear()

            For Each user In SystemUsers.CheckedItems
                Sqlcmd.Parameters.AddWithValue("uname", user.ToString())
                Sqlcmd.CommandText = "select userid from users where username = @uname;"
                uid = Convert.ToInt16(Sqlcmd.ExecuteScalar())
                Sqlcmd.Parameters.Clear()

                Sqlcmd.Parameters.AddWithValue("userid", uid)
                Sqlcmd.Parameters.AddWithValue("eventid", evid)
                Sqlcmd.CommandText = "insert into invitations (eventid, recieverid) values (@eventid, @userid);"
                Sqlcmd.ExecuteNonQuery()
                Sqlcmd.Parameters.Clear()
                MessageBox.Show("Invitation(s) have been sent.")
                Form_Close()
            Next

        End If
    End Sub

    Private Sub Form_Close()
        HomeForm.Show()
    End Sub
End Class