Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ManageEvents
    Dim Sqlcmd As New SqlCommand
    Private Sub ManageEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Sqldr.Close()
        Sqlcmd.Parameters.Clear()
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
End Class