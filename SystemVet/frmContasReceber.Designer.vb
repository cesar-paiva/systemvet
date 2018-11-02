<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContasReceber
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
        Me.btnFinalizar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRecuaData = New System.Windows.Forms.Button()
        Me.btnAvancaData = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fraCaixaInicial = New System.Windows.Forms.Panel()
        Me.txtOBS = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRecebido = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRecebimento = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtAReceber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVencimento = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtContaRecebida = New System.Windows.Forms.Label()
        Me.txtSaldoFinal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtContaReceber = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.fraCaixaInicial.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator1, Me.btnFinalizar, Me.btnImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 585)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(958, 58)
        Me.ToolStrip1.TabIndex = 30
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
        'btnFinalizar
        '
        Me.btnFinalizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnFinalizar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.Image = Global.SystemVet.My.Resources.Resources.caixa
        Me.btnFinalizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFinalizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnFinalizar.Size = New System.Drawing.Size(139, 55)
        Me.btnFinalizar.Text = "&Finalizar Conta"
        Me.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        Me.btnImprimir.Size = New System.Drawing.Size(154, 55)
        Me.btnImprimir.Text = "&Imprimir Relação"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvDados.Location = New System.Drawing.Point(9, 103)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(940, 413)
        Me.lsvDados.TabIndex = 52
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Forma Pagamento"
        Me.ColumnHeader1.Width = 173
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cliente"
        Me.ColumnHeader2.Width = 218
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Vencimento"
        Me.ColumnHeader3.Width = 77
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Valor"
        Me.ColumnHeader4.Width = 73
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Data Recebimento"
        Me.ColumnHeader5.Width = 104
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Valor Recebido"
        Me.ColumnHeader6.Width = 96
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Obs."
        Me.ColumnHeader7.Width = 227
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Green
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDataFinal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDataInicial)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Status)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnRecuaData)
        Me.GroupBox1.Controls.Add(Me.btnAvancaData)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtData)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(937, 71)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Selecione a Data "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(638, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Data Final"
        '
        'txtDataFinal
        '
        Me.txtDataFinal.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataFinal.Location = New System.Drawing.Point(641, 33)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.Size = New System.Drawing.Size(148, 24)
        Me.txtDataFinal.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(483, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Data Inicial"
        '
        'txtDataInicial
        '
        Me.txtDataInicial.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDataInicial.Location = New System.Drawing.Point(487, 32)
        Me.txtDataInicial.Name = "txtDataInicial"
        Me.txtDataInicial.Size = New System.Drawing.Size(148, 24)
        Me.txtDataInicial.TabIndex = 53
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscar.Location = New System.Drawing.Point(795, 16)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(169, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Navegação Datas"
        '
        'btnRecuaData
        '
        Me.btnRecuaData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecuaData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRecuaData.Location = New System.Drawing.Point(171, 35)
        Me.btnRecuaData.Name = "btnRecuaData"
        Me.btnRecuaData.Size = New System.Drawing.Size(58, 26)
        Me.btnRecuaData.TabIndex = 38
        Me.btnRecuaData.Text = "<<"
        Me.btnRecuaData.UseVisualStyleBackColor = True
        '
        'btnAvancaData
        '
        Me.btnAvancaData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvancaData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAvancaData.Location = New System.Drawing.Point(230, 35)
        Me.btnAvancaData.Name = "btnAvancaData"
        Me.btnAvancaData.Size = New System.Drawing.Size(58, 26)
        Me.btnAvancaData.TabIndex = 37
        Me.btnAvancaData.Text = ">>"
        Me.btnAvancaData.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Data"
        '
        'txtData
        '
        Me.txtData.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtData.Location = New System.Drawing.Point(18, 36)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(148, 24)
        Me.txtData.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Green
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(7, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(942, 102)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "C O N T A S  A  R E C E B E R"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'fraCaixaInicial
        '
        Me.fraCaixaInicial.BackColor = System.Drawing.Color.White
        Me.fraCaixaInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fraCaixaInicial.Controls.Add(Me.txtOBS)
        Me.fraCaixaInicial.Controls.Add(Me.Label12)
        Me.fraCaixaInicial.Controls.Add(Me.txtRecebido)
        Me.fraCaixaInicial.Controls.Add(Me.Label8)
        Me.fraCaixaInicial.Controls.Add(Me.txtRecebimento)
        Me.fraCaixaInicial.Controls.Add(Me.Label11)
        Me.fraCaixaInicial.Controls.Add(Me.btnCancelar)
        Me.fraCaixaInicial.Controls.Add(Me.btnConfirmar)
        Me.fraCaixaInicial.Controls.Add(Me.txtAReceber)
        Me.fraCaixaInicial.Controls.Add(Me.Label5)
        Me.fraCaixaInicial.Controls.Add(Me.txtVencimento)
        Me.fraCaixaInicial.Controls.Add(Me.Label13)
        Me.fraCaixaInicial.Controls.Add(Me.Label7)
        Me.fraCaixaInicial.Controls.Add(Me.ShapeContainer1)
        Me.fraCaixaInicial.Location = New System.Drawing.Point(238, 145)
        Me.fraCaixaInicial.Name = "fraCaixaInicial"
        Me.fraCaixaInicial.Size = New System.Drawing.Size(433, 351)
        Me.fraCaixaInicial.TabIndex = 69
        '
        'txtOBS
        '
        Me.txtOBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOBS.Location = New System.Drawing.Point(14, 192)
        Me.txtOBS.Multiline = True
        Me.txtOBS.Name = "txtOBS"
        Me.txtOBS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOBS.Size = New System.Drawing.Size(404, 86)
        Me.txtOBS.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 16)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Observações:"
        '
        'txtRecebido
        '
        Me.txtRecebido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecebido.Location = New System.Drawing.Point(148, 134)
        Me.txtRecebido.Multiline = True
        Me.txtRecebido.Name = "txtRecebido"
        Me.txtRecebido.Size = New System.Drawing.Size(142, 22)
        Me.txtRecebido.TabIndex = 1
        Me.txtRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(145, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Valor Recebido:"
        '
        'txtRecebimento
        '
        Me.txtRecebimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRecebimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecebimento.Location = New System.Drawing.Point(14, 135)
        Me.txtRecebimento.Name = "txtRecebimento"
        Me.txtRecebimento.Size = New System.Drawing.Size(123, 22)
        Me.txtRecebimento.TabIndex = 0
        Me.txtRecebimento.Text = "00/00/0000"
        Me.txtRecebimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 16)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Data Recebimento:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(328, 291)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(90, 47)
        Me.btnCancelar.TabIndex = 44
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.Green
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.White
        Me.btnConfirmar.Location = New System.Drawing.Point(237, 291)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(90, 47)
        Me.btnConfirmar.TabIndex = 43
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'txtAReceber
        '
        Me.txtAReceber.BackColor = System.Drawing.Color.White
        Me.txtAReceber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAReceber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtAReceber.Location = New System.Drawing.Point(227, 55)
        Me.txtAReceber.Multiline = True
        Me.txtAReceber.Name = "txtAReceber"
        Me.txtAReceber.Size = New System.Drawing.Size(142, 27)
        Me.txtAReceber.TabIndex = 35
        Me.txtAReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(224, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Valor a Receber:"
        '
        'txtVencimento
        '
        Me.txtVencimento.BackColor = System.Drawing.Color.White
        Me.txtVencimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVencimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVencimento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtVencimento.Location = New System.Drawing.Point(69, 55)
        Me.txtVencimento.Name = "txtVencimento"
        Me.txtVencimento.Size = New System.Drawing.Size(123, 27)
        Me.txtVencimento.TabIndex = 33
        Me.txtVencimento.Text = "00/00/0000"
        Me.txtVencimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(66, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 16)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Data Vencimento:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Green
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-1, -1)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(433, 29)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Efetuar Recebimento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(431, 349)
        Me.ShapeContainer1.TabIndex = 42
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 430
        Me.LineShape1.Y1 = 100
        Me.LineShape1.Y2 = 100
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(686, 519)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 18)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Contas Recebidas"
        '
        'txtContaRecebida
        '
        Me.txtContaRecebida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContaRecebida.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContaRecebida.ForeColor = System.Drawing.Color.Red
        Me.txtContaRecebida.Location = New System.Drawing.Point(689, 537)
        Me.txtContaRecebida.Name = "txtContaRecebida"
        Me.txtContaRecebida.Size = New System.Drawing.Size(133, 30)
        Me.txtContaRecebida.TabIndex = 86
        Me.txtContaRecebida.Text = "0,00"
        Me.txtContaRecebida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSaldoFinal
        '
        Me.txtSaldoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoFinal.Location = New System.Drawing.Point(828, 537)
        Me.txtSaldoFinal.Name = "txtSaldoFinal"
        Me.txtSaldoFinal.Size = New System.Drawing.Size(121, 30)
        Me.txtSaldoFinal.TabIndex = 84
        Me.txtSaldoFinal.Text = "0,00"
        Me.txtSaldoFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(857, 519)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 18)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Saldo Final"
        '
        'txtContaReceber
        '
        Me.txtContaReceber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContaReceber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContaReceber.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtContaReceber.Location = New System.Drawing.Point(546, 537)
        Me.txtContaReceber.Name = "txtContaReceber"
        Me.txtContaReceber.Size = New System.Drawing.Size(137, 30)
        Me.txtContaReceber.TabIndex = 82
        Me.txtContaReceber.Text = "0,00"
        Me.txtContaReceber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(543, 519)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 18)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Contas a Receber"
        '
        'frmContasReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 643)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtContaRecebida)
        Me.Controls.Add(Me.fraCaixaInicial)
        Me.Controls.Add(Me.txtSaldoFinal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtContaReceber)
        Me.Controls.Add(Me.lsvDados)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmContasReceber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet :: Contas a Receber"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.fraCaixaInicial.ResumeLayout(False)
        Me.fraCaixaInicial.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFinalizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents lsvDados As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDataFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDataInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRecuaData As System.Windows.Forms.Button
    Friend WithEvents btnAvancaData As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fraCaixaInicial As System.Windows.Forms.Panel
    Friend WithEvents txtOBS As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRecebido As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRecebimento As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents txtAReceber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtVencimento As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtContaRecebida As System.Windows.Forms.Label
    Friend WithEvents txtSaldoFinal As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtContaReceber As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
