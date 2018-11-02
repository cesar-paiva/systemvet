Public Class frmBuscaProfissionais
    Private Sub frmBuscaProfissionais_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfBuscaProfissional()
    End Sub


    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        frmCadastroProfissionais.ShowDialog()
        pfBuscaProfissional() ' atualiza o list view
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub pfBuscaProfissional()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM PROFISSIONAL ORDER BY NOMEPROFISSIONAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOPROFISSIONAL").Value, "0##")
                    .SubItems.Add(vlRegistros("NOMEPROFISSIONAL").Value)
                    .SubItems.Add(vlRegistros("TELEFONEPROFISSIONAL").Value & " / " & vlRegistros("CELULARPROFISSIONAL").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros

        End If

    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        If lsvDados.Items.Count = 0 Then Exit Sub
        frmCadastroProfissionais.ShowDialog()
        pfBuscaProfissional()
    End Sub

   
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Deseja  excluir o profissional " & lsvDados.SelectedItems(0).SubItems(1).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet  : : Pergunta ") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM PROFISSIONAL WHERE CODIGOPROFISSIONAL = '" & CDbl(lsvDados.SelectedItems(0).Text) & "'")

        MsgBox("Cliente excluído com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaProfissional()
    End Sub

    Private Sub txtBuscaProfissional_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaProfissional.TextChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM PROFISSIONAL WHERE NOMEPROFISSIONAL LIKE '" & UCase(txtBuscaProfissional.Text) & "%' ORDER BY NOMEPROFISSIONAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOPROFISSIONAL").Value, "0##")
                    .SubItems.Add(vlRegistros("NOMEPROFISSIONAL").Value)
                    .SubItems.Add(vlRegistros("TELEFONEPROFISSIONAL").Value & " / " & vlRegistros("CELULARPROFISSIONAL").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'frmRelatorioFuncionarios.ShowDialog()
    End Sub
End Class