Imports System.Data.SqlClient
Public Class AdminHome
    Dim Sqlcmd As New SqlCommand
    Private Sub AdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Sqldr As SqlDataReader
        Sqlcmd.Connection = Sqlcon
        Sqlcmd.CommandText = "select username from users;"
        Sqldr = Sqlcmd.ExecuteReader()
        While Sqldr.Read()
            UserList.Items.Add(Sqldr(0).ToString())
        End While
        Sqldr.Close()

        Sqlcmd.CommandText = "select name from events;"
        Sqldr = Sqlcmd.ExecuteReader()
        While Sqldr.Read()
            EventList.Items.Add(Sqldr(0).ToString())
        End While
        Sqldr.Close()

        Sqlcmd.CommandText = "select logtext from logs;"
        Sqldr = Sqlcmd.ExecuteReader()
        While Sqldr.Read()
            SystemLogs.Items.Add(Sqldr(0).ToString())
        End While
        Sqldr.Close()
    End Sub

    Private Sub FetchUserEvents_Click(sender As Object, e As EventArgs) Handles FetchUserEvents.Click
        EventList.Items.Clear()
        Sqlcmd.Parameters.AddWithValue("selecteduser", UserList.SelectedItem.ToString())
        Sqlcmd.CommandText = "select name from events, users where username = @selecteduser and organizerid = userid;"
        Dim Sqldr As SqlDataReader
        Sqldr = Sqlcmd.ExecuteReader()

        While Sqldr.Read()
            EventList.Items.Add(Sqldr(0).ToString())
        End While
        Sqldr.Close()
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Dispose()
    End Sub

    Private Sub UserDelete_Click(sender As Object, e As EventArgs) Handles UserDelete.Click
        For Each user In UserList.SelectedItems
            Sqlcmd.Parameters.AddWithValue("usern", user)
            Sqlcmd.CommandText = "delete from users where username = @usern;"
            Sqlcmd.ExecuteNonQuery()
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Dispose()
            MessageBox.Show("User account deleted.")
        Next
    End Sub

    Private Sub EventDelete_Click(sender As Object, e As EventArgs) Handles EventDelete.Click
        For Each eventn In EventList.SelectedItems
            Sqlcmd.Parameters.AddWithValue("eventn", eventn)
            Sqlcmd.CommandText = "delete from events where name = @eventn;"
            Sqlcmd.ExecuteNonQuery()
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Dispose()
            MessageBox.Show("Event deleted.")
        Next

    End Sub
End Class