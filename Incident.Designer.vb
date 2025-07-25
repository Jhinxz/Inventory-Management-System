<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Incident
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Incident))
        DGV = New DataGridView()
        txttitle = New TextBox()
        txtdescription = New TextBox()
        picbox = New PictureBox()
        ButtonBrowse = New Button()
        ButtonSubmit = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(picbox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGV
        ' 
        DGV.BackgroundColor = Color.WhiteSmoke
        DGV.BorderStyle = BorderStyle.Fixed3D
        DGV.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Location = New Point(147, 185)
        DGV.Name = "DGV"
        DGV.RowHeadersWidth = 62
        DGV.Size = New Size(762, 389)
        DGV.TabIndex = 0
        ' 
        ' txttitle
        ' 
        txttitle.BackColor = Color.WhiteSmoke
        txttitle.Font = New Font("Sylfaen", 14F, FontStyle.Bold)
        txttitle.Location = New Point(147, 645)
        txttitle.Name = "txttitle"
        txttitle.Size = New Size(405, 44)
        txttitle.TabIndex = 1
        ' 
        ' txtdescription
        ' 
        txtdescription.BackColor = Color.WhiteSmoke
        txtdescription.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtdescription.Location = New Point(147, 745)
        txtdescription.Multiline = True
        txtdescription.Name = "txtdescription"
        txtdescription.Size = New Size(762, 197)
        txtdescription.TabIndex = 2
        ' 
        ' picbox
        ' 
        picbox.BackgroundImageLayout = ImageLayout.Stretch
        picbox.Location = New Point(1229, 302)
        picbox.Name = "picbox"
        picbox.Size = New Size(505, 451)
        picbox.SizeMode = PictureBoxSizeMode.StretchImage
        picbox.TabIndex = 3
        picbox.TabStop = False
        ' 
        ' ButtonBrowse
        ' 
        ButtonBrowse.BackColor = Color.Transparent
        ButtonBrowse.FlatAppearance.BorderColor = Color.SaddleBrown
        ButtonBrowse.Font = New Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonBrowse.ForeColor = Color.Black
        ButtonBrowse.Location = New Point(1415, 928)
        ButtonBrowse.Name = "ButtonBrowse"
        ButtonBrowse.Size = New Size(139, 54)
        ButtonBrowse.TabIndex = 4
        ButtonBrowse.Text = "Browse"
        ButtonBrowse.UseVisualStyleBackColor = False
        ' 
        ' ButtonSubmit
        ' 
        ButtonSubmit.BackColor = Color.Transparent
        ButtonSubmit.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSubmit.ForeColor = Color.Black
        ButtonSubmit.Location = New Point(355, 958)
        ButtonSubmit.Name = "ButtonSubmit"
        ButtonSubmit.Size = New Size(136, 53)
        ButtonSubmit.TabIndex = 5
        ButtonSubmit.Text = "SUBMIT"
        ButtonSubmit.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(49, 31)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 49)
        Button1.TabIndex = 8
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(563, 958)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 53)
        Button2.TabIndex = 9
        Button2.Text = "DELETE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(937, 504)
        Button3.Name = "Button3"
        Button3.Size = New Size(124, 53)
        Button3.TabIndex = 10
        Button3.Text = "Refresh"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(-1, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1925, 1046)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Incident
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ButtonSubmit)
        Controls.Add(ButtonBrowse)
        Controls.Add(picbox)
        Controls.Add(txtdescription)
        Controls.Add(txttitle)
        Controls.Add(DGV)
        Controls.Add(PictureBox1)
        Name = "Incident"
        Text = "Incident"
        WindowState = FormWindowState.Maximized
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        CType(picbox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents txttitle As TextBox
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents picbox As PictureBox
    Friend WithEvents ButtonBrowse As Button
    Friend WithEvents ButtonSubmit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
