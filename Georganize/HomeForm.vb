Imports System.ComponentModel.DataAnnotations
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class HomeForm
    Public dt As New DataTable
    Dim Sqlcmd As New SqlCommand
    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DoubleBuffered = True
        ' Query to get event name, address , date , start time from user-location and venue-events/venues table combined
        ' select events.name as EName,venues.address as EAdd,date as EDate,[start-time] as ETime from events,[venue-events],venues where events.eventid=[venue-events].eventid and [venue-events].venueid = venues.venueid and visibility = 'public' union select events.name as EName,address as EAdd,date as EDate,[start-time] as ETime from events,[user-location] where events.eventid = [user-location].eventid and visibility = 'public'
        Sqlcmd.Connection = Sqlcon

    End Sub

    Private Sub RefreshForm() Handles MyBase.VisibleChanged
        InvitationsBox.Items.Clear()

        If Me.Visible = True Then
            PublicEventsList.Items.Clear()
            Dim Sqldr As SqlDataReader
            Sqlcmd.Parameters.AddWithValue("Uage", Val(LoggedInUserAge.ToString))
            Sqlcmd.CommandText = "select eventid,name,date from events where visibility = 'Public' and age <= @Uage order by events.date asc"

            Sqldr = Sqlcmd.ExecuteReader
            Do While Sqldr.Read
                Dim item As New ListViewItem
                item.Text = Sqldr.Item(1).ToString
                item.Tag = Sqldr.Item(0).ToString ' event id
                Dim temp As New DateTime
                temp = Sqldr(2)
                item.SubItems.Add(temp.ToString("d"))
                PublicEventsList.Items.Add(item)

            Loop
            Sqldr.Close()

            Sqlcmd.Parameters.AddWithValue("usid", LoggedInUser)
            Sqlcmd.CommandText = "select name from events, users, invitations where users.userid = @usid and users.userid = invitations.recieverid and invitations.eventid = events.eventid;"
            Sqldr = Sqlcmd.ExecuteReader()
            Do While Sqldr.Read()
                InvitationsBox.Items.Add(Sqldr(0))
            Loop
            Sqldr.Close()
            Sqlcmd.Parameters.Clear()
        End If
    End Sub

    Private Sub ExitApplication(sender As Object, e As EventArgs) Handles MyBase.Closed
        LoginForm.Show()
        LoggedInUser = ""
        LoggedInUserAge = 0
    End Sub

    Private Sub CreateEventButton_Click(sender As Object, e As EventArgs) Handles CreateEventButton.Click
        EventCreationForm.Show()
        Me.Hide()
    End Sub

    Private Sub ProfileButton_Click(sender As Object, e As EventArgs) Handles ProfileButton.Click
        Profile.Show()
        Me.Hide()
    End Sub

    Private Sub ManageEventsButton_Click(sender As Object, e As EventArgs) Handles ManageEventsButton.Click
        ManageEvents.Show()
        Me.Hide()
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.Show()
        Me.Hide()
    End Sub

    Private Sub EnrolledEventsButton_Click(sender As Object, e As EventArgs) Handles EnrolledEventsButton.Click
        EnrolledEventsForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Sqlcmd.Connection = Sqlcon
        Sqlcmd.Parameters.AddWithValue("secretcode", Convert.ToInt32(CodeBox.Text))
        If CodeBox.Text = Nothing Or Len(CodeBox.Text) <> 4 Then
            MessageBox.Show("Invalid Private Event Code")
            CodeBox.Text = Nothing
        Else
            Sqlcmd.CommandText = "select [event_id] from [private-events] where code = @secretcode;"
            Dim eventid As Integer
            eventid = Sqlcmd.ExecuteScalar()
            If eventid = Nothing Then
                MessageBox.Show("No event exists with that code")
                Sqlcmd.Parameters.Clear()
            Else
                Sqlcmd.Parameters.Clear()
                Sqlcmd.Parameters.AddWithValue("evnid", eventid)
                Sqlcmd.CommandText = "select age from events where eventid=@evnid"
                If LoggedInUserAge < Sqlcmd.ExecuteScalar Then
                    MessageBox.Show("You cannot join this event as you're under the age limit", "Too young", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Sqlcmd.Parameters.Clear()
                    Sqlcmd.Parameters.AddWithValue("event", eventid)
                    Sqlcmd.Parameters.AddWithValue("user", LoggedInUser)
                    Sqlcmd.CommandText = "select eventid from enrollments where eventid=@event and userid=@user"
                    If Sqlcmd.ExecuteScalar <> Nothing Then
                        MessageBox.Show("You are already enrolled for this event", "Already Enrolled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Sqlcmd.CommandText = "insert into enrollments (eventid, userid) values (@event, @user);"
                        Sqlcmd.ExecuteNonQuery()
                        MessageBox.Show("Successfully enrolled into event", "Enrollment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CodeBox.Text = ""
                        Sqlcmd.Parameters.Clear()
                    End If

                End If
            End If
        End If
    End Sub

    ' Open event template form 
    Private Sub PublicEventsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PublicEventsList.DoubleClick
        If PublicEventsList.SelectedItems.Count > 0 Then
            SelectedPublicEventID = PublicEventsList.SelectedItems.Item(0).Tag
            EventTemplateForm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub InviteButton_Click(sender As Object, e As EventArgs) Handles InviteButton.Click
        Invitations.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Sqlcmd.Connection = Sqlcon
        Dim Sqldr As SqlDataReader
        For Each evname In InvitationsBox.CheckedItems
            Dim evid As Integer
            Sqlcmd.Parameters.AddWithValue("evname", evname.ToString())
            Sqlcmd.CommandText = "select eventid from events where name = @evname;"
            evid = Convert.ToInt16(Sqlcmd.ExecuteScalar())
            Sqlcmd.Parameters.Clear()

            Sqlcmd.Parameters.AddWithValue("userid", LoggedInUser)
            Sqlcmd.Parameters.AddWithValue("eventid", evid)
            Sqlcmd.CommandText = "delete from invitations where eventid = @eventid and recieverid = @userid;"
            Sqlcmd.ExecuteNonQuery()
            Sqlcmd.Parameters.Clear()
        Next

        InvitationsBox.Items.Clear()

        Sqlcmd.Parameters.AddWithValue("usid", LoggedInUser)
        Sqlcmd.CommandText = "select name from events, users, invitations where users.userid = @usid and users.userid = invitations.recieverid and invitations.eventid = events.eventid;"
        Sqldr = Sqlcmd.ExecuteReader()
        Do While Sqldr.Read()
            InvitationsBox.Items.Add(Sqldr(0))
        Loop
        Sqldr.Close()
        Sqlcmd.Parameters.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Sqlcmd.Connection = Sqlcon
        Dim Sqldr As SqlDataReader
        For Each evname In InvitationsBox.CheckedItems
            Dim evid As Integer
            Sqlcmd.Parameters.AddWithValue("evname", evname.ToString())
            Sqlcmd.CommandText = "select eventid from events where name = @evname;"
            evid = Convert.ToInt16(Sqlcmd.ExecuteScalar())
            Sqlcmd.Parameters.Clear()

            Sqlcmd.Parameters.AddWithValue("eid", evid)
            Sqlcmd.CommandText = "select age from events where eventid=@eid"

            If LoggedInUserAge < Sqlcmd.ExecuteScalar Then
                MessageBox.Show("You cannot join the event: " & evname.ToString & " as you're under the age limit", "Too young", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Sqlcmd.Parameters.Clear()
                Sqlcmd.Parameters.AddWithValue("userid", LoggedInUser)
                Sqlcmd.Parameters.AddWithValue("eventid", evid)
                Sqlcmd.CommandText = "delete from invitations where eventid = @eventid and recieverid = @userid;"
                Sqlcmd.ExecuteNonQuery()
                Sqlcmd.Parameters.Clear()
            Else
                Sqlcmd.Parameters.AddWithValue("userid", LoggedInUser)
                Sqlcmd.Parameters.AddWithValue("eventid", evid)
                Sqlcmd.CommandText = "select eventid from enrollments where eventid=@eventid and userid=@userid"
                If Sqlcmd.ExecuteScalar <> Nothing Then
                    MessageBox.Show("You are already enrolled for this event", "Already Enrolled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Sqlcmd.Parameters.AddWithValue("userid", LoggedInUser)
                    Sqlcmd.Parameters.AddWithValue("eventid", evid)
                    Sqlcmd.CommandText = "delete from invitations where eventid = @eventid and recieverid = @userid;"
                    Sqlcmd.ExecuteNonQuery()
                    Sqlcmd.Parameters.Clear()
                Else
                    Sqlcmd.CommandText = "insert into enrollments (eventid, userid) values (@eventid, @userid);"

                    Sqlcmd.ExecuteNonQuery()
                    Sqlcmd.Parameters.Clear()

                    Sqlcmd.Parameters.AddWithValue("userid", LoggedInUser)
                    Sqlcmd.Parameters.AddWithValue("eventid", evid)
                    Sqlcmd.CommandText = "delete from invitations where eventid = @eventid and recieverid = @userid;"
                    Sqlcmd.ExecuteNonQuery()
                    Sqlcmd.Parameters.Clear()

                    MessageBox.Show("You have enrolled into the event: " & evname.ToString & " successfully", "Enrollment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Next

        InvitationsBox.Items.Clear()

        Sqlcmd.Parameters.AddWithValue("usid", LoggedInUser)
        Sqlcmd.CommandText = "select name from events, users, invitations where users.userid = @usid and users.userid = invitations.recieverid and invitations.eventid = events.eventid;"
        Sqldr = Sqlcmd.ExecuteReader()
        Do While Sqldr.Read()
            InvitationsBox.Items.Add(Sqldr(0))
        Loop
        Sqldr.Close()
        Sqlcmd.Parameters.Clear()
    End Sub
End Class