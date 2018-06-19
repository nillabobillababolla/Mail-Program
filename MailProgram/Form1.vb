Imports OpenPop.Pop3
Imports OpenPop.Mime
Imports System.Data
Imports System.Web
Imports System.Windows




Public Class Form1



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim pop3Client As Pop3Client

        pop3Client = New Pop3Client

        Try
            pop3Client.Connect(txtServer.Text, Integer.Parse(txtPort.Text), cbSSL.Checked)
            pop3Client.Authenticate(txtUser.Text, txtPwd.Text)
        Catch ex As Exception
            MsgBox("uyarı", MsgBoxStyle.Information)
        End Try

        Dim count As Integer = pop3Client.GetMessageCount
        Label1.Text = "Total Emails: " & count.ToString

        Dim dtMessages As DataTable = New DataTable
        dtMessages.Columns.Add("MessageNumber")
        dtMessages.Columns.Add("From")
        dtMessages.Columns.Add("Subject")
        dtMessages.Columns.Add("DateSent")
        dtMessages.Columns.Add("Recvd")
        dtMessages.Columns.Add("Attachcount")
        Dim counter As Integer = 0
        Dim i As Integer = count
        Do While (i >= 1)
            Dim message As Message = pop3Client.GetMessage(i)
            dtMessages.Rows.Add()
            dtMessages.Rows((dtMessages.Rows.Count - 1))("MessageNumber") = i
            dtMessages.Rows((dtMessages.Rows.Count - 1))("From") = message.Headers.From.Address
            dtMessages.Rows((dtMessages.Rows.Count - 1))("Subject") = message.Headers.Subject
            dtMessages.Rows((dtMessages.Rows.Count - 1))("DateSent") = message.Headers.DateSent
            dtMessages.Rows((dtMessages.Rows.Count - 1))("Recvd") = message.Headers.Date
            dtMessages.Rows((dtMessages.Rows.Count - 1))("Attachcount") = message.FindAllAttachments.Count
            'E-mail içeriğini al
            'Eklentiyi al
            For Each msgpart As MessagePart In message.FindAllAttachments
                Dim thefile = msgpart.FileName
                Dim filetype = msgpart.ContentType
                Dim contentid = msgpart.ContentId
                System.IO.File.WriteAllBytes(Application.StartupPath() & "\" & thefile, msgpart.Body)
            Next

            counter = counter + 1
            i = i - 1

            If counter = count.ToString Then
                Exit Do
            End If
        Loop
        gvMail.DataSource = dtMessages
        ' gvMail.DataBindings 

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        FormGonder.Show()


    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub
End Class



