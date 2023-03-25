Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class DiscussionForm
    Dim Sqlcmd As New SqlCommand
    Dim temp As DateTime
    Private Sub DiscussionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Sqlcmd.Connection = Sqlcon
        LoadMessages()
        TextBox1.Select(TextBox1.Text.Length, 0)
    End Sub

    Private Sub ScrollContents()
        TextBox1.Select(TextBox1.Text.Length, 0)
        TextBox1.ScrollToCaret()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox2.Text.Trim <> Nothing Then
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Parameters.AddWithValue("event", SelectedPublicEventID)
            Sqlcmd.Parameters.AddWithValue("user", LoggedInUser)
            Sqlcmd.Parameters.AddWithValue("msg", TextBox2.Text)
            Sqlcmd.Parameters.AddWithValue("time", DateTime.Now)

            Sqlcmd.CommandText = "insert into discussion values (@user, @event, @time, @msg);"
            Sqlcmd.ExecuteNonQuery()
            Sqlcmd.Parameters.Clear()

            If TextBox1.Text = Nothing Then
                LoadMessages()
            Else
                LoadNewMessages()
            End If


            TextBox2.Clear()
            ScrollContents()
        Else

        End If

    End Sub
    Private Sub LoadMessages()

        Dim Sqldr As SqlDataReader
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Parameters.AddWithValue("event", SelectedPublicEventID)
        Sqlcmd.CommandText = "select username,message,discussion.datetime from discussion,users where eventid=@event and discussion.userid = users.userid order by datetime asc"
        Sqldr = Sqlcmd.ExecuteReader
        While Sqldr.Read

            temp = Sqldr(2)


            TextBox1.AppendText(System.Environment.NewLine & System.Environment.NewLine & Sqldr(0).ToString & ":" & "    " & Sqldr(1) & "    " & "at " & temp.ToString("hh:mm tt"))
        End While

        Sqlcmd.Parameters.Clear()
        Sqldr.Close()
    End Sub

    Private Sub LoadNewMessages()
        '
        Dim temp2 As DateTime
        Dim Sqldr As SqlDataReader
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Parameters.AddWithValue("event", SelectedPublicEventID)
        Sqlcmd.Parameters.AddWithValue("now", temp)
        Sqlcmd.CommandText = "select username,message,discussion.datetime from discussion,users where eventid=@event and discussion.userid = users.userid and datetime>@now order by datetime asc"
        Sqldr = Sqlcmd.ExecuteReader
        While Sqldr.Read

            temp2 = Sqldr(2)

            TextBox1.AppendText(System.Environment.NewLine & System.Environment.NewLine & Sqldr(0).ToString & ":" & "    " & Sqldr(1) & "    " & "at " & temp2.ToString("hh:mm tt"))
            temp = temp2
        End While
        Sqlcmd.Parameters.Clear()
        Sqldr.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ScrollContents()
    End Sub
End Class