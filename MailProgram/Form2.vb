Imports OpenPop.Pop3
Imports OpenPop.Mime
Imports System.Data
Imports System.Web
Imports System.Windows
Imports SmtpServer
Imports SmtpServer.Mail
Imports System.Net.Mail


Public Class FormGonder
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As New MailMessage()


        msg.From = New MailAddress("samet.alabey@hotmail.com", "Sametalabey4562")

        ' To addresses
        msg.To.Add("samet.alabey@hotmail.com")


        ' You can specify CC and BCC addresses also

        ' Set to high priority
        msg.Priority = MailPriority.High

        msg.Subject = "Hey, a fabulous site!"

        ' You can specify a plain text or HTML contents
        msg.Body =
            "Hello everybody,<br /><br />" &
            "I found an interesting site called <a href=""http:'JustLikeAMagic.WordPress.com"">" &
            "Just Like a Magic</a>. Be sure to visit it soon."
        ' In order for the mail client to interpret message
        ' body correctly, we mark the body as HTML
        ' because we set the body to HTML contents.
        msg.IsBodyHtml = True



        ' Connecting to the server and configuring it
        Dim client As New SmtpClient()
        client.Host = "smtp.live.com"
        client.Port = 578
        client.EnableSsl = True
        ' The server requires user's credentials
        ' not the default credentials
        client.UseDefaultCredentials = False
        ' Provide your credentials
        client.Credentials = New System.Net.NetworkCredential("samet.alabey@hotmail.com", "Sametalabey4562")
        client.DeliveryMethod = SmtpDeliveryMethod.Network


        ' Use SendAsync to send the message asynchronously
        client.Send(msg)
        Label1.Text = "sent"
    End Sub
End Class