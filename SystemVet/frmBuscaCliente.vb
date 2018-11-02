Public Class frmBuscaCliente

    Private Sub frmBuscaCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfPreenchecboTipoFiltro()
        pfBuscaCliente()


    End Sub

    Private Sub pfPreenchecboTipoFiltro()
        cboTipoFiltro.Text = ""
        cboTipoFiltro.Items.Clear()
        cboTipoFiltro.Items.Add("Ordenar por Nome")
        cboTipoFiltro.Items.Add("Ordenar por Código")


    End Sub
    Private Sub pfBuscaCliente()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM CLIENTES ORDER BY NOMEPESSOAFISICA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOPESSOAFISICA").Value, "0##")
                    .SubItems.Add(vlRegistros("NOMEPESSOAFISICA").Value)
                    .SubItems.Add(vlRegistros("TELEFONEPESSOAFISICA").Value)
                    .SubItems.Add(vlRegistros("EMAILPESSOAFISICA").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros

        End If

    End Sub


    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        frmCadastroCliente.ShowDialog()
        pfBuscaCliente()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        If lsvDados.Items.Count = 0 Then Exit Sub
            frmCadastroCliente.Close()
            frmCadastroCliente.ShowDialog()
            frmCadastroCliente.txtCodigo.Text = lsvDados.SelectedItems(0).Text
            frmCadastroCliente.txtNome.Text = lsvDados.SelectedItems(0).SubItems(1).Text
            frmCadastroCliente.txtTelefone.Text = lsvDados.SelectedItems(0).SubItems(2).Text
            frmCadastroCliente.txtEmail.Text = lsvDados.SelectedItems(0).SubItems(3).Text

        pfBuscaCliente()

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Deseja  excluir o cliente " & lsvDados.SelectedItems(0).SubItems(1).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet  :: Pergunta ") = MsgBoxResult.No Then Exit Sub
            vgDados.Execute("DELETE FROM CLIENTES WHERE CODIGOPESSOAFISICA = '" & CDbl(lsvDados.SelectedItems(0).Text) & "'")
        
        MsgBox("Cliente excluído com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaCliente()
    End Sub

    Private Sub txtBuscaCliente_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaCliente.TextChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM CLIENTES WHERE NOMEPESSOAFISICA LIKE '" & UCase(txtBuscaCliente.Text) & "%' ORDER BY NOMEPESSOAFISICA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOPESSOAFISICA").Value, "0##")
                    .SubItems.Add(vlRegistros("NOMEPESSOAFISICA").Value)
                    .SubItems.Add(vlRegistros("TELEFONEPESSOAFISICA").Value)
                    .SubItems.Add(vlRegistros("EMAILPESSOAFISICA").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If
    End Sub

    Private Sub cboTipoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoFiltro.SelectedIndexChanged
        If cboTipoFiltro.Text = "Ordenar por Nome" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM CLIENTES ORDER BY NOMEPESSOAFISICA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGOPESSOAFISICA").Value, "0##")
                        .SubItems.Add(vlRegistros("NOMEPESSOAFISICA").Value)
                        .SubItems.Add(vlRegistros("TELEFONEPESSOAFISICA").Value)
                        .SubItems.Add(vlRegistros("EMAILPESSOAFISICA").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        ElseIf cboTipoFiltro.Text = "Ordenar por Código" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM CLIENTES ORDER BY CODIGOPESSOAFISICA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGOPESSOAFISICA").Value, "0##")
                        .SubItems.Add(vlRegistros("NOMEPESSOAFISICA").Value)
                        .SubItems.Add(vlRegistros("TELEFONEPESSOAFISICA").Value)
                        .SubItems.Add(vlRegistros("EMAILPESSOAFISICA").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'frmRelatorioCliente.ShowDialog()
    End Sub
End Class