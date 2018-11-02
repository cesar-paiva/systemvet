Public Class frmVendas
    Private Sub frmVendas_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfBuscaCliente()
        rdbtnOrcamento.Checked = True
        pfAtualiza()

        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM VENDAS ORDER BY CODIGOVENDA", vgDados)
        vlRegistros.MoveLast()
        txtPedido.Text = vlRegistros("CODIGOVENDA").Value
        dtpDataPedido.Value = vlRegistros("DATAVENDA").Value
        txtHora.Text = vlRegistros("HORAVENDA").Value
        cboCliente.Text = vlRegistros("NOMECLIENTE").Value
        vlRegistros.Close()
    End Sub
    Private Sub pfAtualiza()
        Dim vfTotal As Double = 0
        Dim vfTotalItens As Integer = 0
        For x = 0 To lsvDados.Items.Count - 1
            vfTotal = vfTotal + (lsvDados.Items(x).SubItems(4).Text)
            vfTotalItens = vfTotalItens + (lsvDados.Items(x).SubItems(3).Text)
        Next
        txtTotal.Text = FormatNumber(vfTotal, 2)
        If txtDesconto.Text = "" Then
            txtDesconto.Text = "0,00"
        End If
        txtTotal.Text = FormatNumber(vfTotal - CDbl(txtDesconto.Text), 2)
        'vgDados.Execute("UPDATE VENDAS SET TOTALVENDA = '" & CDbl(txtTotal.Text) & "' WHERE CODIGOVENDA = '" & txtPedido.Text & "' ")
        txtItens.Text = vfTotalItens

    End Sub

    Private Sub pfbuscaItens()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM VENDASITENS WHERE CODIGOVENDA = '" & txtPedido.Text & "'", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount <> 0 Then
            While Not vlRegistros.EOF
                Dim vfitem As New ListViewItem
                With lsvDados.Items.Add(vfitem)
                    .Text = vlRegistros("CODIGOPRODUTO").Value
                    .SubItems.Add(vlRegistros("NOMEPRODUTO").Value)
                    .SubItems.Add(vlRegistros("PRECOPRODUTO").Value)
                    .SubItems.Add(vlRegistros("QUANTIDADEPRODUTO").Value)
                    .SubItems.Add(FormatNumber(CDbl(vlRegistros("QUANTIDADEPRODUTO").Value) * CDbl(vlRegistros("PRECOPRODUTO").Value), 2))
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        Else
            vlRegistros.Close()
        End If

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


    Private Sub btnIncluirProduto_Click(sender As Object, e As EventArgs) Handles btnIncluirProduto.Click
        vfverificaTela = "VENDAS"
        frmIncluiProduto.ShowDialog()
        vfverificaTela = ""
        pfbuscaItens()
        pfAtualiza()
    End Sub

    Private Sub btnFinalizarPedido_Click(sender As Object, e As EventArgs) Handles btnFinalizarPedido.Click
        If lsvDados.Items.Count = 0 Then
            MsgBox("Nenhum produto inserido!", MsgBoxStyle.Critical, "SystemVet :: Vendas e Orçamentos")
            Exit Sub
        End If
        If rdbtnOrcamento.Checked = True Then
            If MsgBox("Deseja finalizar pedido como ORÇAMENTO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            For x = 0 To lsvDados.Items.Count - 1
                vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                vlRegistros.Open("SELECT * FROM PRODUTO WHERE CODIGO = '" & lsvDados.Items(x).Text & "'", vgDados)
                vlRegistros.Close()
            Next
            MsgBox("Orçamento salvo com sucesso!", MsgBoxStyle.Information)
            Me.Close()

        Else
            Dim vfEstoque As Integer = 0
            For x = 0 To lsvDados.Items.Count - 1
                vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                vlRegistros.Open("SELECT * FROM PRODUTO WHERE CODIGO = '" & lsvDados.Items(x).Text & "'", vgDados)
                vfEstoque = vlRegistros("ESTOQUEATUAL").Value - lsvDados.Items(x).SubItems(3).Text
                vlRegistros.Close()
                vgDados.Execute("UPDATE PRODUTO SET ESTOQUEATUAL = '" & vfEstoque & "' WHERE CODIGO = '" & lsvDados.Items(x).Text & "'")
            Next
            vgDados.Execute("UPDATE VENDAS SET TIPOPEDIDO = 'VENDA' WHERE CODIGO = '" & txtPedido.Text & "' ")
            MsgBox("Venda finalizada com sucesso!", MsgBoxStyle.Information)
            Me.Close()
        End If


    End Sub

    'Private Sub pfOrcamento()
    '   If rdbtnOrcamento.Checked = True Then
    '      If MsgBox("Você selecionou ORÇAMENTO salvar este pedido ele não gera financeiro e nem estoque! Deseja mesmo Salvar como ORÇAMENTO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    'inserre no banco mais nao atualiza estoque
    ' End If
    'End Sub


    Private Sub rdbtnOrcamento_Click(sender As Object, e As EventArgs) Handles rdbtnOrcamento.Click
        If rdbtnOrcamento.Checked = True Then
            If MsgBox("Você selecionou ORÇAMENTO! Ao salvar este pedido ele não gera financeiro e nem estoque! Deseja mesmo Salvar como ORÇAMENTO?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            'inserre no banco mais nao atualiza estoque
        End If
    End Sub

    Private Sub txtDesconto_LostFocus(sender As Object, e As EventArgs) Handles txtDesconto.LostFocus
        pfAtualiza()
    End Sub

    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged
        vgDados.Execute("UPDATE VENDAS SET NOMECLIENTE = '" & cboCliente.Text & "' WHERE CODIGOVENDA = '" & txtPedido.Text & "' ")
    End Sub
End Class