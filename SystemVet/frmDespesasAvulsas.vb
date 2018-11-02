Public Class frmDespesasAvulsas

    Private Sub frmDespesasAvulsas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtData.Text = FormatDateTime(Now, DateFormat.ShortDate)
        pfBuscaFuncionarios()
    End Sub

    Private Sub pfBuscaFuncionarios()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM USUARIOS ORDER BY NOMEUSUARIO", vgDados)
        cboClientes.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        Else
            While Not vlRegistros.EOF
                cboClientes.Items.Add(vlRegistros("NOMEUSUARIO").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        End If
    End Sub

    Private Sub txtData_GotFocus(sender As Object, e As EventArgs) Handles txtData.GotFocus
        txtData.SelectionStart = 0
        txtData.SelectionLength = Len(txtData.Text)
    End Sub

    Private Sub txtValor_LostFocus(sender As Object, e As EventArgs) Handles txtValor.LostFocus
        If Not IsNumeric(txtValor.Text) Then
            txtValor.Text = ""
            txtValor.Focus()
            Exit Sub
        Else
            txtValor.Text = FormatNumber(txtValor.Text, 2)
        End If
    End Sub

    Private Sub pfLimpaTela()
        txtData.Text = FormatDateTime(Now, DateFormat.ShortDate)
        txtNome.Clear() : txtValor.Clear() : pfBuscaFuncionarios()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        txtData.Text = FormatDateTime(Now, DateFormat.ShortDate)
        txtNome.Clear() : txtValor.Clear() : pfBuscaFuncionarios()
        cboClientes.Focus()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtNome.Text = "" Then
            MsgBox("Descrição da conta não informada! Informe uma descrição!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtNome.Focus()
            Exit Sub
        End If
        If txtValor.Text = "" Then
            MsgBox("Valor da conta não informado! Informe o valor!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtValor.Focus()
            Exit Sub
        End If
        If txtData.Text = "  /  /" Then txtData.Text = FormatDateTime(Now, DateFormat.ShortDate)
        If MsgBox("Confirma inclusão da conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("INSERT INTO DESPESAS (NOMEDESPESA, DATADESPESA, VALORDESPESA, CODIGOUSUARIO, NOMEUSUARIO, FUNCIONARIODESPESA, STATUSDESPESA) VALUES ('" & UCase(txtNome.Text) & "', '" & Date.Parse(txtData.Text).ToString("MM/dd/yyyy") & "', '" & UCase(txtValor.Text) & "', '" & vfCodigoUsuario & "', '" & vfNomeUsuario & "', '" & UCase(cboClientes.Text) & "', 'ABERTO')")
        MsgBox("Despesa incluída com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfLimpaTela()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class