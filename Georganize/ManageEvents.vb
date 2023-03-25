Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ManageEvents
    Dim Sqlcmd As New SqlCommand
    Private Sub ManageEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Enabled = False
        Panel1.Visible = False
        Me.DoubleBuffered = True
        Sqlcmd.Connection = Sqlcon
        LoadEvents()
    End Sub

    Private Sub LoadEvents()
        CreatedEventsList.Items.Clear()
        Dim Sqldr As SqlDataReader
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Parameters.AddWithValue("org", LoggedInUser)
        Sqlcmd.CommandText = "select name from events where organizerid = @org"
        Sqldr = Sqlcmd.ExecuteReader

        While Sqldr.Read
            CreatedEventsList.Items.Add(Sqldr.Item(0))
        End While
        Sqlcmd.Parameters.Clear()
        Sqldr.Close()
    End Sub

    Private Sub ManageEvents_CLose() Handles MyBase.Closed
        EditEventForm.Close()
        HomeForm.Show()
    End Sub

    Private Sub DeleteEventButton_Click(sender As Object, e As EventArgs) Handles DeleteEventButton.Click
        If CreatedEventsList.SelectedItem = Nothing Then
            MessageBox.Show("No Event has been selected", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this event?" & System.Environment.NewLine & "all attendees will be un-enrolled", "Delete this event?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                Sqlcmd.Parameters.Clear()
                Sqlcmd.Parameters.AddWithValue("sname", CreatedEventsList.SelectedItem)
                Sqlcmd.CommandText = "delete from events where name = @sname"
                Sqlcmd.ExecuteNonQuery()
                Sqlcmd.Parameters.Clear()
                LoadEvents()
            End If
        End If

    End Sub

    Private Sub CreatedEventsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CreatedEventsList.SelectedIndexChanged
        If CreatedEventsList.SelectedIndex <> -1 Then
            CheckBox1.Enabled = True
            DiscussionState()

            Panel1.Visible = False
            AttendeesListBox.Items.Clear()
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Parameters.AddWithValue("Ename", CreatedEventsList.SelectedItem.ToString)

            Dim Sqldr As SqlDataReader
            Sqlcmd.CommandText = "select username from enrollments,users,events where enrollments.userid=users.userid and events.eventid=enrollments.eventid and events.name=@Ename"
            Sqldr = Sqlcmd.ExecuteReader
            If IsDBNull(Sqldr) Then
                CreatedEventsList.Items.Add("No Enrollments")
            Else
                While Sqldr.Read
                    AttendeesListBox.Items.Add(Sqldr(0))
                End While
            End If
            TextBox1.Text = AttendeesListBox.Items.Count
            Sqldr.Close()
            Sqlcmd.Parameters.Clear()
        Else
            Panel1.Visible = False
            AttendeesListBox.Items.Clear()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If AttendeesListBox.SelectedItem = Nothing Then
            MessageBox.Show("No Attendee has been selected", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim age As Integer = 0
            Dim Sqldr As SqlDataReader
            Panel1.Visible = True
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Parameters.AddWithValue("usern", AttendeesListBox.SelectedItem.ToString)
            Sqlcmd.CommandText = "select username,DOB, photodir from users where username = @usern"
            Sqldr = Sqlcmd.ExecuteReader
            While Sqldr.Read
                If Not IsDBNull(Sqldr("photodir")) Then
                    PictureBox1.ImageLocation = Sqldr("photodir")
                Else
                    PictureBox1.Image = Georganize.My.Resources.DefaultPic
                End If

                NameBox.Text = Sqldr("username")
                Dim tempdate As New DateTime
                tempdate = Sqldr("DOB")
                age = DateTime.Today.Year - tempdate.Year
                ' for leap year?
                If tempdate.Date > DateTime.Today.AddYears(-age) Then
                    age -= 1
                End If
                AgeBox.Text = age.ToString

            End While
            Sqlcmd.Parameters.Clear()
            Sqldr.Close()
        End If

    End Sub

    Private Sub DiscussionState()
        If CreatedEventsList.SelectedIndex <> -1 Then
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Parameters.AddWithValue("Ename", CreatedEventsList.SelectedItem.ToString)
            Sqlcmd.CommandText = "select discussion from events where name=@Ename"
            If Not IsDBNull(Sqlcmd.ExecuteScalar) Then
                If Sqlcmd.ExecuteScalar = "yes" Then
                    CheckBox1.Checked = True
                Else
                    CheckBox1.Checked = False
                End If
            Else
                CheckBox1.Checked = False
            End If
            Sqlcmd.Parameters.Clear()
        Else
            CheckBox1.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.Click
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Parameters.AddWithValue("Ename", CreatedEventsList.SelectedItem.ToString)
        If CheckBox1.Checked Then
            Sqlcmd.CommandText = "update events set discussion = 'yes' where name =@Ename"
            Sqlcmd.ExecuteNonQuery()

        Else
            Sqlcmd.CommandText = "update events set discussion = 'no' where name =@Ename"
            Sqlcmd.ExecuteNonQuery()
        End If
        Sqlcmd.Parameters.Clear()
    End Sub

    Private Sub RemoveUserButton_Click(sender As Object, e As EventArgs) Handles RemoveUserButton.Click
        If AttendeesListBox.SelectedIndex <> -1 And CreatedEventsList.SelectedIndex <> -1 Then
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Parameters.AddWithValue("loggd", Val(LoggedInUser))
            Sqlcmd.CommandText = "select username from users where userid=@loggd"

            If AttendeesListBox.SelectedItem.ToString = Sqlcmd.ExecuteScalar Then
                MessageBox.Show("You cannot remove yourself", "cannot remove attendee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Sqlcmd.Parameters.AddWithValue("selu", AttendeesListBox.SelectedItem.ToString)
                Sqlcmd.Parameters.AddWithValue("sele", CreatedEventsList.SelectedItem.ToString)

                Sqlcmd.CommandText = "select userid from users where username = @selu"
                Dim tempuid As Integer = Sqlcmd.ExecuteScalar
                Sqlcmd.CommandText = "select eventid from events where name = @sele"
                Dim tempeid As Integer = Sqlcmd.ExecuteScalar
                Sqlcmd.Parameters.AddWithValue("uid", tempuid)
                Sqlcmd.Parameters.AddWithValue("eid", tempeid)
                Sqlcmd.CommandText = "delete from enrollments where userid=@uid and eventid=@eid"
                Sqlcmd.ExecuteNonQuery()
                Panel1.Visible = False
                AttendeesListBox.Items.Remove(AttendeesListBox.SelectedItem)
            End If
            Sqlcmd.Parameters.Clear()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CreatedEventsList.SelectedIndex <> -1 Then
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Parameters.AddWithValue("ename", CreatedEventsList.SelectedItem)
            Sqlcmd.CommandText = "select eventid from events where name=@ename"
            SelectedPublicEventID = Sqlcmd.ExecuteScalar.ToString

            EditEventForm.Show()
        End If
    End Sub
End Class