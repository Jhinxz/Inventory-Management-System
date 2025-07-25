Imports MySql.Data.MySqlClient

Public Class sample
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=products")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim bindingSource As New BindingSource()
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim sqlQuery As String = "SELECT * FROM `category`"
    Dim sqlQuery2 As String = "SELECT * FROM `manufacturer`"


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `category`(`CATEGORY`) VALUES (@CATEGORY)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@CATEGORY", txtcateg.Text)



            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("CATEGORY ADDED!", "PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("CATEGORY FAILED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


        Catch ex As Exception

        End Try
    End Sub

    Public Sub add()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `category`(`CATEGORY`) VALUES (@CATEGORY)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@CATEGORY", txtcateg.Text)



            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("CATEGORY ADDED!", "PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("CATEGORY FAILED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


        Catch ex As Exception

        End Try
    End Sub

    Public Sub DGV_load()
        DGV.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `category`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DGV.Rows.Add(dr.Item("CATEGORY"), dr.Item("ID"))

            End While
            dr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()


        End Try

    End Sub

    Private Sub sample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
        DGV_load2()
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_Click(sender As Object, e As EventArgs) Handles DGV.Click
        txtcateg.Text = DGV.CurrentRow.Cells(0).Value

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `category` SET `CATEGORY`=@CATEGORY WHERE `CATEGORY` =@CATEGORY", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@CATEGORY", txtcateg.Text)


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("CATEGORY UPDATED!", "PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("CATEGORY UPDATE FAILED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim adapter As New MySqlDataAdapter(sqlQuery, conn)
            Dim dt As New DataTable

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

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Public Sub add2()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `manufacturer` SET `MANUFACTURER` =@MANUFACTURER WHERE `MANUFACTURER` =@MANUFACTURER)", conn)
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `manufacturer` SET `MANUFACTURER`=@MANUFACTURER WHERE `MANUFACTURER`=@MANUFACTURER", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@MANUFACTURER", txtmanu.Text)


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("MANUFACTURER UPDATED!", "PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("MANUFACTURER UPDATE FAILED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If


        Catch ex As Exception

        End Try
    End Sub

    Public Sub DGV_load2()
        DGV.Rows.Clear()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `manufacturer`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DGV2.Rows.Add(dr.Item("ID"), dr.Item("MANUFACTURER"))

            End While
            dr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()


        End Try

    End Sub

    Private Sub DGV2_Click(sender As Object, e As EventArgs) Handles DGV2.Click
        txtmanu.Text = DGV2.CurrentRow.Cells(1).Value

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim adapter As New MySqlDataAdapter(sqlQuery, conn)
            Dim dt As New DataTable

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Main.Show()
        Me.Hide()


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Main.Show()
        Me.Hide()

    End Sub
End Class