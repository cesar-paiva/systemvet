Public Class frmCadastroEspecie
    Private Sub frmCadastroEspecie_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfBuscaEspecie()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtCodigo.Text = "" Then
            'aqui ira inserir no banco de dados
            vgDados.Execute("INSERT INTO ESPECIE (TIPOESPECIE) VALUES ('" & UCase(txtEspecie.Text) & "')")
        Else
            'aqui altera no banco de dados
            vgDados.Execute("UPDATE ESPECIE  SET TIPOESPECIE = '" & UCase(txtEspecie.Text) & "' WHERE CODIGOESPECIE = '" & CDbl(txtCodigo.Text) & "'")
        End If

        MsgBox("Espécie salva com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaEspecie()
        txtEspecie.Clear()
    End Sub

    Private Sub pfBuscaEspecie()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM ESPECIE ORDER BY TIPOESPECIE", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOESPECIE").Value, "0###")
                    .SubItems.Add(vlRegistros("TIPOESPECIE").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        txtCodigo.Clear()
        txtEspecie.Clear()
        pfBuscaEspecie()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Deseja  excluir a espécie " & lsvDados.SelectedItems(0).SubItems(1).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet  : : Pergunta ") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM ESPECIE WHERE CODIGOESPECIE = '" & CDbl(lsvDados.SelectedItems(0).Text) & "'")
        MsgBox("Espécie excluída com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaEspecie()
    End Sub


    Private Sub lsvDados_Click(sender As Object, e As EventArgs) Handles lsvDados.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        txtCodigo.Text = lsvDados.SelectedItems(0).Text
        txtEspecie.Text = lsvDados.SelectedItems(0).SubItems(1).Text
        txtEspecie.Focus()

    End Sub
End Class