<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SRV
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTm = New System.Windows.Forms.Label()
        Me.tmHr = New System.Windows.Forms.Timer(Me.components)
        Me.tmPic = New System.Windows.Forms.Timer(Me.components)
        Me.tmMs = New System.Windows.Forms.Timer(Me.components)
        Me.dlgOp = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'lblTm
        '
        Me.lblTm.AutoSize = True
        Me.lblTm.BackColor = System.Drawing.Color.Transparent
        Me.lblTm.Font = New System.Drawing.Font("Century751 BT", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTm.ForeColor = System.Drawing.Color.White
        Me.lblTm.Location = New System.Drawing.Point(-11, 295)
        Me.lblTm.Name = "lblTm"
        Me.lblTm.Size = New System.Drawing.Size(349, 115)
        Me.lblTm.TabIndex = 0
        Me.lblTm.Text = "Tempo"
        Me.lblTm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmHr
        '
        Me.tmHr.Interval = 1000
        '
        'tmPic
        '
        Me.tmPic.Interval = 30000
        '
        'tmMs
        '
        Me.tmMs.Enabled = True
        Me.tmMs.Interval = 30000
        '
        'dlgOp
        '
        Me.dlgOp.Multiselect = True
        Me.dlgOp.RestoreDirectory = True
        Me.dlgOp.Title = "Adicionar Fotos"
        '
        'SRV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(324, 415)
        Me.Controls.Add(Me.lblTm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "SRV"
        Me.Text = "Proteção de tela"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTm As System.Windows.Forms.Label
    Friend WithEvents tmHr As System.Windows.Forms.Timer
    Friend WithEvents tmPic As System.Windows.Forms.Timer
    Friend WithEvents tmMs As System.Windows.Forms.Timer
    Friend WithEvents dlgOp As System.Windows.Forms.OpenFileDialog

End Class
