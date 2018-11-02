<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendasResumo
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDetalheVenda = New System.Windows.Forms.ToolStripButton()
        Me.btnFechamento = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.cboClientes = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.txtTotalVenda = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator1, Me.btnDetalheVenda, Me.btnFechamento, Me.btnImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 353)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1022, 58)
        Me.ToolStrip1.TabIndex = 69
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.SystemVet.My.Resources.Resources.close_window32
        Me.btnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnFechar.Size = New System.Drawing.Size(80, 55)
        Me.btnFechar.Text = "F&echar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'btnDetalheVenda
        '
        Me.btnDetalheVenda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnDetalheVenda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalheVenda.Image = Global.SystemVet.My.Resources.Resources.venda_detalhes
        Me.btnDetalheVenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDetalheVenda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDetalheVenda.Name = "btnDetalheVenda"
        Me.btnDetalheVenda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDetalheVenda.Size = New System.Drawing.Size(145, 55)
        Me.btnDetalheVenda.Text = "&Detalhar Venda"
        Me.btnDetalheVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnFechamento
        '
        Me.btnFechamento.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnFechamento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechamento.Image = Global.SystemVet.My.Resources.Resources.venda_fechar1
        Me.btnFechamento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFechamento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFechamento.Name = "btnFechamento"
        Me.btnFechamento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnFechamento.Size = New System.Drawing.Size(171, 55)
        Me.btnFechamento.Text = "&Fechamento Vendas"
        Me.btnFechamento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnImprimir
        '
        Me.btnImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SystemVet.My.Resources.Resources.print_icon
        Me.btnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnImprimir.Size = New System.Drawing.Size(108, 55)
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape1.FillColor = System.Drawing.Color.Green
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(5, 1)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1006, 57)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1022, 411)
        Me.ShapeContainer1.TabIndex = 70
        Me.ShapeContainer1.TabStop = False
        '
        'cboClientes
        '
        Me.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.Location = New System.Drawing.Point(14, 24)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(471, 24)
        Me.cboClientes.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Green
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Cliente"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrar.Location = New System.Drawing.Point(714, 9)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(85, 42)
        Me.btnFiltrar.TabIndex = 75
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = False
        '
        'txtTotalVenda
        '
        Me.txtTotalVenda.BackColor = System.Drawing.Color.Green
        Me.txtTotalVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVenda.ForeColor = System.Drawing.Color.White
        Me.txtTotalVenda.Location = New System.Drawing.Point(859, 25)
        Me.txtTotalVenda.Name = "txtTotalVenda"
        Me.txtTotalVenda.Size = New System.Drawing.Size(142, 30)
        Me.txtTotalVenda.TabIndex = 79
        Me.txtTotalVenda.Text = "0,00"
        Me.txtTotalVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Green
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(898, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Total Vendas"
        '
        'txtFinal
        '
        Me.txtFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFinal.Location = New System.Drawing.Point(599, 27)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(101, 22)
        Me.txtFinal.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(596, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Data Final"
        '
        'txtInicial
        '
        Me.txtInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtInicial.Location = New System.Drawing.Point(492, 27)
        Me.txtInicial.Name = "txtInicial"
        Me.txtInicial.Size = New System.Drawing.Size(101, 22)
        Me.txtInicial.TabIndex = 73
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Green
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(489, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 16)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Data Inicial"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Green
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(5, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1007, 26)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "R E S U M O  DE  V E N D A S"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.Location = New System.Drawing.Point(5, 89)
        Me.lsvDados.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(1007, 254)
        Me.lsvDados.TabIndex = 82
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cod. Venda"
        Me.ColumnHeader1.Width = 82
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cliente"
        Me.ColumnHeader2.Width = 522
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Data Venda"
        Me.ColumnHeader4.Width = 86
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Valor R$"
        Me.ColumnHeader5.Width = 114
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        Me.ColumnHeader7.Width = 173
        '
        'frmVendasResumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 411)
        Me.Controls.Add(Me.lsvDados)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.txtTotalVenda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInicial)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboClientes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmVendasResumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet : : Resumo de Vendas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDetalheVenda As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFechamento As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents cboClientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents txtTotalVenda As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lsvDados As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class
