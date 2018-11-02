Public Class frmIncluiProduto

    Private Sub frmIncluiProduto_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfBuscaProduto()
        pfPrenchecboTipoFiltro()
        pfbuscaCategoria()

    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        If lsvDados.SelectedItems(0).SubItems(5).Text = "SERVIÇO" Then
            vftestaProduto = "SERVICO"
        Else
            vftestaProduto = "PRODUTO"
        End If
        frmInserirItem.ShowDialog()
    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM PRODUTO WHERE DESCRICAO LIKE '" & UCase(txtBusca.Text) & "%' ORDER BY DESCRICAO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
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
                    .SubItems.Add(vlRegistros("VALORVENDA").Value)
                    .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                    .SubItems.Add(vlRegistros("MARCA").Value)
                    .SubItems.Add(vlRegistros("CATEGORIA").Value)

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
                    .SubItems.Add(vlRegistros("VALOR").Value)
                    .SubItems.Add("")
                    .SubItems.Add("")
                    .SubItems.Add("SERVIÇO")
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha  a var iavel  de  registros
        End If
        'pfBuscaProduto()
    End Sub

    Private Sub pfPrenchecboTipoFiltro()
        cboTipoFiltro.Text = ""
        cboTipoFiltro.Items.Clear()
        cboTipoFiltro.Items.Add("Ordenar por Descrição")
        cboTipoFiltro.Items.Add("Ordenar por Estoque Atual")
        cboTipoFiltro.Items.Add("Ordenar por Categoria")
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
                        .SubItems.Add(vlRegistros("VALORVENDA").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                        .SubItems.Add(vlRegistros("MARCA").Value)
                        .SubItems.Add(vlRegistros("CATEGORIA").Value)
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
                        .SubItems.Add(vlRegistros("VALORVENDA").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                        .SubItems.Add(vlRegistros("MARCA").Value)
                        .SubItems.Add(vlRegistros("CATEGORIA").Value)
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
                        .SubItems.Add(vlRegistros("VALORVENDA").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                        .SubItems.Add(vlRegistros("MARCA").Value)
                        .SubItems.Add(vlRegistros("CATEGORIA").Value)
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
                        .SubItems.Add(vlRegistros("VALORVENDA").Value)
                        .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                        .SubItems.Add(vlRegistros("MARCA").Value)
                        .SubItems.Add(vlRegistros("CATEGORIA").Value)
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
                    .SubItems.Add(vlRegistros("VALOR").Value)
                    .SubItems.Add("")
                    .SubItems.Add("")
                    .SubItems.Add("SERVIÇO")
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros

        End If
    End Sub

    Private Sub pfBuscaProduto()
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
                    .SubItems.Add(vlRegistros("VALORVENDA").Value)
                    .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                    .SubItems.Add(vlRegistros("MARCA").Value)
                    .SubItems.Add(vlRegistros("CATEGORIA").Value)
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
                    .SubItems.Add(vlRegistros("VALOR").Value)
                    .SubItems.Add("")
                    .SubItems.Add("")
                    .SubItems.Add("SERVIÇO")
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros

        End If
    End Sub

    Private Sub pfbuscaCategoria()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CATEGORIA ORDER BY NOMECATEGORIA", vgDados)
        cboCategoria.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        Else
            While Not vlRegistros.EOF
                cboCategoria.Items.Add(vlRegistros("NOMECATEGORIA").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        End If
        cboCategoria.Items.Add("TODAS")
    End Sub


    Private Sub cboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoria.SelectedIndexChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        If cboCategoria.Text = "TODAS" Then pfBuscaProduto() : Exit Sub
        vlRegistros.Open("SELECT * FROM PRODUTO WHERE CATEGORIA LIKE '" & UCase(cboCategoria.Text) & "%' ORDER BY CATEGORIA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
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
                    .SubItems.Add(vlRegistros("VALORVENDA").Value)
                    .SubItems.Add(vlRegistros("ESTOQUEATUAL").Value)
                    .SubItems.Add(vlRegistros("MARCA").Value)
                    .SubItems.Add(vlRegistros("CATEGORIA").Value)

                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha  a var iavel  de  registros
        End If
    End Sub
End Class