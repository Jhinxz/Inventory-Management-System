<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class monitoring
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
        DGV = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DGV
        ' 
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Location = New Point(323, 205)
        DGV.Name = "DGV"
        DGV.RowHeadersWidth = 62
        DGV.Size = New Size(1262, 652)
        DGV.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 50)
        Button1.TabIndex = 1
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1382, 165)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 2
        Button2.Text = "Refresh"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Screenshot_2025_02_27_005506
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(2, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1923, 1054)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' monitoring
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DGV)
        Controls.Add(PictureBox1)
        Name = "monitoring"
        Text = "monitoring"
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
