<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tanıtım
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
        Me.tanıtım_rtb = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'tanıtım_rtb
        '
        Me.tanıtım_rtb.Location = New System.Drawing.Point(12, 12)
        Me.tanıtım_rtb.Name = "tanıtım_rtb"
        Me.tanıtım_rtb.Size = New System.Drawing.Size(1012, 454)
        Me.tanıtım_rtb.TabIndex = 0
        Me.tanıtım_rtb.Text = ""
        '
        'Tanıtım
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 478)
        Me.Controls.Add(Me.tanıtım_rtb)
        Me.Name = "Tanıtım"
        Me.Text = "Tanıtım"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tanıtım_rtb As RichTextBox
End Class
