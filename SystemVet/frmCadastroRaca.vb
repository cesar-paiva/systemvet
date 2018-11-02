Public Class frmCadastroRaca
    Private Sub frmCadastroRaca_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfBuscaRaca()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtCodigo.Text = "" Then
            'aqui ira inserir no banco de dados
            vgDados.Execute("INSERT INTO RACA (NOMERACA) VALUES ('" & UCase(txtRaca.Text) & "')")
        Else
            'aqui altera no banco de dados
            vgDados.Execute("UPDATE RACA  SET NOMERACA = '" & UCase(txtRaca.Text) & "' WHERE CODIGORACA = '" & CDbl(txtCodigo.Text) & "'")
        End If

        MsgBox("Raça salva com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaRaca()
        txtRaca.Clear()
        txtCodigo.Clear()
    End Sub

    Private Sub pfBuscaRaca()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM RACA ORDER BY NOMERACA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGORACA").Value, "0###")
                    .SubItems.Add(vlRegistros("NOMERACA").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        txtCodigo.Clear()
        txtRaca.Clear()
        pfBuscaRaca()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Deseja  excluir a raça " & lsvDados.SelectedItems(0).SubItems(1).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet  : : Pergunta ") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM RACA WHERE CODIGORACA = '" & CDbl(lsvDados.SelectedItems(0).Text) & "'")
        MsgBox("Raça excluída com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaRaca()
    End Sub
  
    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        txtCodigo.Text = lsvDados.SelectedItems(0).Text
        txtRaca.Text = lsvDados.SelectedItems(0).SubItems(1).Text
        If txtCodigo.Text = "" Then Exit Sub
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM RACA WHERE CODIGORACA = '" & CDbl(txtCodigo.Text) & "'", vgDados)
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        Else
            txtRaca.Text = "" & vlRegistros("NOMERACA").Value
            vlRegistros.Close()
        End If
    End Sub
End Class