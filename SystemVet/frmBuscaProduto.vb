Public Class frmBuscaProduto

    Private Sub frmBuscaProduto_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfBuscaProduto()
        pfPrenchecboTipoFiltro()
        pfBuscaCategoria()
    End Sub

    Private Sub btnNovoProduto_Click(sender As Object, e As EventArgs) Handles btnNovoProduto.Click
        testaCadastro = 0
        frmCadastroProduto.ShowDialog()
        pfBuscaProduto()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnNovoServico_Click(sender As Object, e As EventArgs) Handles btnNovoServico.Click
        frmCadastroServicos.ShowDialog()
        pfBuscaProduto()
    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        testaCadastro = 1
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedItems(0).SubItems(6).Text = "SERVIÇO" Then
            frmCadastroServicos.ShowDialog()
        Else
            frmCadastroProduto.ShowDialog()
        End If
        pfBuscaProduto()
        testaCadastro = 0
    End Sub

    Private Sub pfBuscaProduto()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM PRODUTO ORDER BY DESCRICAO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGO").Value, "0##")
                    .SubItems.Add(vlRegistros("DESCRICAO").Value)
                    .SubItems.Add(vlRegistros("UNIDADE").Value)
                    .SubItems.Add(vlRegistros("VALORVENDA").Value)
                    .SubItems.Add(vlRegistros("ESTOQUEMINIMO").Value)
                    .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                    .SubItems.Add(vlRegistros("CATEGORIA").Value)
                    .SubItems.Add(vlRegistros("MARCA").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros

        End If

        vlRegistros.Open("SELECT * FROM SERVICO ORDER BY DESCRICAO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGO").Value, "0##")
                    .SubItems.Add(vlRegistros("DESCRICAO").Value)
                    .SubItems.Add("")
                    .SubItems.Add(vlRegistros("VALOR").Value)
                    .SubItems.Add("")
                    .SubItems.Add("")
                    .SubItems.Add("SERVIÇO")
                    .SubItems.Add("")
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros

        End If
    End Sub


    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Deseja  excluir o PRODUTO/SERVIÇO " & lsvDados.SelectedItems(0).SubItems(1).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet  :: Pergunta ") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM PRODUTO WHERE CODIGO = '" & CDbl(lsvDados.SelectedItems(0).Text) & "'")

        MsgBox("Produto excluído com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaProduto()
    End Sub

    Private Sub pfPrenchecboTipoFiltro()
        cboTipoFiltro.Text = ""
        cboTipoFiltro.Items.Clear()
        cboTipoFiltro.Items.Add("Ordenar por Descrição")
        cboTipoFiltro.Items.Add("Ordenar por Estoque Mínimo")
        cboTipoFiltro.Items.Add("Ordenar por Estoque Atual")
        cboTipoFiltro.Items.Add("Ordenar por Marca")
    End Sub




    Private Sub cboTipoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoFiltro.SelectedIndexChanged
        If cboTipoFiltro.Text = "Ordenar por Descrição" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM PRODUTO ORDER BY DESCRICAO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGO").Value, "0##")
                        .SubItems.Add(vlRegistros("DESCRICAO").Value)
                        .SubItems.Add(vlRegistros("UNIDADE").Value)
                        .SubItems.Add(vlRegistros("VALORVENDA").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEMINIMO").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                        .SubItems.Add(vlRegistros("CATEGORIA").Value)
                        .SubItems.Add(vlRegistros("MARCA").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        ElseIf cboTipoFiltro.Text = "Ordenar por Estoque Mínimo" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM PRODUTO ORDER BY ESTOQUEMINIMO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGO").Value, "0##")
                        .SubItems.Add(vlRegistros("DESCRICAO").Value)
                        .SubItems.Add(vlRegistros("UNIDADE").Value)
                        .SubItems.Add(vlRegistros("VALORVENDA").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEMINIMO").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                        .SubItems.Add(vlRegistros("CATEGORIA").Value)
                        .SubItems.Add(vlRegistros("MARCA").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        ElseIf cboTipoFiltro.Text = "Ordenar por Estoque Atual" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM PRODUTO ORDER BY ESTOQUEATUAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGO").Value, "0##")
                        .SubItems.Add(vlRegistros("DESCRICAO").Value)
                        .SubItems.Add(vlRegistros("UNIDADE").Value)
                        .SubItems.Add(vlRegistros("VALORVENDA").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEMINIMO").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                        .SubItems.Add(vlRegistros("CATEGORIA").Value)
                        .SubItems.Add(vlRegistros("MARCA").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        ElseIf cboTipoFiltro.Text = "Ordenar por Categoria" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM PRODUTO ORDER BY CATEGORIA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGO").Value, "0##")
                        .SubItems.Add(vlRegistros("DESCRICAO").Value)
                        .SubItems.Add(vlRegistros("UNIDADE").Value)
                        .SubItems.Add(vlRegistros("VALORVENDA").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEMINIMO").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                        .SubItems.Add(vlRegistros("CATEGORIA").Value)
                        .SubItems.Add(vlRegistros("MARCA").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        ElseIf cboTipoFiltro.Text = "Ordenar por Marca" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM PRODUTO ORDER BY MARCA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGO").Value, "0##")
                        .SubItems.Add(vlRegistros("DESCRICAO").Value)
                        .SubItems.Add(vlRegistros("UNIDADE").Value)
                        .SubItems.Add(vlRegistros("VALORVENDA").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEMINIMO").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                        .SubItems.Add(vlRegistros("CATEGORIA").Value)
                        .SubItems.Add(vlRegistros("MARCA").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        End If

        vlRegistros.Open("SELECT * FROM SERVICO ORDER BY DESCRICAO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGO").Value, "0##")
                    .SubItems.Add(vlRegistros("DESCRICAO").Value)
                    .SubItems.Add("")
                    .SubItems.Add(vlRegistros("VALOR").Value)
                    .SubItems.Add("")
                    .SubItems.Add("")
                    .SubItems.Add("SERVIÇO")
                    .SubItems.Add("")
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros

        End If

    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM PRODUTO WHERE DESCRICAO LIKE '" & UCase(txtBusca.Text) & "%' ORDER BY DESCRICAO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGO").Value, "0##")
                    .SubItems.Add(vlRegistros("DESCRICAO").Value)
                    .SubItems.Add(vlRegistros("UNIDADE").Value)
                    .SubItems.Add(vlRegistros("VALORVENDA").Value)
                    .SubItems.Add(vlRegistros("ESTOQUEMINIMO").Value)
                    .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                    .SubItems.Add(vlRegistros("CATEGORIA").Value)
                    .SubItems.Add(vlRegistros("MARCA").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha  a var iavel  de  registros
        End If

        vlRegistros.Open("SELECT * FROM SERVICO ORDER BY DESCRICAO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGO").Value, "0##")
                    .SubItems.Add(vlRegistros("DESCRICAO").Value)
                    .SubItems.Add("")
                    .SubItems.Add(vlRegistros("VALOR").Value)
                    .SubItems.Add("")
                    .SubItems.Add("")
                    .SubItems.Add("SERVIÇO")
                    .SubItems.Add("")
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If
    End Sub

    Private Sub pfBuscaCategoria()
        cboCategoria.Items.Clear()
        cboCategoria.Text = ""
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM CATEGORIA ORDER BY NOMECATEGORIA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados

        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF
                cboCategoria.Items.Add(vlRegistros("NOMECATEGORIA").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        End If
        cboCategoria.Items.Add("TODAS")
    End Sub

    Private Sub cboCategoria_TextChanged(sender As Object, e As EventArgs) Handles cboCategoria.TextChanged
        If cboCategoria.Text = "TODAS" Or cboCategoria.Text = "" Then pfBuscaProduto() : Exit Sub
        If vlRegistros.State = 1 Then vlRegistros.Close()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM PRODUTO WHERE CATEGORIA = '" & cboCategoria.Text & "' ORDER BY DESCRICAO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGO").Value, "0##")
                    .SubItems.Add(vlRegistros("DESCRICAO").Value)
                    .SubItems.Add(vlRegistros("UNIDADE").Value)
                    .SubItems.Add(vlRegistros("VALORVENDA").Value)
                    .SubItems.Add(vlRegistros("ESTOQUEMINIMO").Value)
                    .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                    .SubItems.Add(vlRegistros("CATEGORIA").Value)
                    .SubItems.Add(vlRegistros("MARCA").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If

    End Sub
End Class