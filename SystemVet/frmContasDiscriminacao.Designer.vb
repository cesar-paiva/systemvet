<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContasDiscriminacao
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.txtCredito = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDebito = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDinheiro = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCheques = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGeral = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Green
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDataFinal)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Status)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDataInicial)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 71)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Selecione a Data "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Data Final"
        '
        'txtDataFinal
        '
        Me.txtDataFinal.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataFinal.Location = New System.Drawing.Point(172, 35)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.Size = New System.Drawing.Size(148, 24)
        Me.txtDataFinal.TabIndex = 53
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscar.Location = New System.Drawing.Point(550, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(136, 49)
        Me.btnBuscar.TabIndex = 52
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.BackColor = System.Drawing.Color.Green
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.Location = New System.Drawing.Point(807, 17)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(0, 18)
        Me.Status.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Data Inicial"
        '
        'txtDataInicial
        '
        Me.txtDataInicial.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataInicial.Location = New System.Drawing.Point(18, 36)
        Me.txtDataInicial.Name = "txtDataInicial"
        Me.txtDataInicial.Size = New System.Drawing.Size(148, 24)
        Me.txtDataInicial.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Green
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(7, -1)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(706, 102)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "D I S C R I M I N A Ç Ã O  DE  C O N T A S"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvDados.Location = New System.Drawing.Point(7, 99)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(706, 298)
        Me.lsvDados.TabIndex = 67
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Data"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Dinheiro"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cartão Débito"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cartão Crédito"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Cheque"
        Me.ColumnHeader5.Width = 150
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator1, Me.btnImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 495)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(726, 58)
        Me.ToolStrip1.TabIndex = 68
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
        'txtCredito
        '
        Me.txtCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredito.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtCredito.Location = New System.Drawing.Point(279, 434)
        Me.txtCredito.Name = "txtCredito"
        Me.txtCredito.Size = New System.Drawing.Size(137, 30)
        Me.txtCredito.TabIndex = 74
        Me.txtCredito.Text = "0,00"
        Me.txtCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(274, 416)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 18)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Total Cartão Crédito"
        '
        'txtDebito
        '
        Me.txtDebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebito.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDebito.Location = New System.Drawing.Point(134, 434)
        Me.txtDebito.Name = "txtDebito"
        Me.txtDebito.Size = New System.Drawing.Size(134, 30)
        Me.txtDebito.TabIndex = 72
        Me.txtDebito.Text = "0,00"
        Me.txtDebito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(131, 416)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 18)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Total Cartão Débito"
        '
        'txtDinheiro
        '
        Me.txtDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDinheiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDinheiro.Location = New System.Drawing.Point(7, 434)
        Me.txtDinheiro.Name = "txtDinheiro"
        Me.txtDinheiro.Size = New System.Drawing.Size(121, 30)
        Me.txtDinheiro.TabIndex = 70
        Me.txtDinheiro.Text = "0,00"
        Me.txtDinheiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(4, 416)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 18)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "Total Dinheiro"
        '
        'txtCheques
        '
        Me.txtCheques.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheques.ForeColor = System.Drawing.Color.Red
        Me.txtCheques.Location = New System.Drawing.Point(422, 434)
        Me.txtCheques.Name = "txtCheques"
        Me.txtCheques.Size = New System.Drawing.Size(121, 30)
        Me.txtCheques.TabIndex = 80
        Me.txtCheques.Text = "0,00"
        Me.txtCheques.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(422, 416)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 18)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Total Cheques"
        '
        'txtGeral
        '
        Me.txtGeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGeral.Location = New System.Drawing.Point(592, 434)
        Me.txtGeral.Name = "txtGeral"
        Me.txtGeral.Size = New System.Drawing.Size(121, 30)
        Me.txtGeral.TabIndex = 78
        Me.txtGeral.Text = "0,00"
        Me.txtGeral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(621, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Total Geral"
        '
        'frmContasDiscriminacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 553)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCheques)
        Me.Controls.Add(Me.txtGeral)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCredito)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDebito)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDinheiro)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lsvDados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmContasDiscriminacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet  :: Discriminação de Contas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDataInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lsvDados As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDataFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCredito As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDebito As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDinheiro As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCheques As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtGeral As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
