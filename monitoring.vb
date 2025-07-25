Imports MySql.Data.MySqlClient

Public Class monitoring
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=products")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim bindingSource As New BindingSource()
    Dim sqlQuery As String = "SELECT * FROM `audit_log`"


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Public Sub LoadAuditLogs()
        Try
            Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=products")
            con.Open()

            Dim query As String = "SELECT `id`, `user_account`, `action`, `product_name`, `timestamp` FROM `audit_log` ORDER BY timestamp DESC"
            Dim adapter As New MySqlDataAdapter(query, con)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            DGV.DataSource = dt
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAuditLogs()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

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
End Class