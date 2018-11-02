<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackup))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.pctboxBackup = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.pctboxBackup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Controls.Add(Me.pctboxBackup)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(5, 3)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(713, 367)
        Me.Panel2.TabIndex = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(247, 271)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(200, 26)
        Me.ProgressBar1.TabIndex = 10
        '
        'pctboxBackup
        '
        Me.pctboxBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctboxBackup.Image = CType(resources.GetObject("pctboxBackup.Image"), System.Drawing.Image)
        Me.pctboxBackup.Location = New System.Drawing.Point(305, 130)
        Me.pctboxBackup.Margin = New System.Windows.Forms.Padding(2)
        Me.pctboxBackup.Name = "pctboxBackup"
        Me.pctboxBackup.Size = New System.Drawing.Size(99, 116)
        Me.pctboxBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctboxBackup.TabIndex = 8
        Me.pctboxBackup.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 37)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(707, 27)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "BACKUP"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 371)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet :: Backup"
        Me.Panel2.ResumeLayout(False)
        CType(Me.pctboxBackup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents pctboxBackup As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
