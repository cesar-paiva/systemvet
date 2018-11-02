<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControleAgendamento
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControleAgendamento))
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPesquisar = New System.Windows.Forms.ToolStripButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAnimal = New System.Windows.Forms.TextBox()
        Me.cboVeterinario = New System.Windows.Forms.ComboBox()
        Me.txtDono = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.recuaData = New System.Windows.Forms.Button()
        Me.avancaData = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpData
        '
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(9, 24)
        Me.dtpData.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(85, 20)
        Me.dtpData.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Inicial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(681, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Filtrar por Veterinário"
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lsvDados.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.Location = New System.Drawing.Point(9, 87)
        Me.lsvDados.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(1039, 343)
        Me.lsvDados.TabIndex = 19
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Cod."
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Profissional"
        Me.ColumnHeader8.Width = 235
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Data"
        Me.ColumnHeader10.Width = 85
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Hora"
        Me.ColumnHeader11.Width = 78
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Cliente / Dono"
        Me.ColumnHeader12.Width = 261
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Animal"
        Me.ColumnHeader13.Width = 135
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Status Horário"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 136
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator3, Me.btnCancelar, Me.ToolStripSeparator2, Me.btnImprimir, Me.ToolStripSeparator1, Me.btnPesquisar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 457)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(1054, 54)
        Me.ToolStrip1.TabIndex = 24
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnFechar
        '
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.SystemVet.My.Resources.Resources.close_window32
        Me.btnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnFechar.Size = New System.Drawing.Size(80, 51)
        Me.btnFechar.Text = "F&echar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 54)
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnCancelar.Size = New System.Drawing.Size(106, 51)
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnImprimir.Size = New System.Drawing.Size(108, 51)
        Me.btnImprimir.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnPesquisar.Size = New System.Drawing.Size(188, 51)
        Me.btnPesquisar.Text = "&Pesquisar Atendimento"
        Me.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Pesquisar pelo Nome do Dono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(473, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Pesquisar pelo Nome do Animal"
        '
        'txtAnimal
        '
        Me.txtAnimal.Location = New System.Drawing.Point(476, 24)
        Me.txtAnimal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAnimal.Name = "txtAnimal"
        Me.txtAnimal.Size = New System.Drawing.Size(204, 20)
        Me.txtAnimal.TabIndex = 1
        '
        'cboVeterinario
        '
        Me.cboVeterinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVeterinario.FormattingEnabled = True
        Me.cboVeterinario.Location = New System.Drawing.Point(684, 24)
        Me.cboVeterinario.Margin = New System.Windows.Forms.Padding(2)
        Me.cboVeterinario.Name = "cboVeterinario"
        Me.cboVeterinario.Size = New System.Drawing.Size(251, 21)
        Me.cboVeterinario.TabIndex = 2
        '
        'txtDono
        '
        Me.txtDono.Location = New System.Drawing.Point(207, 24)
        Me.txtDono.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDono.Name = "txtDono"
        Me.txtDono.Size = New System.Drawing.Size(265, 20)
        Me.txtDono.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Green
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(13, 436)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(11, 12)
        Me.TextBox1.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 434)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Confirmado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(107, 434)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Finalizado"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.LightGray
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(92, 436)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(11, 12)
        Me.TextBox3.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Green
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(9, 58)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1035, 27)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "A G E N D A M E N T O  E  C O N T R O L E  DE  A G E N D A"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'recuaData
        '
        Me.recuaData.Location = New System.Drawing.Point(99, 21)
        Me.recuaData.Name = "recuaData"
        Me.recuaData.Size = New System.Drawing.Size(39, 23)
        Me.recuaData.TabIndex = 40
        Me.recuaData.Text = "<<"
        Me.ToolTip1.SetToolTip(Me.recuaData, "Recua para uma data anterior")
        Me.recuaData.UseVisualStyleBackColor = True
        '
        'avancaData
        '
        Me.avancaData.Location = New System.Drawing.Point(149, 21)
        Me.avancaData.Name = "avancaData"
        Me.avancaData.Size = New System.Drawing.Size(39, 23)
        Me.avancaData.TabIndex = 41
        Me.avancaData.Text = ">>"
        Me.ToolTip1.SetToolTip(Me.avancaData, "Avança para uma data posterior")
        Me.avancaData.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(96, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Navegação Datas"
        '
        'frmControleAgendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 511)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.avancaData)
        Me.Controls.Add(Me.recuaData)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtDono)
        Me.Controls.Add(Me.cboVeterinario)
        Me.Controls.Add(Me.txtAnimal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lsvDados)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpData)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmControleAgendamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet  : : Pesquisa e  Controle de Agendamento"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lsvDados As System.Windows.Forms.ListView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAnimal As System.Windows.Forms.TextBox
    Friend WithEvents cboVeterinario As System.Windows.Forms.ComboBox
    Friend WithEvents txtDono As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPesquisar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents recuaData As System.Windows.Forms.Button
    Friend WithEvents avancaData As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
