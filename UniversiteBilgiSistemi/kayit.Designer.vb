<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kayit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(kayit))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.regusername_tb = New System.Windows.Forms.TextBox()
        Me.regpassword_tb = New System.Windows.Forms.TextBox()
        Me.register_btn = New System.Windows.Forms.Button()
        Me.togiris_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kullanıcı Adı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Şifre"
        '
        'regusername_tb
        '
        Me.regusername_tb.Location = New System.Drawing.Point(156, 90)
        Me.regusername_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.regusername_tb.Name = "regusername_tb"
        Me.regusername_tb.Size = New System.Drawing.Size(188, 23)
        Me.regusername_tb.TabIndex = 2
        '
        'regpassword_tb
        '
        Me.regpassword_tb.Location = New System.Drawing.Point(156, 140)
        Me.regpassword_tb.Margin = New System.Windows.Forms.Padding(2)
        Me.regpassword_tb.Name = "regpassword_tb"
        Me.regpassword_tb.Size = New System.Drawing.Size(188, 23)
        Me.regpassword_tb.TabIndex = 3
        '
        'register_btn
        '
        Me.register_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.register_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.register_btn.Location = New System.Drawing.Point(118, 196)
        Me.register_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.register_btn.Name = "register_btn"
        Me.register_btn.Size = New System.Drawing.Size(90, 34)
        Me.register_btn.TabIndex = 4
        Me.register_btn.Text = "Kaydol"
        Me.register_btn.UseVisualStyleBackColor = False
        '
        'togiris_btn
        '
        Me.togiris_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.togiris_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.togiris_btn.Location = New System.Drawing.Point(214, 196)
        Me.togiris_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.togiris_btn.Name = "togiris_btn"
        Me.togiris_btn.Size = New System.Drawing.Size(85, 34)
        Me.togiris_btn.TabIndex = 5
        Me.togiris_btn.Text = "Giriş Ekranı"
        Me.togiris_btn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(152, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kayıt olun !"
        '
        'kayit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(437, 286)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.togiris_btn)
        Me.Controls.Add(Me.register_btn)
        Me.Controls.Add(Me.regpassword_tb)
        Me.Controls.Add(Me.regusername_tb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "kayit"
        Me.Text = "kayit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents regusername_tb As TextBox
    Friend WithEvents regpassword_tb As TextBox
    Friend WithEvents register_btn As Button
    Friend WithEvents togiris_btn As Button
    Friend WithEvents Label3 As Label
End Class
