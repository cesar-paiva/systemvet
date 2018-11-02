<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscaProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscaProduto))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNovoProduto = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNovoServico = New System.Windows.Forms.ToolStripButton()
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoFiltro = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.CodCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DescricaoProduto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Unidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Valor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EstoqueMinimo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Estoque = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GrupoCategoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Marca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator4, Me.btnExcluir, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.btnNovoProduto, Me.ToolStripSeparator1, Me.btnNovoServico})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 351)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(1028, 53)
        Me.ToolStrip1.TabIndex = 18
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 53)
        '
        'btnExcluir
        '
        Me.btnExcluir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(96, 50)
        Me.btnExcluir.Text = "Ex&cluir"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 53)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripButton1.Size = New System.Drawing.Size(108, 50)
        Me.ToolStripButton1.Text = "Imprimir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        '
        'btnNovoProduto
        '
        Me.btnNovoProduto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovoProduto.Image = CType(resources.GetObject("btnNovoProduto.Image"), System.Drawing.Image)
        Me.btnNovoProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNovoProduto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovoProduto.Name = "btnNovoProduto"
        Me.btnNovoProduto.Size = New System.Drawing.Size(137, 50)
        Me.btnNovoProduto.Text = "Novo &Produto"
        Me.btnNovoProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'btnNovoServico
        '
        Me.btnNovoServico.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovoServico.Image = CType(resources.GetObject("btnNovoServico.Image"), System.Drawing.Image)
        Me.btnNovoServico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNovoServico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovoServico.Name = "btnNovoServico"
        Me.btnNovoServico.Size = New System.Drawing.Size(134, 50)
        Me.btnNovoServico.Text = "Novo &Serviço"
        Me.btnNovoServico.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(11, 23)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(647, 20)
        Me.txtBusca.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Pesquisar Produto"
        '
        'cboTipoFiltro
        '
        Me.cboTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoFiltro.FormattingEnabled = True
        Me.cboTipoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboTipoFiltro.Location = New System.Drawing.Point(665, 21)
        Me.cboTipoFiltro.Name = "cboTipoFiltro"
        Me.cboTipoFiltro.Size = New System.Drawing.Size(172, 21)
        Me.cboTipoFiltro.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(662, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Ordem da Pesquisa"
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboCategoria.Location = New System.Drawing.Point(843, 22)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(172, 21)
        Me.cboCategoria.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(840, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Filtro por Categoria"
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodCliente, Me.DescricaoProduto, Me.Unidade, Me.Valor, Me.EstoqueMinimo, Me.Estoque, Me.GrupoCategoria, Me.Marca})
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.Location = New System.Drawing.Point(11, 86)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(1004, 255)
        Me.lsvDados.TabIndex = 27
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'CodCliente
        '
        Me.CodCliente.Text = "Cód."
        '
        'DescricaoProduto
        '
        Me.DescricaoProduto.Text = "Descrição do Produto / Serviço"
        Me.DescricaoProduto.Width = 250
        '
        'Unidade
        '
        Me.Unidade.Text = "Unid."
        Me.Unidade.Width = 100
        '
        'Valor
        '
        Me.Valor.Text = "Valor"
        Me.Valor.Width = 70
        '
        'EstoqueMinimo
        '
        Me.EstoqueMinimo.Text = "Estoque Minímo"
        Me.EstoqueMinimo.Width = 96
        '
        'Estoque
        '
        Me.Estoque.Text = "Estoque Atual"
        Me.Estoque.Width = 82
        '
        'GrupoCategoria
        '
        Me.GrupoCategoria.Text = "Grupo/Categoria"
        Me.GrupoCategoria.Width = 156
        '
        'Marca
        '
        Me.Marca.Text = "Marca"
        Me.Marca.Width = 163
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Green
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 60)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1003, 26)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "P E S Q U I S A  DE  P R O D U T O S"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBuscaProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 404)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lsvDados)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTipoFiltro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBusca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MinimumSize = New System.Drawing.Size(1027, 441)
        Me.Name = "frmBuscaProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet :: Busca por Produto e Serviços"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNovoProduto As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtBusca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipoFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lsvDados As System.Windows.Forms.ListView
    Friend WithEvents CodCliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents DescricaoProduto As System.Windows.Forms.ColumnHeader
    Friend WithEvents Unidade As System.Windows.Forms.ColumnHeader
    Friend WithEvents Valor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Estoque As System.Windows.Forms.ColumnHeader
    Friend WithEvents GrupoCategoria As System.Windows.Forms.ColumnHeader
    Friend WithEvents Marca As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnNovoServico As System.Windows.Forms.ToolStripButton
    Friend WithEvents EstoqueMinimo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
