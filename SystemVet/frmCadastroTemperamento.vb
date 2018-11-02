Public Class frmCadastroTemperamento
    Private Sub frmCadastroTemperamento_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfBuscaTemperamento()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtCodigo.Text = "" Then
            'aqui ira inserir no banco de dados
            vgDados.Execute("INSERT INTO TEMPERAMENTO (TIPOTEMPERAMENTO) VALUES ('" & UCase(txtTemperamento.Text) & "')")
        Else
            'aqui altera no banco de dados
            vgDados.Execute("UPDATE TEMPERAMENTO  SET TIPOTEMPERAMENTO = '" & UCase(txtTemperamento.Text) & "' WHERE CODIGOTEMPERAMENTO = '" & CDbl(txtCodigo.Text) & "'")
        End If

        MsgBox("Temperamento salvo com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaTemperamento()
        txtTemperamento.Clear()
    End Sub

    Private Sub pfBuscaTemperamento()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM TEMPERAMENTO ORDER BY TIPOTEMPERAMENTO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOTEMPERAMENTO").Value, "0###")
                    .SubItems.Add(vlRegistros("TIPOTEMPERAMENTO").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        txtCodigo.Clear()
        txtTemperamento.Clear()
        pfBuscaTemperamento()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Deseja  excluir o temperamento " & lsvDados.SelectedItems(0).SubItems(1).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet  : : Pergunta ") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM TEMPERAMENTO WHERE CODIGOTEMPERAMENTO = '" & CDbl(lsvDados.SelectedItems(0).Text) & "'")
        MsgBox("Temperamento excluído com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaTemperamento()
    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        txtCodigo.Text = lsvDados.SelectedItems(0).Text
        txtTemperamento.Text = lsvDados.SelectedItems(0).SubItems(1).Text
        If txtCodigo.Text = "" Then Exit Sub
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM TEMPERAMENTO WHERE CODIGOTEMPERAMENTO = '" & CDbl(txtCodigo.Text) & "'", vgDados)
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        Else
            txtTemperamento.Text = "" & vlRegistros("TIPOTEMPERAMENTO").Value
            vlRegistros.Close()
        End If
    End Sub
End Class