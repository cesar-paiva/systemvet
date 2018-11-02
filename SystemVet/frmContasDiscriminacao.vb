Public Class frmContasDiscriminacao

    Private Sub frmContasDiscriminacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pfLimpaTela()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim vlRegistroContas As New ADODB.Recordset
        Dim vfTotalDinheiro As Double = 0
        Dim vfTotalDebito As Double = 0
        Dim vfTotalCredito As Double = 0
        Dim vfTotalCheque As Double = 0

        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM FLUXOCAIXA WHERE DATACAIXA BETWEEN '" & Date.Parse(txtDataInicial.Text).ToString("MM/dd/yyyy") & "' AND '" & Date.Parse(txtDataFinal.Text).ToString("MM/dd/yyyy") & "' ORDER BY DATACAIXA ", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Filter = ""
            lsvDados.Items.Clear()
            vlRegistros.Close()
            Exit Sub
        Else
            While Not vlRegistros.EOF
                Dim vfItem As New ListViewItem
                With lsvDados.Items.Add(vfItem)
                    .Text = "" & vlRegistros("DATACAIXA").Value
                    If vlRegistros("TIPOCONTA").Value = "DINHEIRO" Then
                        .SubItems.Add("" & vlRegistros("VALORTOTAL").Value)
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        vfTotalDinheiro = vfTotalDinheiro + vlRegistros("VALORTOTAL").Value
                    Else
                        .SubItems.Add("")
                    End If
                    If vlRegistros("TIPOCONTA").Value = "CARTAO DEBITO" Then
                        .SubItems.Add("" & vlRegistros("VALORTOTAL").Value)
                        .SubItems.Add("")
                        .SubItems.Add("")
                        .SubItems.Add("")
                        vfTotalDebito = vfTotalDebito + vlRegistros("VALORTOTAL").Value
                    Else
                        .SubItems.Add("")
                    End If
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
            vlRegistros.Filter = ""
            vlRegistros.Open("SELECT * FROM CONTASRECEBER ORDER BY DATAAGENDA", vgDados)
            vlRegistros.Filter = "DATAAGENDA >= '" & Date.Parse(txtDataInicial.Text).ToString("MM/dd/yyyy") & "' AND DATAAGENDA <= '" & Date.Parse(txtDataFinal.Text).ToString("MM/dd/yyyy") & "'"
            If vlRegistros.RecordCount = 0 Then
                vlRegistros.Filter = ""
                vlRegistros.Close()
                Exit Sub
            Else
                While Not vlRegistros.EOF
                    Dim vfItem As New ListViewItem
                    With lsvDados.Items.Add(vfItem)
                        .Text = "" & vlRegistros("DATAAGENDA").Value
                        If vlRegistros("TIPOCONTA").Value = "CARTAO CREDITO" Then
                            .SubItems.Add("")
                            .SubItems.Add("")
                            .SubItems.Add("" & vlRegistros("VALORPARCELA").Value)
                            .SubItems.Add("")
                            vfTotalCredito = vfTotalCredito + vlRegistros("VALORPARCELA").Value
                        End If
                        If vlRegistros("TIPOCONTA").Value = "CHEQUE" Then
                            .SubItems.Add("")
                            .SubItems.Add("")
                            .SubItems.Add("")
                            .SubItems.Add("" & vlRegistros("VALORPARCELA").Value)
                            vfTotalCheque = vfTotalCheque + vlRegistros("VALORPARCELA").Value
                        End If
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close()
            End If
        End If
        vlRegistros.Filter = ""
        txtDinheiro.Text = FormatNumber(vfTotalDinheiro, 2)
        txtDebito.Text = FormatNumber(vfTotalDebito, 2)
        txtCredito.Text = FormatNumber(vfTotalCredito, 2)
        txtCheques.Text = FormatNumber(vfTotalCheque, 2)
        txtGeral.Text = FormatNumber(vfTotalCheque + vfTotalCredito + vfTotalDebito + vfTotalDinheiro, 2)
    End Sub

    Private Sub pfLimpaTela()
        lsvDados.Items.Clear()
        txtDinheiro.Text = "0,00"
        txtDebito.Text = "0,00"
        txtCredito.Text = "0,00"
        txtCheques.Text = "0,00"

        txtGeral.Text = "0,00"
        txtDataInicial.Text = Now
        txtDataInicial.Text = Now
    End Sub

    
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If lsvDados.Items.Count = 0 Then
            MsgBox("Nenhuma conta selecionada, selecione uma conta!", MsgBoxStyle.Information, "SystemVet :: Informação")
            Exit Sub
        End If
        If MsgBox("Confirma impressão do resumo de contas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "GAP HEALTH :: Pergunta") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM RELCAIXACONTAS")
        For x = 0 To lsvDados.Items.Count - 1
            If lsvDados.Items(x).SubItems(1).Text <> "" Then 'DINHEIRO
                vgDados.Execute("INSERT INTO RELCAIXACONTAS (DATAINICIAL, DATAFINAL, DATA, TIPO, VALOR, TOTALDINHEIRO, TOTALDEBITO, TOTALCREDITO, TOTALCHEQUE, TOTAL) VALUES ('" & Date.Parse(txtDataInicial.Text).ToString("MM/dd/yyyy") & "', '" & Date.Parse(txtDataFinal.Text).ToString("MM/dd/yyyy") & "', '" & Date.Parse(lsvDados.Items(x).Text).ToString("MM/dd/yyyy") & "', 'DINHEIRO', '" & lsvDados.Items(x).SubItems(1).Text & "', '" & txtDinheiro.Text & "', '" & txtDebito.Text & "', '" & txtCredito.Text & "', '" & txtCheques.Text & "', '" & txtGeral.Text & "')")
            End If
            If lsvDados.Items(x).SubItems(2).Text <> "" Then 'DEBITO
                vgDados.Execute("INSERT INTO RELCAIXACONTAS (DATAINICIAL, DATAFINAL, DATA, TIPO, VALOR, TOTALDINHEIRO, TOTALDEBITO, TOTALCREDITO, TOTALCHEQUE, TOTAL) VALUES ('" & Date.Parse(txtDataInicial.Text).ToString("MM/dd/yyyy") & "', '" & Date.Parse(txtDataFinal.Text).ToString("MM/dd/yyyy") & "', '" & Date.Parse(lsvDados.Items(x).Text).ToString("MM/dd/yyyy") & "','CARTAO DEBITO', '" & lsvDados.Items(x).SubItems(2).Text & "',  '" & txtDebito.Text & "', '" & txtDebito.Text & "', '" & txtCredito.Text & "', '" & txtCheques.Text & "', '" & txtGeral.Text & "')")
            End If
            If lsvDados.Items(x).SubItems(3).Text <> "" Then 'CREDITO
                vgDados.Execute("INSERT INTO RELCAIXACONTAS (DATAINICIAL, DATAFINAL, DATA, TIPO, VALOR, TOTALDINHEIRO, TOTALDEBITO, TOTALCREDITO, TOTALCHEQUE, TOTAL) VALUES ('" & Date.Parse(txtDataInicial.Text).ToString("MM/dd/yyyy") & "', '" & Date.Parse(txtDataFinal.Text).ToString("MM/dd/yyyy") & "', '" & Date.Parse(lsvDados.Items(x).Text).ToString("MM/dd/yyyy") & "','CARTAO CREDITO', '" & lsvDados.Items(x).SubItems(3).Text & "',  '" & txtCredito.Text & "', '" & txtDebito.Text & "', '" & txtCredito.Text & "', '" & txtCheques.Text & "', '" & txtGeral.Text & "')")
            End If
            If lsvDados.Items(x).SubItems(4).Text <> "" Then 'CHEQUE
                vgDados.Execute("INSERT INTO RELCAIXACONTAS (DATAINICIAL, DATAFINAL, DATA, TIPO, VALOR, TOTALDINHEIRO, TOTALDEBITO, TOTALCREDITO, TOTALCHEQUE, TOTAL) VALUES ('" & Date.Parse(txtDataInicial.Text).ToString("MM/dd/yyyy") & "', '" & Date.Parse(txtDataFinal.Text).ToString("MM/dd/yyyy") & "','" & Date.Parse(lsvDados.Items(x).Text).ToString("MM/dd/yyyy") & "', 'CHEQUE', '" & lsvDados.Items(x).SubItems(4).Text & "',  '" & txtCheques.Text & "', '" & txtDebito.Text & "', '" & txtCredito.Text & "', '" & txtCheques.Text & "', '" & txtGeral.Text & "')")
            End If

        Next
        RelCaixaContas.ShowDialog()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

End Class
