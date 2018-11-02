Public Class frmCadastroProduto

    Private Sub frmCadastroProduto_Load(sender As Object, e As EventArgs) Handles Me.Load
        If testaCadastro = 0 Then pfLimpaTela()
        pfPreencheUnidade()
        'pfPreencheMarca()
        pfPreencheCategoria()
        pfPreencheFornecedor()
        If testaCadastro = 0 Then Exit Sub ' teste quando for cadastrar novo produto sem clicar no list view
        txtCodigo.Text = frmBuscaProduto.lsvDados.SelectedItems(0).Text
        pfBuscaDados()

    End Sub

    Private Sub pfBuscaDados() ' procedimento para buscar o resto dos dados que não são mostrados no list view
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM PRODUTO WHERE CODIGO = '" & txtCodigo.Text & "'", vgDados) ' consulta no banco buscando todos os dados
        If vlRegistros.RecordCount = 0 Then vlRegistros.Close() : Exit Sub ' se não tiver registro fecha a variavel e sai do procdimento ( situação de cadastro de um novo produto)
        txtCodigoBarras.Text = vlRegistros("CODIGOBARRAS").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        txtDescricao.Text = vlRegistros("DESCRICAO").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        cboUnidade.Text = vlRegistros("UNIDADE").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        txtValorVenda.Text = vlRegistros("VALORVENDA").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        txtEstoqueMinimo.Text = vlRegistros("ESTOQUEMINIMO").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        txtEstoqueAtual.Text = vlRegistros("ESTOQUEATUAL").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        cboCategoria.Text = vlRegistros("CATEGORIA").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        'cboMarcas.Text = vlRegistros("MARCA").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        'If vlRegistros("CONTROLARESTOQUE").Value = "SIM" Then ' teste para saber se o check box está marcado
        '    chkboxEstoque.Checked = True
        'Else
        '    chkboxEstoque.Checked = False
        'End If
        'If vlRegistros("ATUALIZARCUSTO").Value = "SIM" Then ' teste para saber se o check box está marcado
        '    chkboxAtualizar.Checked = True
        'Else
        '    chkboxAtualizar.Checked = False
        'End If
        'If vlRegistros("VENDERZERADO").Value = "SIM" Then ' teste para saber se o check box está marcado
        '    chkboxVender.Checked = True
        'Else
        '    chkboxVender.Checked = False
        'End If
        txtValorCusto.Text = vlRegistros("VALORCUSTO").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        txtMargem.Text = vlRegistros("MARGEM").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        txtObservaoes.Text = vlRegistros("OBSERVACAO").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        vlRegistros.Close()

    End Sub

    'Private Sub pfPreencheMarca()
    '    vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
    '    vlRegistros.Open("SELECT * FROM MARCA ORDER BY NOMEMARCA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
    '    cboMarcas.Items.Clear()
    '    cboMarcas.Text = ""
    '    While Not vlRegistros.EOF
    '        cboMarcas.Items.Add(vlRegistros("NOMEMARCA").Value)
    '        vlRegistros.MoveNext()
    '    End While
    '    vlRegistros.Close()
    '    cboMarcas.Items.Add("---------------------------------------------------")
    '    cboMarcas.Items.Add("Cadastrar marca")

    'End Sub

    Private Sub pfPreencheUnidade()
        cboUnidade.Text = ""
        cboUnidade.Items.Clear()
        cboUnidade.Items.Add("UNID.")
        cboUnidade.Items.Add("KG")
        cboUnidade.Items.Add("PCT")
        cboUnidade.Items.Add("CX")
        cboUnidade.Items.Add("PAR")
        cboUnidade.Items.Add("SACO")
        cboUnidade.Items.Add("ML")
        cboUnidade.Items.Add("LITRO")
    End Sub

    Private Sub pfPreencheCategoria()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM CATEGORIA ORDER BY NOMECATEGORIA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        cboCategoria.Items.Clear()
        cboCategoria.Text = ""
        While Not vlRegistros.EOF
            cboCategoria.Items.Add(vlRegistros("NOMECATEGORIA").Value)
            vlRegistros.MoveNext()
        End While
        vlRegistros.Close()
        cboCategoria.Items.Add("-----------------------------------------------------------------------------------------------")
        cboCategoria.Items.Add("Cadastrar categoria")
    End Sub

    Private Sub pfPreencheFornecedor()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM FORNECEDOR ORDER BY RAZAOSOCIAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        cboFornecedor.Items.Clear()
        cboFornecedor.Text = ""
        While Not vlRegistros.EOF
            cboFornecedor.Items.Add(vlRegistros("RAZAOSOCIAL").Value)
            vlRegistros.MoveNext()
        End While
        vlRegistros.Close()
        cboFornecedor.Items.Add("------------------------------------------------------------------------------------------------------------------------------------------------------")
        cboFornecedor.Items.Add("Cadastrar fornecedor")

    End Sub


    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        ' teste de preenchimento do nome
        If txtCodigo.Text = "" Then
            MsgBox("Campo CÓDIGO em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtCodigo.Focus()
            Exit Sub
        End If
        If txtDescricao.Text = "" Then
            MsgBox("Campo DESCRIÇÃO em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtDescricao.Focus()
            Exit Sub
        End If
        If cboUnidade.Text = "" Then cboUnidade.Text = "" ' aqui é pra poder passar do endereço e colocar um hifen se for em branco
        'If cboMarcas.Text = "" Then cboMarcas.Text = ""
        If cboCategoria.Text = "" Then cboCategoria.Text = ""
        'Dim vfControlaEstoque As String = ""
        'If chkboxEstoque.Checked = True Then
        '    vfControlaEstoque = "SIM"
        'Else
        '    vfControlaEstoque = "NÃO"
        'End If

        'Dim vfAtualizaCusto As String = ""
        'If chkboxAtualizar.Checked = True Then
        '    vfAtualizaCusto = "SIM"
        'Else
        '    vfAtualizaCusto = "NÃO"
        'End If

        'Dim vfVenderZerado As String = ""
        'If chkboxVender.Checked = True Then
        '    vfVenderZerado = "SIM"
        'Else
        '    vfVenderZerado = "NÃO"
        'End If

        If txtEstoqueMinimo.Text = "" Then txtEstoqueMinimo.Text = "0"
        If txtEstoqueAtual.Text = "" Then txtEstoqueAtual.Text = "0"
        If txtValorCusto.Text = "" Then txtValorCusto.Text = "0,00"
        If txtMargem.Text = "" Then txtMargem.Text = "0,00%"
        If txtValorVenda.Text = "" Then txtValorVenda.Text = "0,00"
        If txtObservaoes.Text = "" Then txtObservaoes.Text = "SEM OBSERVAÇÕES..."
        If testaCadastro = 0 Then
            'aqui ira inserir no banco de dados
            vgDados.Execute("INSERT INTO PRODUTO (CODIGO, CODIGOBARRAS, UNIDADE, DESCRICAO, MARCA, CATEGORIA, DATACADASTRO, ESTOQUEMINIMO, ESTOQUEATUAL, DATAVALIDADE, VALORCUSTO, MARGEM, VALORVENDA, OBSERVACAO) VALUES ('" & txtCodigo.Text & "', '" & txtCodigoBarras.Text & "', '" & cboUnidade.Text & "', '" & UCase(txtDescricao.Text) & "', '" & cboCategoria.Text & "', '" & dtpCadastro.Text & "', '" & txtEstoqueMinimo.Text & "', '" & txtEstoqueAtual.Text & "',  '" & txtValorCusto.Text & "', '" & txtMargem.Text & "', '" & txtValorVenda.Text & "','" & UCase(txtObservaoes.Text) & "')")
            'Tinhas as opçoes de check box de controlar estoque, vender com estoque zerado e atualizar custo
            'vgDados.Execute("INSERT INTO PRODUTO (CODIGO, CODIGOBARRAS, UNIDADE, DESCRICAO, MARCA, CATEGORIA, DATACADASTRO, CONTROLARESTOQUE, ATUALIZARCUSTO, VENDERZERADO, ESTOQUEMINIMO, ESTOQUEATUAL, DATAVALIDADE, VALORCUSTO, MARGEM, VALORVENDA, OBSERVACAO) VALUES ('" & txtCodigo.Text & "', '" & txtCodigoBarras.Text & "', '" & cboUnidade.Text & "', '" & UCase(txtDescricao.Text) & "', '" & cboMarcas.Text & "', '" & cboCategoria.Text & "', '" & dtpCadastro.Text & "', '" & vfControlaEstoque & "', '" & vfAtualizaCusto & "', '" & vfVenderZerado & "', '" & txtEstoqueMinimo.Text & "', '" & txtEstoqueAtual.Text & "', '" & txtDataValidade.Text & "', '" & txtValorCusto.Text & "', '" & txtMargem.Text & "', '" & txtValorVenda.Text & "','" & UCase(txtObservaoes.Text) & "')")
        Else
            'aqui altera no banco de dados
            vgDados.Execute("UPDATE PRODUTO SET DESCRICAO = '" & UCase(txtDescricao.Text) & "', CODIGOBARRAS = '" & txtCodigoBarras.Text & "', UNIDADE = '" & cboUnidade.Text & "', CATEGORIA = '" & cboCategoria.Text & "', DATACADASTRO = '" & dtpCadastro.Text & "', ESTOQUEMINIMO = '" & txtEstoqueMinimo.Text & "', ESTOQUEATUAL = '" & txtEstoqueAtual.Text & "', VALORCUSTO = '" & txtValorCusto.Text & "', MARGEM = '" & txtMargem.Text & "', VALORVENDA = '" & txtValorVenda.Text & "', OBSERVACAO = '" & txtObservaoes.Text & "' WHERE CODIGO = '" & CDbl(txtCodigo.Text) & "'")
            'vgDados.Execute("UPDATE PRODUTO SET DESCRICAO = '" & UCase(txtDescricao.Text) & "', CODIGOBARRAS = '" & txtCodigoBarras.Text & "', UNIDADE = '" & cboUnidade.Text & "', MARCA = '" & cboMarcas.Text & "', CATEGORIA = '" & cboCategoria.Text & "', DATACADASTRO = '" & dtpCadastro.Text & "', CONTROLARESTOQUE = '" & vfControlaEstoque & "', ATUALIZARCUSTO = '" & vfAtualizaCusto & "', VENDERZERADO = '" & vfVenderZerado & "', ESTOQUEMINIMO = '" & txtEstoqueMinimo.Text & "', ESTOQUEATUAL = '" & txtEstoqueAtual.Text & "', DATAVALIDADE = '" & txtDataValidade.Text & "', VALORCUSTO = '" & txtValorCusto.Text & "', MARGEM = '" & txtMargem.Text & "', VALORVENDA = '" & txtValorVenda.Text & "', OBSERVACAO = '" & txtObservaoes.Text & "' WHERE CODIGO = '" & CDbl(txtCodigo.Text) & "'")
        End If
        MsgBox("Produto salvo com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        Me.Close()
    End Sub

    'Private Sub cboMarcas_TextChanged(sender As Object, e As EventArgs)
    '    If cboMarcas.Text = "Cadastrar marca" Then
    '        frmCadastroMarcas.ShowDialog()
    '        pfPreencheMarca()
    '    End If
    'End Sub

    Private Sub cboCategoria_TextChanged(sender As Object, e As EventArgs) Handles cboCategoria.TextChanged
        If cboCategoria.Text = "Cadastrar categoria" Then
            frmCadastroCategoria.ShowDialog()
            pfPreencheCategoria()
        End If
    End Sub

    Private Sub cboFornecedor_TextChanged(sender As Object, e As EventArgs) Handles cboFornecedor.TextChanged
        If cboFornecedor.Text = "Cadastrar fornecedor" Then
            frmCadastroFornecedor.ShowDialog()
            pfPreencheFornecedor()
        End If
    End Sub

    Private Sub pfLimpaTela()
        txtCodigo.Clear() : txtCodigoBarras.Clear() : cboUnidade.Items.Clear() : txtDescricao.Clear() : cboCategoria.Items.Clear()
        'chkboxEstoque.Checked = False : chkboxAtualizar.Checked = False : chkboxVender.Checked = False
        txtEstoqueMinimo.Clear() : txtEstoqueAtual.Clear() : txtValorCusto.Clear() : txtMargem.Clear() : txtValorVenda.Clear() : txtObservaoes.Clear()
        pfPreencheCategoria()
        'pfPreencheMarca()
        pfPreencheUnidade()
    End Sub

    Private Sub txtCodigo_LostFocus(sender As Object, e As EventArgs) Handles txtCodigo.LostFocus
        If txtCodigo.Text = "" Then Exit Sub
        pfBuscaDados()
    End Sub

End Class