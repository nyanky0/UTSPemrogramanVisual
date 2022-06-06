<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLuser = New System.Windows.Forms.TextBox()
        Me.txtLpw = New System.Windows.Forms.TextBox()
        Me.btnL = New System.Windows.Forms.Button()
        Me.cbPass = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UTS PEMROGRAMAN VISUAL - YUDA HERNAWAN 190103121 19TIA4"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "KASIR STEAK HK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(85, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(87, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'txtLuser
        '
        Me.txtLuser.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtLuser.Location = New System.Drawing.Point(202, 53)
        Me.txtLuser.Name = "txtLuser"
        Me.txtLuser.Size = New System.Drawing.Size(130, 20)
        Me.txtLuser.TabIndex = 4
        '
        'txtLpw
        '
        Me.txtLpw.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtLpw.Location = New System.Drawing.Point(202, 96)
        Me.txtLpw.Name = "txtLpw"
        Me.txtLpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLpw.Size = New System.Drawing.Size(130, 20)
        Me.txtLpw.TabIndex = 5
        '
        'btnL
        '
        Me.btnL.Location = New System.Drawing.Point(88, 154)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(92, 34)
        Me.btnL.TabIndex = 6
        Me.btnL.Text = "LOGIN"
        Me.btnL.UseVisualStyleBackColor = True
        '
        'cbPass
        '
        Me.cbPass.AutoSize = True
        Me.cbPass.BackColor = System.Drawing.Color.Transparent
        Me.cbPass.Location = New System.Drawing.Point(202, 122)
        Me.cbPass.Name = "cbPass"
        Me.cbPass.Size = New System.Drawing.Size(123, 17)
        Me.cbPass.TabIndex = 7
        Me.cbPass.Text = "Tampilkan password"
        Me.cbPass.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(211, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "KELUAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.UTSYudaHernawan190103121.My.Resources.Resources.kasir
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(390, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbPass)
        Me.Controls.Add(Me.btnL)
        Me.Controls.Add(Me.txtLpw)
        Me.Controls.Add(Me.txtLuser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLuser As System.Windows.Forms.TextBox
    Friend WithEvents txtLpw As System.Windows.Forms.TextBox
    Friend WithEvents btnL As System.Windows.Forms.Button
    Friend WithEvents cbPass As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
