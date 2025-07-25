Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Users
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=users")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim sqlQuery As String = "SELECT * FROM `accounts`"
    Dim bindingSource As New BindingSource()


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `accounts`(`Firstname`, `Lastname`, `Username`,
            `Password`) VALUES (@Firstname, @Lastname, @Username, @Password)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Firstname", txtfirstname.Text)
            cmd.Parameters.AddWithValue("@Lastname", txtlastname.Text)
            cmd.Parameters.AddWithValue("@Password", txtpassword.Text)
            cmd.Parameters.AddWithValue("@Username", txtusername.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("INFO ADDED!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("INFO FAILED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


        Catch ex As Exception

        End Try
    End Sub

    Public Sub add()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `accounts`(`Firstname`, `Lastname`, `Username`,
            `Password`) VALUES (@Firstname, @Lastname, @Username, @Password)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Firstname", txtfirstname.Text)
            cmd.Parameters.AddWithValue("@Lastname", txtlastname.Text)
            cmd.Parameters.AddWithValue("@Password", txtpassword.Text)
            cmd.Parameters.AddWithValue("@Username", txtusername.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("INFO ADDED!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("INFO FAILED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


        Catch ex As Exception

        End Try
    End Sub
    Public Sub DGV_load()
        DGV.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `accounts`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DGV.Rows.Add(dr.Item("Firstname"), dr.Item("Lastname"), dr.Item("Username"),
                dr.Item("Password"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()


        End Try


    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Main.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `accounts` SET `Lastname`=@Lastname,`Username`=@Username,`Password`=@Password WHERE `Firstname`=@Firstname", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Firstname", txtfirstname.Text)
            cmd.Parameters.AddWithValue("@Lastname", txtlastname.Text)
            cmd.Parameters.AddWithValue("@Password", txtpassword.Text)
            cmd.Parameters.AddWithValue("@Username", txtusername.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("INFO UPDATED!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("INFO UPDATE FAILED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


        Catch ex As Exception

        End Try
    End Sub

    Public Sub update()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `accounts` SET `Lastname`=@Lastname,`Username`=@Username,
            `Password`=@Password WHERE `Firstname`=@Firstname", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Firstname", txtfirstname.Text)
            cmd.Parameters.AddWithValue("@Lastname", txtlastname.Text)
            cmd.Parameters.AddWithValue("@Password", txtpassword.Text)
            cmd.Parameters.AddWithValue("@Username", txtusername.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("INFO UPDATED!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("INFO UPDATE FAILED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DGV.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM accounts WHERE Firstname like '%" & TextBox1.Text & "%' OR Lastname like '%" & TextBox1.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DGV.Rows.Add(dr.Item("Firstname"), dr.Item("Lastname"), dr.Item("Username"),
                dr.Item("Password"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()


        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Delete this record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `accounts` WHERE `Firstname` =@Firstname", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Firstname", txtfirstname.Text)


                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("INFO DELETED!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("INFO FAILED TO DELETE!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If


            Catch ex As Exception

            End Try
            DGV_load()
        Else
            Return

        End If
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        txtfirstname.Text = DGV.CurrentRow.Cells(0).Value
        txtlastname.Text = DGV.CurrentRow.Cells(1).Value
        txtusername.Text = DGV.CurrentRow.Cells(2).Value
        txtpassword.Text = DGV.CurrentRow.Cells(3).Value

        DGV.ReadOnly = True
        Button1.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim adapter As New MySqlDataAdapter(sqlQuery, conn)
            Dim dt As New DataTable()

            adapter.Fill(dt)

            BindingSource.DataSource = dt
            DGV.DataSource = BindingSource

            DGV.DataSource = Nothing
            DGV.Rows.Clear()
            DGV.Columns.Clear()
            DGV.Refresh()

            DGV.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub Load()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim adapter As New MySqlDataAdapter(sqlQuery, conn)
            Dim dt As New DataTable()

            adapter.Fill(dt)

            bindingSource.DataSource = dt
            DGV.DataSource = bindingSource

            DGV.DataSource = Nothing
            DGV.Rows.Clear()
            DGV.Columns.Clear()
            DGV.Refresh()

            DGV.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If txtpassword.UseSystemPasswordChar = True Then

            ' show password
            txtpassword.UseSystemPasswordChar = False

        Else

            ' hide password
            txtpassword.UseSystemPasswordChar = True

        End If

        If txtretype.UseSystemPasswordChar = True Then

            ' show password
            txtretype.UseSystemPasswordChar = False

        Else

            ' hide password
            txtretype.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        DGV.ReadOnly = True

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class