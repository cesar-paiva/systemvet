<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesquisaVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPesquisaVendas))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.txtData = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnResumoVendas = New System.Windows.Forms.ToolStripButton()
        Me.btnExcluirVenda = New System.Windows.Forms.ToolStripButton()
        Me.btnAlterarVenda = New System.Windows.Forms.ToolStripButton()
        Me.btnNovaVenda = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pesquisa por Cliente"
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(12, 25)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(328, 21)
        Me.cboCliente.TabIndex = 4
        '
        'txtData
        '
        Me.txtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtData.Location = New System.Drawing.Point(665, 26)
        Me.txtData.Margin = New System.Windows.Forms.Padding(2)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(85, 20)
        Me.txtData.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(662, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Busca por Data"
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader8})
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.Location = New System.Drawing.Point(12, 52)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(738, 294)
        Me.lsvDados.TabIndex = 9
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nº"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nome do Cliente"
        Me.ColumnHeader2.Width = 221
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data Venda"
        Me.ColumnHeader3.Width = 77
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Valor TOTAL"
        Me.ColumnHeader4.Width = 92
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Status Venda"
        Me.ColumnHeader8.Width = 114
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator2, Me.btnResumoVendas, Me.btnExcluirVenda, Me.btnAlterarVenda, Me.btnNovaVenda})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 358)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(770, 54)
        Me.ToolStrip1.TabIndex = 24
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
        'btnResumoVendas
        '
        Me.btnResumoVendas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResumoVendas.Image = Global.SystemVet.My.Resources.Resources.report
        Me.btnResumoVendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnResumoVendas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnResumoVendas.Name = "btnResumoVendas"
        Me.btnResumoVendas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnResumoVendas.Size = New System.Drawing.Size(167, 51)
        Me.btnResumoVendas.Text = "Re&sumo das Vendas"
        Me.btnResumoVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnExcluirVenda
        '
        Me.btnExcluirVenda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluirVenda.Image = Global.SystemVet.My.Resources.Resources._1401220575_file_delete
        Me.btnExcluirVenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExcluirVenda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluirVenda.Name = "btnExcluirVenda"
        Me.btnExcluirVenda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExcluirVenda.Size = New System.Drawing.Size(133, 51)
        Me.btnExcluirVenda.Text = "&Excluir Venda"
        Me.btnExcluirVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnAlterarVenda
        '
        Me.btnAlterarVenda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterarVenda.Image = Global.SystemVet.My.Resources.Resources.alterar
        Me.btnAlterarVenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAlterarVenda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAlterarVenda.Name = "btnAlterarVenda"
        Me.btnAlterarVenda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAlterarVenda.Size = New System.Drawing.Size(135, 51)
        Me.btnAlterarVenda.Text = "&Alterar Venda"
        Me.btnAlterarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnNovaVenda
        '
        Me.btnNovaVenda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovaVenda.Image = Global.SystemVet.My.Resources.Resources.novo
        Me.btnNovaVenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNovaVenda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovaVenda.Name = "btnNovaVenda"
        Me.btnNovaVenda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnNovaVenda.Size = New System.Drawing.Size(125, 51)
        Me.btnNovaVenda.Text = "&Nova Venda"
        Me.btnNovaVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Pesquisa por Situação"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(346, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(314, 20)
        Me.TextBox1.TabIndex = 26
        '
        'frmPesquisaVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 412)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lsvDados)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmPesquisaVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet  : : Pesquisa de Vendas Geral"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lsvDados As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnResumoVendas As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluirVenda As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAlterarVenda As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNovaVenda As System.Windows.Forms.ToolStripButton
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
