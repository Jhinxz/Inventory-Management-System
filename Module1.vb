Imports MySql.Data.MySqlClient

Module Module1
    Public constring As MySqlConnection
    Public cm As MySqlCommand


    Sub Connection()
        Try
            constring = New MySqlConnection("server=localhost;database=users;username=root;password=")
            constring.Open()

        Catch ex As Exception
            MsgBox("Connection Failed")

        End Try
    End Sub
End Module
