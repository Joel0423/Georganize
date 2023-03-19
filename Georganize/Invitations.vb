Imports System.Data.SqlClient

Public Class Invitations
    Dim Sqlcmd As New SqlCommand
    Dim Sqldr As SqlDataReader

    Private Sub Invitations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchByBox.Items.Add("Username")
        SearchByBox.Items.Add("Phone Number")
        SearchByBox.Items.Add("Email ID")

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

    End Sub

    Private Sub InviteButton_Click(sender As Object, e As EventArgs) Handles InviteButton.Click
        Dim tempb As Boolean = False
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
                Sqlcmd.CommandText = "select eventid from invitations where eventid=@eventid and recieverid=@userid"
                If Sqlcmd.ExecuteScalar <> Nothing Then
                    MessageBox.Show(user.ToString & " is already invited for this event", "Cannot invite", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Sqlcmd.CommandText = "insert into invitations (eventid, recieverid) values (@eventid, @userid);"
                    Sqlcmd.ExecuteNonQuery()
                    Sqlcmd.Parameters.Clear()
                    tempb = True
                End If

            Next
            If tempb = True Then
                MessageBox.Show("Invitation(s) have been sent.")
            End If
        End If

    End Sub

    Private Sub Form_Close() Handles MyBase.Closed
        HomeForm.Show()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If SearchBox.Text.Trim = Nothing Or SearchByBox.SelectedIndex = -1 Then
            MessageBox.Show("Enter all search parameters", "Enter details", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If SearchByBox.SelectedIndex = 0 Then
                Sqlcmd.Parameters.Clear()

                Sqlcmd.Parameters.AddWithValue("userr", LoggedInUser)
                Sqlcmd.Parameters.AddWithValue("uname", SearchBox.Text)
                Sqlcmd.CommandText = "select username from users where userid != @userr and username=@uname"
                If Sqlcmd.ExecuteScalar = Nothing Then
                    MessageBox.Show("No User by that name", "User does not exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim bool = True
                    For Each item In SystemUsers.Items
                        If Sqlcmd.ExecuteScalar = item.ToString Then
                            bool = False
                            Exit For
                        End If
                    Next
                    If bool Then
                        SystemUsers.Items.Add(Sqlcmd.ExecuteScalar.ToString)
                    Else
                        MessageBox.Show("User already in list", "User cannot be added", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                End If
                Sqlcmd.Parameters.Clear()
            End If
            If SearchByBox.SelectedIndex = 1 Then
                Sqlcmd.Parameters.Clear()

                Sqlcmd.Parameters.AddWithValue("userr", LoggedInUser)
                Sqlcmd.Parameters.AddWithValue("phone", SearchBox.Text)
                Sqlcmd.CommandText = "select username from users where userid != @userr and phoneno=@phone"
                Try
                    If Sqlcmd.ExecuteScalar = Nothing Then
                        MessageBox.Show("No User with that phone number", "User does not exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Dim bool = True
                        For Each item In SystemUsers.Items
                            If Sqlcmd.ExecuteScalar = item.ToString Then
                                bool = False
                                Exit For
                            End If
                        Next
                        If bool Then
                            SystemUsers.Items.Add(Sqlcmd.ExecuteScalar.ToString)
                        Else
                            MessageBox.Show("User already in list", "User cannot be added", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("No User with that phone number", "User does not exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try

                Sqlcmd.Parameters.Clear()
            End If
            If SearchByBox.SelectedIndex = 2 Then
                Sqlcmd.Parameters.Clear()

                Sqlcmd.Parameters.AddWithValue("userr", LoggedInUser)
                Sqlcmd.Parameters.AddWithValue("email", SearchBox.Text)
                Sqlcmd.CommandText = "select username from users where userid != @userr and email=@email"
                If Sqlcmd.ExecuteScalar = Nothing Then
                    MessageBox.Show("No User with that Email IDr", "User does not exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim bool = True
                    For Each item In SystemUsers.Items
                        If Sqlcmd.ExecuteScalar = item.ToString Then
                            bool = False
                            Exit For
                        End If
                    Next
                    If bool Then
                        SystemUsers.Items.Add(Sqlcmd.ExecuteScalar.ToString)
                    Else
                        MessageBox.Show("User already in list", "User cannot be added", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
                Sqlcmd.Parameters.Clear()
            End If
        End If
    End Sub
End Class