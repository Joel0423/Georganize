Imports System.Data.SqlClient

Public Class EnrolledEventsForm
    Dim Sqlcmd As New SqlCommand


    Private Sub EnrolledEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sqlcmd.Connection = Sqlcon
        Dim evelist As New List(Of String)

        Dim Sqldr As SqlDataReader
        Sqlcmd.Parameters.AddWithValue("user", LoggedInUser)
        Sqlcmd.CommandText = "select enrollments.eventid, name,events.date,[start-time],[end-time] from enrollments,events where enrollments.userid = @user and enrollments.eventid = events.eventid order by events.date asc;"
        Sqldr = Sqlcmd.ExecuteReader()

        While Sqldr.Read()

            Dim evename As String
            evename = Sqldr(1)
            EnrolledEventsList.Items.Add(evename).SubItems.AddRange({Sqldr(2).ToString.Substring(0, 10), Sqldr(3).ToString, Sqldr(4).ToString})

        End While

        Sqldr.Close()
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Dispose()
    End Sub

    Private Sub EnrolledEventsForm_Close() Handles MyBase.Closed
        HomeForm.Show()
        SelectedPublicEventID = ""
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim cmd2 As New SqlCommand
        cmd2.Connection = Sqlcon

        If EnrolledEventsList.SelectedItems.Count = 0 Then
            MessageBox.Show("No events selected for deletion")
        Else
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Connection = Sqlcon
            Sqlcmd.Parameters.AddWithValue("user", LoggedInUser)

            cmd2.Parameters.AddWithValue("ename", EnrolledEventsList.SelectedItems.Item(0).Text)
            cmd2.CommandText = "select [eventid] from [events] where name = @ename;"
            Dim tempid As Integer = cmd2.ExecuteScalar

            Sqlcmd.Parameters.AddWithValue("event", Convert.ToInt16(cmd2.ExecuteScalar))

            're-using cmd2
            ' cannot un-enroll from your own event
            cmd2.Parameters.Clear()

            cmd2.Parameters.AddWithValue("tid", tempid)
            cmd2.CommandText = "select organizerid from events where eventid=@tid"
            If cmd2.ExecuteScalar = LoggedInUser Then
                MessageBox.Show("You cannot un-enroll from your own event!", "Cannot Un-enroll", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Sqlcmd.CommandText = "delete from [enrollments] where userid = @user and eventid = @event;"
                Sqlcmd.ExecuteNonQuery()
            End If
        End If
        cmd2.Parameters.Clear()
        cmd2.Dispose()
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Dispose()
        EnrolledEvents_Reload()
    End Sub

    Private Sub EnrolledEvents_Reload()
        EnrolledEventsList.Items.Clear()
        Sqlcmd.Connection = Sqlcon
        Dim evelist As New List(Of String)

        Dim Sqldr As SqlDataReader
        Sqlcmd.Parameters.AddWithValue("userb", LoggedInUser)
        Sqlcmd.CommandText = "select enrollments.eventid, name,events.date,[start-time],[end-time] from enrollments,events where enrollments.userid = @userb and enrollments.eventid = events.eventid order by events.date asc;"
        Sqldr = Sqlcmd.ExecuteReader()

        While Sqldr.Read()

            Dim evename As String
            evename = Sqldr(1)
            EnrolledEventsList.Items.Add(evename).SubItems.AddRange({Sqldr(2).ToString.Substring(0, 10), Sqldr(3).ToString, Sqldr(4).ToString})
        End While

        Sqldr.Close()
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EnrolledEventsList.SelectedItems.Count = 0 Then
            MessageBox.Show("No event selected")
        Else
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Connection = Sqlcon
            Sqlcmd.Parameters.AddWithValue("evname", EnrolledEventsList.SelectedItems.Item(0).Text)

            Sqlcmd.CommandText = "select eventid from [events] where name = @evname;"

            SelectedPublicEventID = Convert.ToInt16(Sqlcmd.ExecuteScalar())
            Sqlcmd.Parameters.Clear()
            EventTemplateForm.Show()
            Me.Hide()
        End If
    End Sub

End Class