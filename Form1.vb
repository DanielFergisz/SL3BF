Imports System.IO
Imports System
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vHC.SelectedItem = "hashcat"
    End Sub
    Private Sub sDir_Click(sender As Object, e As EventArgs) Handles sDir.Click
        OpenFileDialog1.ShowDialog()
        If DialogResult.OK Then
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
        OpenFileDialog2.ShowDialog()
        If DialogResult.OK Then
            MC.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog2.FileName)
            Log.Text = "Master Code: " + Mid(MC.Text, 66, 30)
        End If
    End Sub
End Class
