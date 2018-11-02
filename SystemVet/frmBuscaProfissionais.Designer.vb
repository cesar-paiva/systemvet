<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscaProfissionais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscaProfissionais))
        Me.txtBuscaProfissional = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.CodFuncionario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NomeFuncionario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContatoFuncionario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBuscaProfissional
        '
        Me.txtBuscaProfissional.Location = New System.Drawing.Point(12, 25)
        Me.txtBuscaProfissional.Name = "txtBuscaProfissional"
        Me.txtBuscaProfissional.Size = New System.Drawing.Size(640, 20)
        Me.txtBuscaProfissional.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Pesquisar por Nome do Funcionário"
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodFuncionario, Me.NomeFuncionario, Me.ContatoFuncionario})
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.Location = New System.Drawing.Point(12, 86)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(640, 229)
        Me.lsvDados.TabIndex = 19
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'CodFuncionario
        '
        Me.CodFuncionario.Text = "Cód."
        '
        'NomeFuncionario
        '
        Me.NomeFuncionario.Text = "Nome"
        Me.NomeFuncionario.Width = 300
        '
        'ContatoFuncionario
        '
        Me.ContatoFuncionario.Text = "Contato"
        Me.ContatoFuncionario.Width = 274
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator4, Me.btnExcluir, Me.ToolStripSeparator2, Me.btnNovo, Me.ToolStripSeparator3, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 316)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(660, 53)
        Me.ToolStrip1.TabIndex = 20
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
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        Me.ToolStripSeparator3.Visible = False
        '
        'btnNovo
        '
        Me.btnNovo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(89, 50)
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Green
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(11, 60)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(642, 26)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "P E S Q U I S A  DE  P R O F I S S I O N A I S"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBuscaProfissionais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 369)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lsvDados)
        Me.Controls.Add(Me.txtBuscaProfissional)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBuscaProfissionais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet :: Busca por Profissionais"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscaProfissional As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lsvDados As System.Windows.Forms.ListView
    Friend WithEvents CodFuncionario As System.Windows.Forms.ColumnHeader
    Friend WithEvents NomeFuncionario As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContatoFuncionario As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNovo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
