<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAnimais
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAnimais))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.dtpCadastro = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtObito = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDataObito = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkboxObito = New System.Windows.Forms.CheckBox()
        Me.cboTemperamento = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCor = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkboxRestricoes = New System.Windows.Forms.CheckBox()
        Me.chkboxPedigree = New System.Windows.Forms.CheckBox()
        Me.chkboxDisponivel = New System.Windows.Forms.CheckBox()
        Me.cboPorte = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtChip = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAlimentacao = New System.Windows.Forms.TextBox()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtAnimal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pctboxFoto = New System.Windows.Forms.PictureBox()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.cboRaca = New System.Windows.Forms.ComboBox()
        Me.cboPelagem = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboEspecie = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ofd_animal = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pctboxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCliente)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.dtpCadastro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 63)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Animal"
        '
        'cboCliente
        '
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(66, 34)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(387, 21)
        Me.cboCliente.TabIndex = 22
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Cod."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Cliente / Dono"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(6, 34)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(52, 20)
        Me.txtCodigo.TabIndex = 4
        '
        'dtpCadastro
        '
        Me.dtpCadastro.Checked = False
        Me.dtpCadastro.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dtpCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCadastro.Location = New System.Drawing.Point(461, 34)
        Me.dtpCadastro.Name = "dtpCadastro"
        Me.dtpCadastro.Size = New System.Drawing.Size(95, 20)
        Me.dtpCadastro.TabIndex = 30
        Me.dtpCadastro.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(458, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data Cadastro "
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TextBox13)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(562, 321)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Observação de Rotina"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(8, 8)
        Me.TextBox13.Multiline = True
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(546, 304)
        Me.TextBox13.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TextBox12)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(562, 321)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Obs. Comportamental"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(8, 8)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(546, 304)
        Me.TextBox12.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBox11)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(562, 321)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Histórico Veterinário"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(7, 7)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(546, 304)
        Me.TextBox11.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(562, 321)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Relação de Vacinas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(4, 6)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(549, 312)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nome da Vacina"
        Me.ColumnHeader1.Width = 218
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Data Programada"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data Aplicada"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Informação da Dose"
        Me.ColumnHeader4.Width = 114
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtDescricao)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.txtObito)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.txtDataObito)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.chkboxObito)
        Me.TabPage1.Controls.Add(Me.cboTemperamento)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txtCor)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.chkboxRestricoes)
        Me.TabPage1.Controls.Add(Me.chkboxPedigree)
        Me.TabPage1.Controls.Add(Me.chkboxDisponivel)
        Me.TabPage1.Controls.Add(Me.cboPorte)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.cboSexo)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtChip)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtAlimentacao)
        Me.TabPage1.Controls.Add(Me.txtIdade)
        Me.TabPage1.Controls.Add(Me.txtPeso)
        Me.TabPage1.Controls.Add(Me.txtAnimal)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtNascimento)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.pctboxFoto)
        Me.TabPage1.Controls.Add(Me.cboEstado)
        Me.TabPage1.Controls.Add(Me.cboRaca)
        Me.TabPage1.Controls.Add(Me.cboPelagem)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.cboEspecie)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(562, 321)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Informações do Animal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtDescricao
        '
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Location = New System.Drawing.Point(402, 288)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(150, 20)
        Me.txtDescricao.TabIndex = 21
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(397, 268)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 13)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "Descrição"
        '
        'txtObito
        '
        Me.txtObito.Enabled = False
        Me.txtObito.Location = New System.Drawing.Point(403, 245)
        Me.txtObito.Name = "txtObito"
        Me.txtObito.Size = New System.Drawing.Size(149, 20)
        Me.txtObito.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(400, 228)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 13)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "Motivo do Óbito"
        '
        'txtDataObito
        '
        Me.txtDataObito.Enabled = False
        Me.txtDataObito.Location = New System.Drawing.Point(407, 202)
        Me.txtDataObito.Mask = "00/00/0000"
        Me.txtDataObito.Name = "txtDataObito"
        Me.txtDataObito.Size = New System.Drawing.Size(67, 20)
        Me.txtDataObito.TabIndex = 19
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(404, 184)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 13)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Data do Óbito"
        '
        'chkboxObito
        '
        Me.chkboxObito.AutoSize = True
        Me.chkboxObito.Location = New System.Drawing.Point(229, 78)
        Me.chkboxObito.Name = "chkboxObito"
        Me.chkboxObito.Size = New System.Drawing.Size(51, 17)
        Me.chkboxObito.TabIndex = 13
        Me.chkboxObito.Text = "Óbito"
        Me.chkboxObito.UseVisualStyleBackColor = True
        '
        'cboTemperamento
        '
        Me.cboTemperamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTemperamento.FormattingEnabled = True
        Me.cboTemperamento.Location = New System.Drawing.Point(211, 201)
        Me.cboTemperamento.Name = "cboTemperamento"
        Me.cboTemperamento.Size = New System.Drawing.Size(177, 21)
        Me.cboTemperamento.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(208, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Temperamento"
        '
        'txtCor
        '
        Me.txtCor.Location = New System.Drawing.Point(211, 156)
        Me.txtCor.Name = "txtCor"
        Me.txtCor.Size = New System.Drawing.Size(177, 20)
        Me.txtCor.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(208, 139)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 13)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Cor"
        '
        'chkboxRestricoes
        '
        Me.chkboxRestricoes.AutoSize = True
        Me.chkboxRestricoes.Location = New System.Drawing.Point(229, 57)
        Me.chkboxRestricoes.Name = "chkboxRestricoes"
        Me.chkboxRestricoes.Size = New System.Drawing.Size(130, 17)
        Me.chkboxRestricoes.TabIndex = 12
        Me.chkboxRestricoes.Text = "Restrições/Problemas"
        Me.chkboxRestricoes.UseVisualStyleBackColor = True
        '
        'chkboxPedigree
        '
        Me.chkboxPedigree.AutoSize = True
        Me.chkboxPedigree.Location = New System.Drawing.Point(229, 34)
        Me.chkboxPedigree.Name = "chkboxPedigree"
        Me.chkboxPedigree.Size = New System.Drawing.Size(102, 17)
        Me.chkboxPedigree.TabIndex = 11
        Me.chkboxPedigree.Text = "Possui Pedigree"
        Me.chkboxPedigree.UseVisualStyleBackColor = True
        '
        'chkboxDisponivel
        '
        Me.chkboxDisponivel.AutoSize = True
        Me.chkboxDisponivel.Location = New System.Drawing.Point(229, 12)
        Me.chkboxDisponivel.Name = "chkboxDisponivel"
        Me.chkboxDisponivel.Size = New System.Drawing.Size(128, 17)
        Me.chkboxDisponivel.TabIndex = 10
        Me.chkboxDisponivel.Text = "Disponível para Tosa"
        Me.chkboxDisponivel.UseVisualStyleBackColor = True
        '
        'cboPorte
        '
        Me.cboPorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPorte.FormattingEnabled = True
        Me.cboPorte.Location = New System.Drawing.Point(211, 288)
        Me.cboPorte.Name = "cboPorte"
        Me.cboPorte.Size = New System.Drawing.Size(177, 21)
        Me.cboPorte.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(208, 272)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Porte"
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Location = New System.Drawing.Point(13, 74)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(111, 21)
        Me.cboSexo.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Sexo"
        '
        'txtChip
        '
        Me.txtChip.Location = New System.Drawing.Point(10, 156)
        Me.txtChip.Name = "txtChip"
        Me.txtChip.Size = New System.Drawing.Size(191, 20)
        Me.txtChip.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Nº do Chip"
        '
        'txtAlimentacao
        '
        Me.txtAlimentacao.Location = New System.Drawing.Point(211, 115)
        Me.txtAlimentacao.Name = "txtAlimentacao"
        Me.txtAlimentacao.Size = New System.Drawing.Size(177, 20)
        Me.txtAlimentacao.TabIndex = 14
        '
        'txtIdade
        '
        Me.txtIdade.Location = New System.Drawing.Point(13, 114)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(111, 20)
        Me.txtIdade.TabIndex = 4
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(134, 114)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(55, 20)
        Me.txtPeso.TabIndex = 5
        '
        'txtAnimal
        '
        Me.txtAnimal.Location = New System.Drawing.Point(7, 34)
        Me.txtAnimal.Name = "txtAnimal"
        Me.txtAnimal.Size = New System.Drawing.Size(197, 20)
        Me.txtAnimal.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(208, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(180, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Alimentação (Qtde, Ração, Horários)"
        '
        'txtNascimento
        '
        Me.txtNascimento.Location = New System.Drawing.Point(135, 74)
        Me.txtNascimento.Mask = "00/00/0000"
        Me.txtNascimento.Name = "txtNascimento"
        Me.txtNascimento.Size = New System.Drawing.Size(66, 20)
        Me.txtNascimento.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(131, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Nascimento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Idade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Peso Atual"
        '
        'pctboxFoto
        '
        Me.pctboxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctboxFoto.InitialImage = CType(resources.GetObject("pctboxFoto.InitialImage"), System.Drawing.Image)
        Me.pctboxFoto.Location = New System.Drawing.Point(403, 16)
        Me.pctboxFoto.Name = "pctboxFoto"
        Me.pctboxFoto.Size = New System.Drawing.Size(150, 160)
        Me.pctboxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctboxFoto.TabIndex = 35
        Me.pctboxFoto.TabStop = False
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(211, 245)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(177, 21)
        Me.cboEstado.TabIndex = 17
        '
        'cboRaca
        '
        Me.cboRaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRaca.FormattingEnabled = True
        Me.cboRaca.Location = New System.Drawing.Point(10, 245)
        Me.cboRaca.Name = "cboRaca"
        Me.cboRaca.Size = New System.Drawing.Size(191, 21)
        Me.cboRaca.TabIndex = 8
        '
        'cboPelagem
        '
        Me.cboPelagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPelagem.FormattingEnabled = True
        Me.cboPelagem.Location = New System.Drawing.Point(10, 288)
        Me.cboPelagem.Name = "cboPelagem"
        Me.cboPelagem.Size = New System.Drawing.Size(191, 21)
        Me.cboPelagem.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(208, 228)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Estado"
        '
        'cboEspecie
        '
        Me.cboEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspecie.FormattingEnabled = True
        Me.cboEspecie.Location = New System.Drawing.Point(10, 199)
        Me.cboEspecie.Name = "cboEspecie"
        Me.cboEspecie.Size = New System.Drawing.Size(191, 21)
        Me.cboEspecie.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Raça"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Pelagem"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Espécie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Nome do Animal"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(570, 347)
        Me.TabControl1.TabIndex = 24
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFechar, Me.ToolStripSeparator2, Me.btnSalvar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 432)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(597, 54)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnFechar
        '
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnFechar.Size = New System.Drawing.Size(80, 51)
        Me.btnFechar.Text = "F&echar"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        '
        'btnSalvar
        '
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSalvar.Size = New System.Drawing.Size(93, 51)
        Me.btnSalvar.Text = "&Salvar"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ofd_animal
        '
        Me.ofd_animal.FileName = "OpenFileDialog1"
        '
        'frmCadastroAnimais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 486)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCadastroAnimais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet  : :  Cadastro de Animais "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pctboxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpCadastro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtAlimentacao As System.Windows.Forms.TextBox
    Friend WithEvents txtIdade As System.Windows.Forms.TextBox
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents txtAnimal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pctboxFoto As System.Windows.Forms.PictureBox
    Friend WithEvents cboRaca As System.Windows.Forms.ComboBox
    Friend WithEvents cboPelagem As System.Windows.Forms.ComboBox
    Friend WithEvents cboEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtChip As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboPorte As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtObito As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtDataObito As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents chkboxObito As System.Windows.Forms.CheckBox
    Friend WithEvents cboTemperamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCor As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkboxRestricoes As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxPedigree As System.Windows.Forms.CheckBox
    Friend WithEvents chkboxDisponivel As System.Windows.Forms.CheckBox
    Friend WithEvents cboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFechar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSalvar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ofd_animal As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
