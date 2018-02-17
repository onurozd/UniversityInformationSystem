<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class giris
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(giris))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.username_tb = New System.Windows.Forms.TextBox()
        Me.password_tb = New System.Windows.Forms.TextBox()
        Me.giris_btn = New System.Windows.Forms.Button()
        Me.kayit_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(205, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hoş Geldiniz !"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(121, 94)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(121, 137)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'username_tb
        '
        Me.username_tb.AcceptsReturn = True
        Me.username_tb.Location = New System.Drawing.Point(182, 108)
        Me.username_tb.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.username_tb.Name = "username_tb"
        Me.username_tb.Size = New System.Drawing.Size(196, 23)
        Me.username_tb.TabIndex = 3
        Me.username_tb.Text = "Kullanıcı Adı"
        '
        'password_tb
        '
        Me.password_tb.AcceptsReturn = True
        Me.password_tb.Location = New System.Drawing.Point(182, 151)
        Me.password_tb.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.password_tb.Name = "password_tb"
        Me.password_tb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_tb.Size = New System.Drawing.Size(196, 23)
        Me.password_tb.TabIndex = 4
        Me.password_tb.Text = "Şifre"
        '
        'giris_btn
        '
        Me.giris_btn.BackColor = System.Drawing.Color.Maroon
        Me.giris_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.giris_btn.Location = New System.Drawing.Point(182, 209)
        Me.giris_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.giris_btn.Name = "giris_btn"
        Me.giris_btn.Size = New System.Drawing.Size(196, 33)
        Me.giris_btn.TabIndex = 5
        Me.giris_btn.Text = "Giriş"
        Me.giris_btn.UseVisualStyleBackColor = False
        '
        'kayit_btn
        '
        Me.kayit_btn.BackColor = System.Drawing.Color.Maroon
        Me.kayit_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.kayit_btn.Location = New System.Drawing.Point(182, 239)
        Me.kayit_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.kayit_btn.Name = "kayit_btn"
        Me.kayit_btn.Size = New System.Drawing.Size(196, 33)
        Me.kayit_btn.TabIndex = 6
        Me.kayit_btn.Text = "Kayıt Ol"
        Me.kayit_btn.UseVisualStyleBackColor = False
        '
        'giris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(544, 317)
        Me.Controls.Add(Me.kayit_btn)
        Me.Controls.Add(Me.giris_btn)
        Me.Controls.Add(Me.password_tb)
        Me.Controls.Add(Me.username_tb)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "giris"
        Me.Text = "giris"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents username_tb As TextBox
    Friend WithEvents password_tb As TextBox
    Friend WithEvents giris_btn As Button
    Friend WithEvents kayit_btn As Button
End Class
