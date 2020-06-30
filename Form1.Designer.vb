<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.vHC = New System.Windows.Forms.ComboBox()
        Me.IMEI1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GetMC = New System.Windows.Forms.Button()
        Me.Restore = New System.Windows.Forms.Button()
        Me.StartBF1 = New System.Windows.Forms.Button()
        Me.Log = New System.Windows.Forms.RichTextBox()
        Me.sDir = New System.Windows.Forms.Button()
        Me.DirF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.Exe1 = New System.Windows.Forms.Button()
        Me.cmd1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FileName1 = New System.Windows.Forms.TextBox()
        Me.Salt2 = New System.Windows.Forms.TextBox()
        Me.Pass2 = New System.Windows.Forms.TextBox()
        Me.StartBF2 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mc2nck = New System.Windows.Forms.TextBox()
        Me.Hash2nck = New System.Windows.Forms.TextBox()
        Me.Command = New System.Windows.Forms.TextBox()
        Me.Salt = New System.Windows.Forms.TextBox()
        Me.Pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.bench1 = New System.Windows.Forms.Button()
        Me.help1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.RB1 = New System.Windows.Forms.GroupBox()
        Me.algo2 = New System.Windows.Forms.RadioButton()
        Me.algo1 = New System.Windows.Forms.RadioButton()
        Me.MC = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Log2 = New System.Windows.Forms.RichTextBox()
        Me.getNCK = New System.Windows.Forms.RichTextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gb1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.RB1.SuspendLayout()
        Me.SuspendLayout()
        '
        'vHC
        '
        Me.vHC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vHC.FormattingEnabled = True
        Me.vHC.Items.AddRange(New Object() {"hashcat", "hashcat32", "hashcat64"})
        Me.vHC.Location = New System.Drawing.Point(12, 12)
        Me.vHC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.vHC.Name = "vHC"
        Me.vHC.Size = New System.Drawing.Size(121, 24)
        Me.vHC.TabIndex = 0
        '
        'IMEI1
        '
        Me.IMEI1.Enabled = False
        Me.IMEI1.Location = New System.Drawing.Point(607, 24)
        Me.IMEI1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IMEI1.Name = "IMEI1"
        Me.IMEI1.Size = New System.Drawing.Size(179, 22)
        Me.IMEI1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 48)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 390)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GetMC)
        Me.TabPage1.Controls.Add(Me.Restore)
        Me.TabPage1.Controls.Add(Me.StartBF1)
        Me.TabPage1.Controls.Add(Me.Log)
        Me.TabPage1.Controls.Add(Me.sDir)
        Me.TabPage1.Controls.Add(Me.DirF)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(768, 361)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "File"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GetMC
        '
        Me.GetMC.Location = New System.Drawing.Point(52, 321)
        Me.GetMC.Name = "GetMC"
        Me.GetMC.Size = New System.Drawing.Size(136, 32)
        Me.GetMC.TabIndex = 9
        Me.GetMC.Text = "Get Master Code"
        Me.GetMC.UseVisualStyleBackColor = True
        '
        'Restore
        '
        Me.Restore.Location = New System.Drawing.Point(579, 321)
        Me.Restore.Margin = New System.Windows.Forms.Padding(4)
        Me.Restore.Name = "Restore"
        Me.Restore.Size = New System.Drawing.Size(136, 32)
        Me.Restore.TabIndex = 8
        Me.Restore.Text = "Restore"
        Me.Restore.UseVisualStyleBackColor = True
        '
        'StartBF1
        '
        Me.StartBF1.Location = New System.Drawing.Point(253, 318)
        Me.StartBF1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartBF1.Name = "StartBF1"
        Me.StartBF1.Size = New System.Drawing.Size(261, 38)
        Me.StartBF1.TabIndex = 4
        Me.StartBF1.Text = "Start BF"
        Me.StartBF1.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Log.Location = New System.Drawing.Point(27, 69)
        Me.Log.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Log.Name = "Log"
        Me.Log.ReadOnly = True
        Me.Log.Size = New System.Drawing.Size(708, 242)
        Me.Log.TabIndex = 3
        Me.Log.Text = ""
        '
        'sDir
        '
        Me.sDir.Location = New System.Drawing.Point(709, 18)
        Me.sDir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sDir.Name = "sDir"
        Me.sDir.Size = New System.Drawing.Size(36, 23)
        Me.sDir.TabIndex = 2
        Me.sDir.Text = "..."
        Me.sDir.UseVisualStyleBackColor = True
        '
        'DirF
        '
        Me.DirF.Location = New System.Drawing.Point(92, 18)
        Me.DirF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DirF.Name = "DirF"
        Me.DirF.Size = New System.Drawing.Size(600, 22)
        Me.DirF.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hash File:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gb1)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.FileName1)
        Me.TabPage2.Controls.Add(Me.Salt2)
        Me.TabPage2.Controls.Add(Me.Pass2)
        Me.TabPage2.Controls.Add(Me.StartBF2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(768, 361)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Manual"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.Exe1)
        Me.gb1.Controls.Add(Me.cmd1)
        Me.gb1.Location = New System.Drawing.Point(27, 218)
        Me.gb1.Margin = New System.Windows.Forms.Padding(4)
        Me.gb1.Name = "gb1"
        Me.gb1.Padding = New System.Windows.Forms.Padding(4)
        Me.gb1.Size = New System.Drawing.Size(716, 63)
        Me.gb1.TabIndex = 7
        Me.gb1.TabStop = False
        Me.gb1.Text = "Command"
        '
        'Exe1
        '
        Me.Exe1.Location = New System.Drawing.Point(616, 21)
        Me.Exe1.Margin = New System.Windows.Forms.Padding(4)
        Me.Exe1.Name = "Exe1"
        Me.Exe1.Size = New System.Drawing.Size(92, 28)
        Me.Exe1.TabIndex = 1
        Me.Exe1.Text = "Send"
        Me.Exe1.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(8, 23)
        Me.cmd1.Margin = New System.Windows.Forms.Padding(4)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(599, 22)
        Me.cmd1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Output File Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Salt:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hash:"
        '
        'FileName1
        '
        Me.FileName1.Location = New System.Drawing.Point(145, 89)
        Me.FileName1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FileName1.Name = "FileName1"
        Me.FileName1.Size = New System.Drawing.Size(193, 22)
        Me.FileName1.TabIndex = 3
        '
        'Salt2
        '
        Me.Salt2.Location = New System.Drawing.Point(68, 57)
        Me.Salt2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Salt2.Name = "Salt2"
        Me.Salt2.Size = New System.Drawing.Size(305, 22)
        Me.Salt2.TabIndex = 2
        '
        'Pass2
        '
        Me.Pass2.Location = New System.Drawing.Point(68, 25)
        Me.Pass2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pass2.MaxLength = 40
        Me.Pass2.Name = "Pass2"
        Me.Pass2.Size = New System.Drawing.Size(673, 22)
        Me.Pass2.TabIndex = 1
        '
        'StartBF2
        '
        Me.StartBF2.Location = New System.Drawing.Point(236, 315)
        Me.StartBF2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartBF2.Name = "StartBF2"
        Me.StartBF2.Size = New System.Drawing.Size(289, 39)
        Me.StartBF2.TabIndex = 0
        Me.StartBF2.Text = "Start BF"
        Me.StartBF2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Log2)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.mc2nck)
        Me.TabPage3.Controls.Add(Me.Hash2nck)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(768, 361)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "COD2NCK"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 47)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Generate ->"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Master Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Hash:"
        '
        'mc2nck
        '
        Me.mc2nck.Location = New System.Drawing.Point(134, 49)
        Me.mc2nck.Name = "mc2nck"
        Me.mc2nck.Size = New System.Drawing.Size(280, 22)
        Me.mc2nck.TabIndex = 1
        '
        'Hash2nck
        '
        Me.Hash2nck.Location = New System.Drawing.Point(134, 21)
        Me.Hash2nck.Name = "Hash2nck"
        Me.Hash2nck.Size = New System.Drawing.Size(519, 22)
        Me.Hash2nck.TabIndex = 0
        '
        'Command
        '
        Me.Command.Location = New System.Drawing.Point(50, 469)
        Me.Command.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Command.Name = "Command"
        Me.Command.Size = New System.Drawing.Size(681, 22)
        Me.Command.TabIndex = 7
        Me.Command.Visible = False
        '
        'Salt
        '
        Me.Salt.Location = New System.Drawing.Point(538, 497)
        Me.Salt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Salt.Name = "Salt"
        Me.Salt.Size = New System.Drawing.Size(193, 22)
        Me.Salt.TabIndex = 6
        Me.Salt.Visible = False
        '
        'Pass
        '
        Me.Pass.Location = New System.Drawing.Point(50, 497)
        Me.Pass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(481, 22)
        Me.Pass.TabIndex = 5
        Me.Pass.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(563, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "IMEI:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Infinity files|*.bcl|All files|*.*|Text files|*.txt"
        '
        'bench1
        '
        Me.bench1.Location = New System.Drawing.Point(161, 23)
        Me.bench1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bench1.Name = "bench1"
        Me.bench1.Size = New System.Drawing.Size(103, 27)
        Me.bench1.TabIndex = 7
        Me.bench1.Text = "Benchmark"
        Me.bench1.UseVisualStyleBackColor = True
        '
        'help1
        '
        Me.help1.Location = New System.Drawing.Point(269, 23)
        Me.help1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.help1.Name = "help1"
        Me.help1.Size = New System.Drawing.Size(75, 27)
        Me.help1.TabIndex = 8
        Me.help1.Text = "Help"
        Me.help1.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.Controls.Add(Me.algo2)
        Me.RB1.Controls.Add(Me.algo1)
        Me.RB1.Location = New System.Drawing.Point(367, 7)
        Me.RB1.Margin = New System.Windows.Forms.Padding(4)
        Me.RB1.Name = "RB1"
        Me.RB1.Padding = New System.Windows.Forms.Padding(4)
        Me.RB1.Size = New System.Drawing.Size(176, 54)
        Me.RB1.TabIndex = 9
        Me.RB1.TabStop = False
        Me.RB1.Text = "algo"
        '
        'algo2
        '
        Me.algo2.AutoSize = True
        Me.algo2.Location = New System.Drawing.Point(105, 23)
        Me.algo2.Margin = New System.Windows.Forms.Padding(4)
        Me.algo2.Name = "algo2"
        Me.algo2.Size = New System.Drawing.Size(44, 21)
        Me.algo2.TabIndex = 1
        Me.algo2.TabStop = True
        Me.algo2.Text = "v2"
        Me.algo2.UseVisualStyleBackColor = True
        '
        'algo1
        '
        Me.algo1.AutoSize = True
        Me.algo1.Checked = True
        Me.algo1.Location = New System.Drawing.Point(36, 23)
        Me.algo1.Margin = New System.Windows.Forms.Padding(4)
        Me.algo1.Name = "algo1"
        Me.algo1.Size = New System.Drawing.Size(44, 21)
        Me.algo1.TabIndex = 0
        Me.algo1.TabStop = True
        Me.algo1.Text = "v1"
        Me.algo1.UseVisualStyleBackColor = True
        '
        'MC
        '
        Me.MC.Location = New System.Drawing.Point(50, 442)
        Me.MC.Name = "MC"
        Me.MC.Size = New System.Drawing.Size(681, 22)
        Me.MC.TabIndex = 10
        Me.MC.Visible = False
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "Text files|*.txt|All files|*.*"
        '
        'Log2
        '
        Me.Log2.Location = New System.Drawing.Point(28, 175)
        Me.Log2.Name = "Log2"
        Me.Log2.Size = New System.Drawing.Size(711, 174)
        Me.Log2.TabIndex = 5
        Me.Log2.Text = ""
        '
        'getNCK
        '
        Me.getNCK.Location = New System.Drawing.Point(48, 534)
        Me.getNCK.Name = "getNCK"
        Me.getNCK.Size = New System.Drawing.Size(682, 185)
        Me.getNCK.TabIndex = 11
        Me.getNCK.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 849)
        Me.Controls.Add(Me.getNCK)
        Me.Controls.Add(Me.IMEI1)
        Me.Controls.Add(Me.MC)
        Me.Controls.Add(Me.RB1)
        Me.Controls.Add(Me.help1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Command)
        Me.Controls.Add(Me.bench1)
        Me.Controls.Add(Me.Salt)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.vHC)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SL3BF v1.02"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.RB1.ResumeLayout(False)
        Me.RB1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vHC As ComboBox
    Friend WithEvents IMEI1 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents sDir As Button
    Friend WithEvents DirF As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents StartBF1 As Button
    Friend WithEvents Log As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FileName1 As TextBox
    Friend WithEvents Salt2 As TextBox
    Friend WithEvents Pass2 As TextBox
    Friend WithEvents StartBF2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Salt As TextBox
    Friend WithEvents Pass As TextBox
    Friend WithEvents help1 As Button
    Friend WithEvents bench1 As Button
    Friend WithEvents Command As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Restore As Button
    Friend WithEvents RB1 As GroupBox
    Friend WithEvents algo2 As RadioButton
    Friend WithEvents algo1 As RadioButton
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents Exe1 As Button
    Friend WithEvents cmd1 As TextBox
    Friend WithEvents GetMC As Button
    Friend WithEvents MC As TextBox
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mc2nck As TextBox
    Friend WithEvents Hash2nck As TextBox
    Friend WithEvents Log2 As RichTextBox
    Friend WithEvents getNCK As RichTextBox
End Class
