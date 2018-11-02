<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendas))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDataPedido = New System.Windows.Forms.DateTimePicker()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.txtItens = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFinalizarPedido = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluirProduto = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnIncluirProduto = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPedido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.rdbtnOrcamento = New System.Windows.Forms.RadioButton()
        Me.rdbtnPedidoVenda = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Data Pedido"
        '
        'dtpDataPedido
        '
        Me.dtpDataPedido.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataPedido.Location = New System.Drawing.Point(89, 24)
        Me.dtpDataPedido.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDataPedido.Name = "dtpDataPedido"
        Me.dtpDataPedido.Size = New System.Drawing.Size(85, 20)
        Me.dtpDataPedido.TabIndex = 7
        '
        'cboCliente
        '
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(262, 24)
        Me.cboCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(351, 21)
        Me.cboCliente.TabIndex = 0
        '
        'txtItens
        '
        Me.txtItens.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItens.ForeColor = System.Drawing.Color.Blue
        Me.txtItens.Location = New System.Drawing.Point(542, 354)
        Me.txtItens.Margin = New System.Windows.Forms.Padding(2)
        Me.txtItens.Multiline = True
        Me.txtItens.Name = "txtItens"
        Me.txtItens.Size = New System.Drawing.Size(58, 36)
        Me.txtItens.TabIndex = 21
        Me.txtItens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(540, 338)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Nº Itens"
        '
        'txtDesconto
        '
        Me.txtDesconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.Location = New System.Drawing.Point(606, 354)
        Me.txtDesconto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(63, 19)
        Me.txtDesconto.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(604, 338)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Desconto"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(677, 338)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "TOTAL R$"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Red
        Me.txtTotal.Location = New System.Drawing.Point(680, 354)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(116, 55)
        Me.txtTotal.TabIndex = 29
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.Location = New System.Drawing.Point(11, 82)
        Me.lsvDados.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(786, 254)
        Me.lsvDados.TabIndex = 30
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cod."
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descrição do Produto"
        Me.ColumnHeader2.Width = 280
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Valor Unitário"
        Me.ColumnHeader4.Width = 86
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Quantidade de Itens"
        Me.ColumnHeader5.Width = 114
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Valor TOTAL R$"
        Me.ColumnHeader7.Width = 123
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator2, Me.btnImprimir, Me.ToolStripSeparator4, Me.btnFinalizarPedido, Me.ToolStripSeparator3, Me.btnExcluirProduto, Me.ToolStripSeparator1, Me.btnIncluirProduto})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 411)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(810, 54)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnFechar
        '
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFechar.Size = New System.Drawing.Size(96, 51)
        Me.btnFechar.Text = "F&echar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnImprimir.Size = New System.Drawing.Size(108, 51)
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 54)
        '
        'btnFinalizarPedido
        '
        Me.btnFinalizarPedido.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizarPedido.Image = CType(resources.GetObject("btnFinalizarPedido.Image"), System.Drawing.Image)
        Me.btnFinalizarPedido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFinalizarPedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFinalizarPedido.Name = "btnFinalizarPedido"
        Me.btnFinalizarPedido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnFinalizarPedido.Size = New System.Drawing.Size(145, 51)
        Me.btnFinalizarPedido.Text = "&Finalizar Pedido"
        Me.btnFinalizarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 54)
        '
        'btnExcluirProduto
        '
        Me.btnExcluirProduto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluirProduto.Image = CType(resources.GetObject("btnExcluirProduto.Image"), System.Drawing.Image)
        Me.btnExcluirProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExcluirProduto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluirProduto.Name = "btnExcluirProduto"
        Me.btnExcluirProduto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExcluirProduto.Size = New System.Drawing.Size(144, 51)
        Me.btnExcluirProduto.Text = "&Excluir Produto"
        Me.btnExcluirProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'btnIncluirProduto
        '
        Me.btnIncluirProduto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncluirProduto.Image = CType(resources.GetObject("btnIncluirProduto.Image"), System.Drawing.Image)
        Me.btnIncluirProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnIncluirProduto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIncluirProduto.Name = "btnIncluirProduto"
        Me.btnIncluirProduto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnIncluirProduto.Size = New System.Drawing.Size(142, 51)
        Me.btnIncluirProduto.Text = "&Incluir Produto"
        Me.btnIncluirProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Green
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(11, 54)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(786, 26)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "V E N D A S"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº Pedido"
        '
        'txtPedido
        '
        Me.txtPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedido.ForeColor = System.Drawing.Color.Red
        Me.txtPedido.Location = New System.Drawing.Point(11, 22)
        Me.txtPedido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Size = New System.Drawing.Size(52, 23)
        Me.txtPedido.TabIndex = 5
        Me.txtPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hora"
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(188, 24)
        Me.txtHora.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(52, 20)
        Me.txtHora.TabIndex = 6
        '
        'rdbtnOrcamento
        '
        Me.rdbtnOrcamento.AutoSize = True
        Me.rdbtnOrcamento.Location = New System.Drawing.Point(725, 24)
        Me.rdbtnOrcamento.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtnOrcamento.Name = "rdbtnOrcamento"
        Me.rdbtnOrcamento.Size = New System.Drawing.Size(77, 17)
        Me.rdbtnOrcamento.TabIndex = 2
        Me.rdbtnOrcamento.TabStop = True
        Me.rdbtnOrcamento.Text = "Orçamento"
        Me.rdbtnOrcamento.UseVisualStyleBackColor = True
        '
        'rdbtnPedidoVenda
        '
        Me.rdbtnPedidoVenda.AutoSize = True
        Me.rdbtnPedidoVenda.Location = New System.Drawing.Point(617, 24)
        Me.rdbtnPedidoVenda.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtnPedidoVenda.Name = "rdbtnPedidoVenda"
        Me.rdbtnPedidoVenda.Size = New System.Drawing.Size(107, 17)
        Me.rdbtnPedidoVenda.TabIndex = 1
        Me.rdbtnPedidoVenda.TabStop = True
        Me.rdbtnPedidoVenda.Text = "Pedido de Venda"
        Me.rdbtnPedidoVenda.UseVisualStyleBackColor = True
        '
        'frmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 465)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lsvDados)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDesconto)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtItens)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rdbtnOrcamento)
        Me.Controls.Add(Me.rdbtnPedidoVenda)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.dtpDataPedido)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.txtPedido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet  : :  Vendas em Geral"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDataPedido As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtItens As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDesconto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lsvDados As System.Windows.Forms.ListView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFinalizarPedido As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluirProduto As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnIncluirProduto As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents rdbtnOrcamento As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnPedidoVenda As System.Windows.Forms.RadioButton
End Class
