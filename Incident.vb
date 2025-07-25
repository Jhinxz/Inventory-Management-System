Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Incident
    Dim connectionString As String = "server=localhost;port=3306;username=root;password=;database=products"
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=products")
    Dim i As Integer
    Dim bindingSource As New BindingSource()
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim sqlQuery As String = "SELECT * FROM `incident_reports`"

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        Try
            If String.IsNullOrWhiteSpace(txttitle.Text) OrElse String.IsNullOrWhiteSpace(txtdescription.Text) Then
                MessageBox.Show("Please enter all details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim imagePath As String = ""
            If Not String.IsNullOrEmpty(imageFilePath) Then
                ' ✅ Copy image to a fixed directory
                Dim savePath As String = Application.StartupPath & "\IncidentImages\"
                If Not Directory.Exists(savePath) Then Directory.CreateDirectory(savePath)

                imagePath = savePath & Path.GetFileName(imageFilePath)
                File.Copy(imageFilePath, imagePath, True)
            End If

            Using conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=products")
                conn.Open()
                Dim query As String = "INSERT INTO `incident_reports`(`incident_title`, `incident_description`, `image_path`) VALUES (@incident_title, @incident_description, @imagepath)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@incident_title", txttitle.Text)
                    cmd.Parameters.AddWithValue("@incident_description", txtdescription.Text)
                    cmd.Parameters.AddWithValue("@imagepath", imagePath)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Incident report submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadIncidentReports() ' Refresh DataGridView
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Incident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadIncidentReports()

    End Sub

    Private imageFilePath As String
    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            imageFilePath = openFileDialog.FileName
            picbox.Image = Image.FromFile(imageFilePath)
        End If
    End Sub

    Private Sub LoadIncidentReports()
        Try
            Using conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=products")
                conn.Open()
                Dim query As String = "SELECT incident_title, incident_description, image_path, timestamp FROM incident_reports ORDER BY timestamp DESC"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                DGV.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading reports: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridViewReports_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DGV.Rows(e.RowIndex)
            Dim imagePath As String = row.Cells("image_path").Value.ToString()

            If File.Exists(imagePath) Then
                picbox.Image = Image.FromFile(imagePath)
            Else
                picbox.Image = Nothing
            End If
        End If
        txttitle.Text = DGV.CurrentRow.Cells(0).Value
        txtdescription.Text = DGV.CurrentRow.Cells(1).Value
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Hide()

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        LoadIncidentReports()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Delete this record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `incident_reports` WHERE `incident_title` =@incident_title", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@incident_title", txttitle.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("PRODUCT DELETED!", "PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("PRODUCT FAILED TO DELETE!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If


            Catch ex As Exception

            End Try
            Return

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

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