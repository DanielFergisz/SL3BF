<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"Nokia 100 (RH-130)", "Nokia 101 (RM-769)", "Nokia 103 (RM-647)", "Nokia Asha 200 (RM-761, RM-762)", "Nokia Asha 201 (RM-799, RM-800)", "Nokia Asha 300 (RM-781)", "Nokia Asha 301(RM-840)", "Nokia Asha 302 (RM-813)", "Nokia Asha 303 (RM-763)", "Nokia Asha 311 (RM-714)", "Nokia 500 (RM-750)", "Nokia 600 (RM-701)", "Nokia 603 (RM-779)", "Nokia 700 (RM-670)", "Nokia 701 (RM-744)", "Nokia 808 PureView (RM-807)", "1280 (RM-647)", "1616 (RH-125, RH-126)", "1800 (RM-653)", "2690 (RM-635)", "2700 (RM-561)", "2710c (RM-586)", "2710b-2 (RM-586)", "2730 (RM-578/579)", "3600 (RM-352) SW: v56.26 and v57.23", "3710a-1 (RM-509, RM-510)", "3710f (RM-509)", "3710a-1b (RM-510)", "3711a (RM-511)", "3711a-1 (RM-511)", "3720 (RM-518)", "5130 (RM-495)", "5250 (RM-684)", "5230-1b (RM-593)", "5230-1b (RM-594)", "5230 (RM-588)", "5310 (RM-303) SW: v58.58 and v59.42", "5320 (RM-409, RM-417)", "5330 (RM-479/478)", "5530 (RM-504)", "5630 (RM-431)", "5730s (RM-465)", "5800d-1 (RM-356)", "6110 Navigator (RM-122)", "6120C (RM-243)", "6220C (RM-328)", "6290 (RM-176)", "6300 (RM-217) SW: v57.20", "6303ci (RM-638)", "6303 Classic (RM-443)", "6500 Classic (RM-265) SW: v59.45", "6500 Slide (RM-240) SW: v59.60", "6650 (RM-400)", "6700 Classic (RM-470)", "6700 Slide (RM-576)", "6710 Navigator (RM-491)", "6720 Classic(RM-424)", "6730c-1 (RM-547, RM-566)", "6750 Mural (RM-381)", "6760s (RM-573)", "6790s-1c (RM599)", "6790s (RM-492, RM-559)", "702T (RM-730)", "7020 (RM-497)", "7230 (RM-598/604)", "C1-01 (RM-607)", "C1-01.1(RM-608)", "C1-02 (RM-607)", "C1-03 (RM-607)", "C2-00 (RM-704)", "C2-01 (RM-721, RM-722)", "C2-02 (RM-692)", "C2-02.1 (RM-693)", "C2-03 (RM-702)", "C2-05 (RM-724)", "C2-05 (RM-725)", "C2-06 (RM-702)", "C2-07 (RM-692)", "C3-00 (RM-614)", "C3-01 (RM-640)", "C3-01.5 (RM-776)", "C5-00 (RM-645, RM-688)", "C5-02 (RM-745)", "C5-03 (RM-697)", "C6-00 (RM-612)", "C6-01 (RM-601)", "C7-00 (RM-675)", "E52 (RM-244, RM-426, RM-469)", "E55 (RM-482)", "E5-00 (RM-632)", "E63 (RM-437, RM-449, RM-450, RM-600)", "E66 (RM-343, RM-345, RM-420, RM-494)", "E6-00 (RM-609)", "E71 (RM-346, RM-347, RM-357, RM-407, RM-462, RM-493)", "E72 (RM-529, RM-530)", "E73 (RM-658)", "E75 (RM-412, RM-413)", "E7-00 (RM-626)", "N78 (RM-235, RM-236, RM-342)", "N79 (RM-348, RM-349, RM-350)", "N81 (RM-179)", "N81-8GB (RM-223, RM-256)", "N82 (RM-313, RM-314)", "N85 (RM-333, RM-334, RM-335)", "N86 (RM-484, RM-485)", "N8-00 (RM-596)", "N97-1 (RM-505)", "N97-3 (RM-506)", "N97-4 (RM-507)", "N97mini (RM-555)", "N97mini (RM-553)", "N9-00 (RM-696)", "T7-00 (RM-679)", "X1-00 (RM-732/733)", "X1-01 (RM-713)", "X2-00 (RM-618)", "X2-01 (RM-709)", "X2-01.1 (RM-717)", "X2-03 (RM-709)", "X2-05 (RM-772)", "X3-00 (RM-540)", "X3-02 (RM-639)", "X3-02.5 (RM-775)", "X5-01 (RM-627)", "X6-00 (RM-551/559)", "X7-00 (RM-707)"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(333, 420)
        Me.ListBox1.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nokia SL3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
End Class
