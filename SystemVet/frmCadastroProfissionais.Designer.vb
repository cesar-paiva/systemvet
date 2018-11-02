<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroProfissionais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroProfissionais))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboUF = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAdmissao = New System.Windows.Forms.MaskedTextBox()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboProfissao = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtCel = New System.Windows.Forms.MaskedTextBox()
        Me.txtNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Profissão"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(13, 46)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
        Me.txtCodigo.TabIndex = 9
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(15, 94)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(423, 20)
        Me.txtNome.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Endereço"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Nome Completo"
        '
        'cboUF
        '
        Me.cboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUF.FormattingEnabled = True
        Me.cboUF.Location = New System.Drawing.Point(455, 176)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Size = New System.Drawing.Size(59, 21)
        Me.cboUF.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(274, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Cidade"
        '
        'txtCidade
        '
        Me.txtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(277, 176)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(161, 20)
        Me.txtCidade.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(454, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "UF"
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(15, 137)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(423, 20)
        Me.txtEndereco.TabIndex = 3
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(15, 176)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(256, 20)
        Me.txtBairro.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Bairro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Telefone"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(122, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Celular"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(441, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Nascimento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(246, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Sexo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(360, 200)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Data Admissão"
        '
        'txtAdmissao
        '
        Me.txtAdmissao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmissao.Location = New System.Drawing.Point(363, 215)
        Me.txtAdmissao.Mask = "00/00/0000"
        Me.txtAdmissao.Name = "txtAdmissao"
        Me.txtAdmissao.Size = New System.Drawing.Size(75, 22)
        Me.txtAdmissao.TabIndex = 11
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Location = New System.Drawing.Point(239, 214)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(118, 21)
        Me.cboSexo.TabIndex = 10
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator1, Me.btnSalvar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 257)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(531, 61)
        Me.ToolStrip1.TabIndex = 41
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnFechar
        '
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = Global.SystemVet.My.Resources.Resources.close_window32
        Me.btnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(80, 58)
        Me.btnFechar.Text = "F&echar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 61)
        '
        'btnSalvar
        '
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(93, 58)
        Me.btnSalvar.Text = "&Salvar"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 248)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados dos Profissionais"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(435, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Cep"
        '
        'cboProfissao
        '
        Me.cboProfissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfissao.FormattingEnabled = True
        Me.cboProfissao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboProfissao.Location = New System.Drawing.Point(88, 46)
        Me.cboProfissao.Name = "cboProfissao"
        Me.cboProfissao.Size = New System.Drawing.Size(172, 21)
        Me.cboProfissao.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(449, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Cep"
        '
        'txtTelefone
        '
        Me.txtTelefone.BeepOnError = True
        Me.txtTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTelefone.Location = New System.Drawing.Point(15, 215)
        Me.txtTelefone.Mask = "(00) 0000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(79, 20)
        Me.txtTelefone.TabIndex = 8
        '
        'txtCel
        '
        Me.txtCel.BeepOnError = True
        Me.txtCel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCel.Location = New System.Drawing.Point(125, 215)
        Me.txtCel.Mask = "(00) 0 0000-0000"
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(93, 20)
        Me.txtCel.TabIndex = 9
        '
        'txtNascimento
        '
        Me.txtNascimento.Location = New System.Drawing.Point(444, 94)
        Me.txtNascimento.Mask = "00/00/0000"
        Me.txtNascimento.Name = "txtNascimento"
        Me.txtNascimento.Size = New System.Drawing.Size(70, 20)
        Me.txtNascimento.TabIndex = 2
        '
        'txtCep
        '
        Me.txtCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCep.Location = New System.Drawing.Point(444, 137)
        Me.txtCep.Mask = "00.000-000"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(62, 20)
        Me.txtCep.TabIndex = 4
        '
        'frmCadastroProfissionais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 318)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.cboSexo)
        Me.Controls.Add(Me.txtAdmissao)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNascimento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboUF)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.cboProfissao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCadastroProfissionais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet :: Cadastro de Profissionais"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboUF As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAdmissao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboProfissao As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCep As System.Windows.Forms.MaskedTextBox
End Class
