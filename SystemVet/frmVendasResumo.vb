Public Class frmVendasResumo

    Private Sub frmVendasResumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInicial.Text = Now
        txtFinal.Text = Now
        pfBuscaCliente()
        pfBuscaDados()
    End Sub

    Private Sub pfBuscaDados()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM VENDAS ORDER BY DATAVENDA, STATUSVENDA", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        End If
        While Not vlRegistros.EOF
            Dim vfItem As New ListViewItem
            With lsvDados.Items.Add(vfItem)
                .Text = Format(vlRegistros("CODIGOVENDA").Value, "0####")
                If IsDBNull(vlRegistros("NOMECLIENTE").Value) Then
                    .SubItems.Add("NÂO INFORMADO")
                Else
                    .SubItems.Add("" & vlRegistros("NOMECLIENTE").Value)
                End If
                .SubItems.Add(vlRegistros("DATAVENDA").Value)
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
        pfAtualizaSaldo()
    End Sub

    Private Sub pfAtualizaSaldo()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CLIENTES ORDER BY NOMECLIENTE", vgDados)
        cboClientes.Items.Clear()
        cboClientes.Text = ""
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        Else
            While Not vlRegistros.EOF
                cboClientes.Items.Add(vlRegistros("NOMECLIENTE").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
            cboClientes.Items.Add("-----------------------------------------------------")
            cboClientes.Items.Add("TODOS")
            cboClientes.Text = "TODOS"
        End If
    End Sub


    Private Sub btnDetalheVenda_Click(sender As Object, e As EventArgs) Handles btnDetalheVenda.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        frmVendaResumoDetalhes.ShowDialog()
    End Sub

    Private Sub pfBuscaCliente()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM CLIENTES ORDER BY NOMEPESSOAFISICA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        cboClientes.Items.Clear()
        cboClientes.Text = ""
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF
                cboClientes.Items.Add(vlRegistros("NOMEPESSOAFISICA").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        End If
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        If cboClientes.Text = "TODOS" Then
            vlRegistros.Open("SELECT * FROM VENDAS WHERE DATAVENDA BETWEEN '" & Date.Parse(txtInicial.Text).ToString("MM/dd/yyyy") & "' AND '" & Date.Parse(txtFinal.Text).ToString("MM/dd/yyyy") & "' ORDER BY DATAVENDA", vgDados)
        Else
            vlRegistros.Open("SELECT * FROM VENDAS WHERE DATAVENDA BETWEEN '" & Date.Parse(txtInicial.Text).ToString("MM/dd/yyyy") & "' AND '" & Date.Parse(txtFinal.Text).ToString("MM/dd/yyyy") & "'  AND NOMECLIENTE = '" & cboClientes.Text & "' ORDER BY DATAVENDA", vgDados)
        End If
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Filter = ""
            txtTotalVenda.Text = "0,00"
            vlRegistros.Close()
            Exit Sub
        Else
            While Not vlRegistros.EOF
                Dim vfItem As New ListViewItem
                With lsvDados.Items.Add(vfItem)
                    .Text = Format(vlRegistros("CODIGOVENDA").Value, "0####")
                    If IsDBNull(vlRegistros("NOMECLIENTE").Value) Then
                        .SubItems.Add("NÂO INFORMADO")
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
            vlRegistros.Filter = ""
            pfAtualizaSaldo()
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If lsvDados.Items.Count = 0 Then
            MsgBox("Selecione ou filtre um período de vendas!", MsgBoxStyle.Information, "SystemVet :: Erro")
            Exit Sub
        End If
        If MsgBox("Confirma impressão do relatório de resumo de vendas por período", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM RELVENDAS")
        For x = 0 To lsvDados.Items.Count - 1
            vgDados.Execute("INSERT INTO RELVENDAS (CODIGOVENDA, CLIENTEVENDA, DATAVENDA, VALORVENDA, DATAINICIAL, DATAFINAL, TOTALVENDA) VALUES ('" & lsvDados.Items(x).Text & "', '" & lsvDados.Items(x).SubItems(1).Text & "', '" & Date.Parse(lsvDados.Items(x).SubItems(2).Text).ToString("MM/dd/yyyy") & "', '" & lsvDados.Items(x).SubItems(3).Text & "', '" & Date.Parse(txtInicial.Text).ToString("MM/dd/yyyy") & "', '" & Date.Parse(txtFinal.Text).ToString("MM/dd/yyyy") & "', '" & txtTotalVenda.Text & "')")
        Next
        RelVendas.showDialog()
    End Sub

    Private Sub btnFechamento_Click(sender As Object, e As EventArgs) Handles btnFechamento.Click
        Dim vfTotalChecked As Double = 0
        For x = 0 To lsvDados.Items.Count - 1
            If lsvDados.Items(x).Checked = True Then
                vfTotalChecked = vfTotalChecked + 1
            End If
        Next
        If vfTotalChecked = 0 Then
            MsgBox("Selecione uma venda para encerrar!", MsgBoxStyle.Information, "SystemVet :: Erro")
            Exit Sub
        End If
        If MsgBox("Confirma encerramento das vendas selecionadas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
    End Sub

End Class