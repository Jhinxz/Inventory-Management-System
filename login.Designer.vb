<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Panel1 = New Panel()
        LinkLabel1 = New LinkLabel()
        CheckBox1 = New CheckBox()
        Button2 = New Button()
        Button1 = New Button()
        txtpassword = New TextBox()
        txtusername = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(txtpassword)
        Panel1.Controls.Add(txtusername)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1088, 624)
        Panel1.TabIndex = 0
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(696, 436)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(133, 21)
        LinkLabel1.TabIndex = 1
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Password?"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Sylfaen", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = Color.White
        CheckBox1.Location = New Point(699, 395)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(22, 21)
        CheckBox1.TabIndex = 7
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Sylfaen", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(835, 478)
        Button2.Name = "Button2"
        Button2.Size = New Size(152, 43)
        Button2.TabIndex = 6
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Sylfaen", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(649, 476)
        Button1.Name = "Button1"
        Button1.Size = New Size(149, 43)
        Button1.TabIndex = 5
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtpassword
        ' 
        txtpassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtpassword.Location = New Point(699, 338)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(232, 31)
        txtpassword.TabIndex = 4
        txtpassword.UseSystemPasswordChar = True
        ' 
        ' txtusername
        ' 
        txtusername.Font = New Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtusername.Location = New Point(700, 237)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(232, 39)
        txtusername.TabIndex = 3
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1092, 624)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "login"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel

End Class
