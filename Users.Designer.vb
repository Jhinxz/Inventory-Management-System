<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        PictureBox1 = New PictureBox()
        DGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        txtfirstname = New TextBox()
        txtlastname = New TextBox()
        txtpassword = New TextBox()
        txtusername = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        Button5 = New Button()
        txtretype = New TextBox()
        CheckBox1 = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1923, 1045)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DGV
        ' 
        DGV.BackgroundColor = Color.White
        DGV.BorderStyle = BorderStyle.Fixed3D
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DGV.Location = New Point(146, 316)
        DGV.Name = "DGV"
        DGV.RowHeadersVisible = False
        DGV.RowHeadersWidth = 62
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.Size = New Size(764, 418)
        DGV.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "First name"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Last name"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Password"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Username"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        ' 
        ' txtfirstname
        ' 
        txtfirstname.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        txtfirstname.Location = New Point(1152, 192)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(498, 40)
        txtfirstname.TabIndex = 2
        ' 
        ' txtlastname
        ' 
        txtlastname.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        txtlastname.Location = New Point(1152, 303)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(498, 40)
        txtlastname.TabIndex = 3
        ' 
        ' txtpassword
        ' 
        txtpassword.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        txtpassword.Location = New Point(1152, 414)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(498, 40)
        txtpassword.TabIndex = 4
        txtpassword.UseSystemPasswordChar = True
        ' 
        ' txtusername
        ' 
        txtusername.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        txtusername.Location = New Point(1151, 523)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(499, 40)
        txtusername.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(1171, 769)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 52)
        Button1.TabIndex = 10
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(1330, 885)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 54)
        Button2.TabIndex = 11
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(1488, 769)
        Button3.Name = "Button3"
        Button3.Size = New Size(129, 52)
        Button3.TabIndex = 12
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Wheat
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.Black
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(50, 28)
        Button4.Name = "Button4"
        Button4.Size = New Size(152, 50)
        Button4.TabIndex = 13
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(335, 234)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(353, 35)
        TextBox1.TabIndex = 14
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.Font = New Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.Black
        Button5.Location = New Point(776, 224)
        Button5.Name = "Button5"
        Button5.Size = New Size(108, 46)
        Button5.TabIndex = 16
        Button5.Text = "Refresh"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' txtretype
        ' 
        txtretype.Font = New Font("Times New Roman", 14F, FontStyle.Bold)
        txtretype.Location = New Point(1151, 634)
        txtretype.Name = "txtretype"
        txtretype.Size = New Size(499, 40)
        txtretype.TabIndex = 17
        txtretype.UseSystemPasswordChar = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        CheckBox1.Location = New Point(1152, 700)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(44, 45)
        CheckBox1.TabIndex = 19
        CheckBox1.Text = vbCrLf
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Users
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(CheckBox1)
        Controls.Add(txtretype)
        Controls.Add(Button5)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtusername)
        Controls.Add(txtpassword)
        Controls.Add(txtlastname)
        Controls.Add(txtfirstname)
        Controls.Add(DGV)
        Controls.Add(PictureBox1)
        Name = "Users"
        Text = "Form5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents txtretype As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
