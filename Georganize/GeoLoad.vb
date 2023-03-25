Imports System.Data.SqlClient
Imports Georganize.Georganize

Public Module GeoLoad
    Public Sqlcon As New SqlConnection
    Public LoggedInUser = ""
    Public SelectedPublicEventID = ""
    Public LoggedInUserDOB As DateTime
    Public LoggedInUserAge = 0
    Public VenueAddressList As New List(Of String)
    Public ProfilePicDirectory As String = "C:\Users\joela\Desktop\Georganize-20230215T143004Z-001\GeoProfilePics"
    Public InitialDirectoryString As String = "C:\Users\joela\Pictures"

    Public Sub GeoOpen()
        Sqlcon.ConnectionString = "Data Source=JOEL-WINDOWS\SQLEXPRESS;Initial Catalog=GEODATABASE;Integrated Security=True"
        Sqlcon.Open()
    End Sub

    Public Sub GeoClose()
        Sqlcon.Close()
    End Sub

    Public Sub FindAge()
        LoggedInUserAge = DateTime.Today.Year - LoggedInUserDOB.Year
        ' for leap year?
        If LoggedInUserDOB.Date > DateTime.Today.AddYears(-LoggedInUserAge) Then
            LoggedInUserAge -= 1
        End If
    End Sub

End Module
