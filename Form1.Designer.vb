<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.getData_F = New System.Windows.Forms.Button()
        Me.Log2 = New System.Windows.Forms.RichTextBox()
        Me.genCod2NCK = New System.Windows.Forms.Button()
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
        Me.getNCK = New System.Windows.Forms.RichTextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.M1 = New System.Windows.Forms.TextBox()
        Me.M2 = New System.Windows.Forms.TextBox()
        Me.M3 = New System.Windows.Forms.TextBox()
        Me.M4 = New System.Windows.Forms.TextBox()
        Me.M5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.M6 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mailData = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gb1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.RB1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'vHC
        '
        Me.vHC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vHC.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.vHC.FormattingEnabled = True
        Me.vHC.Items.AddRange(New Object() {"hashcat", "hashcat32", "hashcat64"})
        Me.vHC.Location = New System.Drawing.Point(10, 12)
        Me.vHC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.vHC.Name = "vHC"
        Me.vHC.Size = New System.Drawing.Size(106, 26)
        Me.vHC.TabIndex = 0
        '
        'IMEI1
        '
        Me.IMEI1.Enabled = False
        Me.IMEI1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.IMEI1.Location = New System.Drawing.Point(531, 22)
        Me.IMEI1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IMEI1.Name = "IMEI1"
        Me.IMEI1.Size = New System.Drawing.Size(157, 26)
        Me.IMEI1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(10, 45)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(679, 299)
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
        Me.TabPage1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(671, 268)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "File"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GetMC
        '
        Me.GetMC.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GetMC.Location = New System.Drawing.Point(547, 164)
        Me.GetMC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GetMC.Name = "GetMC"
        Me.GetMC.Size = New System.Drawing.Size(105, 46)
        Me.GetMC.TabIndex = 9
        Me.GetMC.Text = "Get Master Code"
        Me.GetMC.UseVisualStyleBackColor = True
        '
        'Restore
        '
        Me.Restore.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Restore.Location = New System.Drawing.Point(547, 215)
        Me.Restore.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Restore.Name = "Restore"
        Me.Restore.Size = New System.Drawing.Size(105, 24)
        Me.Restore.TabIndex = 8
        Me.Restore.Text = "Restore"
        Me.Restore.UseVisualStyleBackColor = True
        '
        'StartBF1
        '
        Me.StartBF1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.StartBF1.ForeColor = System.Drawing.Color.Red
        Me.StartBF1.Location = New System.Drawing.Point(547, 66)
        Me.StartBF1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartBF1.Name = "StartBF1"
        Me.StartBF1.Size = New System.Drawing.Size(105, 94)
        Me.StartBF1.TabIndex = 4
        Me.StartBF1.Text = "Start BF"
        Me.StartBF1.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Log.Location = New System.Drawing.Point(30, 53)
        Me.Log.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Log.Name = "Log"
        Me.Log.ReadOnly = True
        Me.Log.Size = New System.Drawing.Size(499, 201)
        Me.Log.TabIndex = 3
        Me.Log.Text = ""
        '
        'sDir
        '
        Me.sDir.Location = New System.Drawing.Point(620, 17)
        Me.sDir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sDir.Name = "sDir"
        Me.sDir.Size = New System.Drawing.Size(32, 22)
        Me.sDir.TabIndex = 2
        Me.sDir.Text = "..."
        Me.sDir.UseVisualStyleBackColor = True
        '
        'DirF
        '
        Me.DirF.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DirF.Location = New System.Drawing.Point(80, 17)
        Me.DirF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DirF.Name = "DirF"
        Me.DirF.Size = New System.Drawing.Size(526, 26)
        Me.DirF.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(671, 268)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Manual"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.Exe1)
        Me.gb1.Controls.Add(Me.cmd1)
        Me.gb1.Location = New System.Drawing.Point(18, 195)
        Me.gb1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gb1.Name = "gb1"
        Me.gb1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.gb1.Size = New System.Drawing.Size(626, 59)
        Me.gb1.TabIndex = 7
        Me.gb1.TabStop = False
        Me.gb1.Text = "Dos Command"
        '
        'Exe1
        '
        Me.Exe1.Location = New System.Drawing.Point(539, 20)
        Me.Exe1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Exe1.Name = "Exe1"
        Me.Exe1.Size = New System.Drawing.Size(80, 27)
        Me.Exe1.TabIndex = 1
        Me.Exe1.Text = "Send"
        Me.Exe1.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(7, 22)
        Me.cmd1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(525, 26)
        Me.cmd1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Output File Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Salt:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hash:"
        '
        'FileName1
        '
        Me.FileName1.Location = New System.Drawing.Point(127, 83)
        Me.FileName1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FileName1.Name = "FileName1"
        Me.FileName1.Size = New System.Drawing.Size(200, 26)
        Me.FileName1.TabIndex = 3
        '
        'Salt2
        '
        Me.Salt2.AccessibleDescription = ""
        Me.Salt2.AccessibleName = ""
        Me.Salt2.Location = New System.Drawing.Point(60, 53)
        Me.Salt2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Salt2.Name = "Salt2"
        Me.Salt2.Size = New System.Drawing.Size(267, 26)
        Me.Salt2.TabIndex = 2
        Me.Salt2.Tag = ""
        '
        'Pass2
        '
        Me.Pass2.Location = New System.Drawing.Point(60, 23)
        Me.Pass2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pass2.MaxLength = 40
        Me.Pass2.Name = "Pass2"
        Me.Pass2.Size = New System.Drawing.Size(267, 26)
        Me.Pass2.TabIndex = 1
        '
        'StartBF2
        '
        Me.StartBF2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.StartBF2.ForeColor = System.Drawing.Color.Red
        Me.StartBF2.Location = New System.Drawing.Point(391, 42)
        Me.StartBF2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartBF2.Name = "StartBF2"
        Me.StartBF2.Size = New System.Drawing.Size(253, 44)
        Me.StartBF2.TabIndex = 0
        Me.StartBF2.Text = "Start BF"
        Me.StartBF2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.getData_F)
        Me.TabPage3.Controls.Add(Me.Log2)
        Me.TabPage3.Controls.Add(Me.genCod2NCK)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.mc2nck)
        Me.TabPage3.Controls.Add(Me.Hash2nck)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(671, 268)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "COD2NCK"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'getData_F
        '
        Me.getData_F.Location = New System.Drawing.Point(450, 13)
        Me.getData_F.Name = "getData_F"
        Me.getData_F.Size = New System.Drawing.Size(203, 27)
        Me.getData_F.TabIndex = 6
        Me.getData_F.Text = "Get data from last open file"
        Me.getData_F.UseVisualStyleBackColor = True
        '
        'Log2
        '
        Me.Log2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Log2.Location = New System.Drawing.Point(30, 102)
        Me.Log2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Log2.Name = "Log2"
        Me.Log2.ReadOnly = True
        Me.Log2.Size = New System.Drawing.Size(623, 156)
        Me.Log2.TabIndex = 5
        Me.Log2.Text = ""
        '
        'genCod2NCK
        '
        Me.genCod2NCK.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.genCod2NCK.ForeColor = System.Drawing.Color.Red
        Me.genCod2NCK.Location = New System.Drawing.Point(450, 45)
        Me.genCod2NCK.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.genCod2NCK.Name = "genCod2NCK"
        Me.genCod2NCK.Size = New System.Drawing.Size(203, 44)
        Me.genCod2NCK.TabIndex = 4
        Me.genCod2NCK.Text = "Generate"
        Me.genCod2NCK.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Master Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Hash:"
        '
        'mc2nck
        '
        Me.mc2nck.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.mc2nck.Location = New System.Drawing.Point(99, 27)
        Me.mc2nck.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.mc2nck.MaxLength = 30
        Me.mc2nck.Name = "mc2nck"
        Me.mc2nck.Size = New System.Drawing.Size(263, 26)
        Me.mc2nck.TabIndex = 1
        '
        'Hash2nck
        '
        Me.Hash2nck.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Hash2nck.Location = New System.Drawing.Point(99, 54)
        Me.Hash2nck.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Hash2nck.MaxLength = 40
        Me.Hash2nck.Name = "Hash2nck"
        Me.Hash2nck.Size = New System.Drawing.Size(263, 26)
        Me.Hash2nck.TabIndex = 0
        '
        'Command
        '
        Me.Command.Location = New System.Drawing.Point(44, 374)
        Me.Command.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Command.Name = "Command"
        Me.Command.Size = New System.Drawing.Size(596, 24)
        Me.Command.TabIndex = 7
        Me.Command.Visible = False
        '
        'Salt
        '
        Me.Salt.Location = New System.Drawing.Point(471, 400)
        Me.Salt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Salt.Name = "Salt"
        Me.Salt.Size = New System.Drawing.Size(169, 24)
        Me.Salt.TabIndex = 6
        Me.Salt.Visible = False
        '
        'Pass
        '
        Me.Pass.Location = New System.Drawing.Point(44, 400)
        Me.Pass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(421, 24)
        Me.Pass.TabIndex = 5
        Me.Pass.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(493, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "IMEI:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Infinity files|*.bcl|Cyclone files|*.log|Text files|*.txt"
        '
        'bench1
        '
        Me.bench1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bench1.Location = New System.Drawing.Point(140, 17)
        Me.bench1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bench1.Name = "bench1"
        Me.bench1.Size = New System.Drawing.Size(90, 25)
        Me.bench1.TabIndex = 7
        Me.bench1.Text = "Benchmark"
        Me.bench1.UseVisualStyleBackColor = True
        '
        'help1
        '
        Me.help1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.help1.Location = New System.Drawing.Point(235, 17)
        Me.help1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.help1.Name = "help1"
        Me.help1.Size = New System.Drawing.Size(66, 25)
        Me.help1.TabIndex = 8
        Me.help1.Text = "Help"
        Me.help1.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.Controls.Add(Me.algo2)
        Me.RB1.Controls.Add(Me.algo1)
        Me.RB1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RB1.Location = New System.Drawing.Point(330, 10)
        Me.RB1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RB1.Name = "RB1"
        Me.RB1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RB1.Size = New System.Drawing.Size(142, 47)
        Me.RB1.TabIndex = 9
        Me.RB1.TabStop = False
        Me.RB1.Text = "algo"
        '
        'algo2
        '
        Me.algo2.AutoSize = True
        Me.algo2.Location = New System.Drawing.Point(83, 17)
        Me.algo2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.algo2.Name = "algo2"
        Me.algo2.Size = New System.Drawing.Size(43, 22)
        Me.algo2.TabIndex = 1
        Me.algo2.TabStop = True
        Me.algo2.Text = "v2"
        Me.algo2.UseVisualStyleBackColor = True
        '
        'algo1
        '
        Me.algo1.AutoSize = True
        Me.algo1.Checked = True
        Me.algo1.Location = New System.Drawing.Point(32, 17)
        Me.algo1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.algo1.Name = "algo1"
        Me.algo1.Size = New System.Drawing.Size(43, 22)
        Me.algo1.TabIndex = 0
        Me.algo1.TabStop = True
        Me.algo1.Text = "v1"
        Me.algo1.UseVisualStyleBackColor = True
        '
        'MC
        '
        Me.MC.Location = New System.Drawing.Point(44, 348)
        Me.MC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MC.Name = "MC"
        Me.MC.Size = New System.Drawing.Size(596, 24)
        Me.MC.TabIndex = 10
        Me.MC.Visible = False
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "Text files|*.txt|All files|*.*"
        '
        'getNCK
        '
        Me.getNCK.Location = New System.Drawing.Point(42, 435)
        Me.getNCK.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.getNCK.Name = "getNCK"
        Me.getNCK.Size = New System.Drawing.Size(597, 95)
        Me.getNCK.TabIndex = 11
        Me.getNCK.Text = ""
        Me.getNCK.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.M6)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.M5)
        Me.TabPage4.Controls.Add(Me.M4)
        Me.TabPage4.Controls.Add(Me.M3)
        Me.TabPage4.Controls.Add(Me.M2)
        Me.TabPage4.Controls.Add(Me.M1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(671, 268)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Settings"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'M1
        '
        Me.M1.Location = New System.Drawing.Point(137, 23)
        Me.M1.Name = "M1"
        Me.M1.Size = New System.Drawing.Size(356, 26)
        Me.M1.TabIndex = 0
        '
        'M2
        '
        Me.M2.Location = New System.Drawing.Point(137, 55)
        Me.M2.Name = "M2"
        Me.M2.Size = New System.Drawing.Size(356, 26)
        Me.M2.TabIndex = 1
        '
        'M3
        '
        Me.M3.Location = New System.Drawing.Point(137, 87)
        Me.M3.Name = "M3"
        Me.M3.Size = New System.Drawing.Size(356, 26)
        Me.M3.TabIndex = 2
        '
        'M4
        '
        Me.M4.Location = New System.Drawing.Point(137, 119)
        Me.M4.Name = "M4"
        Me.M4.Size = New System.Drawing.Size(356, 26)
        Me.M4.TabIndex = 3
        '
        'M5
        '
        Me.M5.Location = New System.Drawing.Point(137, 151)
        Me.M5.Name = "M5"
        Me.M5.Size = New System.Drawing.Size(356, 26)
        Me.M5.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(86, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 18)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Login:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(60, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 18)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Password:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 18)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "RecipientAddress:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 18)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "SenderAddress:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 18)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "MessageText:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(49, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "SMTP Client:"
        '
        'M6
        '
        Me.M6.Location = New System.Drawing.Point(137, 183)
        Me.M6.Name = "M6"
        Me.M6.Size = New System.Drawing.Size(356, 26)
        Me.M6.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(548, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 40)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mailData
        '
        Me.mailData.Location = New System.Drawing.Point(695, 95)
        Me.mailData.Name = "mailData"
        Me.mailData.Size = New System.Drawing.Size(387, 226)
        Me.mailData.TabIndex = 13
        Me.mailData.Text = ""
        Me.mailData.Visible = False
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.FileName = "OpenFileDialog3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 351)
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
        Me.Controls.Add(Me.mailData)
        Me.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SL3BF v1.08"
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
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
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
    Friend WithEvents genCod2NCK As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents mc2nck As TextBox
    Friend WithEvents Hash2nck As TextBox
    Friend WithEvents Log2 As RichTextBox
    Friend WithEvents getNCK As RichTextBox
    Friend WithEvents getData_F As Button
    Friend WithEvents Salt2 As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents M6 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents M5 As TextBox
    Friend WithEvents M4 As TextBox
    Friend WithEvents M3 As TextBox
    Friend WithEvents M2 As TextBox
    Friend WithEvents M1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents mailData As RichTextBox
    Friend WithEvents OpenFileDialog3 As OpenFileDialog
End Class
