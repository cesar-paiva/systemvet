<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAgendamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAgendamento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.txtDiaSemana = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.cboServicos = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboCLientes = New System.Windows.Forms.ComboBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboAnimal = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txtAtendimento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVeterinario = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(154, 7)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Dia da Semana"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(87, 7)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Hora"
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(90, 24)
        Me.txtHora.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(62, 20)
        Me.txtHora.TabIndex = 10
        '
        'txtDiaSemana
        '
        Me.txtDiaSemana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiaSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaSemana.Location = New System.Drawing.Point(156, 25)
        Me.txtDiaSemana.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDiaSemana.Name = "txtDiaSemana"
        Me.txtDiaSemana.ReadOnly = True
        Me.txtDiaSemana.Size = New System.Drawing.Size(135, 20)
        Me.txtDiaSemana.TabIndex = 11
        Me.txtDiaSemana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 88)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Serviços"
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(11, 24)
        Me.txtData.Margin = New System.Windows.Forms.Padding(2)
        Me.txtData.Name = "txtData"
        Me.txtData.ReadOnly = True
        Me.txtData.Size = New System.Drawing.Size(73, 20)
        Me.txtData.TabIndex = 24
        '
        'cboServicos
        '
        Me.cboServicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServicos.FormattingEnabled = True
        Me.cboServicos.Location = New System.Drawing.Point(10, 106)
        Me.cboServicos.Margin = New System.Windows.Forms.Padding(2)
        Me.cboServicos.Name = "cboServicos"
        Me.cboServicos.Size = New System.Drawing.Size(364, 21)
        Me.cboServicos.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 138)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Nome do Cliente/Dono"
        '
        'cboCLientes
        '
        Me.cboCLientes.FormattingEnabled = True
        Me.cboCLientes.Location = New System.Drawing.Point(10, 154)
        Me.cboCLientes.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCLientes.Name = "cboCLientes"
        Me.cboCLientes.Size = New System.Drawing.Size(363, 21)
        Me.cboCLientes.TabIndex = 1
        '
        'txtCelular
        '
        Me.txtCelular.Enabled = False
        Me.txtCelular.Location = New System.Drawing.Point(103, 192)
        Me.txtCelular.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(88, 20)
        Me.txtCelular.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(99, 176)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Celular"
        '
        'txtTelefone
        '
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.Location = New System.Drawing.Point(13, 192)
        Me.txtTelefone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(82, 20)
        Me.txtTelefone.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 176)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Telefone"
        '
        'cboAnimal
        '
        Me.cboAnimal.FormattingEnabled = True
        Me.cboAnimal.Location = New System.Drawing.Point(195, 192)
        Me.cboAnimal.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAnimal.Name = "cboAnimal"
        Me.cboAnimal.Size = New System.Drawing.Size(179, 21)
        Me.cboAnimal.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(192, 176)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Nome do Animal"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 47)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Veterinário"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator3, Me.btnSalvar, Me.ToolStripSeparator2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 222)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(396, 54)
        Me.ToolStrip1.TabIndex = 36
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnFechar
        '
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(80, 51)
        Me.btnFechar.Text = "F&echar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 54)
        '
        'btnSalvar
        '
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(93, 51)
        Me.btnSalvar.Text = "&Salvar"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripButton1.Size = New System.Drawing.Size(108, 51)
        Me.ToolStripButton1.Text = "Imprimir"
        '
        'txtAtendimento
        '
        Me.txtAtendimento.Location = New System.Drawing.Point(295, 25)
        Me.txtAtendimento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAtendimento.Name = "txtAtendimento"
        Me.txtAtendimento.ReadOnly = True
        Me.txtAtendimento.Size = New System.Drawing.Size(78, 20)
        Me.txtAtendimento.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(293, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Nº Atendimento"
        '
        'txtVeterinario
        '
        Me.txtVeterinario.Location = New System.Drawing.Point(9, 62)
        Me.txtVeterinario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtVeterinario.Name = "txtVeterinario"
        Me.txtVeterinario.ReadOnly = True
        Me.txtVeterinario.Size = New System.Drawing.Size(365, 20)
        Me.txtVeterinario.TabIndex = 39
        '
        'frmCadastroAgendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 276)
        Me.Controls.Add(Me.txtVeterinario)
        Me.Controls.Add(Me.txtAtendimento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cboAnimal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboCLientes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboServicos)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDiaSemana)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(414, 369)
        Me.Name = "frmCadastroAgendamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet  : :  Cadastro de Agendamento"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaSemana As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents cboServicos As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboCLientes As System.Windows.Forms.ComboBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboAnimal As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtAtendimento As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVeterinario As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
