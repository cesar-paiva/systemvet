Public Class frmCadastroProfissao

    Private Sub frmCadastroProfissao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pfBuscaProfissao()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtCodigo.Text = "" Then
            'aqui ira inserir no banco de dados
            vgDados.Execute("INSERT INTO PROFISSAO (NOMEPROFISSAO) VALUES ('" & UCase(txtProfissao.Text) & "')")
        Else
            'aqui altera no banco de dados
            vgDados.Execute("UPDATE PROFISSAO  SET NOMEPROFISSAO = '" & UCase(txtProfissao.Text) & "' WHERE CODIGOPROFISSAO = '" & CDbl(txtCodigo.Text) & "'")
        End If

        MsgBox("Profissão salva com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaProfissao()
        txtProfissao.Clear()
    End Sub

    Private Sub pfBuscaProfissao()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM PROFISSAO ORDER BY NOMEPROFISSAO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOPROFISSAO").Value, "0###")
                    .SubItems.Add(vlRegistros("NOMEPROFISSAO").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If

    End Sub


    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Deseja  excluir a profissão " & lsvDados.SelectedItems(0).SubItems(1).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet  : : Pergunta ") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM PROFISSAO WHERE CODIGOPROFISSAO = '" & CDbl(lsvDados.SelectedItems(0).Text) & "'")
        MsgBox("Profissão excluída com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaProfissao()
    End Sub

    Private Sub lsvDados_Click(sender As Object, e As EventArgs) Handles lsvDados.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        txtCodigo.Text = lsvDados.SelectedItems(0).Text
        txtProfissao.Text = lsvDados.SelectedItems(0).SubItems(1).Text
        txtProfissao.Focus()
    End Sub

  
End Class

