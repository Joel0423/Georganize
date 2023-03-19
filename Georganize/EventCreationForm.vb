Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.Design

Public Class EventCreationForm
    Private Sqlcmd As New SqlCommand
    Dim random As New Random()

    Private Sub EventCreationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label12.Visible = False
        Sqlcmd.Connection = Sqlcon
        Populate()
        ' Events can only be created from today to 5 years from now
        EventDatePicker.MinDate = DateTime.Today
        ' max date is 5 years from now
        EventDatePicker.MaxDate = DateAdd(DateInterval.Year, 5, DateTime.Today)
        ErrorProvider1.SetIconAlignment(EventEndTimePicker, ErrorIconAlignment.BottomLeft)
        ErrorProvider1.SetIconPadding(EventEndTimePicker, 15)
        EventVisibilityComboBox.SelectedIndex = 0
    End Sub

    Private Sub EventCreationForm_CLose() Handles MyBase.Closed
        HomeForm.Show()
    End Sub

    Private Sub Populate()
        Dim Sqldr As SqlDataReader
        Sqlcmd.Connection = Sqlcon
        Sqlcmd.CommandText = "select name,address from venues"
        Sqldr = Sqlcmd.ExecuteReader

        While Sqldr.Read

            VenueComboBox.Items.Add(Sqldr.GetValue(0))

            VenueAddressList.Add(Sqldr.GetValue(1))
        End While
        ' Close DataReader asap
        ' ExecuteScalar() and possibly ExecuteNonQuery() can't be used with another datareader open
        Sqldr.Close()
    End Sub

    Private Sub BookVenueCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BookVenueCheckBox.CheckedChanged
        If BookVenueCheckBox.Checked Then
            ListView1.Visible = True
            Label12.Visible = True
            EventModeBox.SelectedIndex = 0
            EventModeBox.Enabled = False
            VenueComboBox.Visible = True
            'EventAddressBox.Text = " "
            EventAddressBox.Text = ""
            EventAddressBox.Enabled = False
        Else
            ListView1.Visible = False
            Label12.Visible = False
            ListView1.Items.Clear()
            VenueComboBox.SelectedIndex = -1
            EventModeBox.Enabled = True
            VenueComboBox.Visible = False
            EventAddressBox.Enabled = True
            EventAddressBox.Text = ""
        End If
    End Sub

    Private Sub VenueComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VenueComboBox.SelectedIndexChanged
        If VenueComboBox.SelectedIndex > -1 Then
            EventAddressBox.Text = VenueAddressList(VenueComboBox.SelectedIndex).ToString
        Else
            EventAddressBox.Text = ""
        End If
    End Sub


    Private Sub EventModeBox_Validation(sender As Object, e As EventArgs) Handles EventModeBox.SelectedIndexChanged

        ErrorProvider1.SetError(EventModeBox, "")

        If EventModeBox.SelectedIndex = 0 Then
            BookVenueCheckBox.Visible = True 'only checkbox should be shown at first
        ElseIf EventModeBox.SelectedIndex = 1 Then
            BookVenueCheckBox.Checked = False
            VenueComboBox.Visible = False
            BookVenueCheckBox.Visible = False
        End If
    End Sub

    Private Sub TimeFormatCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles TimeFormatCheckBox.CheckedChanged
        ' Add or remove AM/PM
        If TimeFormatCheckBox.Checked Then
            EventStartTimePicker.CustomFormat = "  hh      '|'   mm         '|'   ss  tt"
            EventEndTimePicker.CustomFormat = "  hh      '|'   mm         '|'   ss  tt"
        Else
            EventStartTimePicker.CustomFormat = "  HH      '|'   mm         '|'   ss"
            EventEndTimePicker.CustomFormat = "  HH      '|'   mm         '|'   ss"
        End If
    End Sub

    ' end-time cannot be earlier than start-time
    Private Sub EventEndTimePicker_Validation(sender As Object, e As EventArgs) Handles EventEndTimePicker.ValueChanged, EventStartTimePicker.ValueChanged
        If EventEndTimePicker.Value <= EventStartTimePicker.Value Then
            ErrorProvider1.SetError(EventEndTimePicker, "Event cannot end before it starts")
        Else
            ErrorProvider1.SetError(EventEndTimePicker, "")
        End If
    End Sub

    Private Sub EventNameBox_Validation(sender As Object, e As EventArgs) Handles EventNameBox.TextChanged, EventNameBox.LostFocus
        If EventNameBox.Text.Trim = Nothing Then
            ErrorProvider1.SetError(EventNameBox, "Enter a event name")
        ElseIf EventNameBox.Text.Length < 5 Then
            ErrorProvider1.SetError(EventNameBox, "Enter more than 4 letters")
        Else
            ErrorProvider1.SetError(EventNameBox, "")
        End If
    End Sub

    Private Sub EventAddressBox_Validation(sender As Object, e As EventArgs) Handles EventAddressBox.TextChanged, EventAddressBox.LostFocus
        If EventAddressBox.Text.Trim = Nothing Then
            ErrorProvider1.SetError(EventAddressBox, "Enter the address or meeting link")
        Else
            ErrorProvider1.SetError(EventAddressBox, "")
        End If
    End Sub

    Private Sub VenueComboBox_Validate(sender As Object, e As EventArgs) Handles VenueComboBox.SelectedIndexChanged
        If BookVenueCheckBox.Checked And VenueComboBox.SelectedIndex = -1 Then
            ErrorProvider1.SetError(VenueComboBox, "Select the desired venue")
        Else
            ErrorProvider1.SetError(VenueComboBox, "")
        End If
    End Sub

    ' More validation will be done after submit button is clicked
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If EventNameBox.Text.Trim = Nothing Then
            ErrorProvider1.SetError(EventNameBox, "Enter a event name")
        End If
        If EventAddressBox.Text.Trim = Nothing Then
            ErrorProvider1.SetError(EventAddressBox, "Enter the address or meeting link")
        End If
        If BookVenueCheckBox.Checked And VenueComboBox.SelectedIndex = -1 Then
            ErrorProvider1.SetError(VenueComboBox, "Select the desired venue")
        End If
        If EventModeBox.SelectedIndex = -1 Then
            ErrorProvider1.SetError(EventModeBox, "Select event mode")
        End If

        If ErrorProvider1.GetError(EventNameBox) = Nothing And ErrorProvider1.GetError(EventAddressBox) = Nothing And ErrorProvider1.GetError(EventModeBox) = Nothing And ErrorProvider1.GetError(VenueComboBox) = Nothing And ErrorProvider1.GetError(EventEndTimePicker) = Nothing And ErrorProvider1.GetError(AgeBox) = Nothing Then
            Dim Temp As String
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Parameters.AddWithValue("ename", EventNameBox.Text)
            Sqlcmd.CommandText = "select name from events where name=@ename"
            Temp = Sqlcmd.ExecuteScalar
            If Temp Is Nothing Then
                If BookVenueCheckBox.Checked Then
                    CheckDatabase()
                Else
                    SubmitDetails()
                End If
            Else
                MessageBox.Show("The name " & Temp.TrimEnd & " is already taken, enter another name", "Form not filled correctly", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("Enter all the required details correctly", "Form not filled correctly", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Dim log As String
        log = LoggedInUser.ToString() & " created a new event."
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Parameters.AddWithValue("log", log)
        Sqlcmd.CommandText = "insert into logs (logtext) values (@log);"
        Sqlcmd.ExecuteNonQuery()
        Sqlcmd.Parameters.Clear()
        Sqlcmd.Dispose()
    End Sub

    ' Check if there is event timing clash in a Venue
    Private Sub CheckDatabase()

        Sqlcmd.Parameters.AddWithValue("SelectedVenue", VenueComboBox.SelectedItem)

        ' You have to specify the 'date' part of the 'Value' or the query will not work
        Sqlcmd.Parameters.AddWithValue("SelectedDate", EventDatePicker.Value.Date)

        ' add 30 minutes to end time
        Dim EventEnd As Date = DateAdd(DateInterval.Minute, 30, EventEndTimePicker.Value)

        Sqlcmd.Parameters.AddWithValue("SelEnd", EventEnd.TimeOfDay)
        ' subtract 30 mins to start time
        Dim EventStart As Date = DateAdd(DateInterval.Minute, -30, EventStartTimePicker.Value)

        Sqlcmd.Parameters.AddWithValue("SelStart", EventStart.TimeOfDay)
        Sqlcmd.Parameters.AddWithValue("SelVenue", VenueComboBox.SelectedIndex)

        ' columns start-time and end-time have a '-'
        ' so they must be enclosed in []
        Sqlcmd.CommandText = "select events.eventid from events,[venue-events] where events.eventid=[venue-events].eventid and [venue-events].venueid = @SelVenue and date = @SelectedDate and [start-time] < @SelEnd and @SelStart < [end-time]"

        If Sqlcmd.ExecuteScalar = Nothing Then
            SubmitDetails()
        Else
            MessageBox.Show("There is a clash in the timings of your event and an already occuring event in venue: " & VenueComboBox.SelectedItem.ToString & "" & Environment.NewLine & "Change the date or the event timing", "Timing Clash", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Sqlcmd.Parameters.Clear()
    End Sub

    Private Sub SubmitDetails()
        Sqlcmd.Parameters.AddWithValue("loggedinP", LoggedInUser)
        Sqlcmd.Parameters.AddWithValue("nameP", EventNameBox.Text)
        Sqlcmd.Parameters.AddWithValue("descP", EventDescriptionBox.Text)
        '
        Sqlcmd.Parameters.AddWithValue("ageP", AgeBox.Text)
        Sqlcmd.Parameters.AddWithValue("dateP", EventDatePicker.Value.Date)
        Sqlcmd.Parameters.AddWithValue("startP", EventStartTimePicker.Value)
        Sqlcmd.Parameters.AddWithValue("endP", EventEndTimePicker.Value)
        Sqlcmd.Parameters.AddWithValue("visP", EventVisibilityComboBox.SelectedItem.ToString)

        Sqlcmd.CommandText = "insert into events (organizerid,name,description,date,[start-time],[end-time],visibility,age) values (@loggedinP,@nameP,@descP,@dateP,@startP,@endP,@visP,@ageP); select SCOPE_IDENTITY();"
        ' scope_identity() return primary key of last inserted tuple
        Dim tempid As Integer = Sqlcmd.ExecuteScalar()
        Sqlcmd.Parameters.Clear()


        If EventVisibilityComboBox.SelectedItem = "Private" Then
            Sqlcmd.Parameters.AddWithValue("code", SecretCode.Text)
            Sqlcmd.Parameters.AddWithValue("eventid", tempid)
            Sqlcmd.CommandText = "insert into [private-events] ([event_id], code) values (@eventid, @code);"
            Sqlcmd.ExecuteNonQuery()
            Sqlcmd.Parameters.Clear()
        End If

        Sqlcmd.Parameters.AddWithValue("EventID", tempid)
        Sqlcmd.Parameters.AddWithValue("LoggedInUser", LoggedInUser)
        Sqlcmd.CommandText = "insert into enrollments (eventid,userid) values (@EventID, @LoggedInUser)"
        Sqlcmd.ExecuteNonQuery()
        Sqlcmd.Parameters.Clear()

        If BookVenueCheckBox.Checked And VenueComboBox.SelectedIndex <> -1 Then
            ' can select wrong venue if two venue have same name
            Sqlcmd.Parameters.AddWithValue("SelVenP", VenueComboBox.SelectedItem.ToString)
            Sqlcmd.CommandText = "select venueid from venues where name =@SelVenP"
            Dim tempvid As Integer = Sqlcmd.ExecuteScalar
            Sqlcmd.Parameters.AddWithValue("TempidP", tempid)
            Sqlcmd.Parameters.AddWithValue("vid", tempvid)

            Sqlcmd.CommandText = "insert into [venue-events] values (@TempidP,@vid)"
            Sqlcmd.ExecuteNonQuery()
            Sqlcmd.Parameters.Clear()
        Else
            Sqlcmd.Parameters.AddWithValue("TempidP", tempid)
            Sqlcmd.Parameters.AddWithValue("addP", EventAddressBox.Text)
            Sqlcmd.CommandText = "insert into [user-location] values(@TempidP,@addP)"
            Sqlcmd.ExecuteNonQuery()
            Sqlcmd.Parameters.Clear()
        End If




        MessageBox.Show("Event has been created", "Success", MessageBoxButtons.OK, MessageBoxIcon.None)
        Sqlcmd.Parameters.Clear()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles AgeBox.TextChanged, AgeBox.VisibleChanged
        If AgeBox.Visible Then
            If AgeBox.Text.Trim = Nothing Then
                ErrorProvider1.SetError(AgeBox, "Enter the age requirement")
            ElseIf Regex.IsMatch(AgeBox.Text, "[^0-9]") Then
                ErrorProvider1.SetError(AgeBox, "Enter only numbers (0-99)")
            Else
                ErrorProvider1.SetError(AgeBox, "")
            End If
        Else
            AgeBox.Text = "0"
            ErrorProvider1.SetError(AgeBox, "")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles AgeCheckBox.CheckedChanged
        If AgeCheckBox.Checked Then
            AgeBox.Visible = True
            AgeBox.Text = "18"
        Else
            AgeBox.Visible = False
            AgeBox.Text = "0"
        End If
    End Sub

    Private Sub EventVisibilityComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EventVisibilityComboBox.SelectedIndexChanged
        If EventVisibilityComboBox.SelectedItem = "Public" Then
            SecretCode.Visible = False
            SecretCode.Text = "0"
        ElseIf EventVisibilityComboBox.SelectedItem = "Private" Then
            SecretCode.Visible = True
            SecretCode.Text = random.Next(1000, 9999) ' can only be 4 digits
        End If
    End Sub

    Private Sub DisplayTimings_Click(sender As Object, e As EventArgs) Handles VenueComboBox.SelectedIndexChanged, EventDatePicker.ValueChanged
        If VenueComboBox.SelectedIndex >= 0 Then
            ListView1.Items.Clear()
            Dim Sqldr As SqlDataReader
            Sqlcmd.Parameters.Clear()
            Sqlcmd.Parameters.AddWithValue("venueid", VenueComboBox.SelectedIndex)
            Sqlcmd.Parameters.AddWithValue("date", EventDatePicker.Value.Date)
            Sqlcmd.CommandText = "select distinct [start-time], [end-time] from events,venues,[venue-events] where events.eventid = [venue-events].eventid and [venue-events].venueid =@venueid  and date = @date"
            Sqldr = Sqlcmd.ExecuteReader
            Sqlcmd.Parameters.Clear()

            While Sqldr.Read
                ListView1.Items.Add(Sqldr.Item(0).ToString).SubItems.Add(Sqldr.Item(1).ToString)
            End While
            Sqldr.Close()
        End If

    End Sub
End Class