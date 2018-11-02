Public Class frmPesquisaVendas

    Private Sub frmPesquisaVendas_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfBuscaCliente()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub pfBuscaCliente()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM CLIENTES ORDER BY NOMEPESSOAFISICA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        cboCliente.Items.Clear()
        cboCliente.Text = ""
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF
                cboCliente.Items.Add(vlRegistros("NOMEPESSOAFISICA").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        End If

    End Sub

    Private Sub btnNovaVenda_Click(sender As Object, e As EventArgs) Handles btnNovaVenda.Click
        If MsgBox("COnfirma criacão de nova venda?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        frmVendas.ShowDialog()
        'pfBuscaItens()
    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If lsvDados.SelectedItems(0).SubItems(6).Text = "ENCERRADA" Then
            MsgBox("Venda já encerrada!", MsgBoxStyle.Information, "SystemVet :: Informação")
            Exit Sub
        End If
        frmVendas.ShowDialog()
        'pfBuscaItens()
    End Sub

    Private Sub btnAlterarVenda_Click(sender As Object, e As EventArgs) Handles btnAlterarVenda.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then
            MsgBox("Nenhuma venda selecionada, selecione uma venda para alterar!", MsgBoxStyle.Information, "SystemVet :: Informação")
            Exit Sub
        End If
        frmVendas.ShowDialog()
        'pfBuscaItens()
    End Sub

    Private Sub btnExcluirVenda_Click(sender As Object, e As EventArgs) Handles btnExcluirVenda.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then
            MsgBox("Nenhuma venda selecionada, selecione uma venda para excluir!", MsgBoxStyle.Information, "SystemVet :: Informação")
            Exit Sub
        End If
        If MsgBox("Confirma exclusão da venda" & lsvDados.SelectedItems(0).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM VENDAS WHERE CODIGOVENDA = '" & CDbl(lsvDados.SelectedItems(0).Text & "'"))
        'pfBuscaItens()
    End Sub

    Private Sub txtData_ValueChanged(sender As Object, e As EventArgs) Handles txtData.ValueChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM VENDAS WHERE DATAVENDA = '" & Date.Parse(txtData.Text).ToString("MM/dd/yyyy") & "' ORDER BY DATAVENDA, STATUSVENDA", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        End If
        While Not vlRegistros.EOF
            Dim vfitem As New ListViewItem
            With lsvDados.Items.Add(vfitem)
                .Text = Format(vlRegistros("CODIGOVENDA").Value, "0#####")
                If IsDBNull(vlRegistros("NOMECLIENTE").Value) Then
                    .SubItems.Add("NÃO INFORMADO")
                Else
                    .SubItems.Add("" & vlRegistros("NOMECLIENTE").Value)
                End If
                .SubItems.Add("" & vlRegistros("DATAVENDA").Value)
                If IsDBNull(vlRegistros("TOTALVENDA").Value) Then
                    .SubItems.Add("0,00")
                Else
                    .SubItems.Add("" & vlRegistros("TOTALVENDA").Value)
                End If
                .SubItems.Add("" & vlRegistros("STATUSVENDA").Value)
            End With
            vlRegistros.MoveNext()
        End While
        vlRegistros.Close()

    End Sub

    Private Sub btnResumoVendas_Click(sender As Object, e As EventArgs) Handles btnResumoVendas.Click
        frmVendasResumo.ShowDialog()
    End Sub
End Class