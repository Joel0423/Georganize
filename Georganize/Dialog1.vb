Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If CardPanel.Visible = True Then
            If CardNOTextBox.Text.Trim <> Nothing And CVVTextBox.Text.Trim <> Nothing And ExpiryTextBox.Text.Trim <> Nothing Then
                If ErrorProvider1.GetError(CardNOTextBox) = Nothing And ErrorProvider1.GetError(CVVTextBox) = Nothing And ErrorProvider1.GetError(ExpiryTextBox) = Nothing Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MessageBox.Show("Enter valid payament details", "Incorrect details", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                If CardNOTextBox.Text.Trim = Nothing Then
                    ErrorProvider1.SetError(CardNOTextBox, "Invalid Card No.")
                End If
                If CVVTextBox.Text.Trim = Nothing Then
                    ErrorProvider1.SetError(CVVTextBox, "Invalid CVV No.")
                End If
                If ExpiryTextBox.Text.Trim = Nothing Then
                    ErrorProvider1.SetError(ExpiryTextBox, "Invalid expiry date")
                End If

            End If
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CardPanel.Visible = True
        UPIPanel.Visible = False
    End Sub

    Private Sub CardNOTextBox_TextChanged(sender As Object, e As EventArgs) Handles CardNOTextBox.TextChanged
        If CardNOTextBox.Text.Length = 16 And Not Regex.IsMatch(CardNOTextBox.Text, "[^0-9]") Then
            ErrorProvider1.SetError(CardNOTextBox, "")
        Else
            ErrorProvider1.SetError(CardNOTextBox, "Invalid Card No.")
        End If
    End Sub

    Private Sub CVVTextBox_TextChanged(sender As Object, e As EventArgs) Handles CVVTextBox.TextChanged
        If CVVTextBox.Text.Length > 2 And Not Regex.IsMatch(CVVTextBox.Text, "[^0-9]") Then
            ErrorProvider1.SetError(CVVTextBox, "")
        Else
            ErrorProvider1.SetError(CVVTextBox, "Invalid CVV No.")
        End If
    End Sub

    Private Sub ExpiryTextBox_TextChanged(sender As Object, e As EventArgs) Handles ExpiryTextBox.TextChanged
        If Regex.IsMatch(ExpiryTextBox.Text, "((0[1-9])|(1 [0-2]))/[0-9]{2}") Then
            ErrorProvider1.SetError(ExpiryTextBox, "")
        Else
            ErrorProvider1.SetError(ExpiryTextBox, "Invalid expiry date")
        End If
    End Sub

    Private Sub CardRadio_CheckedChanged(sender As Object, e As EventArgs) Handles CardRadio.CheckedChanged, UPIRadio.CheckedChanged
        If CardRadio.Checked Then
            CardPanel.Visible = True
            UPIPanel.Visible = False
        ElseIf UPIRadio.Checked Then
            UPIPanel.Visible = True
            CardPanel.Visible = False
        End If
    End Sub
End Class
