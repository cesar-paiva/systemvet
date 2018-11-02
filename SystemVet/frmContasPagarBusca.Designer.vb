<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContasPagarBusca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContasPagarBusca))
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPagamento = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.txtData = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvDados.Location = New System.Drawing.Point(6, 28)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(966, 413)
        Me.lsvDados.TabIndex = 53
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cód."
        Me.ColumnHeader1.Width = 48
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descrição Conta"
        Me.ColumnHeader2.Width = 287
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data Vencimento"
        Me.ColumnHeader3.Width = 103
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Valor"
        Me.ColumnHeader4.Width = 73
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Data Pagamento"
        Me.ColumnHeader5.Width = 104
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Obs."
        Me.ColumnHeader6.Width = 325
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Green
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(6, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(966, 27)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "C O N T A S  À  P A G A R "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator1, Me.btnExcluir, Me.ToolStripSeparator2, Me.btnPagamento, Me.ToolStripSeparator3, Me.btnNovo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 450)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(981, 53)
        Me.ToolStrip1.TabIndex = 55
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnFechar
        '
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(80, 50)
        Me.btnFechar.Text = "F&echar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'btnExcluir
        '
        Me.btnExcluir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = Global.SystemVet.My.Resources.Resources._1401220575_file_delete
        Me.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(131, 50)
        Me.btnExcluir.Text = "&Excluir Conta"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 53)
        '
        'btnPagamento
        '
        Me.btnPagamento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagamento.Image = Global.SystemVet.My.Resources.Resources.US_dollar
        Me.btnPagamento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPagamento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPagamento.Name = "btnPagamento"
        Me.btnPagamento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPagamento.Size = New System.Drawing.Size(122, 50)
        Me.btnPagamento.Text = "&Pagamento"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        '
        'btnNovo
        '
        Me.btnNovo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(123, 50)
        Me.btnNovo.Text = "&Nova Conta"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'txtData
        '
        Me.txtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtData.Location = New System.Drawing.Point(117, 469)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(111, 22)
        Me.txtData.TabIndex = 57
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.Location = New System.Drawing.Point(12, 472)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Busca por Data:"
        '
        'frmContasPagarBusca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 503)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lsvDados)
        Me.Name = "frmContasPagarBusca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet : :Busca de Contas a Pagar"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsvDados As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPagamento As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
