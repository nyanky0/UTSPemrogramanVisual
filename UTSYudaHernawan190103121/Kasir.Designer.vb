<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kasir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kasir))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.listbox = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.nudJerukpanas = New System.Windows.Forms.NumericUpDown()
        Me.nudTehpanas = New System.Windows.Forms.NumericUpDown()
        Me.nudEsjeruk = New System.Windows.Forms.NumericUpDown()
        Me.nudEsteh = New System.Windows.Forms.NumericUpDown()
        Me.cbJerukpanas = New System.Windows.Forms.CheckBox()
        Me.cbTehpanas = New System.Windows.Forms.CheckBox()
        Me.cbEsjeruk = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbEsteh = New System.Windows.Forms.CheckBox()
        Me.nudNasihotplate = New System.Windows.Forms.NumericUpDown()
        Me.nudSteakayam2 = New System.Windows.Forms.NumericUpDown()
        Me.nudSteaksapi = New System.Windows.Forms.NumericUpDown()
        Me.nudSteakayam1 = New System.Windows.Forms.NumericUpDown()
        Me.cbNasihotplate = New System.Windows.Forms.CheckBox()
        Me.cbSteakayam2 = New System.Windows.Forms.CheckBox()
        Me.cbSteaksapi = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbSteakayam1 = New System.Windows.Forms.CheckBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudJerukpanas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTehpanas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEsjeruk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEsteh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNasihotplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSteakayam2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSteaksapi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSteakayam1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Warung Makan Steak HK"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnBayar)
        Me.GroupBox1.Controls.Add(Me.txtCash)
        Me.GroupBox1.Controls.Add(Me.lblKembalian)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.listbox)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnHitung)
        Me.GroupBox1.Controls.Add(Me.nudJerukpanas)
        Me.GroupBox1.Controls.Add(Me.nudTehpanas)
        Me.GroupBox1.Controls.Add(Me.nudEsjeruk)
        Me.GroupBox1.Controls.Add(Me.nudEsteh)
        Me.GroupBox1.Controls.Add(Me.cbJerukpanas)
        Me.GroupBox1.Controls.Add(Me.cbTehpanas)
        Me.GroupBox1.Controls.Add(Me.cbEsjeruk)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbEsteh)
        Me.GroupBox1.Controls.Add(Me.nudNasihotplate)
        Me.GroupBox1.Controls.Add(Me.nudSteakayam2)
        Me.GroupBox1.Controls.Add(Me.nudSteaksapi)
        Me.GroupBox1.Controls.Add(Me.nudSteakayam1)
        Me.GroupBox1.Controls.Add(Me.cbNasihotplate)
        Me.GroupBox1.Controls.Add(Me.cbSteakayam2)
        Me.GroupBox1.Controls.Add(Me.cbSteaksapi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbSteakayam1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(799, 368)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.UTSYudaHernawan190103121.My.Resources.Resources.Untitled_2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(56, 186)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 182)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'btnBayar
        '
        Me.btnBayar.Location = New System.Drawing.Point(691, 284)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(79, 31)
        Me.btnBayar.TabIndex = 30
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = True
        '
        'txtCash
        '
        Me.txtCash.Enabled = False
        Me.txtCash.Location = New System.Drawing.Point(615, 258)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(155, 20)
        Me.txtCash.TabIndex = 29
        '
        'lblKembalian
        '
        Me.lblKembalian.Location = New System.Drawing.Point(612, 334)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(103, 13)
        Me.lblKembalian.TabIndex = 28
        Me.lblKembalian.Text = "0"
        Me.lblKembalian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(612, 223)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(103, 13)
        Me.lblTotal.TabIndex = 27
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(568, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Rp."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(568, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Rp."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(568, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Rp."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(501, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Kembalian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(501, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Cash"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(501, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Total Bayar"
        '
        'listbox
        '
        Me.listbox.FormattingEnabled = True
        Me.listbox.Location = New System.Drawing.Point(615, 23)
        Me.listbox.Name = "listbox"
        Me.listbox.Size = New System.Drawing.Size(163, 173)
        Me.listbox.TabIndex = 20
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(504, 94)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 31)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(504, 53)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(79, 31)
        Me.btnHitung.TabIndex = 18
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'nudJerukpanas
        '
        Me.nudJerukpanas.Location = New System.Drawing.Point(418, 145)
        Me.nudJerukpanas.Name = "nudJerukpanas"
        Me.nudJerukpanas.Size = New System.Drawing.Size(54, 20)
        Me.nudJerukpanas.TabIndex = 17
        Me.nudJerukpanas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudTehpanas
        '
        Me.nudTehpanas.Location = New System.Drawing.Point(418, 119)
        Me.nudTehpanas.Name = "nudTehpanas"
        Me.nudTehpanas.Size = New System.Drawing.Size(54, 20)
        Me.nudTehpanas.TabIndex = 16
        Me.nudTehpanas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudEsjeruk
        '
        Me.nudEsjeruk.Location = New System.Drawing.Point(418, 93)
        Me.nudEsjeruk.Name = "nudEsjeruk"
        Me.nudEsjeruk.Size = New System.Drawing.Size(54, 20)
        Me.nudEsjeruk.TabIndex = 15
        Me.nudEsjeruk.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudEsteh
        '
        Me.nudEsteh.Location = New System.Drawing.Point(418, 67)
        Me.nudEsteh.Name = "nudEsteh"
        Me.nudEsteh.Size = New System.Drawing.Size(54, 20)
        Me.nudEsteh.TabIndex = 14
        Me.nudEsteh.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbJerukpanas
        '
        Me.cbJerukpanas.AutoSize = True
        Me.cbJerukpanas.Location = New System.Drawing.Point(269, 146)
        Me.cbJerukpanas.Name = "cbJerukpanas"
        Me.cbJerukpanas.Size = New System.Drawing.Size(115, 17)
        Me.cbJerukpanas.TabIndex = 13
        Me.cbJerukpanas.Text = "Jeruk Panas 3.000"
        Me.cbJerukpanas.UseVisualStyleBackColor = True
        '
        'cbTehpanas
        '
        Me.cbTehpanas.AutoSize = True
        Me.cbTehpanas.Location = New System.Drawing.Point(269, 120)
        Me.cbTehpanas.Name = "cbTehpanas"
        Me.cbTehpanas.Size = New System.Drawing.Size(108, 17)
        Me.cbTehpanas.TabIndex = 12
        Me.cbTehpanas.Text = "Teh Panas 2.000"
        Me.cbTehpanas.UseVisualStyleBackColor = True
        '
        'cbEsjeruk
        '
        Me.cbEsjeruk.AutoSize = True
        Me.cbEsjeruk.Location = New System.Drawing.Point(269, 94)
        Me.cbEsjeruk.Name = "cbEsjeruk"
        Me.cbEsjeruk.Size = New System.Drawing.Size(97, 17)
        Me.cbEsjeruk.TabIndex = 11
        Me.cbEsjeruk.Text = "Es Jeruk 4.000"
        Me.cbEsjeruk.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Minuman"
        '
        'cbEsteh
        '
        Me.cbEsteh.AutoSize = True
        Me.cbEsteh.Location = New System.Drawing.Point(269, 68)
        Me.cbEsteh.Name = "cbEsteh"
        Me.cbEsteh.Size = New System.Drawing.Size(87, 17)
        Me.cbEsteh.TabIndex = 9
        Me.cbEsteh.Text = "Es Teh 3000"
        Me.cbEsteh.UseVisualStyleBackColor = True
        '
        'nudNasihotplate
        '
        Me.nudNasihotplate.Location = New System.Drawing.Point(191, 145)
        Me.nudNasihotplate.Name = "nudNasihotplate"
        Me.nudNasihotplate.Size = New System.Drawing.Size(54, 20)
        Me.nudNasihotplate.TabIndex = 8
        Me.nudNasihotplate.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudSteakayam2
        '
        Me.nudSteakayam2.Location = New System.Drawing.Point(191, 119)
        Me.nudSteakayam2.Name = "nudSteakayam2"
        Me.nudSteakayam2.Size = New System.Drawing.Size(54, 20)
        Me.nudSteakayam2.TabIndex = 7
        Me.nudSteakayam2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudSteaksapi
        '
        Me.nudSteaksapi.Location = New System.Drawing.Point(191, 93)
        Me.nudSteaksapi.Name = "nudSteaksapi"
        Me.nudSteaksapi.Size = New System.Drawing.Size(54, 20)
        Me.nudSteaksapi.TabIndex = 6
        Me.nudSteaksapi.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudSteakayam1
        '
        Me.nudSteakayam1.Location = New System.Drawing.Point(191, 67)
        Me.nudSteakayam1.Name = "nudSteakayam1"
        Me.nudSteakayam1.Size = New System.Drawing.Size(54, 20)
        Me.nudSteakayam1.TabIndex = 5
        Me.nudSteakayam1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbNasihotplate
        '
        Me.cbNasihotplate.AutoSize = True
        Me.cbNasihotplate.Location = New System.Drawing.Point(29, 146)
        Me.cbNasihotplate.Name = "cbNasihotplate"
        Me.cbNasihotplate.Size = New System.Drawing.Size(130, 17)
        Me.cbNasihotplate.TabIndex = 4
        Me.cbNasihotplate.Text = "Nasi Hot Plate 12.000"
        Me.cbNasihotplate.UseVisualStyleBackColor = True
        '
        'cbSteakayam2
        '
        Me.cbSteakayam2.AutoSize = True
        Me.cbSteakayam2.Location = New System.Drawing.Point(29, 120)
        Me.cbSteakayam2.Name = "cbSteakayam2"
        Me.cbSteakayam2.Size = New System.Drawing.Size(156, 17)
        Me.cbSteakayam2.TabIndex = 3
        Me.cbSteakayam2.Text = "Steak Ayam Double 17.000"
        Me.cbSteakayam2.UseVisualStyleBackColor = True
        '
        'cbSteaksapi
        '
        Me.cbSteaksapi.AutoSize = True
        Me.cbSteaksapi.Location = New System.Drawing.Point(29, 94)
        Me.cbSteaksapi.Name = "cbSteaksapi"
        Me.cbSteaksapi.Size = New System.Drawing.Size(114, 17)
        Me.cbSteaksapi.TabIndex = 2
        Me.cbSteaksapi.Text = "Steak Sapi 15.000"
        Me.cbSteaksapi.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Makanan"
        '
        'cbSteakayam1
        '
        Me.cbSteakayam1.AutoSize = True
        Me.cbSteakayam1.Location = New System.Drawing.Point(29, 68)
        Me.cbSteakayam1.Name = "cbSteakayam1"
        Me.cbSteakayam1.Size = New System.Drawing.Size(119, 17)
        Me.cbSteakayam1.TabIndex = 0
        Me.cbSteakayam1.Text = "Steak Ayam 10.000"
        Me.cbSteakayam1.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(733, 9)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(79, 31)
        Me.btnKeluar.TabIndex = 31
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(648, 9)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(79, 31)
        Me.btnLogout.TabIndex = 32
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(9, 424)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(309, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "UTS Pemrograman Visual - Yuda Hernawan 190103121 19TIA4"
        '
        'Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.UTSYudaHernawan190103121.My.Resources.Resources.kasir2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(824, 446)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kasir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudJerukpanas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTehpanas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEsjeruk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEsteh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNasihotplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSteakayam2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSteaksapi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSteakayam1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nudJerukpanas As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudTehpanas As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudEsjeruk As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudEsteh As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbJerukpanas As System.Windows.Forms.CheckBox
    Friend WithEvents cbTehpanas As System.Windows.Forms.CheckBox
    Friend WithEvents cbEsjeruk As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbEsteh As System.Windows.Forms.CheckBox
    Friend WithEvents nudNasihotplate As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSteakayam2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSteaksapi As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSteakayam1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbNasihotplate As System.Windows.Forms.CheckBox
    Friend WithEvents cbSteakayam2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbSteaksapi As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbSteakayam1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnBayar As System.Windows.Forms.Button
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents lblKembalian As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents listbox As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
