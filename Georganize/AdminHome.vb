Imports System.Data.SqlClient
Public Class AdminHome
    Dim Sqlcmd As New SqlCommand
    Private Sub AdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        UpdateUserList()
        ShowAllEvents()

        ShowLogs()
        LoadVenues()

    End Sub

    Private Sub FetchUserEvents_Click(sender As Object, e As EventArgs) Handles FetchUserEvents.Click
        If UserList.CheckedItems.Count = 0 Then
            EventLabel.Text = ""
        End If
        If UserList.CheckedItems.Count = 1 Then
            EventLabel.Text = UserList.CheckedItems.Item(0).ToString & "'s events"
        End If
        If UserList.CheckedItems.Count > 1 Then
            EventLabel.Text = UserList.CheckedItems.Item(0).ToString & "'s and other's events"
        End If
        EventList.Items.Clear()
        UpdateSelectedUsersEvents()
    End Sub

    Private Sub UpdateSelectedUsersEvents()
        EventList.Items.Clear()

        For Each item In UserList.CheckedItems
            Sqlcmd.Parameters.AddWithValue("selecteduser", item.ToString())
            Sqlcmd.CommandText = "select name from events, users where username = @selecteduser and organizerid = userid;"
            Dim Sqldr As SqlDataReader
            Sqldr = Sqlcmd.ExecuteReader()

            While Sqldr.Read()
                EventList.Items.Add(Sqldr(0).ToString())
            End While
            Sqldr.Close()
            Sqlcmd.Parameters.Clear()
        Next

        Sqlcmd.Dispose()
    End Sub

    Private Sub UserDelete_Click(sender As Object, e As EventArgs) Handles UserDelete.Click
        For Each user In UserList.CheckedItems
            Sqlcmd.Parameters.AddWithValue("usern", user)
            Sqlcmd.CommandText = "delete from users where username = @usern;"
            Sqlcmd.ExecuteNonQuery()
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Dispose()
            MessageBox.Show("User account deleted.")
        Next
    End Sub

    Private Sub EventDelete_Click(sender As Object, e As EventArgs) Handles EventDelete.Click
        For Each eventn In EventList.CheckedItems
            Sqlcmd.Parameters.AddWithValue("eventn", eventn)
            Sqlcmd.CommandText = "delete from events where name = @eventn;"
            Sqlcmd.ExecuteNonQuery()
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Dispose()
            MessageBox.Show("Event deleted.")
        Next

    End Sub

    Private Sub CloseForm() Handles MyBase.Closed
        LoginForm.Show()
    End Sub

    Private Sub UserUpdate_Click(sender As Object, e As EventArgs) Handles UserUpdate.Click
        UpdateUserList()
    End Sub

    Private Sub UpdateUserList()
        UserList.Items.Clear()
        Dim Sqldr As SqlDataReader
        Sqlcmd.Connection = Sqlcon
        Sqlcmd.CommandText = "select username from users;"
        Sqldr = Sqlcmd.ExecuteReader()
        While Sqldr.Read()
            UserList.Items.Add(Sqldr(0).ToString())
        End While
        Sqldr.Close()
    End Sub

    Private Sub ShowAllEvents()
        EventList.Items.Clear()
        EventLabel.Text = "All Georganize Events"
        Dim Sqldr As SqlDataReader
        Sqlcmd.CommandText = "select name from events;"
        Sqldr = Sqlcmd.ExecuteReader()
        While Sqldr.Read()
            EventList.Items.Add(Sqldr(0).ToString())
        End While
        Sqldr.Close()
    End Sub

    Private Sub AllEventButton_Click(sender As Object, e As EventArgs) Handles AllEventButton.Click
        ShowAllEvents()
    End Sub

    Private Sub ShowLogs()
        Dim Sqldr As SqlDataReader
        Sqlcmd.CommandText = "select logtext from logs;"
        Sqldr = Sqlcmd.ExecuteReader()
        While Sqldr.Read()
            SystemLogs.Items.Add(Sqldr(0).ToString())
        End While
        Sqldr.Close()
    End Sub

    Private Sub EventUpdate_Click(sender As Object, e As EventArgs) Handles EventUpdate.Click
        If EventLabel.Text <> "All Georganize Events" Then
            UpdateSelectedUsersEvents()
        Else
            ShowAllEvents()
        End If
    End Sub

    Private Sub LoadVenues()
        VenueListBox.Items.Clear()
        Dim Sqldr As SqlDataReader
        Sqlcmd.CommandText = "select * from venues"
        Sqldr = Sqlcmd.ExecuteReader()
        While Sqldr.Read()
            VenueListBox.Items.Add(Sqldr.Item(0).ToString).SubItems.AddRange({Sqldr.Item(1).ToString, Sqldr(2).ToString})
        End While
        Sqldr.Close()
    End Sub

    Private Sub AddVenueButton_Click(sender As Object, e As EventArgs) Handles AddVenueButton.Click
        If VenueNameBox.Text.Trim <> Nothing And VenueAddressBox.Text.Trim <> Nothing Then
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Parameters.AddWithValue("name", VenueNameBox.Text)
            Sqlcmd.Parameters.AddWithValue("add", VenueAddressBox.Text)
            Sqlcmd.CommandText = "insert into venues (name,address) values (@name,@add)"
            Sqlcmd.ExecuteNonQuery()
            Sqlcmd.Parameters.Clear()
            LoadVenues()
            MessageBox.Show("Venue has been entered into the database", "Venue Entered", MessageBoxButtons.OK, MessageBoxIcon.Information)
            VenueNameBox.Text = ""
            VenueAddressBox.Text = ""
        Else
            MessageBox.Show("Enter the name and address of the venue", "Enter all details", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub RemoveVenueButton_Click(sender As Object, e As EventArgs) Handles RemoveVenueButton.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this venue?" & System.Environment.NewLine & "all associated events will also be deleted!", "Delete this venue?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If result = DialogResult.OK Then
            Dim eidlist As New List(Of Integer)
            For Each item As ListViewItem In VenueListBox.CheckedItems

                Dim Sqldr As SqlDataReader
                Sqlcmd.Parameters.AddWithValue("id", Val(item.Text))
                Sqlcmd.CommandText = "select eventid from [venue-events] where [venue-events].venueid = @id"
                Sqldr = Sqlcmd.ExecuteReader
                While Sqldr.Read
                    eidlist.Add(Sqldr.Item(0))
                End While
                Sqldr.Close()

                For Each listitem In eidlist
                    Sqlcmd.Parameters.Clear()
                    Sqlcmd.Parameters.AddWithValue("eid", listitem)
                    Sqlcmd.CommandText = "delete from events where eventid=@eid"
                    Sqlcmd.ExecuteNonQuery()
                    Sqlcmd.Parameters.Clear()
                Next

                Sqlcmd.Parameters.Clear()
                Sqlcmd.Parameters.AddWithValue("id", Val(item.Text))
                Sqlcmd.CommandText = "delete from venues where venueid = @id"
                Sqlcmd.ExecuteNonQuery()
                Sqlcmd.Parameters.Clear()
            Next
            LoadVenues()
        End If

    End Sub
End Class