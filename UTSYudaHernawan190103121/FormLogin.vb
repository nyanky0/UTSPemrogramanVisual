Public Class FormLogin

    Private Sub btnL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL.Click
        If txtLuser.Text = "" Or txtLpw.Text = "" Then
            MessageBox.Show("Kode Admin atau Password Tidak Boleh Kosong!", "Login")
        ElseIf txtLuser.Text = "budi" And txtLpw.Text = "123" Then
            MessageBox.Show("Login berhasil! Selamat bekerja, Budi.", "Login")
            txtLuser.Select()
            cbPass.Checked = False
            txtLpw.PasswordChar = "*"
            Me.Hide()
            Kasir.ShowDialog()
        Else
            MessageBox.Show("Kode Admin atau Password Salah!", "Login")
        End If
    End Sub
    Private Sub txtLpw_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLpw.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnL_Click(sender, e)
        End If
    End Sub

    Private Sub cbPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPass.CheckedChanged
        If cbPass.Checked = True Then
            txtLpw.PasswordChar = ""
        Else
            txtLpw.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Application.Exit()

    End Sub
End Class
