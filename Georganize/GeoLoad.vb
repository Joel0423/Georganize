Imports System.Data.SqlClient
Imports Georganize.Georganize

Public Module GeoLoad
    Public Sqlcon As New SqlConnection
    Public LoggedInUser = ""
    Public SelectedPublicEventID = ""
    Public VenueAddressList As New List(Of String)
    Public ProfilePicDirectory As String = "C:\Users\Admin\Downloads\Georganize-20230215T143004Z-001-20230227T033452Z-001\Georganize-20230215T143004Z-001\GeoProfilePics"
    Public InitialDirectoryString As String = "C:\Users\Public\Pictures"

    Public Sub GeoOpen()
        Sqlcon.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Downloads\Georganize-20230215T143004Z-001-20230303T034701Z-001\Georganize-20230215T143004Z-001\Georganize\Georganize\GeoDatabase.mdf;Integrated Security=True"
        Sqlcon.Open()
    End Sub

    Public Sub GeoClose()
        Sqlcon.Close()
        LoginForm.Close()
    End Sub

End Module
