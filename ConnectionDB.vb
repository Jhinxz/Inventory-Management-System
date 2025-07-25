Imports MySql.Data.MySqlClient

Public Class ConnectionDB
    Private connection As New MySqlConnection("Datasource=localhost;port=3306;username=root;password=;database=users")

    Function getconnection() As MySqlConnection
        Return connection
    End Function

    Sub openConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Sub closeConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class
