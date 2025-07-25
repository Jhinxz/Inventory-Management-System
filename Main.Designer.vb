<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button2 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1923, 1049)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(401, 209)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 91)
        Button1.TabIndex = 2
        Button1.Text = "Manage Products"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Control
        Button3.Font = New Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(406, 787)
        Button3.Name = "Button3"
        Button3.Size = New Size(156, 88)
        Button3.TabIndex = 4
        Button3.Text = "User Management"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.White
        Button4.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(100, 24)
        Button4.Name = "Button4"
        Button4.Size = New Size(161, 92)
        Button4.TabIndex = 5
        Button4.Text = "Logout"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Wheat
        Button5.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button5.Location = New Point(26, 559)
        Button5.Name = "Button5"
        Button5.Size = New Size(214, 138)
        Button5.TabIndex = 6
        Button5.Text = "Manage Categories"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Wheat
        Button6.Font = New Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button6.Location = New Point(26, 737)
        Button6.Name = "Button6"
        Button6.Size = New Size(214, 138)
        Button6.TabIndex = 7
        Button6.Text = "Manage Manufacturer"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(406, 510)
        Button2.Name = "Button2"
        Button2.Size = New Size(156, 87)
        Button2.TabIndex = 8
        Button2.Text = "Incident Report"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.BackColor = SystemColors.Control
        Button7.Font = New Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.Location = New Point(406, 648)
        Button7.Name = "Button7"
        Button7.Size = New Size(151, 92)
        Button7.TabIndex = 9
        Button7.Text = "Monitor"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.White
        Button8.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.Black
        Button8.Location = New Point(405, 359)
        Button8.Name = "Button8"
        Button8.Size = New Size(156, 97)
        Button8.TabIndex = 10
        Button8.Text = "Data Management"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1050)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button2)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        Name = "Main"
        Text = " "
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
