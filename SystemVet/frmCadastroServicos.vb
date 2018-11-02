Public Class frmCadastroServicos
    Private Sub frmCadastroProduto_Load(sender As Object, e As EventArgs) Handles Me.Load
        If testaCadastro = 0 Then pfLimpaTela()
        If testaCadastro = 0 Then Exit Sub ' teste quando for cadastrar novo produto sem clicar no list view
        txtCodigo.Text = frmBuscaProduto.lsvDados.SelectedItems(0).Text
        pfBuscaServicos()

    End Sub

    Private Sub pfBuscaServicos() ' procedimento para buscar o resto dos dados que não são mostrados no list view
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM SERVICO WHERE CODIGO = '" & txtCodigo.Text & "'", vgDados) ' consulta no banco buscando todos os dados
        If vlRegistros.RecordCount = 0 Then vlRegistros.Close() : Exit Sub ' se não tiver registro fecha a variavel e sai do procdimento ( situação de cadastro de um novo produto)
        txtCodigoBarras.Text = vlRegistros("CODIGOBARRAS").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        dtpDataCadastro.Text = vlRegistros("DATACADASTRO").Value
        txtDescricao.Text = vlRegistros("DESCRICAO").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        txtValor.Text = vlRegistros("VALOR").Value ' recebe o valor do banco de dentro da variavel vlRegistro
        vlRegistros.Close()

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        ' teste de preenchimento do nome
        If txtDescricao.Text = "" Then
            MsgBox("Campo DESCRIÇÃO em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtDescricao.Focus()
            Exit Sub
        End If
        If txtValor.Text = "" Then txtValor.Text = "0,00"
        If testaCadastro = 0 Then
            'aqui ira inserir no banco de dados
            vgDados.Execute("INSERT INTO SERVICO (CODIGOBARRAS, DATACADASTRO, DESCRICAO, VALOR) VALUES ('" & txtCodigoBarras.Text & "', '" & Date.Parse(dtpDataCadastro.Text).ToString("MM/dd/yyyy") & "',  '" & txtDescricao.Text & "', '" & txtValor.Text & "')")
        Else
            'aqui altera no banco de dados
            vgDados.Execute("UPDATE SERVICO SET DESCRICAO = '" & UCase(txtDescricao.Text) & "', CODIGOBARRAS = '" & txtCodigoBarras.Text & "', DATACADASTRO = '" & dtpDataCadastro.Text & "',  VALOR = '" & txtValor.Text & "'  WHERE CODIGO = '" & CDbl(txtCodigo.Text) & "'")
        End If
        MsgBox("Serviço salvo com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        Me.Close()
    End Sub

    Private Sub pfLimpaTela()
        txtCodigo.Clear() : txtCodigoBarras.Clear() : txtDescricao.Clear() : txtValor.Clear()
       
    End Sub

End Class