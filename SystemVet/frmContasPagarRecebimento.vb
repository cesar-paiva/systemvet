Public Class frmContasPagarRecebimento

    Private Sub frmContasPagarRecebimento_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        txtDataVencimento.Text = frmContasPagarBusca.lsvDados.SelectedItems(0).SubItems(2).Text
        txtPagar.Text = frmContasPagarBusca.lsvDados.SelectedItems(0).SubItems(3).Text
        txtObs.Text = frmContasPagarBusca.lsvDados.SelectedItems(0).SubItems(6).Text
        txtDataPagamento.Text = FormatDateTime(Now, DateFormat.ShortDate)
        txtPago.Text = frmContasPagarBusca.lsvDados.SelectedItems(0).SubItems(3).Text
        txtCodigo.Text = frmContasPagarBusca.lsvDados.SelectedItems(0).Text
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If MsgBox("Confirma pagamento da conta " & frmContasPagarBusca.lsvDados.SelectedItems(0).SubItems(1).Text & "no valor de R$ " & frmContasPagarBusca.lsvDados.SelectedItems(0).SubItems(3).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("UPDATE CONTASPAGAR SET PAGAMENTOCONTA = '" & Date.Parse(txtDataPagamento.Text).ToString("MM/dd/yyyy") & "', VALORPAGAMENTOCONTA = '" & UCase(txtPago.Text) & "', OBSCONTA = '" & Trim(UCase(txtObs.Text)) & "'  WHERE CODIGOCONTASPAGAR = '" & CDbl(txtCodigo.Text) & "'")
        Me.Close()
    End Sub

    Private Sub txtPago_LostFocus(sender As Object, e As EventArgs) Handles txtPago.LostFocus
        If Not IsNumeric(txtPago.Text) Then
            txtPago.Text = "0,00"
            txtPago.Focus()
            Exit Sub
        Else
            txtPago.Text = FormatNumber(txtPago.Text, 2)
        End If
    End Sub

    Private Sub txtDataPagamento_LostFocus(sender As Object, e As EventArgs) Handles txtDataPagamento.LostFocus
        If Not IsDate(txtDataPagamento.Text) Then
            txtDataPagamento.Text = FormatDateTime(Now, DateFormat.ShortDate)
            txtDataPagamento.Focus()
            Exit Sub
        End If
    End Sub

End Class
