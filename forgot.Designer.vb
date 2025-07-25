<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forgot))
        txtusername = New TextBox()
        txtcode = New TextBox()
        ButtonSendCode = New Button()
        ButtonVerifyCode = New Button()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtusername
        ' 
        txtusername.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtusername.Location = New Point(261, 270)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(228, 29)
        txtusername.TabIndex = 0
        ' 
        ' txtcode
        ' 
        txtcode.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtcode.Location = New Point(261, 337)
        txtcode.Name = "txtcode"
        txtcode.Size = New Size(228, 29)
        txtcode.TabIndex = 1
        ' 
        ' ButtonSendCode
        ' 
        ButtonSendCode.BackColor = Color.Transparent
        ButtonSendCode.FlatStyle = FlatStyle.Flat
        ButtonSendCode.Font = New Font("Sylfaen", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSendCode.Location = New Point(529, 269)
        ButtonSendCode.Name = "ButtonSendCode"
        ButtonSendCode.Size = New Size(63, 27)
        ButtonSendCode.TabIndex = 2
        ButtonSendCode.Text = "Send Code"
        ButtonSendCode.UseVisualStyleBackColor = False
        ' 
        ' ButtonVerifyCode
        ' 
        ButtonVerifyCode.BackColor = Color.Transparent
        ButtonVerifyCode.FlatStyle = FlatStyle.Flat
        ButtonVerifyCode.Font = New Font("Sylfaen", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonVerifyCode.Location = New Point(520, 337)
        ButtonVerifyCode.Name = "ButtonVerifyCode"
        ButtonVerifyCode.Size = New Size(72, 29)
        ButtonVerifyCode.TabIndex = 3
        ButtonVerifyCode.Text = "Verify"
        ButtonVerifyCode.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(855, 495)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 51)
        Button1.TabIndex = 8
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' forgot
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(857, 498)
        Controls.Add(Button1)
        Controls.Add(ButtonVerifyCode)
        Controls.Add(ButtonSendCode)
        Controls.Add(txtcode)
        Controls.Add(txtusername)
        Controls.Add(PictureBox1)
        Name = "forgot"
        Text = "forgot"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtcode As TextBox
    Friend WithEvents ButtonSendCode As Button
    Friend WithEvents ButtonVerifyCode As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
