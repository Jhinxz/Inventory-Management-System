<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manufacturer
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
        PictureBox1 = New PictureBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        btnadd = New Button()
        txtmanu = New TextBox()
        Label1 = New Label()
        DGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Button5 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Screenshot_2025_03_16_001828
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(10, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1946, 1050)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.Font = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button4.Image = My.Resources.Resources.backbutton
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(21, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(108, 52)
        Button4.TabIndex = 14
        Button4.Text = "Back"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 16F, FontStyle.Bold)
        Button3.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button3.Location = New Point(1376, 455)
        Button3.Name = "Button3"
        Button3.Size = New Size(154, 59)
        Button3.TabIndex = 13
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 16F, FontStyle.Bold)
        Button2.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button2.Location = New Point(1486, 375)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 59)
        Button2.TabIndex = 12
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnadd
        ' 
        btnadd.Font = New Font("Times New Roman", 16F, FontStyle.Bold)
        btnadd.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        btnadd.Location = New Point(1266, 375)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(154, 59)
        btnadd.TabIndex = 11
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' txtmanu
        ' 
        txtmanu.Font = New Font("Microsoft Sans Serif", 14F)
        txtmanu.Location = New Point(1266, 311)
        txtmanu.Name = "txtmanu"
        txtmanu.Size = New Size(374, 39)
        txtmanu.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label1.Location = New Point(1191, 262)
        Label1.Name = "Label1"
        Label1.Size = New Size(522, 36)
        Label1.TabIndex = 9
        Label1.Text = "NAME OF THE MANUFACTURER"
        ' 
        ' DGV
        ' 
        DGV.BackgroundColor = Color.White
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        DGV.Location = New Point(155, 242)
        DGV.Name = "DGV"
        DGV.RowHeadersVisible = False
        DGV.RowHeadersWidth = 62
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.Size = New Size(648, 591)
        DGV.TabIndex = 8
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "MANUFACTURERS"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Wheat
        Button5.Font = New Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button5.Location = New Point(155, 202)
        Button5.Name = "Button5"
        Button5.Size = New Size(112, 34)
        Button5.TabIndex = 19
        Button5.Text = "Refresh"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Manufacturer
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(btnadd)
        Controls.Add(txtmanu)
        Controls.Add(Label1)
        Controls.Add(DGV)
        Controls.Add(PictureBox1)
        Name = "Manufacturer"
        Text = "Manufacturer"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents txtmanu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Button5 As Button
End Class
