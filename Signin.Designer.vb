<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signin))
        txtfirstname = New TextBox()
        txtlastname = New TextBox()
        txtusername = New TextBox()
        txtpassword = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        txtpass = New TextBox()
        CheckBox1 = New CheckBox()
        comborole = New ComboBox()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtfirstname
        ' 
        txtfirstname.Font = New Font("Segoe UI", 8F)
        txtfirstname.Location = New Point(634, 178)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(253, 29)
        txtfirstname.TabIndex = 3
        ' 
        ' txtlastname
        ' 
        txtlastname.Font = New Font("Segoe UI", 8F)
        txtlastname.Location = New Point(634, 240)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(253, 29)
        txtlastname.TabIndex = 4
        ' 
        ' txtusername
        ' 
        txtusername.Font = New Font("Segoe UI", 8F)
        txtusername.Location = New Point(634, 355)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(253, 29)
        txtusername.TabIndex = 5
        txtusername.UseSystemPasswordChar = True
        ' 
        ' txtpassword
        ' 
        txtpassword.Font = New Font("Segoe UI", 8F)
        txtpassword.Location = New Point(634, 296)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(253, 29)
        txtpassword.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Button1.Location = New Point(705, 508)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 49)
        Button1.TabIndex = 8
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(15, 16)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 33)
        Button2.TabIndex = 9
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = False
        ' 
        ' txtpass
        ' 
        txtpass.Font = New Font("Segoe UI", 8F)
        txtpass.Location = New Point(634, 413)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(253, 29)
        txtpass.TabIndex = 11
        txtpass.UseSystemPasswordChar = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Sylfaen", 9F)
        CheckBox1.ForeColor = Color.Transparent
        CheckBox1.Location = New Point(545, 516)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(154, 27)
        CheckBox1.TabIndex = 12
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' comborole
        ' 
        comborole.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        comborole.FormattingEnabled = True
        comborole.Location = New Point(634, 459)
        comborole.Name = "comborole"
        comborole.Size = New Size(253, 29)
        comborole.TabIndex = 17
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(comborole)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(txtpass)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(txtpassword)
        Panel1.Controls.Add(txtusername)
        Panel1.Controls.Add(txtlastname)
        Panel1.Controls.Add(txtfirstname)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1093, 624)
        Panel1.TabIndex = 0
        ' 
        ' Signin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1093, 624)
        Controls.Add(Panel1)
        Name = "Signin"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtpass As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents comborole As ComboBox
    Friend WithEvents Panel1 As Panel
End Class
