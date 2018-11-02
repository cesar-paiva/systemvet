<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroProduto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.dtpCadastro = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboUnidade = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEstoqueAtual = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEstoqueMinimo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMargem = New System.Windows.Forms.MaskedTextBox()
        Me.txtValorVenda = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtValorCusto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnConsultarCompra = New System.Windows.Forms.Button()
        Me.btnConsultarFornecedor = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtObservaoes = New System.Windows.Forms.TextBox()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCategoria)
        Me.GroupBox1.Controls.Add(Me.dtpCadastro)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDescricao)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboUnidade)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodigoBarras)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Produto"
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(9, 126)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(292, 21)
        Me.cboCategoria.TabIndex = 5
        '
        'dtpCadastro
        '
        Me.dtpCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCadastro.Location = New System.Drawing.Point(315, 126)
        Me.dtpCadastro.Name = "dtpCadastro"
        Me.dtpCadastro.Size = New System.Drawing.Size(98, 20)
        Me.dtpCadastro.TabIndex = 14
        Me.dtpCadastro.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(312, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Data Cadastro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Grupo / Categoria"
        '
        'txtDescricao
        '
        Me.txtDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(9, 80)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(416, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descrição do Produto"
        '
        'cboUnidade
        '
        Me.cboUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnidade.FormattingEnabled = True
        Me.cboUnidade.Location = New System.Drawing.Point(361, 31)
        Me.cboUnidade.Name = "cboUnidade"
        Me.cboUnidade.Size = New System.Drawing.Size(65, 21)
        Me.cboUnidade.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(358, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Unidade"
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarras.Location = New System.Drawing.Point(101, 32)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(254, 20)
        Me.txtCodigoBarras.TabIndex = 1
        Me.txtCodigoBarras.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(9, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(87, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código de Barras"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEstoqueAtual)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtEstoqueMinimo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 93)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'txtEstoqueAtual
        '
        Me.txtEstoqueAtual.Location = New System.Drawing.Point(126, 36)
        Me.txtEstoqueAtual.Name = "txtEstoqueAtual"
        Me.txtEstoqueAtual.Size = New System.Drawing.Size(54, 20)
        Me.txtEstoqueAtual.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Estoque Atual"
        '
        'txtEstoqueMinimo
        '
        Me.txtEstoqueMinimo.Location = New System.Drawing.Point(126, 12)
        Me.txtEstoqueMinimo.Name = "txtEstoqueMinimo"
        Me.txtEstoqueMinimo.Size = New System.Drawing.Size(54, 20)
        Me.txtEstoqueMinimo.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Estoque Mínimo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMargem)
        Me.GroupBox3.Controls.Add(Me.txtValorVenda)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtValorCusto)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(244, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 93)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'txtMargem
        '
        Me.txtMargem.Location = New System.Drawing.Point(96, 36)
        Me.txtMargem.Name = "txtMargem"
        Me.txtMargem.Size = New System.Drawing.Size(98, 20)
        Me.txtMargem.TabIndex = 15
        '
        'txtValorVenda
        '
        Me.txtValorVenda.Location = New System.Drawing.Point(96, 61)
        Me.txtValorVenda.Name = "txtValorVenda"
        Me.txtValorVenda.Size = New System.Drawing.Size(98, 20)
        Me.txtValorVenda.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Valor de Venda"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "(%) Margem"
        '
        'txtValorCusto
        '
        Me.txtValorCusto.Location = New System.Drawing.Point(96, 13)
        Me.txtValorCusto.Name = "txtValorCusto"
        Me.txtValorCusto.Size = New System.Drawing.Size(98, 20)
        Me.txtValorCusto.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Valor CUSTO"
        '
        'btnConsultarCompra
        '
        Me.btnConsultarCompra.Location = New System.Drawing.Point(13, 306)
        Me.btnConsultarCompra.Name = "btnConsultarCompra"
        Me.btnConsultarCompra.Size = New System.Drawing.Size(200, 31)
        Me.btnConsultarCompra.TabIndex = 22
        Me.btnConsultarCompra.Text = "Consultar Compras desse Produto"
        Me.btnConsultarCompra.UseVisualStyleBackColor = True
        Me.btnConsultarCompra.Visible = False
        '
        'btnConsultarFornecedor
        '
        Me.btnConsultarFornecedor.Location = New System.Drawing.Point(244, 305)
        Me.btnConsultarFornecedor.Name = "btnConsultarFornecedor"
        Me.btnConsultarFornecedor.Size = New System.Drawing.Size(200, 31)
        Me.btnConsultarFornecedor.TabIndex = 23
        Me.btnConsultarFornecedor.Text = "Consultar Fornecedor desse Produto"
        Me.btnConsultarFornecedor.UseVisualStyleBackColor = True
        Me.btnConsultarFornecedor.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(11, 350)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(103, 13)
        Me.Label25.TabIndex = 24
        Me.Label25.Text = "Observações Gerais"
        '
        'txtObservaoes
        '
        Me.txtObservaoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtObservaoes.Location = New System.Drawing.Point(11, 365)
        Me.txtObservaoes.Margin = New System.Windows.Forms.Padding(2)
        Me.txtObservaoes.Multiline = True
        Me.txtObservaoes.Name = "txtObservaoes"
        Me.txtObservaoes.Size = New System.Drawing.Size(437, 86)
        Me.txtObservaoes.TabIndex = 17
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
        Me.btnFechar.Size = New System.Drawing.Size(80, 56)
        Me.btnFechar.Text = "F&echar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnSalvar
        '
        Me.btnSalvar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSalvar.Size = New System.Drawing.Size(93, 56)
        Me.btnSalvar.Text = "&Salvar"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator2, Me.btnSalvar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 445)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(454, 59)
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 59)
        '
        'cboFornecedor
        '
        Me.cboFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFornecedor.FormattingEnabled = True
        Me.cboFornecedor.Location = New System.Drawing.Point(22, 192)
        Me.cboFornecedor.Name = "cboFornecedor"
        Me.cboFornecedor.Size = New System.Drawing.Size(426, 21)
        Me.cboFornecedor.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 175)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Fornecedor"
        '
        'frmCadastroProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 504)
        Me.Controls.Add(Me.cboFornecedor)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtObservaoes)
        Me.Controls.Add(Me.btnConsultarFornecedor)
        Me.Controls.Add(Me.btnConsultarCompra)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmCadastroProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet  : :  Cadastro de Produto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboUnidade As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBarras As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpCadastro As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEstoqueAtual As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEstoqueMinimo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMargem As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtValorVenda As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtValorCusto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnConsultarCompra As System.Windows.Forms.Button
    Friend WithEvents btnConsultarFornecedor As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtObservaoes As System.Windows.Forms.TextBox
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboFornecedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
