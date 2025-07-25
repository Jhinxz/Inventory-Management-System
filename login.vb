Imports MySql.Data.MySqlClient

Public Class login
    Dim command As MySqlCommand
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=users")



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim query As String = "SELECT accounts.Username, roles.role_name FROM accounts 
                                   JOIN roles ON accounts.role_id = roles.id 
                                   WHERE accounts.Username = @Username AND accounts.Password = @Password"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", txtusername.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim role As String = reader("role_name").ToString()
                Dim username As String = reader("Username").ToString()

                MessageBox.Show("Welcome, " & username & " (" & role & ")")

                If role = "Admin" Then
                    Main.Show()
                ElseIf role = "Staff" Then
                    Main2.Show()
                End If

                Me.Hide()
            Else
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Signin.Show()
        Me.Hide()


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If txtpassword.UseSystemPasswordChar = True Then

            ' show password
            txtpassword.UseSystemPasswordChar = False

        Else

            ' hide password
            txtpassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        forgot.Show()
        Me.Hide()


    End Sub
End Class
