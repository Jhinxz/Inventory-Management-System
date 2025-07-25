Imports MySql.Data.MySqlClient

Public Class Manufacturer
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=products")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim sqlQuery As String = "SELECT * FROM `manufacturer`"

    Dim bindingSource As New BindingSource()
    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `manufacturer`(`MANUFACTURER`) VALUES (@MANUFACTURER)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@MANUFACTURER", txtmanu.Text)



            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("MANUFACTURER HAS BEEN ADDED!", "MANUFACTURER", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("MANUFACTURER ADDED HAS BEEN FAILED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


        Catch ex As Exception

        End Try
    End Sub

    Public Sub add()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `manufacturer`(`MANUFACTURER`) VALUES (@MANUFACTURER)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@MANUFACTURER", txtmanu.Text)



            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("MANUFACTURER HAS BEEN ADDED!", "MANUFACTURER", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("MANUFACTURER ADDED HAS BEEN FAILED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


        Catch ex As Exception

        End Try
    End Sub

    Public Sub DGV_load()
        DGV.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `manufacturer`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DGV.Rows.Add(dr.Item("MANUFACTURER"), dr.Item("ID"))

            End While
            dr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()


        End Try

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Main.Show()
        Me.Hide()

    End Sub

    Private Sub Manufacturer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        txtmanu.Text = DGV.CurrentRow.Cells(0).Value
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class