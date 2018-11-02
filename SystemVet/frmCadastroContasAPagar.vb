Public Class frmCadastroContasaPagar

    Private Sub frmCadastroContasaPagar_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfLimpaTela()
        pfBuscaServicos()
        vfTestaForm = 0
        txtDescricao.Focus()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnNova_Click(sender As Object, e As EventArgs) Handles btnNova.Click
        pfLimpaTela()
        vfTestaForm = 0
        txtDescricao.Focus()
    End Sub

    Private Sub pfLimpaTela()
        txtCodigo.Text = "" : txtDescricao.Text = ""
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtDescricao.Text = "" Then
            MsgBox("Campo DESCRIÇÃO DA CONTA não pode estar em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtDescricao.Focus()
            Exit Sub
        End If
        If MsgBox("Confirma inclusão/alteração da conta " & txtDescricao.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        If vfTestaForm = 0 Then
            'Insere dados no banco
            vgDados.Execute("INSERT INTO CONTAS (NOMECONTA) VALUES ('" & UCase(txtDescricao.Text) & "')")
        Else
            'Altera dados no banco
            vgDados.Execute("UPDATE CONTAS SET NOMECONTA = '" & UCase(txtDescricao.Text) & "' WHERE CODIGOCONTA = '" & CDbl(txtCodigo.Text) & "'")
        End If
        pfBuscaServicos()
        pfLimpaTela()
        vfTestaForm = 0
        txtDescricao.Focus()
    End Sub

    Private Sub pfBuscaServicos()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CONTAS", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        End If
        While Not vlRegistros.EOF
            Dim vfItem As New ListViewItem
            With lsvDados.Items.Add(vfItem)
                .Text = "" & Format(vlRegistros("CODIGOCONTA").Value, "0####")
                .SubItems.Add("" & vlRegistros("NOMECONTA").Value)
            End With
            vlRegistros.MoveNext()
        End While
        vlRegistros.Close()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If txtCodigo.Text = "" Then Exit Sub
        If MsgBox("Deseja excluir a conta " & txtDescricao.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM CONTAS WHERE CODIGOCONTA = '" & CDbl(txtCodigo.Text) & "'")
        MsgBox("Conta excluída com sucesso!", MsgBoxStyle.Information, "SystemVet :: Pergunta")
        pfLimpaTela()
        pfBuscaServicos()
        vfTestaForm = 0
        txtDescricao.Focus()
    End Sub

    Private Sub lsvDados_Click(sender As Object, e As EventArgs) Handles lsvDados.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        txtCodigo.Text = "" & lsvDados.SelectedItems(0).Text
        txtDescricao.Text = "" & lsvDados.SelectedItems(0).SubItems(1).Text
        txtDescricao.Focus()
        vfTestaForm = 1
    End Sub

End Class