Public Class frmBuscaUsuario

        Private Sub frmBuscaCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfBuscaUsuario()


        End Sub

    Private Sub pfBuscaUsuario()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM USUARIOS ORDER BY NOMEUSUARIO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOUSUARIO").Value, "0###")
                    .SubItems.Add(vlRegistros("NOMEUSUARIO").Value)
                    .SubItems.Add(vlRegistros("TELEFONEUSUARIO").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros

        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub txtBuscaUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaUsuario.TextChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM USUARIOS WHERE upper(NOMEUSUARIO) LIKE '" & UCase(txtBuscaUsuario.Text) & "%' ORDER BY NOMEUSUARIO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOUSUARIO").Value, "0###")
                    .SubItems.Add(vlRegistros("NOMEUSUARIO").Value)
                    .SubItems.Add("" & vlRegistros("TELEFONEUSUARIO").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros

        End If
    End Sub

    Private Sub lsvBuscaUSuario_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        If lsvDados.Items.Count = 0 Then Exit Sub
        frmCadastroUsuario.txtCodigo.Text = lsvDados.SelectedItems(0).Text
        frmCadastroUsuario.txtNome.Text = lsvDados.SelectedItems(0).SubItems(1).Text
        frmCadastroUsuario.txtTelefone.Text = lsvDados.SelectedItems(0).SubItems(2).Text
        frmCadastroUsuario.ShowDialog()
        Me.Close()

    End Sub

    
    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        frmCadastroUsuario.ShowDialog()
        pfBuscaUsuario()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Deseja  excluir o usuário " & lsvDados.SelectedItems(0).SubItems(1).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet  : : Pergunta ") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM USUARIOS WHERE CODIGOUSUARIO = '" & CDbl(lsvDados.SelectedItems(0).Text) & "'")
        MsgBox("Usuário excluído com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaUsuario()
    End Sub
End Class
