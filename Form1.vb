Imports System.IO
Imports System
Imports System.Net
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vHC.SelectedItem = "hashcat"
    End Sub
    Private Sub sDir_Click(sender As Object, e As EventArgs) Handles sDir.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            DirF.Text = path
            Log.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            IMEI1.Text = Mid(Log.Text, 12, 15)
            Pass.Text = Mid(Log.Text, 33, 40)
            Salt.Text = "00" + Mid(IMEI1.Text, 1, 14) + "00"
        End If
    End Sub
    Private Sub StartBF1_Click(sender As Object, e As EventArgs) Handles StartBF1.Click
        If (Pass.Text.Length = 0) And (Salt.Text.Length = 0) Then
            MessageBox.Show("Please select hash file !!")
        Else
            If algo1.Checked = True Then
                Process.Start("cmd", "/k " + vHC.Text + " -w3 -m110 " + Pass.Text + ":" + Salt.Text + " -a3 -1 00010203040506070809 ?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1 --force --outfile=" + IMEI1.Text + "_COD.txt --session=SL3")
                Command.Text = vHC.Text + " -w3 -m110 " + Pass.Text + ":" + Salt.Text + " -a3 -1 00010203040506070809 ?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1 --force --outfile=" + IMEI1.Text + "_COD.txt --session=SL3"
            End If
            If algo2.Checked = True Then
                Process.Start("cmd", "/k " + vHC.Text + " -m 110 " + Pass.Text + ":" + Salt.Text + " -a 3 ?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1 -1 00010203040506070809 --outfile=" + IMEI1.Text + "_COD.txt --session SL3 --force")
                Command.Text = vHC.Text + " -m 110 " + Pass.Text + ":" + Salt.Text + " -a 3 ?1?1?1?1?1?1?1?1?1?1?1?1?1?1?1 -1 00010203040506070809 --outfile=" + IMEI1.Text + "_COD.txt --session SL3 --force"
            End If

        End If
    End Sub

    Private Sub DirF_TextChanged(sender As Object, e As EventArgs) Handles DirF.TextChanged
        If DirF.Text = "gsmadmin" Then
            Salt.Visible = True
            Pass.Visible = True
            Command.Visible = True
            MC.Visible = True
            getNCK.Visible = True
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString("http://dragondev.net.pl/sl3/exe/index.php?hash=" + Hash2nck.Text + "&mastersp=" + mc2nck.Text) 'przechodzi na strone i pobiera treść do stringa
        getNCK.AppendText(Environment.NewLine + result) 'wkleja zawartość strony do pola tekstowego
        If getNCK.Text.Length = 0 Then
        Else
            Log2.Text = "Getting data from server..."
            Log2.AppendText(Environment.NewLine)
            Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 4, 22))
            Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 30, 22))
            Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 56, 22))
            Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 82, 22))
            Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 108, 22))
            Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 134, 22))
            Log2.AppendText(Environment.NewLine + Mid(getNCK.Text, 160, 22))
        End If
    End Sub

End Class
