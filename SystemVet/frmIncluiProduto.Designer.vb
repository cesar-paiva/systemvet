<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncluiProduto
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
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.CodCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DescricaoProduto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Valor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Estoque = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Marca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTipoFiltro = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodCliente, Me.DescricaoProduto, Me.Valor, Me.Estoque, Me.Marca, Me.ColumnHeader1})
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.Location = New System.Drawing.Point(5, 55)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(755, 375)
        Me.lsvDados.TabIndex = 28
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
        Me.DescricaoProduto.Width = 225
        '
        'Valor
        '
        Me.Valor.Text = "Valor"
        Me.Valor.Width = 70
        '
        'Estoque
        '
        Me.Estoque.Text = "Estoque Atual"
        Me.Estoque.Width = 110
        '
        'Marca
        '
        Me.Marca.Text = "Marca"
        Me.Marca.Width = 146
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Categoria"
        Me.ColumnHeader1.Width = 120
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(5, 25)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(371, 20)
        Me.txtBusca.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Pesquisar Produto"
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboCategoria.Location = New System.Drawing.Point(560, 26)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(172, 21)
        Me.cboCategoria.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(557, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Filtro por Categoria"
        '
        'cboTipoFiltro
        '
        Me.cboTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoFiltro.FormattingEnabled = True
        Me.cboTipoFiltro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboTipoFiltro.Location = New System.Drawing.Point(382, 26)
        Me.cboTipoFiltro.Name = "cboTipoFiltro"
        Me.cboTipoFiltro.Size = New System.Drawing.Size(172, 21)
        Me.cboTipoFiltro.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(379, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Ordem da Pesquisa"
        '
        'frmIncluiProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 434)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTipoFiltro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBusca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsvDados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(786, 476)
        Me.MinimizeBox = False
        Me.Name = "frmIncluiProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet :: Incluir Produto e Serviços"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsvDados As System.Windows.Forms.ListView
    Friend WithEvents CodCliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents DescricaoProduto As System.Windows.Forms.ColumnHeader
    Friend WithEvents Valor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Estoque As System.Windows.Forms.ColumnHeader
    Friend WithEvents Marca As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtBusca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTipoFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
