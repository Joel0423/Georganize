Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ManageEvents
    Dim Sqlcmd As New SqlCommand
    Private Sub ManageEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this event?" & System.Environment.NewLine & "all attendees will be un-enrolled", "Delete this event?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If result = DialogResult.OK Then
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Parameters.AddWithValue("sname", CreatedEventsList.SelectedItem)
            Sqlcmd.CommandText = "delete from events where name = @sname"
            Sqlcmd.ExecuteNonQuery()
            Sqlcmd.Parameters.Clear()
            LoadEvents()
        End If

    End Sub
End Class