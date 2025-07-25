Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.DirectoryServices.ActiveDirectory
Imports ClosedXML.Excel

Public Class Add
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=products")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim sqlQuery As String = "SELECT * FROM `curd`"
    Dim bindingSource As New BindingSource()
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Public LoggedInUser As String = "Admin"



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Main.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `curd`(`PRODUCTNAME`, `BRAND`, `QUANTITY`, `CATEGORY`, `EXPDATE`, `DATEADDED`, `MANUFACTURER`)
            VALUES (@PRODUCTNAME, @BRAND, @QUANTITY, @CATEGORY, @EXPDATE, @DATEADDED, @MANUFACTURER)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PRODUCTNAME", txtproduct.Text)
            cmd.Parameters.AddWithValue("@BRAND", txtbrand.Text)
            cmd.Parameters.AddWithValue("@QUANTITY", CDec(txtquantity.Text))
            cmd.Parameters.AddWithValue("@CATEGORY", combocategory.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", CDate(datepick_exp.Value))
            cmd.Parameters.AddWithValue("@DATEADDED", CDate(dateadded.Value))
            cmd.Parameters.AddWithValue("@MANUFACTURER", combomanufact.Text)

            i = cmd.ExecuteNonQuery

            Dim productName As String = txtproduct.Text.Trim()
            LogAction("Added", ProductName, "Added a new product with price: ")

            If i > 0 Then
                MessageBox.Show("PRODUCT ADDED!", "PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("PRODUCT FAILED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If

            refreshtable()


        Catch ex As Exception

        End Try
    End Sub

    Public Sub add()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `curd`(`PRODUCTNAME`, `BRAND`, `QUANTITY`, `CATEGORY`, `EXPDATE`, `DATEADDED`, `MANUFACTURER`)
            VALUES (@PRODUCTNAME, @BRAND, @QUANTITY, @CATEGORY, @EXPDATE, @DATEADDED, @MANUFACTURER)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PRODUCTNAME", txtproduct.Text)
            cmd.Parameters.AddWithValue("@BRAND", txtbrand.Text)
            cmd.Parameters.AddWithValue("@QUANTITY", CDec(txtquantity.Text))
            cmd.Parameters.AddWithValue("@CATEGORY", combocategory.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", CDate(datepick_exp.Value))
            cmd.Parameters.AddWithValue("@DATEADDED", CDate(dateadded.Value))
            cmd.Parameters.AddWithValue("@MANUFACTURER", combomanufact.Text)



            i = cmd.ExecuteNonQuery

            LogAction("Added", ProductName, "Added a new product with price: ")

            If i > 0 Then
                MessageBox.Show("PRODUCT ADDED!", "PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("PRODUCT FAILED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
        category()
        monitor()
        manufacturer()
    End Sub

    Public Sub DGV_load()
        DGV.DataSource = Nothing
        DGV.Rows.Clear()
        DGV.Refresh()

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `curd`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DGV.Rows.Add(dr.Item("PRODUCTNAME"), dr.Item("BRAND"), dr.Item("QUANTITY"), dr.Item("CATEGORY"),
                dr.Item("EXPDATE"), dr.Item("DATEADDED"), dr.Item("MANUFACTURER"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        Finally
            conn.Close()


        End Try


    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        txtproduct.Text = DGV.CurrentRow.Cells(0).Value
        txtbrand.Text = DGV.CurrentRow.Cells(1).Value
        txtquantity.Text = DGV.CurrentRow.Cells(2).Value
        combocategory.Text = DGV.CurrentRow.Cells(3).Value
        datepick_exp.Text = DGV.CurrentRow.Cells(4).Value
        dateadded.Text = DGV.CurrentRow.Cells(5).Value
        combomanufact.Text = DGV.CurrentRow.Cells(6).Value



        txtproduct.ReadOnly = True
        Button1.Enabled = False

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        DGV_load()
        HighlightLowStock()

    End Sub

    Public Sub monitor()
        DGV.EnableHeadersVisualStyles = False

        Try
            conn = New MySqlConnection("server=localhost;port=3306;username=root;password=;database=products")
            conn.Open()

            Dim query As String = "SELECT * FROM `curd`"
            cm = New MySqlCommand(query, conn)
            adapter = New MySqlDataAdapter(cm)
            table = New DataTable()
            adapter.Fill(table)

            DGV.DataSource = table


            HighlightLowStock()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub HighlightLowStock()
        Dim lowStockThreshold As Integer = 15

        Try

            For Each row As DataGridViewRow In DGV.Rows
                Dim stockValue As String = If(row.Cells("QUANTITY").Value IsNot Nothing, row.Cells("QUANTITY").Value.ToString(), "NULL")


                If row.Cells("QUANTITY").Value IsNot Nothing Then
                    Dim stock As Integer

                    If Integer.TryParse(row.Cells("QUANTITY").Value.ToString(), stock) Then

                        If stock < lowStockThreshold Then
                            row.DefaultCellStyle.BackColor = Color.Red
                            row.DefaultCellStyle.ForeColor = Color.White
                        ElseIf stock < (lowStockThreshold * 2) Then
                            row.DefaultCellStyle.BackColor = Color.Yellow
                            row.DefaultCellStyle.ForeColor = Color.Black
                        Else
                            row.DefaultCellStyle.BackColor = Color.White
                            row.DefaultCellStyle.ForeColor = Color.Black
                        End If
                    End If
                End If
            Next

            DGV.ResumeLayout()
        Catch ex As Exception
            MessageBox.Show("Error in HighlightLowStock: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtproduct.Clear()
        txtquantity.Clear()
        combocategory.Text = ""
        datepick_exp.Value = Now
        dateadded.Value = Now
        combomanufact.Text = ""


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `curd` SET `BRAND` =@BRAND, `QUANTITY`=@QUANTITY,`CATEGORY`=@CATEGORY,`EXPDATE`=@EXPDATE,
            `DATEADDED`=@DATEADDED, `MANUFACTURER`=@MANUFACTURER WHERE `PRODUCTNAME`=@PRODUCTNAME", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PRODUCTNAME", txtproduct.Text)
            cmd.Parameters.AddWithValue("@BRAND", txtbrand.Text)
            cmd.Parameters.AddWithValue("@QUANTITY", CDec(txtquantity.Text))
            cmd.Parameters.AddWithValue("@CATEGORY", combocategory.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", CDate(datepick_exp.Value))
            cmd.Parameters.AddWithValue("@DATEADDED", CDate(dateadded.Value))
            cmd.Parameters.AddWithValue("@MANUFACTURER", combomanufact.Text)

            i = cmd.ExecuteNonQuery

            Dim productName As String = txtproduct.Text.Trim()
            LogAction("Updated", productName, "Added a new product with price: ")

            If i > 0 Then
                MessageBox.Show("PRODUCT UPDATED!", "PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("PRODUCT UPDATE FAILED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If

            refreshtable()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Delete this record?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `curd` WHERE `PRODUCTNAME` =@PRODUCTNAME", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@PRODUCTNAME", txtproduct.Text)

                i = cmd.ExecuteNonQuery

                Dim productName As String = txtproduct.Text.Trim()
                LogAction("Archived", productName, "Added a new product with price: ")

                If i > 0 Then
                    MessageBox.Show("PRODUCT DELETED!", "PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("PRODUCT FAILED TO DELETE!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If


            Catch ex As Exception

            End Try
            DGV_load()
        Else
            Return

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        SearchProduct(txtsearch.Text)
    End Sub

    Private Sub SearchProduct(searchText As String)
        Try
            Using connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=products")
                connection.Open()
                Dim query As String = "SELECT `PRODUCTNAME`, `BRAND`, `QUANTITY`, `CATEGORY`, `EXPDATE`, `DATEADDED`, `MANUFACTURER` FROM `curd` WHERE `PRODUCTNAME` LIKE @CATEGORY"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@CATEGORY", "%" & searchText & "%")

                    Using adapter As New MySqlDataAdapter(command)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        DGV.DataSource = table
                    End Using
                End Using
            End Using

            HighlightLowStock()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub refreshtable()

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

            monitor()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click

        refreshtable()

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



    Private Sub combocategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combocategory.SelectedIndexChanged
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `category`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                combocategory.Items.Add(dr(0))
            End While
            dr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()


        End Try
    End Sub

    Public Sub category()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `category`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                combocategory.Items.Add(dr(0))
            End While
            dr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()


        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combomanufact.SelectedIndexChanged
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `manufacturer`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                combomanufact.Items.Add(dr(0))
            End While
            dr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()


        End Try
    End Sub

    Public Sub manufacturer()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `manufacturer`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                combomanufact.Items.Add(dr(0))
            End While
            dr.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()


        End Try
    End Sub

    Public Sub LogAction(actionType As String, itemName As String, details As String)
        Try
            Dim con As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=products")
            con.Open()

            Dim query As String = "INSERT INTO `audit_log`(`action`, `product_name`) VALUES (@action, @product_name)"
            Dim cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@action", actionType)
            cmd.Parameters.AddWithValue("@product_name", itemName)

            cmd.ExecuteNonQuery()
            con.Close()



        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ExportToExcel()
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
            saveDialog.FileName = "DataGridView_Export.xlsx"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                ' Create Excel Workbook
                Dim workbook As New XLWorkbook()
                Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Sheet1")

                ' Export Column Headers
                For col As Integer = 0 To DGV.ColumnCount - 1
                    worksheet.Cell(1, col + 1).Value = DGV.Columns(col).HeaderText
                Next

                ' Export Data (Handling Null Values)
                For row As Integer = 0 To DGV.RowCount - 1
                    For col As Integer = 0 To DGV.ColumnCount - 1
                        Dim cellValue As Object = DGV.Rows(row).Cells(col).Value

                        ' Check for NULL or empty values and replace with an empty string
                        If cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue) Then
                            worksheet.Cell(row + 2, col + 1).Value = cellValue.ToString()
                        Else
                            worksheet.Cell(row + 2, col + 1).Value = ""
                        End If
                    Next
                Next

                ' Save Excel File
                workbook.SaveAs(saveDialog.FileName)
                MessageBox.Show("Export Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting: " & ex.Message)
        End Try
    End Sub


    ' Release Excel COM Object (Prevents Memory Leaks)
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        ExportToExcel()

    End Sub
End Class