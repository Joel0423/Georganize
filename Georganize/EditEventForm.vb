Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class EditEventForm
    Dim Sqlcmd As New SqlCommand
    Dim selvid As Integer
    Dim IsVenueEvent As Boolean
    Private Sub EditEventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EventDateBox.MinDate = DateTime.Today.Date
        Sqlcmd.Connection = Sqlcon
        IsVenueEvent = False
        VenueNameLabel.Visible = False
        VenueNameBox.Visible = False
        LoadData()


    End Sub

    Private Sub EventEndTimePicker_Validation(sender As Object, e As EventArgs) Handles EventEndTimeBox.ValueChanged, EventStartTimeBox.ValueChanged
        If EventEndTimeBox.Value <= EventStartTimeBox.Value Then
            ErrorProvider1.SetError(EventEndTimeBox, "Event cannot end before it starts")
        Else
            ErrorProvider1.SetError(EventEndTimeBox, "")
        End If
    End Sub

    Private Sub LoadData()
        Dim Sqldr As SqlDataReader
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Parameters.AddWithValue("sele", Val(SelectedPublicEventID))
        Sqlcmd.CommandText = "select * from events where eventid=@sele"
        Sqldr = Sqlcmd.ExecuteReader
        While Sqldr.Read
            EventNameLabel.Text = Sqldr(2)
            EventDescriptionBox.Text = Sqldr(3)
            EventDateBox.Value = Sqldr(4)
            Dim tempdate As DateTime = DateTime.Today.Add(Sqldr(5))
            EventStartTimeBox.Value = tempdate
            tempdate = DateTime.Today.Add(Sqldr(6))
            EventEndTimeBox.Text = tempdate

            If VisCombo.GetItemText(VisCombo.Items.Item(0)) = Sqldr(7).ToString.TrimEnd Then
                VisCombo.SelectedIndex = 0
            Else
                VisCombo.SelectedIndex = 1
            End If

            AgeResLabel.Text = Sqldr(8).ToString
        End While
        Sqldr.Close()
        Sqlcmd.CommandText = "select address,eventid from [user-location] where eventid=@sele"
        If Sqlcmd.ExecuteScalar <> Nothing Then
            EventAddressBox.Text = Sqlcmd.ExecuteScalar
            MessageBox.Show("fine")
        Else
            IsVenueEvent = True
            EventAddressBox.ReadOnly = True

            VenueNameLabel.Visible = True
            VenueNameBox.Visible = True
            Sqlcmd.CommandText = "select venueid,eventid from [venue-events] where eventid=@sele"
            Sqlcmd.Parameters.AddWithValue("vid", Sqlcmd.ExecuteScalar)
            selvid = Sqlcmd.ExecuteScalar

            Sqlcmd.CommandText = "select * from venues where venueid=@vid"
            Sqldr = Sqlcmd.ExecuteReader
            While Sqldr.Read
                EventAddressBox.Text = Sqldr(2)
                VenueNameBox.Text = Sqldr(1)
            End While
            Sqldr.Close()
        End If
        Sqldr.Close()
        Sqlcmd.Parameters.Clear()
    End Sub

    Private Sub TimeFormatCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TimeFormatCheckBox.CheckedChanged
        ' Add or remove AM/PM
        If TimeFormatCheckBox.Checked Then
            EventStartTimeBox.CustomFormat = "  hh      '|'   mm         '|'   ss  tt"
            EventEndTimeBox.CustomFormat = "  hh      '|'   mm         '|'   ss  tt"
        Else
            EventStartTimeBox.CustomFormat = "  HH      '|'   mm         '|'   ss"
            EventEndTimeBox.CustomFormat = "  HH      '|'   mm         '|'   ss"
        End If
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If ErrorProvider1.GetError(EventEndTimeBox) = "" Then
            If IsVenueEvent Then
                VenueTimeClash()
            Else
                SubmitDetails()
            End If
        Else
            MessageBox.Show("Enter the correct timings", "invalid timings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub VenueTimeClash()

        Sqlcmd.Parameters.Clear()
        ' You have to specify the 'date' part of the 'Value' or the query will not work
        Sqlcmd.Parameters.AddWithValue("SelectedDate", EventDateBox.Value.Date)

        ' add 30 minutes to end time
        Dim EventEnd As Date = DateAdd(DateInterval.Minute, 30, EventEndTimeBox.Value)

        Sqlcmd.Parameters.AddWithValue("SelEnd", EventEnd.TimeOfDay)
        ' subtract 30 mins to start time
        Dim EventStart As Date = DateAdd(DateInterval.Minute, -30, EventStartTimeBox.Value)

        Sqlcmd.Parameters.AddWithValue("SelStart", EventStart.TimeOfDay)


        Sqlcmd.Parameters.AddWithValue("selvid", selvid)

        ' columns start-time and end-time have a '-'
        ' so they must be enclosed in []
        Sqlcmd.CommandText = "select events.eventid from events,[venue-events] where events.eventid=[venue-events].eventid and [venue-events].venueid = @selvid and date = @SelectedDate and [start-time] < @SelEnd and @SelStart < [end-time]"

        If Sqlcmd.ExecuteScalar = Nothing Then
            Dim timediff As TimeSpan = EventEndTimeBox.Value.TimeOfDay - EventStartTimeBox.Value.TimeOfDay
            Dim tempc As Integer = Val(timediff.Hours) * 800

            Dim costtext As String = "Total cost = hours booked x cost per hour:" & System.Environment.NewLine & System.Environment.NewLine & timediff.ToString & " x " & "Rs. 800 " & System.Environment.NewLine & "      = Rs. " & tempc.ToString
            Dim PayDialog As New Dialog1
            PayDialog.RichTextBox1.Text = costtext
            PayDialog.ShowDialog()

            If PayDialog.DialogResult = DialogResult.OK Then
                MessageBox.Show("Payment completed", "Payment Completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SubmitDetails()
            Else
                MessageBox.Show("Payment not sent, event has not been created", "Payment pending", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("There is a clash in the timings of your event and an already occuring event in venue: " & VenueNameBox.Text & "" & Environment.NewLine & "Change the date or the event timing", "Timing Clash", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Sqlcmd.Parameters.Clear()
    End Sub

    Private Sub SubmitDetails()

        Sqlcmd.Parameters.Clear()
        Sqlcmd.Parameters.AddWithValue("sele", SelectedPublicEventID)
        Sqlcmd.Parameters.AddWithValue("desc", EventDescriptionBox.Text)
        Sqlcmd.Parameters.AddWithValue("date", EventDateBox.Value)
        Sqlcmd.Parameters.AddWithValue("start", EventStartTimeBox.Value.TimeOfDay)
        Sqlcmd.Parameters.AddWithValue("end", EventEndTimeBox.Value.TimeOfDay)
        Sqlcmd.Parameters.AddWithValue("age", Val(AgeResLabel.Text))
        Sqlcmd.Parameters.AddWithValue("vis", VisCombo.SelectedItem)
        Sqlcmd.CommandText = "update events set description=@desc,date=@date,[start-time]=@start,[end-time]=@end,visibility=@vis,age=@age where eventid=@sele"
        Sqlcmd.ExecuteNonQuery()

        If Not IsVenueEvent Then
            Sqlcmd.Parameters.AddWithValue("adrr", EventAddressBox.Text)
            Sqlcmd.CommandText = "update [user-location] set address =@adrr where eventid=@sele"
            Sqlcmd.ExecuteNonQuery()
        End If
        Sqlcmd.Parameters.Clear()
        Me.Close()
    End Sub
End Class