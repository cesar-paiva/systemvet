Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnConfirma_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        'testa se os botoes usuario/senha estao preenchidos
        If txtUsuario.Text = "" Then
            ' exibe tela de erro
            MsgBox("Digite um nome de USUÁRIO!", MsgBoxStyle.Critical, "Login - Erro")
            ' volta o foco para o campo usuario
            txtUsuario.Focus()
            'sai do procedimento
            Exit Sub
        End If
        If txtSenha.Text = "" Then
            MsgBox("Digite uma senha!", MsgBoxStyle.Critical, "Login - Erro")
            txtSenha.Focus()
            Exit Sub
        End If
        ' aqui diz que o local é cliente e ja esta logando  com o banco de dados!!
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM USUARIOS WHERE LOGINUSUARIO = '" & txtUsuario.Text & "'", vgDados)
        If vlRegistros.RecordCount = 0 Then
            MsgBox("Usuário não cadastrado!", MsgBoxStyle.Critical, "SystemVet : Erro")
            txtUsuario.Clear() : txtSenha.Text = ""
            txtUsuario.Focus()
            vlRegistros.Close()
            Exit Sub
        End If
        If vlRegistros("SENHAUSUARIO").Value = txtSenha.Text Then
            vfTestaNivelAcesso = vlRegistros("NIVELACESSOUSUARIO").Value
            vfUsuarioLogado = vlRegistros("LOGINUSUARIO").Value
            vlRegistros.Close()
            frmTelaInicial.ShowDialog()
            txtUsuario.Select()
            Exit Sub
        Else
            MsgBox("SENHA INCORRETA!", MsgBoxStyle.Critical, "Login - Erro")
            txtSenha.Clear()
            txtSenha.Focus()
            vlRegistros.Close()
            Exit Sub
        End If

        '  ****   aqui é quando tava logando sem banco ainda  ***** 
        'testa se o campo usuario = senac e senha = 123
        'If txtUsuario.Text = "senac" Then
        '    ' se for igual a senac testa a senha
        '    If txtSenha.Text = "123" Then
        '        MsgBox(" Logado com sucesso!", MsgBoxStyle.Information, "Login - Sucesso")
        '        Exit Sub
        '        frmTelaInicial.ShowDialog()
        '    Else
        '        MsgBox("SENHA INVÁLIDA!", MsgBoxStyle.Critical, "Login - Erro")
        '        txtSenha.Clear()
        '        txtSenha.Focus()
        '        Exit Sub
        '    End If
        'Else
        '    MsgBox("Usuario nao cadastrado!", MsgBoxStyle.Critical, "Login - Erro")
        '    txtUsuario.Clear() : txtSenha.Text = ""
        '    txtUsuario.Focus()
        '    Exit Sub
        'End If
    End Sub

End Class
