Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Net
Public Class forgot
    Dim connectionString As String = "server=localhost;database=users;username=root;password="
    Dim verificationCode As String
    Dim userEmail As String

    Private Function GenerateCode() As String
        Dim rand As New Random()
        Return rand.Next(100000, 999999).ToString()
    End Function

    Private Sub SendEmail(email As String, code As String)
        Try
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            smtpServer.Port = 587
            smtpServer.Credentials = New NetworkCredential("jhirorosales46@gmail.com", "ofdf mmts jwps nfzf")
            smtpServer.EnableSsl = True

            Dim mail As New MailMessage()
            mail.From = New MailAddress("jhirorosales46@gmail.com")
            mail.To.Add(email)
            mail.Subject = "Password Reset Verification Code"
            mail.Body = "Your verification code is: " & code

            smtpServer.Send(mail)
            MessageBox.Show("Verification code sent to " & email, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub forgot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonSendCode_Click(sender As Object, e As EventArgs) Handles ButtonSendCode.Click
        Try
            Using conn As New MySqlConnection("server=localhost;database=users;username=root;password=")
                conn.Open()
                Dim query As String = "SELECT * FROM `accounts` WHERE `Username` = @Username"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", txtusername.Text)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        userEmail = reader("Username").ToString()
                        verificationCode = GenerateCode()
                        SendEmail(userEmail, verificationCode)
                    Else
                        MessageBox.Show("Username not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonVerifyCode_Click(sender As Object, e As EventArgs) Handles ButtonVerifyCode.Click
        If txtcode.Text = verificationCode Then
            Dim newPassword As String = InputBox("Enter new password:", "Reset Password")

            If Not String.IsNullOrWhiteSpace(newPassword) Then
                Try
                    Using conn As New MySqlConnection(connectionString)
                        conn.Open()
                        Dim query As String = "UPDATE `accounts` SET `Password`=@Password WHERE `Username`=@Username"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@Password", newPassword)
                            cmd.Parameters.AddWithValue("@Username", userEmail)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    login.Show()
                    Me.hide
                Catch ex As Exception
                    MessageBox.Show("Error updating password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Invalid verification code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login.Show()
        Me.Hide()

    End Sub
End Class