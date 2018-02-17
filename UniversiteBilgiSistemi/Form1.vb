Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String
        Dim connection As SqlConnection
        str = "Data Source=DESKTOP-EQ28FCA\SQLEXPRESS; Initial Catalog=denemedatabase; Integrated Security=True"
        connection = New SqlConnection(str)
        Dim command As SqlCommand = New SqlCommand("select DISTINCT Üniversite from Projetablosu order by Üniversite asc;", connection)
        connection.Open()

        Dim dtr As SqlDataReader = command.ExecuteReader()
        While dtr.Read()
            uniara_cbox.Items.Add(dtr("Üniversite").ToString)
        End While
        connection.Close()

        Dim cnnstring As String
        Dim cnn As SqlConnection
        cnnstring = "Data Source=DESKTOP-EQ28FCA\SQLEXPRESS; Initial Catalog=denemedatabase; Integrated Security=True"
        cnn = New SqlConnection(cnnstring)
        command = New SqlCommand("select distinct Bölüm from Projetablosu order by Bölüm asc;", connection)
        connection.Open()

        Dim dr As SqlDataReader = command.ExecuteReader()
        While dr.Read()
            bolumara_cbox.Items.Add(dr("Bölüm").ToString)
        End While
        connection.Close()

        str = "Data Source=DESKTOP-EQ28FCA\SQLEXPRESS; Initial Catalog=denemedatabase; Integrated Security=True"
        connection = New SqlConnection(str)
        command = New SqlCommand("select DISTINCT Şehir from Projetablosu order by Şehir asc;", connection)
        connection.Open()

        Dim datareader As SqlDataReader = command.ExecuteReader()
        While datareader.Read()
            sehir_cbox.Items.Add(datareader("Şehir").ToString)
        End While
    End Sub
    Private Sub sehirtanıt_btn_Click(sender As Object, e As EventArgs) Handles sehirtanıt_btn.Click
        Dim str As String
        Dim connection As SqlConnection
        str = "Data Source=DESKTOP-EQ28FCA\SQLEXPRESS; Initial Catalog=denemedatabase; Integrated Security=True"
        connection = New SqlConnection(str)
        Dim komut As SqlCommand = New SqlCommand("SELECT Tanıtım FROM Tanıt where Şehir ='" & sehir_cbox.Text & "'", connection)
        Try
            connection.Open()

            Dim dr As SqlDataReader = komut.ExecuteReader()
            While dr.Read()
                Tanıtım.tanıtım_rtb.Text = dr("Tanıtım").ToString
                Tanıtım.Show()
            End While
            connection.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub uniara_cbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles uniara_cbox.SelectedIndexChanged
        Dim str As String
        Dim connection As SqlConnection
        str = "Data Source=DESKTOP-EQ28FCA\SQLEXPRESS; Initial Catalog=denemedatabase; Integrated Security=True"
        connection = New SqlConnection(str)
        If bolumara_cbox.Text = "Bölüm Seçiniz" Then
            Dim komut As SqlCommand = New SqlCommand("SELECT Şehir, Üniversite, Bölüm, [Puan Türü], Kontenjan, [Taban Sıralaması], Tabanpuanı, [Devlet Yurdu] FROM Projetablosu where Üniversite ='" & uniara_cbox.Text & "'", connection)
            Try
                connection.Open()

                Dim da As New SqlDataAdapter(komut)
                Dim table As New DataTable()
                da.Fill(table)
                DataGridView1.DataSource = table
                sehir_cbox.Text = " "
                connection.Close()

            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()

            End Try
        Else
            Dim komut As SqlCommand = New SqlCommand("SELECT Şehir, Üniversite, Bölüm, [Puan Türü], Kontenjan, [Taban Sıralaması], Tabanpuanı, [Devlet Yurdu] FROM Projetablosu where Üniversite ='" & uniara_cbox.Text & "' and Bölüm ='" & bolumara_cbox.Text & "'", connection)
            Try
                connection.Open()

                Dim da As New SqlDataAdapter(komut)
                Dim table As New DataTable()
                da.Fill(table)
                DataGridView1.DataSource = table
                sehir_cbox.Text = " "
                connection.Close()

            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        End If
        taban_tb.Text = " "
        tavan_tb.Text = " "
    End Sub

    Private Sub bolumara_cbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bolumara_cbox.SelectedIndexChanged
        Dim str As String
        Dim connection As SqlConnection
        str = "Data Source=DESKTOP-EQ28FCA\SQLEXPRESS; Initial Catalog=denemedatabase; Integrated Security=True"
        connection = New SqlConnection(str)
        If uniara_cbox.Text = "Üniversite Seçiniz" Then
            Dim cmd As SqlCommand = New SqlCommand("SELECT Şehir, Üniversite, Bölüm, [Puan Türü], Kontenjan, [Taban Sıralaması], Tabanpuanı, [Devlet Yurdu] FROM  Projetablosu where Bölüm ='" & bolumara_cbox.Text & "'", connection)
            Try
                connection.Open()

                Dim da As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                da.Fill(table)
                DataGridView1.DataSource = table
                connection.Close()

            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        Else
            Dim cmd As SqlCommand = New SqlCommand("SELECT Şehir, Üniversite, Bölüm, [Puan Türü], Kontenjan, [Taban Sıralaması], Tabanpuanı, [Devlet Yurdu] FROM  Projetablosu where Bölüm ='" & bolumara_cbox.Text & "'and Üniversite ='" & uniara_cbox.Text & "'", connection)
            Try
                connection.Open()

                Dim da As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                da.Fill(table)
                DataGridView1.DataSource = table
                connection.Close()

            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            Finally
                connection.Dispose()
            End Try
        End If
        taban_tb.Text = " "
        tavan_tb.Text = " "
        sehir_cbox.Text = " "
    End Sub
    Private Sub sehir_cbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sehir_cbox.SelectedIndexChanged
        Dim str As String
        Dim connection As SqlConnection
        str = "Data Source=DESKTOP-EQ28FCA\SQLEXPRESS; Initial Catalog=denemedatabase; Integrated Security=True"
        connection = New SqlConnection(str)
        Dim cmd As SqlCommand = New SqlCommand("Select Şehir, Üniversite, Bölüm, [Puan Türü], Kontenjan, [Taban Sıralaması], Tabanpuanı, [Devlet Yurdu] FROM  Projetablosu where Şehir ='" & sehir_cbox.Text & "'", connection)
        Try
            connection.Open()

            Dim da As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            da.Fill(table)
            DataGridView1.DataSource = table
            uniara_cbox.Text = " "
            bolumara_cbox.Text = " "
            taban_tb.Text = " "
            tavan_tb.Text = " "
            connection.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub sıralama_btn_Click(sender As Object, e As EventArgs) Handles sıralama_btn.Click
        Dim str As String
        Dim connection As SqlConnection
        str = "Data Source=DESKTOP-EQ28FCA\SQLEXPRESS; Initial Catalog=denemedatabase; Integrated Security=True"
        connection = New SqlConnection(str)
        Dim cmd As SqlCommand = New SqlCommand("SELECT Şehir, Üniversite, Bölüm, [Puan Türü], Kontenjan, [Taban Sıralaması], Tabanpuanı, [Devlet Yurdu] FROM  Projetablosu where [Taban Sıralaması] between '" & taban_tb.Text & "' and '" & tavan_tb.Text & "'order by [Taban Sıralaması] asc;", connection)
        connection.Open()

        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        da.Fill(table)
        DataGridView1.DataSource = table
        sehir_cbox.Text = " "
        connection.Close()

    End Sub

    Private Sub tavan_tb_TextChanged(sender As Object, e As EventArgs) Handles tavan_tb.TextChanged

    End Sub

    Private Sub taban_tb_TextChanged(sender As Object, e As EventArgs) Handles taban_tb.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Dim str As String
        Dim connection As SqlConnection
        str = "Data Source=DESKTOP-EQ28FCA\SQLEXPRESS; Initial Catalog=denemedatabase; Integrated Security=True"
        connection = New SqlConnection(str)
        Dim cmd As SqlCommand = New SqlCommand("Select Şehir, Üniversite, Bölüm, [Puan Türü], Kontenjan, [Taban Sıralaması], Tabanpuanı, [Devlet Yurdu] FROM  Projetablosu where [Puan Türü] ='" & CheckedListBox1.Text & "'", connection)
        Try
            connection.Open()

            Dim da As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            da.Fill(table)
            DataGridView1.DataSource = table
            uniara_cbox.Text = " "
            bolumara_cbox.Text = " "
            taban_tb.Text = " "
            tavan_tb.Text = " "
            connection.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
End Class
