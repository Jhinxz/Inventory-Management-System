<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categories
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
        DGV = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        txtcateg = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label5 = New Label()
        TextBox1 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Screenshot_2025_03_10_1140211
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(1, -9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1921, 1047)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DGV
        ' 
        DGV.BackgroundColor = Color.White
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        DGV.Location = New Point(162, 283)
        DGV.Name = "DGV"
        DGV.RowHeadersVisible = False
        DGV.RowHeadersWidth = 62
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.Size = New Size(605, 534)
        DGV.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Resizable = DataGridViewTriState.False
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "CATEGORY"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1318, 319)
        Label1.Name = "Label1"
        Label1.Size = New Size(311, 36)
        Label1.TabIndex = 2
        Label1.Text = "NAME OF CATEGORY"
        ' 
        ' txtcateg
        ' 
        txtcateg.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtcateg.Location = New Point(1249, 397)
        txtcateg.Name = "txtcateg"
        txtcateg.Size = New Size(436, 45)
        txtcateg.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1277, 474)
        Button1.Name = "Button1"
        Button1.Size = New Size(149, 80)
        Button1.TabIndex = 4
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(1497, 474)
        Button2.Name = "Button2"
        Button2.Size = New Size(149, 80)
        Button2.TabIndex = 5
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(1390, 583)
        Button3.Name = "Button3"
        Button3.Size = New Size(149, 80)
        Button3.TabIndex = 6
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Image = My.Resources.Resources.backbutton
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(12, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(104, 63)
        Button4.TabIndex = 7
        Button4.Text = "Back"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button5.Location = New Point(655, 243)
        Button5.Name = "Button5"
        Button5.Size = New Size(112, 34)
        Button5.TabIndex = 22
        Button5.Text = "Refresh"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label5.Location = New Point(162, 204)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 32)
        Label5.TabIndex = 21
        Label5.Text = "Search"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(162, 243)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(321, 31)
        TextBox1.TabIndex = 20
        ' 
        ' Categories
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(Button5)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtcateg)
        Controls.Add(Label1)
        Controls.Add(DGV)
        Controls.Add(PictureBox1)
        Name = "Categories"
        Text = "Form7"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcateg As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
