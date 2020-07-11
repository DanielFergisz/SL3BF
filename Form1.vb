Imports System.IO
Imports System
Imports System.Net
Imports System.Net.Mail

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vHC.SelectedItem = "hashcat"
        numPC.SelectedItem = "1"
        If My.Computer.FileSystem.FileExists("Mail_Data.tds") Then
            mailData.LoadFile("Mail_Data.tds", RichTextBoxStreamType.PlainText)
            M1.Text = mailData.Lines(0)
            M2.Text = mailData.Lines(1)
            M3.Text = mailData.Lines(2)
            M4.Text = mailData.Lines(3)
            M5.Text = mailData.Lines(4)
            M6.Text = mailData.Lines(5)
            M7.Text = mailData.Lines(6)
        End If
    End Sub
    Private Sub sDir_Click(sender As Object, e As EventArgs) Handles sDir.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            DirF.Text = path
            If DirF.Text.Contains(".bcl") Then
                Log.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                IMEI1.Text = Mid(Log.Text, 12, 15)
                Pass.Text = Mid(Log.Text, 33, 40)
                Salt.Text = "00" + Mid(IMEI1.Text, 1, 14) + "00"
            End If
            If DirF.Text.Contains(".log") Then
                Log.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
                IMEI1.Text = Mid(Log.Text, 1, 15)
                Pass.Text = Mid(Log.Text, 17, 40)
                Salt.Text = "00" + Mid(IMEI1.Text, 1, 14) + "00"
            End If
        End If
    End Sub
    Private Sub StartBF1_Click(sender As Object, e As EventArgs) Handles StartBF1.Click
        Dim Commv1 As String
        Commv1 = vHC.Text + " -w3 -m110 " + Pass.Text + ":" + Salt.Text + " -a3 -1 00010203040506070809 ?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1 --force --outfile=" + IMEI1.Text + "\" + IMEI1.Text + "_COD.txt --session=SL3"
        Dim Commv2 As String
        Commv2 = vHC.Text + " -m 110 " + Pass.Text + ":" + Salt.Text + " -a 3 ?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1 -1 00010203040506070809 --outfile=" + IMEI1.Text + "\" + IMEI1.Text + "_COD.txt --session SL3 --force"
        Dim ksMax As String
        ksMax = "1000000000000"
        Dim ks2 As String
        ks2 = "500000000000"
        Dim ks3 As String
        ks3 = "333333333334"
        Dim ks31 As String
        ks31 = "666666666668"

        If (Pass.Text.Length = 0) And (Salt.Text.Length = 0) Then
            MessageBox.Show("Please select hash file !!")
        Else
            If Directory.Exists(IMEI1.Text) Then
            Else
                Directory.CreateDirectory(IMEI1.Text)
            End If

            If algo1.Checked = True Then

                If numPC.SelectedItem = "1" Then
                    Process.Start("cmd", "/k " + Commv1)
                    Command.Text = Commv1
                End If
                If numPC.SelectedItem = "2" And pcV.SelectedItem = "1" Then
                    Process.Start("cmd", "/k " + Commv1 + " -s 0 -l " + ks2)
                    Command.Text = Commv1 + " -s 0 -l " + ks2
                End If
                If numPC.SelectedItem = "2" And pcV.SelectedItem = "2" Then
                    Process.Start("cmd", "/k " + Commv1 + " -s " + ks2 + " -l " + ksMax)
                    Command.Text = Commv1 + " -s " + ks2 + " -l " + ksMax
                End If

                If numPC.SelectedItem = "3" And pcV.SelectedItem = "1" Then
                    Process.Start("cmd", "/k " + Commv1 + " -s 0 -l " + ks3)
                    Command.Text = Commv1 + " -s 0 -l " + ks3
                End If
                If numPC.SelectedItem = "3" And pcV.SelectedItem = "2" Then
                    Process.Start("cmd", "/k " + Commv1 + " -s " + ks3 + " -l " + ks31)
                    Command.Text = Commv1 + " -s " + ks3 + " -l " + ks31
                End If
                If numPC.SelectedItem = "3" And pcV.SelectedItem = "3" Then
                    Process.Start("cmd", "/k " + Commv1 + " -s " + ks31 + " -l " + ksMax)
                    Command.Text = Commv1 + " -s " + ks31 + " -l " + ksMax
                End If
            End If

            If algo2.Checked = True Then
                If numPC.SelectedItem = "1" Then
                    Process.Start("cmd", "/k " + Commv2)
                    Command.Text = Commv2
                End If
                If numPC.SelectedItem = "2" And pcV.SelectedItem = "1" Then
                    Process.Start("cmd", "/k " + Commv2 + " -s 0 -l " + ks2)
                    Command.Text = Commv2 + " -s 0 -l " + ks2
                End If
                If numPC.SelectedItem = "2" And pcV.SelectedItem = "2" Then
                    Process.Start("cmd", "/k " + Commv2 + " -s " + ks2 + " -l " + ksMax)
                    Command.Text = Commv2 + " -s " + ks2 + " -l " + ksMax
                End If

                If numPC.SelectedItem = "3" And pcV.SelectedItem = "1" Then
                    Process.Start("cmd", "/k " + Commv2 + " -s 0 -l " + ks3)
                    Command.Text = Commv2 + " -s 0 -l " + ks3
                End If
                If numPC.SelectedItem = "3" And pcV.SelectedItem = "2" Then
                    Process.Start("cmd", "/k " + Commv2 + " -s " + ks3 + " -l " + ks31)
                    Command.Text = Commv2 + " -s " + ks3 + " -l " + ks31
                End If
                If numPC.SelectedItem = "3" And pcV.SelectedItem = "3" Then
                    Process.Start("cmd", "/k " + Commv2 + " -s " + ks31 + " -l " + ksMax)
                    Command.Text = Commv2 + " -s " + ks31 + " -l " + ksMax
                End If
            End If

            If M1.Text.Length = 0 Or M2.Text.Length = 0 Or M3.Text.Length = 0 Or M4.Text.Length = 0 Or M5.Text.Length = 0 Or M6.Text.Length = 0 Or M7.Text.Length = 0 Then
            Else
                fileCodCheck.Enabled = True
                manualCheck.BackColor = Color.Yellow
            End If
        End If
    End Sub

    Private Sub DirF_TextChanged(sender As Object, e As EventArgs) Handles DirF.TextChanged
        If DirF.Text = "gsmadmin" Then
            Me.AutoSize = False
            Salt.Visible = True
            Pass.Visible = True
            Command.Visible = True
            MC.Visible = True
            MC2.Visible = True
            getNCK.Visible = True
            mailData.Visible = True
            DirF.Clear()
        End If
        If DirF.Text = "tlod" Then
            manualCheck.Visible = True
            DirF.Clear()
        End If
    End Sub
    Private Sub StartBF2_Click(sender As Object, e As EventArgs) Handles StartBF2.Click
        If (Pass2.Text.Length = 0) And (Salt2.Text.Length = 0) Then
            MessageBox.Show("Salt and Pass cannot be empty !!")
        Else
            Process.Start("cmd", "/k " + vHC.Text + " -w3 -m110 " + Pass2.Text + ":" + Salt2.Text + " -a3 -1 00010203040506070809 ?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1 --force --outfile=" + FileName1.Text + "_COD.txt --session=SL3")
        End If
    End Sub

    Private Sub bench1_Click(sender As Object, e As EventArgs) Handles bench1.Click
        Process.Start("cmd", "/k " + vHC.Text + " -b")
    End Sub

    Private Sub help1_Click(sender As Object, e As EventArgs) Handles help1.Click
        Process.Start("cmd", "/k " + vHC.Text + " --help")
    End Sub

    Private Sub Restore_Click(sender As Object, e As EventArgs) Handles Restore.Click
        Process.Start("cmd", "/k " + vHC.Text + " --session=SL3 --restore")
    End Sub

    Private Sub Exe1_Click(sender As Object, e As EventArgs) Handles Exe1.Click
        Process.Start("cmd", "/k " + cmd1.Text)
        Log.Text = "Benchmark Start.."
    End Sub

    Private Sub GetMC_Click(sender As Object, e As EventArgs) Handles GetMC.Click
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            MC.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog2.FileName)
            Log.Clear()
            Log.Text = "Reading data.."
            Log.AppendText(Environment.NewLine + "Master Code: ")
            Log.SelectionColor = Color.DarkBlue
            Log.AppendText(Mid(MC.Text, 66, 30))
            Log.SelectionColor = Color.Empty
            Log.AppendText(Environment.NewLine + "Hash: " + Mid(MC.Text, 1, 40))
        End If
    End Sub

    Private Sub genCod2NCK_Click(sender As Object, e As EventArgs) Handles genCod2NCK.Click
        If mc2nck.Text.Length = 0 Or Hash2nck.Text.Length = 0 Then
            Log2.Text = "Please enter Master Code and Hash !!"
        Else
            Dim webClient As New System.Net.WebClient
            Dim result As String = webClient.DownloadString("http://repairbox.pl/sl3/exe/index.php?hash=" + Hash2nck.Text + "&mastersp=" + mc2nck.Text) 'przechodzi na strone i pobiera treść do stringa
            getNCK.Clear()
            Log2.Text = "Getting data from server..."
            getNCK.AppendText(Environment.NewLine + result) 'wkleja zawartość strony do pola tekstowego
            If getNCK.Text.Length = 0 Then
            Else
                Log2.AppendText(Environment.NewLine)
                Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 4, 22))
                Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 30, 22))
                Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 56, 22))
                Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 82, 22))
                Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 108, 22))
                Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 134, 22))
                Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 160, 22))
            End If
        End If
    End Sub

    Private Sub getData_F_Click(sender As Object, e As EventArgs) Handles getData_F.Click
        Hash2nck.Text = Mid(MC.Text, 1, 40)
        mc2nck.Text = Mid(MC.Text, 66, 30)
    End Sub

    Private Sub saveMailData_Click(sender As Object, e As EventArgs) Handles saveMailData.Click
        If M1.Text.Length = 0 Or M2.Text.Length = 0 Or M3.Text.Length = 0 Or M4.Text.Length = 0 Or M5.Text.Length = 0 Or M6.Text.Length = 0 Or M7.Text.Length = 0 Then
            MsgBox("Please check all textbox !!")
        Else
            If My.Computer.FileSystem.FileExists("Mail_Data.tds") Then
                My.Computer.FileSystem.DeleteFile("Mail_Data.tds")
                My.Computer.FileSystem.WriteAllText("Mail_Data.tds", M1.Text + vbCrLf + M2.Text + vbCrLf + M3.Text + vbCrLf + M4.Text + vbCrLf + M5.Text + vbCrLf + M6.Text + vbCrLf + M7.Text, True)
                mailData.Clear()
                mailData.LoadFile("Mail_Data.tds", RichTextBoxStreamType.PlainText)
                TimerSaveOk.Enabled = True
                saveInfo.Visible = True
            Else
                My.Computer.FileSystem.WriteAllText("Mail_Data.tds", M1.Text + vbCrLf + M2.Text + vbCrLf + M3.Text + vbCrLf + M4.Text + vbCrLf + M5.Text + vbCrLf + M6.Text + vbCrLf + M7.Text, True)
                mailData.Clear()
                mailData.LoadFile("Mail_Data.tds", RichTextBoxStreamType.PlainText)
                TimerSaveOk.Enabled = True
                saveInfo.Visible = True
            End If
        End If
    End Sub

    Private Sub clearMailConfig_Click(sender As Object, e As EventArgs) Handles clearMailConfig.Click
        If My.Computer.FileSystem.FileExists("Mail_Data.tds") Then
            My.Computer.FileSystem.DeleteFile("Mail_Data.tds")
            mailData.Clear()
            M1.Clear()
            M2.Clear()
            M3.Clear()
            M4.Clear()
            M5.Clear()
            M6.Clear()
            M7.Clear()
        Else
        End If
    End Sub

    Private Sub TimerSaveOk_Tick(sender As Object, e As EventArgs) Handles TimerSaveOk.Tick
        TimerSaveOk.Enabled = False
        saveInfo.Visible = False
    End Sub

    Private Sub fileCodCheck_Tick(sender As Object, e As EventArgs) Handles fileCodCheck.Tick
        If My.Computer.FileSystem.FileExists(IMEI1.Text + "\" + IMEI1.Text + "_COD.txt") Then
            fileCodCheck.Enabled = False

            '***********************************************************************************************************************
            Try
                Dim mailfrom As New MailAddress(M1.Text, "SL3BF") ' adres mail do wysyłki + nazwa
                Dim mailto As New MailAddress(M2.Text, "D2") ' adres docelowy + nazwa
                Dim message As New MailMessage(mailfrom, mailto)
                Dim smtp As New SmtpClient(M3.Text) 'serwer smtp
                Dim zaloncznik As String
                zaloncznik = IMEI1.Text + "\" + IMEI1.Text + "_COD.txt" 'nazwa pliku
                If File.Exists(zaloncznik) Then
                    Dim data As New Attachment(zaloncznik)
                    message.Attachments.Add(data)
                End If

                message.Subject = M6.Text 'temat wiadomości


                message.BodyEncoding = System.Text.Encoding.UTF8
                message.Body = M7.Text 'tekst wiadomości

                smtp.Credentials = New NetworkCredential(M4.Text, M5.Text) 'login i hasło

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network

                smtp.Send(message)

                Log.AppendText(Environment.NewLine)
                Log.AppendText(Environment.NewLine + "Mail has been sent")


            Catch ex As SmtpException
                Log.AppendText(Environment.NewLine + ex.Message)
            End Try

            MC2.LoadFile(IMEI1.Text + "\" + IMEI1.Text + "_COD.txt", RichTextBoxStreamType.PlainText)
            Log.AppendText(Environment.NewLine + "Reading data...")
            Log.AppendText(Environment.NewLine)
            Log.AppendText(Environment.NewLine + "Master Code: ")
            Log.SelectionColor = Color.DarkBlue
            Log.AppendText(Mid(MC2.Text, 66, 30))
            Log.SelectionColor = Color.Empty
            Log.AppendText(Environment.NewLine + "Hash: " + Mid(MC2.Text, 1, 40))
            Hash2nck.Text = Mid(MC2.Text, 1, 40)
            mc2nck.Text = Mid(MC2.Text, 66, 30)
            nckC.Enabled = True
        Else
            If manualCheck.BackColor = Color.Yellow Then
                manualCheck.BackColor = Color.Green
            Else
                If manualCheck.BackColor = Color.Green Then
                    manualCheck.BackColor = Color.Red
                Else
                    If manualCheck.BackColor = Color.Red Then
                        manualCheck.BackColor = Color.Yellow
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub manualCheck_Click(sender As Object, e As EventArgs) Handles manualCheck.Click
        fileCodCheck.Enabled = True
        manualCheck.BackColor = Color.Yellow
    End Sub
    Private Sub numPC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numPC.SelectedIndexChanged
        If numPC.SelectedItem = "1" Then
            pcV.Items.Clear()
        End If
        If numPC.SelectedItem = "2" Then
            pcV.Items.Clear()
            pcV.Items.Add("1")
            pcV.Items.Add("2")
            pcV.SelectedItem = "1"
        End If
        If numPC.SelectedItem = "3" Then
            pcV.Items.Clear()
            pcV.Items.Add("1")
            pcV.Items.Add("2")
            pcV.Items.Add("3")
            pcV.SelectedItem = "1"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles nckC.Tick
        nckC.Enabled = False
        genCod2NCK_Click(Nothing, Nothing)
        Log.AppendText(Environment.NewLine)
        Log.AppendText(Environment.NewLine + Log2.Text)
        My.Computer.FileSystem.WriteAllText(IMEI1.Text + "\" + IMEI1.Text + "_NCK.txt", Log2.Text, True)
    End Sub
End Class
