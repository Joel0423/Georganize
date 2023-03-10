Public Class Help
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HelpBox.Text = "Hello! Georganize is an event organizing system
that allows you to create and manage events such as parties, meetings,
gatherings, etc., You can also enroll into events created by others.

On your home page, you will see a list of public events that you can join
right away, and invitations that others have sent to you. There are also private
events, which you can join only if you have a secret code or if you were
invited to that event.

After enrolling into an event, you can talk to others who are enrolled into
the same event using the discussion board.

Hope you like it!"
    End Sub

    Private Sub HelpForm_Close() Handles Me.Closed
        HomeForm.Show()
    End Sub
End Class