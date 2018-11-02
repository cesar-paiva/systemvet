<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaixa
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
        Me.btnFinalizaCaixa = New System.Windows.Forms.ToolStripButton()
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtContasPagar = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVendas = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSaidas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEntradas = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSaldoInicial = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Status = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRecuaData = New System.Windows.Forms.Button()
        Me.btnAvancaData = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.DateTimePicker()
        Me.txtStatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator1, Me.btnFinalizaCaixa})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 495)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(939, 58)
        Me.ToolStrip1.TabIndex = 29
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
        'btnFinalizaCaixa
        '
        Me.btnFinalizaCaixa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnFinalizaCaixa.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizaCaixa.Image = Global.SystemVet.My.Resources.Resources.caixa
        Me.btnFinalizaCaixa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFinalizaCaixa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFinalizaCaixa.Name = "btnFinalizaCaixa"
        Me.btnFinalizaCaixa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnFinalizaCaixa.Size = New System.Drawing.Size(136, 55)
        Me.btnFinalizaCaixa.Text = "&Finalizar Caixa"
        Me.btnFinalizaCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvDados.Location = New System.Drawing.Point(11, 109)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(919, 303)
        Me.lsvDados.TabIndex = 41
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Data"
        Me.ColumnHeader1.Width = 79
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descrição Conta"
        Me.ColumnHeader2.Width = 423
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Entrada"
        Me.ColumnHeader3.Width = 127
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Saída"
        Me.ColumnHeader4.Width = 121
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Saldo"
        Me.ColumnHeader5.Width = 141
        '
        'txtContasPagar
        '
        Me.txtContasPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContasPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContasPagar.ForeColor = System.Drawing.Color.Red
        Me.txtContasPagar.Location = New System.Drawing.Point(531, 455)
        Me.txtContasPagar.Name = "txtContasPagar"
        Me.txtContasPagar.Size = New System.Drawing.Size(121, 30)
        Me.txtContasPagar.TabIndex = 62
        Me.txtContasPagar.Text = "0,00"
        Me.txtContasPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(528, 437)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 18)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Pagamentos"
        '
        'txtVendas
        '
        Me.txtVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendas.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtVendas.Location = New System.Drawing.Point(263, 455)
        Me.txtVendas.Name = "txtVendas"
        Me.txtVendas.Size = New System.Drawing.Size(121, 30)
        Me.txtVendas.TabIndex = 60
        Me.txtVendas.Text = "0,00"
        Me.txtVendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 437)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 18)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Vendas Varejo"
        '
        'txtSaldo
        '
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(791, 455)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(121, 30)
        Me.txtSaldo.TabIndex = 58
        Me.txtSaldo.Text = "0,00"
        Me.txtSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(788, 437)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Saldo Final"
        '
        'txtSaidas
        '
        Me.txtSaidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaidas.ForeColor = System.Drawing.Color.Red
        Me.txtSaidas.Location = New System.Drawing.Point(661, 455)
        Me.txtSaidas.Name = "txtSaidas"
        Me.txtSaidas.Size = New System.Drawing.Size(121, 30)
        Me.txtSaidas.TabIndex = 56
        Me.txtSaidas.Text = "0,00"
        Me.txtSaidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(658, 437)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 18)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Saídas"
        '
        'txtEntradas
        '
        Me.txtEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEntradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntradas.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtEntradas.Location = New System.Drawing.Point(136, 455)
        Me.txtEntradas.Name = "txtEntradas"
        Me.txtEntradas.Size = New System.Drawing.Size(121, 30)
        Me.txtEntradas.TabIndex = 54
        Me.txtEntradas.Text = "0,00"
        Me.txtEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Serviços"
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoInicial.Location = New System.Drawing.Point(9, 455)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(121, 30)
        Me.txtSaldoInicial.TabIndex = 52
        Me.txtSaldoInicial.Text = "0,00"
        Me.txtSaldoInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 437)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 18)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Saldo Inicial"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Green
        Me.GroupBox1.Controls.Add(Me.Status)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnRecuaData)
        Me.GroupBox1.Controls.Add(Me.btnAvancaData)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtData)
        Me.GroupBox1.Controls.Add(Me.txtStatus)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(22, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 71)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Selecione a Data "
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.BackColor = System.Drawing.Color.Green
        Me.Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.Color.White
        Me.Status.Location = New System.Drawing.Point(807, 17)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(91, 18)
        Me.Status.TabIndex = 51
        Me.Status.Text = "Status Caixa"
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
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.Green
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.ForeColor = System.Drawing.Color.Red
        Me.txtStatus.Location = New System.Drawing.Point(644, 31)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(251, 30)
        Me.txtStatus.TabIndex = 52
        Me.txtStatus.Text = "Status"
        Me.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Green
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(11, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(920, 102)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "C O N T R O L E  D E  C A I X A    D O    D I A"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 553)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtContasPagar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtVendas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSaidas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEntradas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSaldoInicial)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lsvDados)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet :: Caixa"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnFinalizaCaixa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lsvDados As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtContasPagar As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtVendas As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSaidas As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEntradas As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoInicial As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnRecuaData As System.Windows.Forms.Button
    Friend WithEvents btnAvancaData As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtStatus As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
