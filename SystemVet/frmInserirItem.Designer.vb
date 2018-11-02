<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInserirItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInserirItem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCalculadora = New System.Windows.Forms.ToolStripButton()
        Me.txtQuantia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVenda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descrição do Produto/Serviço"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Código do Item"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(15, 64)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.ReadOnly = True
        Me.txtDescricao.Size = New System.Drawing.Size(310, 20)
        Me.txtDescricao.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(15, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(75, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.Color.White
        Me.txtValor.Location = New System.Drawing.Point(15, 103)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.ReadOnly = True
        Me.txtValor.Size = New System.Drawing.Size(74, 20)
        Me.txtValor.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Valor Unitário"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExcluir, Me.ToolStripSeparator2, Me.btnSalvar, Me.ToolStripSeparator1, Me.btnCalculadora})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 141)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip2.Size = New System.Drawing.Size(337, 58)
        Me.ToolStrip2.TabIndex = 16
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnExcluir
        '
        Me.btnExcluir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = Global.SystemVet.My.Resources.Resources.close_window32
        Me.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(80, 55)
        Me.btnExcluir.Text = "F&echar"
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 58)
        '
        'btnSalvar
        '
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(93, 55)
        Me.btnSalvar.Text = "Sal&var"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        '
        'btnCalculadora
        '
        Me.btnCalculadora.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculadora.Image = Global.SystemVet.My.Resources.Resources.calculator32
        Me.btnCalculadora.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCalculadora.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCalculadora.Name = "btnCalculadora"
        Me.btnCalculadora.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCalculadora.Size = New System.Drawing.Size(122, 55)
        Me.btnCalculadora.Text = "Calculadora"
        '
        'txtQuantia
        '
        Me.txtQuantia.Location = New System.Drawing.Point(280, 103)
        Me.txtQuantia.Name = "txtQuantia"
        Me.txtQuantia.Size = New System.Drawing.Size(44, 20)
        Me.txtQuantia.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Qtd"
        '
        'txtVenda
        '
        Me.txtVenda.Location = New System.Drawing.Point(246, 25)
        Me.txtVenda.Name = "txtVenda"
        Me.txtVenda.ReadOnly = True
        Me.txtVenda.Size = New System.Drawing.Size(75, 20)
        Me.txtVenda.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Código Venda"
        '
        'frmInserirItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 199)
        Me.Controls.Add(Me.txtVenda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQuantia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(353, 233)
        Me.Name = "frmInserirItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet :: Inserir Itens"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCalculadora As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtQuantia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVenda As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
