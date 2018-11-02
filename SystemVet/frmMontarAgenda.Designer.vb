<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMontarAgenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMontarAgenda))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDiaInicial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboIntervalo = New System.Windows.Forms.ComboBox()
        Me.cboHoraFinal = New System.Windows.Forms.ComboBox()
        Me.cboHoraInicial = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalvarAgenda = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGerar = New System.Windows.Forms.ToolStripButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboVeterinario = New System.Windows.Forms.ComboBox()
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.txtDiaInicial)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpInicial)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(343, 119)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(175, 80)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(152, 17)
        Me.CheckBox2.TabIndex = 20
        Me.CheckBox2.Text = "Agendamento no Domingo"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(28, 80)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(147, 17)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Agendamento no Sábado"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 165)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(370, 150)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Horário de Atendimento"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(163, 83)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(103, 24)
        Me.TextBox3.TabIndex = 17
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(163, 31)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(103, 24)
        Me.TextBox4.TabIndex = 16
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(186, 120)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(152, 17)
        Me.CheckBox3.TabIndex = 15
        Me.CheckBox3.Text = "Agendamento no Domingo"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(28, 120)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(147, 17)
        Me.CheckBox4.TabIndex = 14
        Me.CheckBox4.Text = "Agendamento no Sábado"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 67)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "DIA DA SEMANA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(160, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "DIA DA SEMANA"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(28, 36)
        Me.DateTimePicker3.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(85, 20)
        Me.DateTimePicker3.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "DATA INICIAL"
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(28, 88)
        Me.DateTimePicker4.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(83, 20)
        Me.DateTimePicker4.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 67)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "DATA FINAL"
        '
        'txtDiaInicial
        '
        Me.txtDiaInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaInicial.Location = New System.Drawing.Point(163, 36)
        Me.txtDiaInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiaInicial.Multiline = True
        Me.txtDiaInicial.Name = "txtDiaInicial"
        Me.txtDiaInicial.ReadOnly = True
        Me.txtDiaInicial.Size = New System.Drawing.Size(164, 24)
        Me.txtDiaInicial.TabIndex = 16
        Me.txtDiaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DIA DA SEMANA"
        '
        'dtpInicial
        '
        Me.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicial.Location = New System.Drawing.Point(28, 36)
        Me.dtpInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpInicial.Name = "dtpInicial"
        Me.dtpInicial.Size = New System.Drawing.Size(97, 20)
        Me.dtpInicial.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboIntervalo)
        Me.GroupBox3.Controls.Add(Me.cboHoraFinal)
        Me.GroupBox3.Controls.Add(Me.cboHoraInicial)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 157)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(343, 73)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Horário de Atendimento"
        '
        'cboIntervalo
        '
        Me.cboIntervalo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIntervalo.FormattingEnabled = True
        Me.cboIntervalo.Location = New System.Drawing.Point(235, 46)
        Me.cboIntervalo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboIntervalo.Name = "cboIntervalo"
        Me.cboIntervalo.Size = New System.Drawing.Size(62, 21)
        Me.cboIntervalo.TabIndex = 2
        '
        'cboHoraFinal
        '
        Me.cboHoraFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHoraFinal.FormattingEnabled = True
        Me.cboHoraFinal.Location = New System.Drawing.Point(134, 46)
        Me.cboHoraFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.cboHoraFinal.Name = "cboHoraFinal"
        Me.cboHoraFinal.Size = New System.Drawing.Size(74, 21)
        Me.cboHoraFinal.TabIndex = 1
        '
        'cboHoraInicial
        '
        Me.cboHoraInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHoraInicial.Location = New System.Drawing.Point(21, 46)
        Me.cboHoraInicial.Margin = New System.Windows.Forms.Padding(2)
        Me.cboHoraInicial.Name = "cboHoraInicial"
        Me.cboHoraInicial.Size = New System.Drawing.Size(77, 21)
        Me.cboHoraInicial.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(232, 25)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "INTERVALO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "HORA INICIAL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(132, 25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "HORA FINAL"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator2, Me.btnSalvarAgenda, Me.ToolStripSeparator1, Me.btnGerar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 295)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(823, 54)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnFechar
        '
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.SystemVet.My.Resources.Resources.close_window32
        Me.btnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(80, 51)
        Me.btnFechar.Text = "F&echar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        '
        'btnSalvarAgenda
        '
        Me.btnSalvarAgenda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvarAgenda.Image = CType(resources.GetObject("btnSalvarAgenda.Image"), System.Drawing.Image)
        Me.btnSalvarAgenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSalvarAgenda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvarAgenda.Name = "btnSalvarAgenda"
        Me.btnSalvarAgenda.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSalvarAgenda.Size = New System.Drawing.Size(138, 51)
        Me.btnSalvarAgenda.Text = "&Salvar Agenda"
        Me.btnSalvarAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 54)
        '
        'btnGerar
        '
        Me.btnGerar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGerar.Image = CType(resources.GetObject("btnGerar.Image"), System.Drawing.Image)
        Me.btnGerar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnGerar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGerar.Name = "btnGerar"
        Me.btnGerar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnGerar.Size = New System.Drawing.Size(141, 51)
        Me.btnGerar.Text = "&Gerar Horários"
        Me.btnGerar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 242)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "VETERINÁRIO"
        '
        'cboVeterinario
        '
        Me.cboVeterinario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVeterinario.Location = New System.Drawing.Point(11, 258)
        Me.cboVeterinario.Margin = New System.Windows.Forms.Padding(2)
        Me.cboVeterinario.Name = "cboVeterinario"
        Me.cboVeterinario.Size = New System.Drawing.Size(336, 21)
        Me.cboVeterinario.TabIndex = 3
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.Location = New System.Drawing.Point(358, 46)
        Me.lsvDados.Margin = New System.Windows.Forms.Padding(2)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(457, 233)
        Me.lsvDados.TabIndex = 26
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Data"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Horário"
        Me.ColumnHeader2.Width = 82
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Veterinário"
        Me.ColumnHeader3.Width = 155
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status Horário"
        Me.ColumnHeader4.Width = 107
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(358, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(457, 27)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "H O R Á R I O S  DA  A G E N D A"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMontarAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 349)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lsvDados)
        Me.Controls.Add(Me.cboVeterinario)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmMontarAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDiaInicial As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboIntervalo As System.Windows.Forms.ComboBox
    Friend WithEvents cboHoraFinal As System.Windows.Forms.ComboBox
    Friend WithEvents cboHoraInicial As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboVeterinario As System.Windows.Forms.ComboBox
    Friend WithEvents btnGerar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalvarAgenda As System.Windows.Forms.ToolStripButton
    Friend WithEvents lsvDados As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
