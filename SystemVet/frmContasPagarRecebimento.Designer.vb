<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContasPagarRecebimento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContasPagarRecebimento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPagar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDataVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDataPagamento = New System.Windows.Forms.MaskedTextBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnConfirmar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtCodigo = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Valor a Pagar"
        '
        'txtPagar
        '
        Me.txtPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagar.Location = New System.Drawing.Point(241, 35)
        Me.txtPagar.Name = "txtPagar"
        Me.txtPagar.Size = New System.Drawing.Size(104, 24)
        Me.txtPagar.TabIndex = 35
        Me.txtPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Data Vencimento"
        '
        'txtDataVencimento
        '
        Me.txtDataVencimento.BackColor = System.Drawing.SystemColors.Window
        Me.txtDataVencimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataVencimento.Location = New System.Drawing.Point(85, 35)
        Me.txtDataVencimento.Mask = "00/00/0000"
        Me.txtDataVencimento.Name = "txtDataVencimento"
        Me.txtDataVencimento.Size = New System.Drawing.Size(99, 26)
        Me.txtDataVencimento.TabIndex = 34
        Me.txtDataVencimento.Text = "00000000"
        Me.txtDataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Valor Pago"
        '
        'txtPago
        '
        Me.txtPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.Location = New System.Drawing.Point(119, 102)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(104, 22)
        Me.txtPago.TabIndex = 1
        Me.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 15)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Data Pagamento"
        '
        'txtDataPagamento
        '
        Me.txtDataPagamento.BackColor = System.Drawing.SystemColors.Window
        Me.txtDataPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataPagamento.Location = New System.Drawing.Point(12, 102)
        Me.txtDataPagamento.Mask = "00/00/0000"
        Me.txtDataPagamento.Name = "txtDataPagamento"
        Me.txtDataPagamento.Size = New System.Drawing.Size(98, 22)
        Me.txtDataPagamento.TabIndex = 0
        Me.txtDataPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -2
        Me.LineShape1.X2 = 434
        Me.LineShape1.Y1 = 75
        Me.LineShape1.Y2 = 75
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(435, 327)
        Me.ShapeContainer1.TabIndex = 42
        Me.ShapeContainer1.TabStop = False
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.White
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.Location = New System.Drawing.Point(12, 145)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(420, 122)
        Me.txtObs.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Observações"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar, Me.ToolStripSeparator1, Me.btnConfirmar, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 274)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(435, 53)
        Me.ToolStrip1.TabIndex = 56
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 50)
        Me.btnCancelar.Text = "C&ancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 53)
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Image = Global.SystemVet.My.Resources.Resources.pagamento
        Me.btnConfirmar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnConfirmar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnConfirmar.Size = New System.Drawing.Size(115, 50)
        Me.btnConfirmar.Text = "&Confirmar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 53)
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(3, 296)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(68, 22)
        Me.txtCodigo.TabIndex = 79
        Me.txtCodigo.Text = "Tipo"
        Me.txtCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtCodigo.Visible = False
        '
        'frmContasPagarRecebimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 327)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDataPagamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPagar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDataVencimento)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmContasPagarRecebimento"
        Me.Text = "frmContasPagarRecebimento"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPagar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDataVencimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPago As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDataPagamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnConfirmar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtCodigo As System.Windows.Forms.Label
End Class
