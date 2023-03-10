Imports System.Data.SqlClient

Public Class EventTemplateForm
    Dim Sqlcmd As New SqlCommand

    Private Sub EventTemplateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrivateCodeLabel.Visible = False
        VenueNameLabel.Visible = False
        VenueNameBox.Visible = False
        AgeResLabel.Visible = False
        Label5.Text = "" 'to add some padding

        Sqlcmd.Connection = Sqlcon
        Me.DoubleBuffered = True
        Dim Sqldr As SqlDataReader

        Sqlcmd.Parameters.AddWithValue("eventidP", SelectedPublicEventID)
        ' do not modify this query
        Sqlcmd.CommandText = "select events.*, venues.name as Vname,ISNULL(venues.address, [user-location].address) as address,[private-events].code,users.username from events left join [venue-events] on @eventidP = [venue-events].eventid left join venues on venues.venueid = [venue-events].venueid left join [user-location] on @eventidP = [user-location].eventid left join [private-events] on @eventidP = [private-events].event_id left join users on events.organizerid = users.userid where events.eventid = @eventidP"

        'I think it is a good idea to show event visibility and age restriction in this form
        ' and the private code only if the organizer is logged in
        Sqldr = Sqlcmd.ExecuteReader
        Sqlcmd.Parameters.Clear()

        If Sqldr.Read() Then
            OrganizerNameLabel.Text = Sqldr.Item(12).ToString
            ' if you're organizer you can see the private code
            If LoggedInUser = Sqldr.Item(1).ToString And Not IsDBNull(Sqldr.Item(11)) Then
                PrivateCodeLabel.Visible = True
                PrivateCodeLabel.Text = "Code : " & Sqldr.Item(11).ToString
            End If
            VisibilityLabel.Text = Sqldr.Item(7).ToString.Trim & " event"
            EventDescriptionBox.Text = Sqldr.Item(3).ToString
            EventAddressBox.Text = Sqldr.Item(10).ToString
            EventDateBox.Text = Sqldr.GetDateTime(4).ToLongDateString
            'convert TimeSpan to DateTime to format easier
            Dim tempdt As DateTime = DateTime.Today.Add(Sqldr.GetTimeSpan(5))
            EventStartTimeBox.Text = tempdt.ToString("hh : mm tt")
            tempdt = DateTime.Today.Add(Sqldr.GetTimeSpan(6))
            EventEndTimeBox.Text = tempdt.ToString("hh : mm tt")
            EventNameLabel.Text = Sqldr.Item(2).ToString.TrimEnd

            ' if it is a venue event it'll show name of venue
            If Not IsDBNull(Sqldr.Item(9)) Then
                VenueNameLabel.Visible = True
                VenueNameBox.Visible = True
                VenueNameBox.Text = Sqldr.Item(9).ToString
            End If
            ' if there is age restriction it will show
            If Val(Sqldr(8)) > 0 Then
                AgeResLabel.Visible = True
                AgeResLabel.Text = AgeResLabel.Text & " " & Sqldr(8).ToString & " +"
            End If
        Else
            MessageBox.Show("no event data returned by query in EventTemplateForm")
        End If

        Sqldr.Close()
        Sqlcmd.Parameters.Clear()
        CheckEnrollments()
    End Sub

    Private Sub EventTemplateForm_Close() Handles MyBase.Closing
        HomeForm.Show()
    End Sub

    Private Sub CheckEnrollments()
        Sqlcmd.Parameters.AddWithValue("LoggedInUser", LoggedInUser)
        Sqlcmd.Parameters.AddWithValue("EventIDP", SelectedPublicEventID)
        Sqlcmd.CommandText = "select userid from enrollments where userid = @LoggedInUser and eventid = @EventIDP"
        If Sqlcmd.ExecuteScalar <> Nothing Then
            EventJoinButton.Visible = False
        Else
            EventJoinButton.Visible = True
        End If
        Sqlcmd.Parameters.Clear()
    End Sub

    Private Sub EventJoinButton_Click(sender As Object, e As EventArgs) Handles EventJoinButton.Click
        Sqlcmd.Parameters.AddWithValue("SelectedPEventID", SelectedPublicEventID)
        Sqlcmd.Parameters.AddWithValue("LoggedInUser", LoggedInUser)
        Sqlcmd.CommandText = "insert into enrollments (eventid,userid) values (@SelectedPEventID, @LoggedInUser)"
        Sqlcmd.Connection = Sqlcon
        Sqlcmd.ExecuteNonQuery()
        Sqlcmd.Parameters.Clear()
        CheckEnrollments()
        MessageBox.Show("You have been enrolled for the event : " & EventNameLabel.Text, "Enrolled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub EventTemplateFormClosed()
        SelectedPublicEventID = ""
    End Sub

End Class