Public Class frmInserirItem

    Private Sub frmInserirItem_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtQuantia.Focus()
        If frmIncluiProduto.lsvDados.SelectedIndices.Count > 0 Then
            txtVenda.Text = frmAtendimento.txtAtendimento.Text
            txtCodigo.Text = frmIncluiProduto.lsvDados.SelectedItems(0).Text
            txtDescricao.Text = frmIncluiProduto.lsvDados.SelectedItems(0).SubItems(1).Text
            txtValor.Text = frmIncluiProduto.lsvDados.SelectedItems(0).SubItems(2).Text
        End If
    End Sub

    Private Sub Excluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        ' teste de preenchimento do nome
        If txtQuantia.Text = "" Then
            MsgBox("Campo QUANTIDADE em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtCodigo.Focus()
            Exit Sub
        End If
        If testaCadastro = 0 Then
            If vfverificaTela = "VENDAS" Then
                vgDados.Execute("INSERT INTO VENDASITENS (CODIGOVENDA, CODIGOPRODUTO, NOMEPRODUTO, PRECOPRODUTO, QUANTIDADEPRODUTO) VALUES ('" & CDbl(frmVendas.txtPedido.Text) & "', '" & txtCodigo.Text & "', '" & txtDescricao.Text & "', '" & FormatNumber(txtValor.Text, 2) & "', '" & txtQuantia.Text & "')")
            Else
                'aqui ira inserir no banco de dados
                vgDados.Execute("INSERT INTO ITEMATENDIMENTO (CODATENDIMENTO, CATEGORIAITEM, QUANTIDADEITEM, VALORITEM, CODITEM, DESCRICAOITEM, TIPO) VALUES ('" & CDbl(txtVenda.Text) & "', '" & frmIncluiProduto.lsvDados.SelectedItems(0).SubItems(5).Text & "', '" & txtQuantia.Text & "', '" & FormatNumber(txtValor.Text, 2) & "', '" & txtCodigo.Text & "', '" & UCase(txtDescricao.Text) & "', '" & vftestaProduto & "')")

            End If
                   End If
        vftestaProduto = ""
        Me.Close()
    End Sub
End Class