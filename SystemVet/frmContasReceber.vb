Public Class frmContasReceber

    Private Sub frmContasReceber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtData.Text = FormatDateTime(Now, DateFormat.ShortDate)
        txtOBS.Clear() : txtRecebido.Clear() : txtAReceber.Clear() : txtVencimento.Text = "" : txtRecebimento.Text = ""
        txtDataInicial.Value = Now
        txtDataFinal.Value = Now
        txtContaReceber.Text = "0,00" : txtContaRecebida.Text = "0,00" : txtSaldoFinal.Text = "0,00"
        pfBuscaContas()
        fraCaixaInicial.Visible = False
    End Sub

    Private Sub txtData_ValueChanged(sender As Object, e As EventArgs) Handles txtData.ValueChanged
        txtAReceber.Text = "0,00" : txtContaReceber.Text = "0,00" : txtRecebido.Text = "0,00" : txtContaRecebida.Text = "0,00" : txtSaldoFinal.Text = "0,00"
        pfBuscaContas()
    End Sub

    Private Sub pfBuscaContas()
        pfBuscaSaidas()
        pfBuscaSaldo()
    End Sub
    Private Sub pfBuscaSaldo()
        Dim vfSaldo As Double = 0
        Dim vfContaAReceber As Double = 0
        Dim vfContaRecebida As Double = 0

        For x = 0 To lsvDados.Items.Count - 1
            If lsvDados.Items(x).SubItems(3).Text <> "" Then
                vfContaAReceber = vfContaAReceber + lsvDados.Items(x).SubItems(3).Text
            End If
            If lsvDados.Items(x).SubItems(5).Text <> "" Then
                vfContaRecebida = vfContaRecebida + lsvDados.Items(x).SubItems(5).Text
            End If
            txtAReceber.Text = FormatNumber(vfContaAReceber, 2)
            txtContaRecebida.Text = FormatNumber(vfContaRecebida, 2)
            txtSaldoFinal.Text = FormatNumber(vfSaldo, 2)
            If CDbl(txtSaldoFinal.Text) > 0 Then
                txtSaldoFinal.ForeColor = Color.Green
            Else
                txtSaldoFinal.ForeColor = Color.Red
            End If
        Next
    End Sub

    Private Sub pfBuscaSaidas()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CONTASRECEBER WHERE DATAPARCELA = '" & Date.Parse(txtData.Text).ToString("MM/dd/yyyy") & "'", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
        Else
            While Not vlRegistros.EOF
                Dim vfItem As New ListViewItem
                With lsvDados.Items.Add(vfItem)
                    If IsDBNull(vlRegistros("DATAPAGAMENTO").Value) Then
                        vfItem.ForeColor = Color.Red
                    Else
                        vfItem.ForeColor = Color.Green
                    End If
                    .Text = "" & vlRegistros("TIPOCONTA").Value
                    .SubItems.Add("" & vlRegistros("NOMECLIENTE").Value)
                    .SubItems.Add("" & vlRegistros("DATAPARCELA").Value)
                    .SubItems.Add("" & vlRegistros("VALORPARCELA").Value)
                    .SubItems.Add("" & vlRegistros("DATAPAGAMENTO").Value)
                    .SubItems.Add("" & vlRegistros("CODIGOCONSTASRECEBER").Value)
                    .SubItems.Add("" & vlRegistros("OBSCONTA").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnAvancaData_Click(sender As Object, e As EventArgs) Handles btnAvancaData.Click
        txtData.Value = DateAdd("d", 1, txtData.Value)
    End Sub

    Private Sub btnRecuaData_Click(sender As Object, e As EventArgs) Handles btnRecuaData.Click
        txtData.Value = DateAdd("d", -1, txtData.Value)
    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If lsvDados.Items.Count = 0 Then Exit Sub
        txtOBS.Clear() : txtRecebido.Clear() : txtAReceber.Clear() : txtVencimento.Text = "" : txtRecebimento.Text = ""
        If MsgBox("Confirma recebimento de parcela?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        fraCaixaInicial.Visible = True
        txtVencimento.Text = lsvDados.SelectedItems(0).SubItems(2).Text
        txtAReceber.Text = lsvDados.SelectedItems(0).SubItems(3).Text
        txtRecebimento.Text = FormatDateTime(Now, DateFormat.ShortDate)
        txtRecebido.Text = lsvDados.SelectedItems(0).SubItems(3).Text
        txtRecebido.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        fraCaixaInicial.Visible = False
        txtOBS.Clear() : txtRecebido.Clear() : txtAReceber.Clear() : txtVencimento.Text = "" : txtRecebimento.Text = ""
    End Sub


    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If lsvDados.SelectedIndices.Count = 0 Then
            MsgBox("Nenhuma conta selecionada, selecione uma conta para finalizar!", MsgBoxStyle.Information, "SystemVet :: Informação")
            Exit Sub
        End If
        If lsvDados.Items.Count = 0 Then Exit Sub
        txtOBS.Clear() : txtRecebido.Clear() : txtAReceber.Clear() : txtVencimento.Text = "" : txtRecebimento.Text = ""
        If MsgBox("Confirma recebimento da Parcela?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        fraCaixaInicial.Visible = True
        txtVencimento.Text = lsvDados.SelectedItems(0).SubItems(2).Text
        txtAReceber.Text = lsvDados.SelectedItems(0).SubItems(3).Text
        txtRecebimento.Text = FormatDateTime(Now, DateFormat.ShortDate)
        txtRecebido.Text = lsvDados.SelectedItems(0).SubItems(3).Text
        txtRecebido.Focus()
    End Sub

    'Aqui confirma o recebimento E salva no banco
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If txtRecebido.Text = "0,00" Or txtRecebido.Text = "" Then
            MsgBox("Digite o valor recebido!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtRecebido.Focus()
            Exit Sub
        End If
        If txtOBS.Text = "" Then txtOBS.Text = "-"
        If MsgBox("Confirma recebimento no valor de R$ " & txtRecebido.Text & "referente a parcela vencida em " & txtVencimento.Text & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        'Instrução que da baixa na conta no banco de dados
        vgDados.Execute("UPDATE CONSTASRECEBER SET DATAPAGAMENTO = '" & Date.Parse(txtRecebido.Text).ToString("MM/dd/yyyy") & "', VALORPAGAMENTO = '" & UCase(txtRecebido.Text) & "', OBSCONTA = '" & UCase(txtOBS.Text) & "', STATUSCONTA = 'ENCERRADO' WHERE CODIGOCONSTASRECEBER = '" & CDbl(lsvDados.SelectedItems(0).SubItems(6).Text) & "'")
        MsgBox("Conta recebida com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaContas()
        pfBuscaSaldo()
        fraCaixaInicial.Visible = False
    End Sub

    Private Sub txtRecebido_LostFocus(sender As Object, e As EventArgs) Handles txtRecebido.LostFocus
        If Not IsNumeric(txtRecebido.Text) Then
            txtRecebido.Text = "0,00"
            txtRecebido.Focus()
            Exit Sub
        Else
            txtRecebido.Text = FormatNumber(txtRecebido.Text)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CONTASRECEBER WHERE DATAPARCELA BETWEEN '" & Date.Parse(txtDataInicial.Text).ToString("MM/dd/yyyy") & "' AND '" & Date.Parse(txtDataFinal.Text).ToString("MM/dd/yyyy") & "'", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
        Else
            While Not vlRegistros.EOF
                Dim vfItem As New ListViewItem
                With lsvDados.Items.Add(vfItem)
                    If IsDBNull(vlRegistros("DATAPAGAMENTO").Value) Then
                        vfItem.ForeColor = Color.Red
                    Else
                        vfItem.ForeColor = Color.Green
                    End If
                    .Text = "" & vlRegistros("TIPOCONTA").Value
                    .SubItems.Add("" & vlRegistros("NOMECLIENTE").Value)
                    .SubItems.Add("" & vlRegistros("DATAPARCELA").Value)
                    .SubItems.Add("" & vlRegistros("VALORPARCELA").Value)
                    .SubItems.Add("" & vlRegistros("DATAPAGAMENTO").Value)
                    .SubItems.Add("" & vlRegistros("VALORPAGAMENTO").Value)
                    .SubItems.Add("" & vlRegistros("CODIGOCONSTASRECEBER").Value)
                    .SubItems.Add("" & vlRegistros("OBSCONTA").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        End If
        pfBuscaSaldo()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If lsvDados.Items.Count = 0 Then
            MsgBox("Nenhuma conta selecionada, selecione uma conta!", MsgBoxStyle.Information, "SystemVet :: Informação")
            Exit Sub
        End If
        If MsgBox("Confirma impressão do resumo de Contas a Receber?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM RELCONTASRECEBER")
        For x = 0 To lsvDados.Items.Count - 1
            If lsvDados.Items(x).SubItems(4).Text <> "" Then
                vgDados.Execute("INSERT INTO RELCONTASRECEBER (DATAINICIAL, DATAFINAL, TIPO, CLIENTE, VENCIMENTO, VALORVENCIMENTO, RECEBIMENTO, VALORRECEBIMENTO, TOTALARECEBER, TOTALRECEBIDO, SALDO) VALUES ('" & Date.Parse(txtDataInicial.Text).ToString("MM/dd/yyyy") & "', '" & Date.Parse(txtDataFinal.Text).ToString("MM/dd/yyyy") & "', '" & lsvDados.Items(x).Text & "', '" & lsvDados.Items(x).SubItems(1).Text & "', '" & Date.Parse(lsvDados.Items(x).SubItems(2).Text).ToString("MM/dd/yyyy") & "', '" & lsvDados.Items(x).SubItems(3).Text & "', '" & Date.Parse(lsvDados.Items(x).SubItems(4).Text).ToString("MM/dd/yyyy") & "', '" & lsvDados.Items(x).SubItems(5).Text & "', '" & txtContaReceber.Text & "', '" & txtContaRecebida.Text & "', '" & txtSaldoFinal.Text & "')")
            Else
                vgDados.Execute("INSERT INTO RELCONTASRECEBER (DATAINICIAL, DATAFINAL, TIPO, CLIENTE, VENCIMENTO, VALORVENCIMENTO, TOTALARECEBER, TOTALRECEBIDO, SALDO) VALUES ('" & Date.Parse(txtDataInicial.Text).ToString("MM/dd/yyyy") & "', '" & Date.Parse(txtDataFinal.Text).ToString("MM/dd/yyyy") & "', '" & lsvDados.Items(x).Text & "', '" & lsvDados.Items(x).SubItems(1).Text & "', '" & Date.Parse(lsvDados.Items(x).SubItems(2).Text).ToString("MM/dd/yyyy") & "', '" & lsvDados.Items(x).SubItems(3).Text & "', '" & txtContaReceber.Text & "', '" & txtContaRecebida.Text & "', '" & txtSaldoFinal.Text & "')")
            End If
        Next
        RelContasReceber.showDialog()
    End Sub
End Class