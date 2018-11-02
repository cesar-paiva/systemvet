Public Class frmContasPagarBusca
    Private Sub frmContasPagarBusca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pfBuscaContasCadastradas()
    End Sub

    Private Sub pfBuscaContasCadastradas()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CONTASPAGAR ORDER BY DATACONTA", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        End If
        While Not vlRegistros.EOF
            Dim vfItem As New ListViewItem
            With lsvDados.Items.Add(vfItem)
                .Text = "" & Format(CDbl(vlRegistros("CODIGOCONTASPAGAR").Value), "0####")
                .SubItems.Add("" & vlRegistros("NOMECONTA").Value)
                .SubItems.Add("" & vlRegistros("DATACONTA").Value)
                .SubItems.Add("" & vlRegistros("VALORCONTA").Value)
                .SubItems.Add("" & vlRegistros("PAGAMENTOCONTA").Value)
                .SubItems.Add("" & vlRegistros("VALORPAGAMENTOCONTA").Value)
                .SubItems.Add("" & vlRegistros("OBSCONTA").Value)
            End With
            vlRegistros.MoveNext()
        End While
        vlRegistros.Close()
    End Sub



    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        frmContasPagar.ShowDialog()
        pfBuscaContasCadastradas()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If lsvDados.Items.Count = 0 Then
            MsgBox("Nenhuma conta selecionada, selecione uma conta para excluir!", MsgBoxStyle.Information, "SystemVet :: Informação")
            Exit Sub
        End If
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Confirma exclusão da conta " & lsvDados.SelectedItems(0).SubItems(1).Text & " no valor de R$ " & lsvDados.SelectedItems(0).SubItems(3).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM CONTASPAGAR WHERE CODIGOCONTASPAGAR = '" & CDbl(lsvDados.SelectedItems(0).Text) & "'")
        pfBuscaContasCadastradas()
    End Sub

    Private Sub txtData_ValueChanged(sender As Object, e As EventArgs) Handles txtData.ValueChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CONTASPAGAR WHERE DATACONTA = '" & Date.Parse(txtData.Text).ToString("MM/dd/yyy") & "' ORDER BY DATACONTA", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        End If
        While Not vlRegistros.EOF
            Dim vfItem As New ListViewItem
            With lsvDados.Items.Add(vfItem)
                .Text = "" & Format(CDbl(vlRegistros("CODIGOCONTASPAGAR").Value), "0####")
                .SubItems.Add("" & vlRegistros("NOMECONTA").Value)
                .SubItems.Add("" & vlRegistros("DATACONTA").Value)
                .SubItems.Add("" & vlRegistros("VALORCONTA").Value)
                .SubItems.Add("" & vlRegistros("PAGAMENTOCONTA").Value)
                .SubItems.Add("" & vlRegistros("VALORPAGAMENTOCONTA").Value)
                .SubItems.Add("" & vlRegistros("OBSCONTA").Value)
            End With
            vlRegistros.MoveNext()
        End While
        vlRegistros.Close()
    End Sub

    Private Sub btnPagamento_Click(sender As Object, e As EventArgs) Handles btnPagamento.Click
        If lsvDados.SelectedIndices.Count = 0 Then
            MsgBox("Nenhuma conta selecionada, selecione uma conta para dar baixa!", MsgBoxStyle.Information, "SystemVet :: Informação")
            Exit Sub
        End If

        If lsvDados.SelectedItems(0).SubItems(4).Text <> "" Then
            MsgBox("Contá já foi paga!" & vbCrLf & "Favor entrar em contato com o Administrador do Sistema!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            Exit Sub
        End If
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Confirma pagamento da conta " & lsvDados.SelectedItems(0).SubItems(1).Text & "no valor de R$" & lsvDados.SelectedItems(0).SubItems(3).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        frmContasPagarRecebimento.ShowDialog()
        pfBuscaContasCadastradas()
    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If lsvDados.SelectedItems(0).SubItems(4).Text <> "" Then
            MsgBox("Contá já foi paga!" & vbCrLf & "Favor entrar em contato com o Administrador do Sistema!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            Exit Sub
        End If
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Confirma pagamento da conta " & lsvDados.SelectedItems(0).SubItems(1).Text & "no valor de R$" & lsvDados.SelectedItems(0).SubItems(3).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        frmContasPagarRecebimento.ShowDialog()
        pfBuscaContasCadastradas()
    End Sub

End Class