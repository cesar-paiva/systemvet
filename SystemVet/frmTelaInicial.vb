Imports System.Data.SqlClient
Public Class frmTelaInicial

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Me.Visible = False
        frmLogin.txtUsuario.Select()
        frmLogin.txtUsuario.Clear()
        frmLogin.txtSenha.Clear()
        frmLogin.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel4.Text = " Hora: " + Format(Now, "HH:mm:ss")
    End Sub

    Private Sub frmTelaInicial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Visible = False
        frmLogin.txtUsuario.Select()
        frmLogin.txtUsuario.Clear()
        frmLogin.txtSenha.Clear()
        frmLogin.Visible = True
    End Sub

    Private Sub frmTelaInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.Visible = False
        lblUsuario.Text = "Usuario logado: " & vfUsuarioLogado
        PanelItens.Left = Me.Width / 2 - PanelItens.Width / 2
        PanelItens.Top = Me.Height / 2 - PanelItens.Height / 2 - 75
        ToolStripStatusLabel3.Width = 200


        If vfTestaNivelAcesso = "FUNCIONÁRIO" Then
            pctboxAgenda.Enabled = False
            pctboxBackup.Enabled = False
            pctboxUsuarios.Enabled = False
            AgendamentoToolStripMenuItem.Enabled = False
        Else
            pctboxAgenda.Enabled = True
            pctboxBackup.Enabled = True
            pctboxUsuarios.Enabled = True
            AgendamentoToolStripMenuItem.Enabled = True
        End If
        ToolStripStatusLabel3.Text = " Data de acesso: " + Format(Date.Now, "MM/dd/yyyy")
        pfIniciaCaixa()

    End Sub

    Public Shared Sub TextBoxMoeda(ByRef txtSaldo As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0
        Try
            n = txtSaldo.Text.Replace(",", "").Replace(".", "")
            If n.Equals("") Then n = "000"
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
            v = Convert.ToDouble(n) / 100
            txtSaldo.Text = String.Format("{0:N}", v)
            txtSaldo.SelectionStart = txtSaldo.Text.Length
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Saldo inicial do caixa:")
        End Try
    End Sub

    Private Sub pfIniciaCaixa()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CAIXA WHERE DATACAIXA = '" & Date.Parse(Now).ToString("MM/dd/yyyy") & "'", vgDados)
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            If MsgBox("Caixa do dia " & FormatDateTime(Now, DateFormat.ShortDate) & " não iniciado! " & vbCrLf & "Confirma inicialização do caixa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then End
            If vfTestaNivelAcesso = "GERENTE" Then
                frmCaixaAbertura.ShowDialog()
                frmCaixaAbertura.txtSaldo.Focus()
            Else
                MsgBox("Você não tem privigélios para executar essa ação!" & vbCrLf & vbCrLf & "Entre em contato com o administrador!", MsgBoxStyle.Critical, "SystemVet :: Pergunta")
                vlRegistros.Close()
                End
            End If
        Else
            vlRegistros.Close()
        End If
    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem.Click
        frmBuscaUsuario.ShowDialog()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        frmBuscaFornecedor.ShowDialog()
    End Sub

    Private Sub CadastroProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroProdutosToolStripMenuItem.Click
        frmBuscaProduto.ShowDialog()

    End Sub

    Private Sub pctboxClientes_Click_1(sender As Object, e As EventArgs) Handles pctboxClientes.Click
        frmBuscaCliente.ShowDialog()
    End Sub

    Private Sub pctboxUsuarios_Click_1(sender As Object, e As EventArgs) Handles pctboxUsuarios.Click
        frmBuscaUsuario.ShowDialog()
    End Sub

    Private Sub AnimaisToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AnimaisToolStripMenuItem3.Click
        frmBuscaAnimal.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmBuscaCliente.ShowDialog()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem1.Click
        frmBuscaProfissionais.ShowDialog()
    End Sub

    Private Sub pctboxProfissionais_Click(sender As Object, e As EventArgs) Handles pctboxProfissionais.Click
        frmBuscaProfissionais.ShowDialog()
    End Sub

    Private Sub pctboxSair_Click_1(sender As Object, e As EventArgs) Handles pctboxSair.Click
        Me.Visible = False
        frmLogin.txtUsuario.Focus()
        frmLogin.txtUsuario.Clear()
        frmLogin.txtSenha.Clear()
        frmLogin.Visible = True
        'If MessageBox.Show("Deseja mesmo sair do sistema?", " CWC SystemVet - Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        'desconecta()
        'End
        'End If
    End Sub

    Private Sub pctboxAnimais_Click_1(sender As Object, e As EventArgs) Handles pctboxAnimais.Click
        frmBuscaAnimal.ShowDialog()
    End Sub

    Private Sub pctboxFornecedores_Click(sender As Object, e As EventArgs) Handles pctboxFornecedores.Click
        frmBuscaFornecedor.ShowDialog()
    End Sub

    Private Sub pctboxProdutos_Click(sender As Object, e As EventArgs) Handles pctboxProdutos.Click
        frmBuscaProduto.ShowDialog()
    End Sub

    Private Sub ControlarAgendamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlarAgendamentoToolStripMenuItem.Click
        frmControleAgendamento.ShowDialog()
    End Sub

    Private Sub MontarHoráriosDaAgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MontarHoráriosDaAgendaToolStripMenuItem.Click
        frmMontarAgenda.ShowDialog()
    End Sub

    Private Sub CadastroDeAgendamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeAgendamentoToolStripMenuItem.Click
        frmControleAgendamento.ShowDialog()
    End Sub

    Private Sub pctboxAgenda_Click(sender As Object, e As EventArgs) Handles pctboxAgenda.Click
        frmControleAgendamento.ShowDialog()
    End Sub

    Private Sub ItensToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItensToolStripMenuItem.Click
        frmCadastroMarcas.ShowDialog()
    End Sub

    Private Sub CadastroDasCategoriasTipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDasCategoriasTipoToolStripMenuItem.Click
        frmCadastroCategoria.ShowDialog()
    End Sub

    Private Sub PedidosVendasTODOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosVendasTODOSToolStripMenuItem.Click
        frmPesquisaVendas.ShowDialog()
    End Sub

    Private Sub PedidosVendasFINALIZADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosVendasFINALIZADOSToolStripMenuItem.Click
        frmPesquisaVendasFinalizadas.ShowDialog()
    End Sub

    Private Sub PedidosVendasCANCELADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidosVendasCANCELADOSToolStripMenuItem.Click
        frmPesquisaVendasCanceladas.ShowDialog()
    End Sub

    Private Sub PesquisarAtendimentosTODOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesquisarAtendimentosTODOSToolStripMenuItem.Click
        frmPesquisaAgendamento.ShowDialog()
    End Sub

    Private Sub pctboxVendas_Click(sender As Object, e As EventArgs) Handles pctboxVendas.Click
        'If MsgBox("Deseja gerar VENDA/ORÇAMENTO ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SyetemVet :: Vendas e Orçamento") = MsgBoxResult.No Then Exit Sub
        'vgDados.Execute("INSERT INTO VENDAS (DATAVENDA, HORAVENDA,  NOMECLIENTE, TOTALVENDA, TIPOPEDIDO) VALUES ('" & Date.Parse(Now).ToString("MM/dd/yyyy") & "', '" & FormatDateTime(Now, DateFormat.ShortTime) & "' , 'CONSUMIDOR', '0,00','ORCAMENTO')")
        frmPesquisaVendas.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem2.Click
        'frmRelatorioCLiente.Showdialog()
    End Sub

    Private Sub AnimaisToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AnimaisToolStripMenuItem2.Click
        'frmRelatorioAnimal.ShowDialog()
    End Sub

    Private Sub pctboxBackup_Click(sender As Object, e As EventArgs) Handles pctboxBackup.Click
        frmBackup.ShowDialog()
    End Sub

    'Private Sub btnSincronizacao_Click(sender As Object, e As EventArgs) Handles btnSincronizacao.Click
    '    If MsgBox("Deseja atualizar o banco de dados da Web?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Sincronização") = MsgBoxResult.No Then Exit Sub
    '    conectaweb()
    '    cmd.CommandText = ("DELETE FROM  ANIMAL")
    '    cmd.Connection = cnn
    '    cmd.ExecuteNonQuery()
    '    cmd.CommandText = ""
    '    cmd.CommandText = ("DELETE  FROM CLIENTES")
    '    cmd.Connection = cnn
    '    cmd.ExecuteNonQuery()
    '    cmd.CommandText = ""
    '    vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '    vlRegistros.Open("SELECT * FROM ANIMAL", vgDados)
    '    If vlRegistros.RecordCount = 0 Then
    '        vlRegistros.Close()
    '    Else
    '        While Not vlRegistros.EOF
    '            cmd.CommandText = ("INSERT INTO ANIMAL (NOMEANIMAL, NOMEDONOANIMAL, SEXOANIMAL, NASCIMENTOANIMAL, IDADEANIMAL, PESOANIMAL, CHIPANIMAL, ESPECIEANIMAL, RACAANIMAL, PELAGEMANIMAL, ALIMENTACAOANIMAL, CORANIMAL, TEMPERAMENTOANIMAL, ESTADOANIMAL, PORTEANIMAL, DISPONIVELTOSAANIMAL, PEDIGREEANIMAL, RESTRICOESANIMAL, OBITOANIMAL, DATACADASTRO) VALUES ('" & (vlRegistros("NOMEANIMAL").Value) & "', '" & (vlRegistros("NOMEDONOANIMAL").Value) & "', '" & (vlRegistros("SEXOANIMAL").Value) & "', '" & vlRegistros("NASCIMENTOANIMAL").Value & "','" & vlRegistros("IDADEANIMAL").Value & "','" & vlRegistros("PESOANIMAL").Value & "','" & vlRegistros("CHIPANIMAL").Value & "','" & (vlRegistros("ESPECIEANIMAL").Value) & "','" & (vlRegistros("RACAANIMAL").Value) & "','" & (vlRegistros("PELAGEMANIMAL").Value) & "','" & (vlRegistros("ALIMENTACAOANIMAL").Value) & "','" & (vlRegistros("CORANIMAL").Value) & "','" & (vlRegistros("TEMPERAMENTOANIMAL").Value) & "','" & (vlRegistros("ESTADOANIMAL").Value) & "','" & (vlRegistros("PORTEANIMAL").Value) & "','" & vlRegistros("DISPONIVELTOSAANIMAL").Value & "','" & vlRegistros("PEDIGREEANIMAL").Value & "','" & vlRegistros("RESTRICOESANIMAL").Value & "','" & vlRegistros("OBITOANIMAL").Value & "','" & vlRegistros("DATACADASTRO").Value & "')")
    '            cmd.Connection = cnn
    '            cmd.ExecuteNonQuery()
    '            cmd.CommandText = ""
    '            vlRegistros.MoveNext()
    '        End While
    '        vlRegistros.Close()
    '    End If
    '    vlRegistros.Open("SELECT * FROM CLIENTES", vgDados)
    '    If vlRegistros.RecordCount = 0 Then
    '        vlRegistros.Close()
    '    Else
    '        While Not vlRegistros.EOF
    '            cmd.CommandText = ("INSERT INTO CLIENTES (NOMEPESSOAFISICA, DATANASCIMENTOPESSOAFISICA, ENDERECOPESSOAFISICA, NUMEROPESSOAFISICA, CEPPESSOAFISICA, UFPESSOAFISICA, BAIRROPESSOAFISICA, CIDADEPESSOAFISICA, TELEFONEPESSOAFISICA, CELULARPESSOAFISICA, COMPLEMENTOPESSOAFISICA, EMAILPESSOAFISICA, SEXOPESSOAFISICA, CPFPESSOAFISICA, RGPESSOAFISICA, CNPJ, INSESTADUAL, DATACADASTRO, SENHACLIENTE) VALUES ('" & (vlRegistros("NOMEPESSOAFISICA").Value) & "','" & (vlRegistros("DATANASCIMENTOPESSOAFISICA").Value) & "','" & (vlRegistros("ENDERECOPESSOAFISICA").Value) & "','" & (vlRegistros("NUMEROPESSOAFISICA").Value) & "','" & (vlRegistros("CEPPESSOAFISICA").Value) & "','" & (vlRegistros("UFPESSOAFISICA").Value) & "','" & (vlRegistros("BAIRROPESSOAFISICA").Value) & "','" & (vlRegistros("CIDADEPESSOAFISICA").Value) & "','" & (vlRegistros("TELEFONEPESSOAFISICA").Value) & "','" & (vlRegistros("CELULARPESSOAFISICA").Value) & "','" & (vlRegistros("COMPLEMENTOPESSOAFISICA").Value) & "','" & (vlRegistros("EMAILPESSOAFISICA").Value) & "','" & (vlRegistros("SEXOPESSOAFISICA").Value) & "','" & (vlRegistros("CPFPESSOAFISICA").Value) & "','" & (vlRegistros("RGPESSOAFISICA").Value) & "','" & (vlRegistros("CNPJ").Value) & "','" & (vlRegistros("INSESTADUAL").Value) & "','" & (vlRegistros("DATACADASTRO").Value) & "','" & vlRegistros("SENHACLIENTE").Value & "')")
    '            cmd.Connection = cnn
    '            cmd.ExecuteNonQuery()
    '            cmd.CommandText = ""
    '            vlRegistros.MoveNext()
    '        End While
    '        vlRegistros.Close()
    '    End If
    '    cnn.Close()
    '    MsgBox("Arquivos sincronizados com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
    'End Sub

    Private Sub AgendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendaToolStripMenuItem.Click
        'frmRelatorioAgenda.ShowDialog()
    End Sub
    Private Sub ListaDeEmailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeEmailsToolStripMenuItem.Click
        'frmRelatorioEmailClientes.ShowDialog()
    End Sub

    Private Sub FornecedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem1.Click
        'frmRelatorioFornecedores.ShowDialog()
    End Sub

    Private Sub ProdutosServiçosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosServiçosToolStripMenuItem.Click
        'frmRelatorioProdutos.ShowDialog()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem2.Click
        'frmRelatorioFuncionarios.ShowDialog()
    End Sub

    Private Sub ContasAPagarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContasAPagarToolStripMenuItem.Click
        frmContasPagarBusca.ShowDialog()
    End Sub

    Private Sub CaixaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaixaToolStripMenuItem.Click
        frmCaixa.ShowDialog()
    End Sub

    Private Sub DiscriminaçãoDeContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscriminaçãoDeContasToolStripMenuItem.Click
        frmContasDiscriminacao.ShowDialog()
    End Sub

    Private Sub ContasAReceberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContasAReceberToolStripMenuItem.Click
        frmContasReceber.ShowDialog()
    End Sub

    Private Sub DespesasAvulsasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespesasAvulsasToolStripMenuItem.Click
        frmDespesasAvulsas.ShowDialog()
    End Sub

    Private Sub VendasVarejoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasVarejoToolStripMenuItem.Click
        frmVendasResumo.ShowDialog()
    End Sub

    Private Sub ContasAPagarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContasAPagarToolStripMenuItem1.Click
        frmCadastroContasaPagar.ShowDialog()
    End Sub

    Private Sub RaçaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RaçaToolStripMenuItem.Click
        frmCadastroRaca.ShowDialog()
    End Sub

    Private Sub PorteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorteToolStripMenuItem.Click
        frmCadastroPorte.ShowDialog()
    End Sub

    Private Sub PelagemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelagemToolStripMenuItem.Click
        frmCadastroPelagem.ShowDialog()
    End Sub

    Private Sub EspécieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspécieToolStripMenuItem.Click
        frmCadastroEspecie.ShowDialog()
    End Sub

    Private Sub EstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoToolStripMenuItem.Click
        frmCadastroEstado.ShowDialog()
    End Sub

    Private Sub TemperamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemperamentoToolStripMenuItem.Click
        frmCadastroTemperamento.ShowDialog()
    End Sub

    Private Sub pctboxCaixa_Click(sender As Object, e As EventArgs) Handles pctboxCaixa.Click
        frmCaixa.ShowDialog()
    End Sub
End Class