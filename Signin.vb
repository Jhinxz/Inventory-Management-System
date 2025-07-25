
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Signin
    Dim connection As New ConnectionDB
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=users")
    Dim command As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtusername.Text = "" Or txtpassword.Text = "" Or comborole.SelectedItem Is Nothing Then
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            conn.Open()

            ' Get Role ID from Role Name
            Dim getRoleQuery As String = "SELECT id FROM `roles` WHERE `role_name` = @role_name"
            Dim cmdRole As New MySqlCommand(getRoleQuery, conn)
            cmdRole.Parameters.AddWithValue("@role_name", comborole.SelectedItem.ToString())

            Dim roleId As Object = cmdRole.ExecuteScalar()

            If roleId Is Nothing Then
                MessageBox.Show("Invalid role selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.Close()
                Exit Sub
            End If

            ' Insert User
            Dim query As String = "INSERT INTO `accounts`(`Firstname`, `Lastname`, `Username`, `Password`, `Retype`, `role_id`) VALUES (@Firstname, @Lastname, @Username, @Password, @Retype, @role_id)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@Firstname", txtfirstname.Text.Trim())
            cmd.Parameters.AddWithValue("@Lastname", txtlastname.Text.Trim())
            cmd.Parameters.AddWithValue("@Username", txtpassword.Text.Trim())
            cmd.Parameters.AddWithValue("@Password", txtusername.Text.Trim())
            cmd.Parameters.AddWithValue("@Retype", txtpass.Text.Trim()) ' Use hashing in production
            cmd.Parameters.AddWithValue("@role_id", roleId)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            conn.Close()
            Me.Close()
            login.Show()

        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim query As String = "SELECT role_name FROM roles"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                comborole.Items.Add(reader("role_name").ToString())
            End While

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading roles: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.Show()
        Me.Hide()


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If txtpass.UseSystemPasswordChar = True Then

            ' show password
            txtpass.UseSystemPasswordChar = False

        Else

            ' hide password
            txtpass.UseSystemPasswordChar = True

        End If

        If txtusername.UseSystemPasswordChar = True Then

            ' show password
            txtusername.UseSystemPasswordChar = False

        Else

            ' hide password
            txtusername.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comborole.SelectedIndexChanged


    End Sub

    Private Sub txtfirstname_TextChanged(sender As Object, e As EventArgs) Handles txtfirstname.TextChanged

    End Sub
End Class