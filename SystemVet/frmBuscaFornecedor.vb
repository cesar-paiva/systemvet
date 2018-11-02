Public Class frmBuscaFornecedor

    Private Sub frmBuscaFornecedor_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfPreenchecboTipoFiltro()
        pfBuscaFornecedor()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        frmCadastroFornecedor.ShowDialog()
        pfBuscaFornecedor()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub pfPreenchecboTipoFiltro()
        cboTipoFiltro.Text = ""
        cboTipoFiltro.Items.Clear()
        cboTipoFiltro.Items.Add("Ordenar por Fornecedor")
        cboTipoFiltro.Items.Add("Ordenar por Código")
    End Sub

    Private Sub pfBuscaFornecedor()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM FORNECEDOR ORDER BY RAZAOSOCIAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGO").Value, "0##")
                    .SubItems.Add(vlRegistros("RAZAOSOCIAL").Value)
                    .SubItems.Add(vlRegistros("TELEFONE1").Value)
                    .SubItems.Add(vlRegistros("EMAIL").Value)
                    .SubItems.Add(vlRegistros("CATEGORIA").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If
    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        If lsvDados.Items.Count = 0 Then Exit Sub
        frmCadastroFornecedor.Close()
        frmCadastroFornecedor.ShowDialog()
        frmCadastroFornecedor.txtCodigo.Text = lsvDados.SelectedItems(0).Text
        frmCadastroFornecedor.txtRazaoSocial.Text = lsvDados.SelectedItems(0).SubItems(1).Text
        frmCadastroFornecedor.txtTelefone.Text = lsvDados.SelectedItems(0).SubItems(2).Text
        frmCadastroFornecedor.txtEmail.Text = lsvDados.SelectedItems(0).SubItems(3).Text
        If lsvDados.SelectedItems(0).SubItems(4).Text = "Distribuidor" Then frmCadastroFornecedor.optDistribuidor.Checked = True
        If lsvDados.SelectedItems(0).SubItems(4).Text = "Atacadista" Then frmCadastroFornecedor.optAtacadista.Checked = True
        If lsvDados.SelectedItems(0).SubItems(4).Text = "Fabricante" Then frmCadastroFornecedor.optFabricante.Checked = True
        If lsvDados.SelectedItems(0).SubItems(4).Text = "Outros" Then frmCadastroFornecedor.optOutros.Checked = True
        pfBuscaFornecedor()
    End Sub


    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Deseja  excluir o fornecedor " & lsvDados.SelectedItems(0).SubItems(1).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet  :: Pergunta ") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM FORNECEDOR WHERE CODIGO = '" & CDbl(lsvDados.SelectedItems(0).Text) & "'")
        MsgBox("Fornecedor excluído com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaFornecedor()
    End Sub

    Private Sub txtBuscaFornecedor_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaFornecedor.TextChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM FORNECEDOR WHERE RAZAOSOCIAL LIKE '" & UCase(txtBuscaFornecedor.Text) & "%' ORDER BY RAZAOSOCIAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGO").Value, "0##")
                    .SubItems.Add(vlRegistros("RAZAOSOCIAL").Value)
                    .SubItems.Add(vlRegistros("TELEFONE1").Value)
                    .SubItems.Add(vlRegistros("EMAIL").Value)
                    .SubItems.Add(vlRegistros("CATEGORIA").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If

    End Sub

    Private Sub cboTipoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoFiltro.SelectedIndexChanged
        If cboTipoFiltro.Text = "Ordenar por Fornecedor" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM FORNECEDOR ORDER BY RAZAOSOCIAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGO").Value, "0##")
                        .SubItems.Add(vlRegistros("RAZAOSOCIAL").Value)
                        .SubItems.Add(vlRegistros("TELEFONE1").Value)
                        .SubItems.Add(vlRegistros("EMAIL").Value)
                        .SubItems.Add(vlRegistros("CATEGORIA").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        ElseIf cboTipoFiltro.Text = "Ordenar por Código" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM FORNECEDOR ORDER BY CODIGO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGO").Value, "0##")
                        .SubItems.Add(vlRegistros("RAZAOSOCIAL").Value)
                        .SubItems.Add(vlRegistros("TELEFONE1").Value)
                        .SubItems.Add(vlRegistros("EMAIL").Value)
                        .SubItems.Add(vlRegistros("CATEGORIA").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If

        End If

    End Sub
End Class