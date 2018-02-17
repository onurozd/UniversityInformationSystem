Imports System.Data.SqlClient

Public Class kayit
    Private Sub togiris_btn_Click(sender As Object, e As EventArgs) Handles togiris_btn.Click
        giris.Show()
        Me.Hide()
    End Sub
    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        Dim connetionString As String
        Dim cnn As SqlConnection
        connetionString = "Data Source=DESKTOP-EQ28FCA\SQLEXPRESS; Initial Catalog=denemedatabase; Integrated Security=True"
        cnn = New SqlConnection(connetionString)
        cnn.Open()

        Dim komut As New SqlCommand("INSERT INTO Kullanici (KullaniciAdi, Sifre) VALUES(@kullaniciAdi,@sifre)", cnn)

        komut.Parameters.AddWithValue("@kullaniciAdi", regusername_tb.Text)
        komut.Parameters.AddWithValue("@sifre", regpassword_tb.Text)
        komut.ExecuteNonQuery()
        MsgBox("Kayıt işlemi basarılı")
        cnn.Close()

    End Sub
End Class