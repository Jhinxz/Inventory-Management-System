<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add))
        PictureBox1 = New PictureBox()
        txtquantity = New TextBox()
        combocategory = New ComboBox()
        datepick_exp = New DateTimePicker()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Button5 = New Button()
        txtsearch = New TextBox()
        btnrefresh = New Button()
        dateadded = New DateTimePicker()
        combomanufact = New ComboBox()
        Button6 = New Button()
        txtbrand = New TextBox()
        txtproduct = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(3, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1919, 1050)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtquantity
        ' 
        txtquantity.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtquantity.Location = New Point(221, 761)
        txtquantity.Name = "txtquantity"
        txtquantity.Size = New Size(372, 35)
        txtquantity.TabIndex = 2
        ' 
        ' combocategory
        ' 
        combocategory.Font = New Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        combocategory.FormattingEnabled = True
        combocategory.Location = New Point(221, 874)
        combocategory.Name = "combocategory"
        combocategory.Size = New Size(372, 38)
        combocategory.TabIndex = 3
        ' 
        ' datepick_exp
        ' 
        datepick_exp.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        datepick_exp.Location = New Point(715, 527)
        datepick_exp.Name = "datepick_exp"
        datepick_exp.Size = New Size(371, 40)
        datepick_exp.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(624, 860)
        Button1.Name = "Button1"
        Button1.Size = New Size(141, 52)
        Button1.TabIndex = 5
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(1194, 858)
        Button2.Name = "Button2"
        Button2.Size = New Size(135, 54)
        Button2.TabIndex = 6
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(816, 856)
        Button3.Name = "Button3"
        Button3.Size = New Size(134, 58)
        Button3.TabIndex = 7
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.Black
        Button4.Location = New Point(1005, 859)
        Button4.Name = "Button4"
        Button4.Size = New Size(133, 52)
        Button4.TabIndex = 8
        Button4.Text = "Clear"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' DGV
        ' 
        DGV.BackgroundColor = Color.White
        DGV.BorderStyle = BorderStyle.Fixed3D
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column7, Column2, Column3, Column4, Column5, Column6})
        DGV.Location = New Point(221, 179)
        DGV.Name = "DGV"
        DGV.ReadOnly = True
        DGV.RowHeadersVisible = False
        DGV.RowHeadersWidth = 62
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.Size = New Size(1103, 276)
        DGV.TabIndex = 14
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Product"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Resizable = DataGridViewTriState.False
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column7.HeaderText = "Brand"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Resizable = DataGridViewTriState.False
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Quantity"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Resizable = DataGridViewTriState.False
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Category"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Resizable = DataGridViewTriState.False
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Expiry date"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Resizable = DataGridViewTriState.False
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column5.HeaderText = "Date Added"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Resizable = DataGridViewTriState.False
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column6.HeaderText = "Manufacturer"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Resizable = DataGridViewTriState.False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Sylfaen", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.Black
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(60, 25)
        Button5.Name = "Button5"
        Button5.Size = New Size(133, 51)
        Button5.TabIndex = 15
        Button5.Text = "Back"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' txtsearch
        ' 
        txtsearch.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtsearch.Location = New Point(449, 117)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(335, 40)
        txtsearch.TabIndex = 16
        ' 
        ' btnrefresh
        ' 
        btnrefresh.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnrefresh.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        btnrefresh.Location = New Point(847, 86)
        btnrefresh.Name = "btnrefresh"
        btnrefresh.Size = New Size(112, 34)
        btnrefresh.TabIndex = 18
        btnrefresh.Text = "Refresh"
        btnrefresh.UseVisualStyleBackColor = True
        ' 
        ' dateadded
        ' 
        dateadded.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dateadded.Location = New Point(715, 641)
        dateadded.Name = "dateadded"
        dateadded.Size = New Size(371, 40)
        dateadded.TabIndex = 21
        ' 
        ' combomanufact
        ' 
        combomanufact.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        combomanufact.FormattingEnabled = True
        combomanufact.Location = New Point(715, 756)
        combomanufact.Name = "combomanufact"
        combomanufact.Size = New Size(371, 40)
        combomanufact.TabIndex = 24
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.Black
        Button6.Location = New Point(1140, 112)
        Button6.Name = "Button6"
        Button6.Size = New Size(132, 48)
        Button6.TabIndex = 25
        Button6.Text = "Export "
        Button6.UseVisualStyleBackColor = True
        ' 
        ' txtbrand
        ' 
        txtbrand.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtbrand.Location = New Point(221, 646)
        txtbrand.Name = "txtbrand"
        txtbrand.Size = New Size(372, 35)
        txtbrand.TabIndex = 26
        ' 
        ' txtproduct
        ' 
        txtproduct.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtproduct.Location = New Point(221, 527)
        txtproduct.Name = "txtproduct"
        txtproduct.Size = New Size(372, 39)
        txtproduct.TabIndex = 28
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(847, 151)
        Label9.Name = "Label9"
        Label9.Size = New Size(229, 25)
        Label9.TabIndex = 29
        Label9.Text = "Red - Super Low Stock"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(847, 123)
        Label10.Name = "Label10"
        Label10.Size = New Size(175, 25)
        Label10.TabIndex = 30
        Label10.Text = "Yellow - Warning"
        ' 
        ' Add
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(txtproduct)
        Controls.Add(txtbrand)
        Controls.Add(Button6)
        Controls.Add(combomanufact)
        Controls.Add(dateadded)
        Controls.Add(btnrefresh)
        Controls.Add(txtsearch)
        Controls.Add(Button5)
        Controls.Add(DGV)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(datepick_exp)
        Controls.Add(combocategory)
        Controls.Add(txtquantity)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        Name = "Add"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents combocategory As ComboBox
    Friend WithEvents datepick_exp As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnrefresh As Button
    Friend WithEvents dateadded As DateTimePicker
    Friend WithEvents combomanufact As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents txtbrand As TextBox
    Friend WithEvents txtproduct As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
