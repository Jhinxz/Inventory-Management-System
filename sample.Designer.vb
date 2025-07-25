<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sample
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sample))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Button8 = New Button()
        Button5 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        txtcateg = New TextBox()
        DGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        PictureBox2 = New PictureBox()
        TabPage2 = New TabPage()
        Button7 = New Button()
        Button6 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        txtmanu = New TextBox()
        DGV2 = New DataGridView()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        PictureBox1 = New PictureBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(DGV2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1924, 1050)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Button8)
        TabPage1.Controls.Add(Button5)
        TabPage1.Controls.Add(Button3)
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(txtcateg)
        TabPage1.Controls.Add(DGV)
        TabPage1.Controls.Add(PictureBox2)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1916, 1012)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.Location = New Point(55, 27)
        Button8.Name = "Button8"
        Button8.Size = New Size(123, 51)
        Button8.TabIndex = 24
        Button8.Text = "Back"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.Black
        Button5.Location = New Point(670, 267)
        Button5.Name = "Button5"
        Button5.Size = New Size(112, 34)
        Button5.TabIndex = 23
        Button5.Text = "Refresh"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(1477, 422)
        Button3.Name = "Button3"
        Button3.Size = New Size(135, 49)
        Button3.TabIndex = 11
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1194, 422)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 49)
        Button1.TabIndex = 9
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtcateg
        ' 
        txtcateg.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtcateg.Location = New Point(1170, 341)
        txtcateg.Name = "txtcateg"
        txtcateg.Size = New Size(500, 45)
        txtcateg.TabIndex = 8
        ' 
        ' DGV
        ' 
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        DGV.Location = New Point(109, 307)
        DGV.Name = "DGV"
        DGV.RowHeadersVisible = False
        DGV.RowHeadersWidth = 62
        DGV.Size = New Size(673, 378)
        DGV.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Categories"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "ID"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(0, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1916, 1009)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Button7)
        TabPage2.Controls.Add(Button6)
        TabPage2.Controls.Add(Button4)
        TabPage2.Controls.Add(Button2)
        TabPage2.Controls.Add(txtmanu)
        TabPage2.Controls.Add(DGV2)
        TabPage2.Controls.Add(PictureBox1)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1916, 1012)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Sylfaen", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.Location = New Point(67, 24)
        Button7.Name = "Button7"
        Button7.Size = New Size(112, 52)
        Button7.TabIndex = 7
        Button7.Text = "Back"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(668, 288)
        Button6.Name = "Button6"
        Button6.Size = New Size(112, 34)
        Button6.TabIndex = 6
        Button6.Text = "Refresh"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(1491, 418)
        Button4.Name = "Button4"
        Button4.Size = New Size(128, 48)
        Button4.TabIndex = 5
        Button4.Text = "Update"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(1195, 418)
        Button2.Name = "Button2"
        Button2.Size = New Size(128, 48)
        Button2.TabIndex = 4
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtmanu
        ' 
        txtmanu.Font = New Font("Times New Roman", 18F, FontStyle.Bold)
        txtmanu.Location = New Point(1169, 337)
        txtmanu.Name = "txtmanu"
        txtmanu.Size = New Size(497, 49)
        txtmanu.TabIndex = 3
        ' 
        ' DGV2
        ' 
        DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV2.Columns.AddRange(New DataGridViewColumn() {Column3, Column4})
        DGV2.Location = New Point(110, 328)
        DGV2.Name = "DGV2"
        DGV2.RowHeadersVisible = False
        DGV2.RowHeadersWidth = 62
        DGV2.Size = New Size(670, 351)
        DGV2.TabIndex = 1
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Manufacturers"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "ID"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1913, 1009)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' sample
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(TabControl1)
        Name = "sample"
        Text = "sample"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(DGV2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcateg As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtmanu As TextBox
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
