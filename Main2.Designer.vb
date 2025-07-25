<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main2
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
        Button8 = New Button()
        Button2 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button8.Location = New Point(344, 561)
        Button8.Name = "Button8"
        Button8.Size = New Size(214, 138)
        Button8.TabIndex = 19
        Button8.Text = "Data Management"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Image = My.Resources.Resources.backbutton
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(798, 13)
        Button2.Name = "Button2"
        Button2.Size = New Size(168, 58)
        Button2.TabIndex = 17
        Button2.Text = "Add Report"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Wheat
        Button6.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button6.Location = New Point(27, 738)
        Button6.Name = "Button6"
        Button6.Size = New Size(214, 138)
        Button6.TabIndex = 16
        Button6.Text = "Manage Manufacturer"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Wheat
        Button5.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button5.Location = New Point(27, 560)
        Button5.Name = "Button5"
        Button5.Size = New Size(214, 138)
        Button5.TabIndex = 15
        Button5.Text = "Manage Categories"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImage = My.Resources.Resources.Icons8_Windows_8_Computer_Hardware_Shutdown_512
        Button4.Image = My.Resources.Resources.Logout
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(13, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(52, 68)
        Button4.TabIndex = 14
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button1.Location = New Point(344, 338)
        Button1.Name = "Button1"
        Button1.Size = New Size(214, 138)
        Button1.TabIndex = 12
        Button1.Text = "Manage Products"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Screenshot_2025_03_10_125912
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(1, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1923, 1049)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Main2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(Button8)
        Controls.Add(Button2)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "Main2"
        Text = "Main2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button8 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
