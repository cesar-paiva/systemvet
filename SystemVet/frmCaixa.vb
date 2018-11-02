Public Class frmCaixa

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub txtData_ValueChanged(sender As Object, e As EventArgs) Handles txtData.ValueChanged
        pfBuscaContas()
    End Sub

    Private Sub pfBuscaContas()
        txtSaldo.Text = "0,00"
        txtEntradas.Text = "0,00"
        txtSaidas.Text = "0,00"
        txtContasPagar.Text = "0,00"
        txtSaldoInicial.Text = "0,00"
        txtVendas.Text = "0,00"
        txtStatus.Text = ""

        pfbuscaCaixa()
        If txtStatus.Text = "NÃO ENCONTRADO" Then
            txtStatus.ForeColor = Color.Black
            lsvDados.Items.Clear()
            Exit Sub
        End If
        If txtStatus.Text = "ABERTO" Then
            txtStatus.ForeColor = Color.White
        Else
            txtStatus.ForeColor = Color.Red
        End If

        pfBuscaSaldoInicial()
        pfBuscaEntradas()
        pfBuscaVendas()
        pfBuscaSaidas()
        pfBuscaContasPagar()
        pfBuscaSaldo()

    End Sub

    Private Sub pfBuscaCaixa()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CAIXA WHERE DATACAIXA = '" & Date.Parse(txtData.Text).ToString("MM/dd/yyyy") & "'", vgDados)
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            txtStatus.Text = "NÃO ENCONTRADO"
            Exit Sub
        Else
            txtStatus.Text = vlRegistros("STATUSCAIXA").Value
            vlRegistros.Close()
        End If
    End Sub

    Private Sub pfBuscaSaldo()
        txtSaldo.Text = FormatNumber(CDbl(txtSaldoInicial.Text) + CDbl(txtEntradas.Text) + CDbl(txtVendas.Text) - CDbl(txtSaidas.Text) - CDbl(txtContasPagar.Text), 2)
        Dim vfItem As New ListViewItem
        With lsvDados.Items.Add(vfItem)
            .Text = txtData.Text
            .SubItems.Add("SALDO FINAL")
            .SubItems.Add("")
            .SubItems.Add("")
            .SubItems.Add(txtSaldo.Text)
            .SubItems.Add("CODIGOCAIXA")
        End With
    End Sub

    Private Sub pfBuscaSaldoInicial()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CAIXA WHERE DATACAIXA = '" & Date.Parse(txtData.Text).ToString("MM/dd/yyyy") & "'", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Dim vfItem As New ListViewItem
            With lsvDados.Items.Add(vfItem)
                .Text = txtData.Text
                .SubItems.Add("SALDO INICIAL")
                .SubItems.Add("")
                .SubItems.Add("")
                .SubItems.Add("")
                txtSaldoInicial.Text = "0,00"
            End With
        Else
            Dim vfItem As New ListViewItem
            With lsvDados.Items.Add(vfItem)
                .Text = "" & vlRegistros("DATACAIXA").Value
                .SubItems.Add("SALDO INICIAL")
                .SubItems.Add("" & vlRegistros("SALDOINICIALCAIXA").Value)
                .SubItems.Add("")
                .SubItems.Add("" & vlRegistros("SALDOINICIALCAIXA").Value)
                .SubItems.Add("CODIGOCAIXA")
                txtSaldoInicial.Text = vlRegistros("SALDOINICIALCAIXA").Value
            End With
            vlRegistros.Close()
        End If
    End Sub

    Private Sub pfBuscaEntradas()
        Dim vfSomaEntradas As Double = 0
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM FLUXOCAIXA WHERE DATACAIXA = '" & Date.Parse(txtData.Text).ToString("MM/dd/yyyy") & "'", vgDados)
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
        Else
            While Not vlRegistros.EOF
                Dim vfItem As New ListViewItem
                With lsvDados.Items.Add(vfItem)
                    .Text = "" & vlRegistros("DATACAIXA").Value
                    .SubItems.Add("ENTRADAS")
                    Dim vfTotal As Double = vlRegistros("VALORTOTAL").Value - vlRegistros("VALORDESCONTO").Value
                    vfSomaEntradas = vfSomaEntradas + vfTotal
                    .SubItems.Add(FormatNumber(vfTotal, 2))
                    .SubItems.Add("")
                    .SubItems.Add("")
                    .SubItems.Add("CODIGOCAIXA")
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
            txtEntradas.Text = FormatNumber(vfSomaEntradas, 2)
        End If
    End Sub

    Private Sub pfBuscaVendas()
        Dim vfSomaVendas As Double = 0
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM VENDAS WHERE DATAVENDA = '" & Date.Parse(txtData.Text).ToString("MM/dd/yyyy") & "'", vgDados)
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Dim vfitem As New ListViewItem
            With lsvDados.Items.Add(vfitem)
                .Text = txtData.Text
                .SubItems.Add("VENDA VAREJO")
                .SubItems.Add("")
                .SubItems.Add("0,00")
                .SubItems.Add("")
                .SubItems.Add("")
            End With
        Else
            While Not vlRegistros.EOF
                Dim vfitem As New ListViewItem
                With lsvDados.Items.Add(vfitem)
                    .Text = "" & vlRegistros("DATAVENDA").Value
                    .SubItems.Add("VENDA VAREJO")
                    Dim vftotal As Double = vlRegistros("TOTALVENDA").Value
                    vfSomaVendas = vfSomaVendas + vftotal
                    .SubItems.Add(FormatNumber(vftotal, 2))
                    .SubItems.Add("")
                    .SubItems.Add("")
                    .SubItems.Add("CODIGOVENDA")
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
            txtVendas.Text = FormatNumber(vfSomaVendas, 2)
        End If
    End Sub

    Private Sub pfBuscaSaidas()
        Dim vfSomaSaidas As Double = 0
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM DESPESAS WHERE DATADESPESA = '" & Date.Parse(txtData.Text).ToString("MM/dd/yyyy") & "'", vgDados)
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Dim vfitem As New ListViewItem
            With lsvDados.Items.Add(vfitem)
                .Text = txtData.Text
                .SubItems.Add("DESPESAS")
                .SubItems.Add("")
                .SubItems.Add("0,00")
                .SubItems.Add("")
                .SubItems.Add("")
            End With
        Else
            While Not vlRegistros.EOF
                Dim vfitem As New ListViewItem
                With lsvDados.Items.Add(vfitem)
                    .Text = "" & vlRegistros("DATADESPESA").Value
                    vfSomaSaidas = vfSomaSaidas + vlRegistros("VALORDESPESA").Value
                    .SubItems.Add("DESPESAS")
                    .SubItems.Add("")
                    .SubItems.Add(vlRegistros("VALORDESPESA").Value)
                    .SubItems.Add("")
                    .SubItems.Add("CODIGOCAIXA")
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
            txtSaidas.Text = FormatNumber(vfSomaSaidas, 2)
        End If
    End Sub

    Private Sub pfBuscaContasPagar()
        Dim vfSomaContasPagar As Double = 0
        vfSomaContasPagar = 0
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CONTASPAGAR WHERE PAGAMENTOCONTA = '" & Date.Parse(txtData.Text).ToString("MM/dd/yyyy") & "'", vgDados)
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Dim vfitem As New ListViewItem
            With lsvDados.Items.Add(vfitem)
                .Text = txtData.Text
                .SubItems.Add("CONTAS A PAGAR")
                .SubItems.Add("")
                .SubItems.Add("0,00")
                .SubItems.Add("")
                .SubItems.Add("")
            End With
        Else
            While Not vlRegistros.EOF
                Dim vfitem As New ListViewItem
                With lsvDados.Items.Add(vfitem)
                    .Text = "" & vlRegistros("DATACONTA").Value
                    vfSomaContasPagar = vfSomaContasPagar + vlRegistros("VALORCONTA").Value
                    .SubItems.Add("CONTAS A PAGAR")
                    .SubItems.Add("")
                    .SubItems.Add(vlRegistros("VALORPAGAMENTOCONTA").Value)
                    .SubItems.Add("")
                    .SubItems.Add("CODIGOCONTASPAGAR")
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
            txtContasPagar.Text = FormatNumber(vfSomaContasPagar, 2)
        End If
    End Sub




    Private Sub frmCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsvDados.Items.Clear()
        txtData.Value = FormatDateTime(Now, DateFormat.ShortDate)
        pfBuscaContas()
    End Sub


    Private Sub btnAvancaData_Click(sender As Object, e As EventArgs) Handles btnAvancaData.Click
        txtData.Value = DateAdd("d", 1, txtData.Value)
    End Sub

    Private Sub btnRecuaData_Click(sender As Object, e As EventArgs) Handles btnRecuaData.Click
        txtData.Value = DateAdd("d", -1, txtData.Value)
    End Sub

    Private Sub btnFinalizaCaixa_Click(sender As Object, e As EventArgs) Handles btnFinalizaCaixa.Click
        If txtStatus.Text <> "ABERTO" Then
            MsgBox("Caixa inexistente ou já finalizado!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            Exit Sub
        End If
        If MsgBox("Confirma fechamento do caixa do dia " & txtData.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("UPDATE CAIXA SET TOTALSERVICOS = '" & txtEntradas.Text & "', TOTALVENDAS = '" & txtVendas.Text & "', TOTALPAGAMENTOS = '" & txtContasPagar.Text & "', TOTALSAIDAS = '" & txtSaidas.Text & "', SALDOFINALCAIXA = '" & txtSaldo.Text & "', STATUSCAIXA = 'ENCERRADO' WHERE DATACAIXA = '" & Date.Parse(txtData.Text).ToString("MM/dd/yyyy") & "'")
        txtStatus.Text = "ENCERRADO" : txtStatus.ForeColor = Color.Red
        MsgBox("Caixa fechado com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")

    End Sub
End Class