Imports System.Data.SqlClient

Public Class EnrolledEventsForm
    Dim Sqlcmd As New SqlCommand


    Private Sub EnrolledEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sqlcmd.Connection = Sqlcon
        Dim evelist As New List(Of String)

        Dim Sqldr As SqlDataReader
        Sqlcmd.Parameters.AddWithValue("user", LoggedInUser)
        Sqlcmd.CommandText = "select enrollments.eventid, name from enrollments,events where enrollments.userid = @user and enrollments.eventid = events.eventid;"
        Sqldr = Sqlcmd.ExecuteReader()

        While Sqldr.Read()

            Dim evename As String
            evename = Sqldr(1)
            EnrolledEventsList.Items.Add(evename)

        End While

        Sqldr.Close()
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Dispose()
    End Sub

    Private Sub EnrolledEventsForm_Close()
        HomeForm.Show()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim cmd2 As New SqlCommand
        cmd2.Connection = Sqlcon

        If EnrolledEventsList.SelectedItem = Nothing Then
            MessageBox.Show("No events selected for deletion")
        Else
            Sqlcmd.Connection = Sqlcon
            Sqlcmd.Parameters.AddWithValue("user", LoggedInUser)

            cmd2.Parameters.AddWithValue("ename", EnrolledEventsList.SelectedItem)
            cmd2.CommandText = "select [eventid] from [events] where name = @ename;"

            Sqlcmd.Parameters.AddWithValue("event", Convert.ToInt16(cmd2.ExecuteScalar))
            Sqlcmd.CommandText = "delete from [enrollments] where userid = @user and eventid = @event;"
            Sqlcmd.ExecuteNonQuery()
        End If
        cmd2.Parameters.Clear()
        cmd2.Dispose()
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Dispose()
        EnrolledEvents_Reload()

        Sqlcmd.Connection = Sqlcon
        Dim log As String
        log = LoggedInUser.ToString & " deenrolled from an event."
        Sqlcmd.Parameters.AddWithValue("log", log)
        Sqlcmd.CommandText = "insert into logs (@logtext) values (@log);"
        Sqlcmd.ExecuteNonQuery()
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Dispose()
    End Sub

    Private Sub EnrolledEvents_Reload()
        EnrolledEventsList.Items.Clear()
        Sqlcmd.Connection = Sqlcon
        Dim evelist As New List(Of String)

        Dim Sqldr As SqlDataReader
        Sqlcmd.Parameters.AddWithValue("userb", LoggedInUser)
        Sqlcmd.CommandText = "select enrollments.eventid, name from enrollments,events where enrollments.userid = @userb and enrollments.eventid = events.eventid;"
        Sqldr = Sqlcmd.ExecuteReader()

        While Sqldr.Read()

            Dim evename As String
            evename = Sqldr(1)
            EnrolledEventsList.Items.Add(evename)

        End While

        Sqldr.Close()
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EnrolledEventsList.SelectedItem = Nothing Then
            MessageBox.Show("No event selected")
        Else
            Sqlcmd.Connection = Sqlcon
            Sqlcmd.Parameters.AddWithValue("evname", EnrolledEventsList.SelectedItem.ToString)
            Sqlcmd.CommandText = "select eventid from [events] where name = @evname;"

            SelectedPublicEventID = Convert.ToInt16(Sqlcmd.ExecuteScalar())
            EventTemplateForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form_Close() Handles MyBase.Closing
        SelectedPublicEventID = ""
    End Sub
End Class