Imports System.Data.SqlClient

Public Class giris
    Private Sub giris_btn_Click(sender As Object, e As EventArgs) Handles giris_btn.Click
        If username_tb.Text <> "" And password_tb.Text <> "" Then
            If girisUygunMu(username_tb.Text, password_tb.Text) Then
                Dim Form1Ac As New Form1
                Me.Hide()
                Form1.Show()
            Else
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.")
            End If
        End If
    End Sub
    Public Function girisUygunMu(kullaniciAdi As String, sifre As String) As Boolean
        Dim connetionString As String
        Dim cnn As SqlConnection
        connetionString = "Data Source=DESKTOP-EQ28FCA\SQLEXPRESS; Initial Catalog=denemedatabase; Integrated Security=True"
        cnn = New SqlConnection(connetionString)
        Dim komut As New SqlCommand("SELECT * FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @sifre", cnn)
        komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi)
        komut.Parameters.AddWithValue("@sifre", sifre)
        cnn.Open()

        Dim dr As SqlDataReader = komut.ExecuteReader()
        Dim sonuc As Boolean = dr.HasRows
        cnn.Close()

        Return sonuc
    End Function
    Private Sub kayit_btn_Click(sender As Object, e As EventArgs) Handles kayit_btn.Click
        kayit.Show()
        Me.Hide()
    End Sub
    Private Sub password_tb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles password_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            giris_btn.PerformClick()
        End If
    End Sub
End Class