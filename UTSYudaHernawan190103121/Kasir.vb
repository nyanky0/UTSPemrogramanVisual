Public Class Kasir
    Dim menulist(8) As String
    Dim harga(8) As Integer
    Dim jml(8) As Integer
    Dim ttl(8) As Integer
    Dim list(8) As String
    Dim n As Integer
    Dim totalbayar As Integer = 0
    Dim cash As Integer
    Public Sub Kasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nudSteaksapi.Visible = False
        nudJerukpanas.Visible = False
        nudEsjeruk.Visible = False
        nudEsteh.Visible = False
        nudSteakayam1.Visible = False
        nudNasihotplate.Visible = False
        nudSteakayam2.Visible = False
        nudTehpanas.Visible = False
        btnBayar.Enabled = False
    End Sub

    Private Sub cbSteakayam1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSteakayam1.CheckedChanged
        If cbSteakayam1.Checked = True Then
            nudSteakayam1.Visible = True
        Else
            nudSteakayam1.Visible = False
            nudSteakayam1.Value = 1
        End If
    End Sub

    Private Sub cbSteaksapi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSteaksapi.CheckedChanged
        If cbSteaksapi.Checked = True Then
            nudSteaksapi.Visible = True
        Else
            nudSteaksapi.Visible = False
            nudSteaksapi.Value = 1
        End If
    End Sub

    Private Sub cbSteakayam2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSteakayam2.CheckedChanged
        If cbSteakayam2.Checked = True Then
            nudSteakayam2.Visible = True
        Else
            nudSteakayam2.Visible = False
            nudSteakayam2.Value = 1
        End If
    End Sub

    Private Sub cbNasihotplate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNasihotplate.CheckedChanged
        If cbNasihotplate.Checked = True Then
            nudNasihotplate.Visible = True
        Else
            nudNasihotplate.Visible = False
            nudNasihotplate.Value = 1
        End If
    End Sub

    Private Sub cbEsteh_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEsteh.CheckedChanged
        If cbEsteh.Checked = True Then
            nudEsteh.Visible = True
        Else
            nudEsteh.Visible = False
            nudEsteh.Value = 1
        End If
    End Sub

    Private Sub cbEsjeruk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEsjeruk.CheckedChanged
        If cbEsjeruk.Checked = True Then
            nudEsjeruk.Visible = True
        Else
            nudEsjeruk.Visible = False
            nudEsjeruk.Value = 1
        End If
    End Sub

    Private Sub cbTehpanas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTehpanas.CheckedChanged
        If cbTehpanas.Checked = True Then
            nudTehpanas.Visible = True
        Else
            nudTehpanas.Visible = False
            nudTehpanas.Value = 1
        End If
    End Sub

    Private Sub cbJerukpanas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbJerukpanas.CheckedChanged
        If cbJerukpanas.Checked = True Then
            nudJerukpanas.Visible = True
        Else
            nudJerukpanas.Visible = False
            nudJerukpanas.Value = 1
        End If
    End Sub

    Sub clear()
        cbSteakayam1.Checked = False
        nudSteakayam1.Visible = False
        nudSteakayam1.Value = 1
        cbSteaksapi.Checked = False
        nudSteaksapi.Visible = False
        nudSteaksapi.Value = 1
        cbSteakayam2.Checked = False
        nudSteakayam2.Visible = False
        nudSteakayam2.Value = 1
        cbNasihotplate.Checked = False
        nudNasihotplate.Visible = False
        nudNasihotplate.Value = 1
        cbEsteh.Checked = False
        nudEsteh.Visible = False
        nudEsteh.Value = 1
        cbEsjeruk.Checked = False
        nudEsjeruk.Visible = False
        nudEsjeruk.Value = 1
        cbTehpanas.Checked = False
        nudTehpanas.Visible = False
        nudTehpanas.Value = 1
        cbJerukpanas.Checked = False
        nudJerukpanas.Visible = False
        nudJerukpanas.Value = 1
        listbox.Items.Clear()
        txtCash.Enabled = False
        btnBayar.Enabled = False
        lblKembalian.Text = "0"
        lblTotal.Text = 0
        totalbayar = 0
        n = 0
        txtCash.Text = 0
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call clear()

    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Call clear()
        Close()
        FormLogin.txtLuser.Text = ""
        FormLogin.txtLpw.Text = ""
        FormLogin.Show()
        FormLogin.txtLuser.Select()
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Close()
        FormLogin.Close()
        Application.Exit()
    End Sub

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        n = 0
        listbox.Items.Clear()
        lblTotal.Text = 0
        If cbSteakayam1.Checked = True Then
            n = n + 1
            menulist(n) = "Steak Ayam "
            harga(n) = 10000
            jml(n) = Trim(nudSteakayam1.Value)
            ttl(n) = jml(n) * harga(n)
            list(n) = menulist(n) + "(" + jml(n).ToString + ")" + " = " + ttl(n).ToString
            listbox.Items.Add(list(n))
        End If
        If cbSteaksapi.Checked = True Then
            n = n + 1
            menulist(n) = "Steak Sapi "
            harga(n) = 15000
            jml(n) = Trim(nudSteaksapi.Value)
            ttl(n) = jml(n) * harga(n)
            list(n) = menulist(n) + "(" + jml(n).ToString + ")" + " = " + ttl(n).ToString
            listbox.Items.Add(list(n))
        End If
        If cbSteakayam2.Checked = True Then
            n = n + 1
            menulist(n) = "Steak Ayam Double "
            harga(n) = 17000
            jml(n) = Trim(nudSteakayam2.Value)
            ttl(n) = jml(n) * harga(n)
            list(n) = menulist(n) + "(" + jml(n).ToString + ")" + " = " + ttl(n).ToString
            listbox.Items.Add(list(n))
        End If
        If cbNasihotplate.Checked = True Then
            n = n + 1
            menulist(n) = "Nasi Hot Plate "
            harga(n) = 12000
            jml(n) = Trim(nudNasihotplate.Value)
            ttl(n) = jml(n) * harga(n)
            list(n) = menulist(n) + "(" + jml(n).ToString + ")" + " = " + ttl(n).ToString
            listbox.Items.Add(list(n))
        End If
        If cbEsteh.Checked = True Then
            n = n + 1
            menulist(n) = "Es Teh "
            harga(n) = 3000
            jml(n) = Trim(nudEsteh.Value)
            ttl(n) = jml(n) * harga(n)
            list(n) = menulist(n) + "(" + jml(n).ToString + ")" + " = " + ttl(n).ToString
            listbox.Items.Add(list(n))
        End If
        If cbEsjeruk.Checked = True Then
            n = n + 1
            menulist(n) = "Es Jeruk "
            harga(n) = 4000
            jml(n) = Trim(nudEsjeruk.Value)
            ttl(n) = jml(n) * harga(n)
            list(n) = menulist(n) + "(" + jml(n).ToString + ")" + " = " + ttl(n).ToString
            listbox.Items.Add(list(n))
        End If
        If cbTehpanas.Checked = True Then
            n = n + 1
            menulist(n) = "Teh Panas "
            harga(n) = 2000
            jml(n) = Trim(nudTehpanas.Value)
            ttl(n) = jml(n) * harga(n)
            list(n) = menulist(n) + "(" + jml(n).ToString + ")" + " = " + ttl(n).ToString
            listbox.Items.Add(list(n))
        End If
        If cbJerukpanas.Checked = True Then
            n = n + 1
            menulist(n) = "Jeruk Panas "
            harga(n) = 3000
            jml(n) = Trim(nudJerukpanas.Value)
            ttl(n) = jml(n) * harga(n)
            list(n) = menulist(n) + "(" + jml(n).ToString + ")" + " = " + ttl(n).ToString
            listbox.Items.Add(list(n))
        End If
        totalbayar = 0
        For i = 0 To ttl.GetUpperBound(0)
            totalbayar += ttl(i)
        Next
        txtCash.Enabled = True
        lblTotal.Text = totalbayar
        txtCash.Select()

    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCash.TextChanged
        Dim uang As Integer
        Dim uang2 As Integer
        uang = txtCash.Text
        uang2 = lblTotal.Text
        If uang >= uang2 Then
            btnBayar.Enabled = True
            lblKembalian.Text = uang - totalbayar
        Else
            btnBayar.Enabled = False
            lblKembalian.Text = ""
        End If
    End Sub

    Private Sub btnBayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBayar.Click
        Call clear()
        MessageBox.Show("Transaksi Selesai!", "Pembayaran")
    End Sub

End Class