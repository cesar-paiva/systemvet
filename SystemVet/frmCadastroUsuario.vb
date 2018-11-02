Public Class frmCadastroUsuario

    Private Sub frmCadastroUsuario_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' aqui nao precisa preencher o UF mais porque esta dentro do pfLimpaTela
        'pfPreenchecboUF()
        pfPreenchecboNivelAcesso()
        pfLimpaTela()
        txtNome.Focus()
        If frmBuscaUsuario.lsvDados.SelectedIndices.Count = 0 Then
            Exit Sub
        Else
            txtCodigo.Text = frmBuscaUsuario.lsvDados.SelectedItems(0).Text
            txtNome.Text = frmBuscaUsuario.lsvDados.SelectedItems(0).SubItems(1).Text
            If txtCodigo.Text = "" Then Exit Sub
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            vlRegistros.Open("SELECT * FROM USUARIOS WHERE CODIGOUSUARIO = '" & CDbl(txtCodigo.Text) & "'", vgDados)
            If vlRegistros.RecordCount = 0 Then
                vlRegistros.Close()
                Exit Sub
            Else
                txtEndereco.Text = vlRegistros("ENDERECOUSUARIO").Value
                txtCep.Text = vlRegistros("CEPUSUARIO").Value
                txtBairro.Text = vlRegistros("BAIRROUSUARIO").Value
                txtCidade.Text = vlRegistros("CIDADEUSUARIO").Value
                cboUF.Text = vlRegistros("UFUSUARIO").Value
                txtTelefone.Text = vlRegistros("TELEFONEUSUARIO").Value
                txtCel.Text = vlRegistros("CELULARUSUARIO").Value
                txtEndereco.Text = vlRegistros("ENDERECOUSUARIO").Value
                txtLogin.Text = vlRegistros("LOGINUSUARIO").Value
                txtSenha.Text = vlRegistros("SENHAUSUARIO").Value
                If vlRegistros("NIVELACESSOUSUARIO").Value = "FUNCIONÁRIO" Then
                    cboNivelAcesso.Text = "FUNCIONÁRIO"
                Else
                    cboNivelAcesso.Text = "GERENTE"
                End If
                vlRegistros.Close()
            End If
        End If


    End Sub

    Private Sub pfPreenchecboUF()

        cboUF.Text = ""
        cboUF.Items.Clear()
        cboUF.Items.Add("AC")
        cboUF.Items.Add("AP")
        cboUF.Items.Add("AM")
        cboUF.Items.Add("BA")
        cboUF.Items.Add("CE")
        cboUF.Items.Add("DF")
        cboUF.Items.Add("ES")
        cboUF.Items.Add("GO")
        cboUF.Items.Add("MA")
        cboUF.Items.Add("MT")
        cboUF.Items.Add("MS")
        cboUF.Items.Add("MG")
        cboUF.Items.Add("PA")
        cboUF.Items.Add("PB")
        cboUF.Items.Add("PR")
        cboUF.Items.Add("PE")
        cboUF.Items.Add("PI")
        cboUF.Items.Add("RJ")
        cboUF.Items.Add("RN")
        cboUF.Items.Add("RS")
        cboUF.Items.Add("RO")
        cboUF.Items.Add("RR")
        cboUF.Items.Add("SC")
        cboUF.Items.Add("SP")
        cboUF.Items.Add("SE")
        cboUF.Items.Add("TO")

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click

        Me.Close()

    End Sub

    Private Sub pfPreenchecboNivelAcesso()

        cboNivelAcesso.Text = ""
        cboNivelAcesso.Items.Clear()
        cboNivelAcesso.Items.Add("GERENTE")
        cboNivelAcesso.Items.Add("FUNCIONÁRIO")



    End Sub

    'Private Sub btnNovo_Click(sender As Object, e As EventArgs)
    '    If MsgBox("Deseja inserir um novo usuário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
    '    pfLimpaTela()
    '    txtNome.Focus()
    'End Sub

    Private Sub pfLimpaTela()

        txtCodigo.Clear() : txtNome.Clear() : txtEndereco.Clear() : txtCep.Clear() : txtBairro.Clear()
        txtCidade.Clear() : txtTelefone.Clear() : txtCel.Clear() : txtLogin.Clear() : txtSenha.Clear()
        pfPreenchecboUF()
        pfPreenchecboNivelAcesso()
        ' aqui seria se o nivel fosse radio button
        'optTotal.Checked = False : optRestrito.Checked = False

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        ' teste de preenchimento do nome
        If txtNome.Text = "" Then
            MsgBox("Campo NOME em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtNome.Focus()
            Exit Sub
        End If
        If txtEndereco.Text = "" Then txtEndereco.Text = "-" ' aqui é pra poder passar do endereço e colocar um hifen se for em branco
        If txtBairro.Text = "" Then txtBairro.Text = "-"
        If txtCidade.Text = "" Then txtCidade.Text = "-"
        If txtCep.Text = "  ,   -" Then txtCep.Text = "00.000-000"
        If cboUF.Text = "" Then cboUF.Text = ""
        If txtTelefone.Text = "(  )     -" Then txtTelefone.Text = "(00) 0000-0000"
        If txtCel.Text = "(  )       -" Then txtCel.Text = "(00) 0 0000-0000"
        If txtLogin.Text = "" Then
            MsgBox("Campo LOGIN em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtLogin.Focus()
            Exit Sub
        End If
        If txtSenha.Text = "" Then
            MsgBox("Campo SENHA em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtSenha.Focus()
            Exit Sub
        End If
        If cboNivelAcesso.Text = "" Then cboNivelAcesso.Text = "FUNCIONARIO"

        If txtCodigo.Text = "" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            vlRegistros.Open("SELECT * FROM USUARIOS WHERE LOGINUSUARIO = '" & txtLogin.Text & "'", vgDados)
            If vlRegistros.RecordCount = 0 Then
                'inserir no banco de dados
                vgDados.Execute("INSERT INTO USUARIOS (NOMEUSUARIO, ENDERECOUSUARIO, CEPUSUARIO, BAIRROUSUARIO, CIDADEUSUARIO, UFUSUARIO, TELEFONEUSUARIO, CELULARUSUARIO, LOGINUSUARIO, SENHAUSUARIO, NIVELACESSOUSUARIO, DATACADASTRO) VALUES ('" & UCase(txtNome.Text) & "', '" & UCase(txtEndereco.Text) & "', '" & UCase(txtCep.Text) & "', '" & UCase(txtBairro.Text) & "', '" & UCase(txtCidade.Text) & "', '" & cboUF.Text & "', '" & UCase(txtTelefone.Text) & "', '" & UCase(txtCel.Text) & "', '" & txtLogin.Text & "', '" & txtSenha.Text & "', '" & cboNivelAcesso.Text & "', '" & Date.Parse(dtpDataCadastro.Text).ToString("MM/dd/yyyy") & "')")
                vlRegistros.Close()
            Else
                MsgBox("Login já existe!", MsgBoxStyle.Critical, "SystemVet :: Erro")
                txtLogin.Focus()
                'vlRegistros.Close()
                Exit Sub
            End If
        Else
            ' alterar no banco de dados
            vgDados.Execute("UPDATE USUARIOS SET NOMEUSUARIO = '" & UCase(txtNome.Text) & "', ENDERECOUSUARIO = '" & UCase(txtEndereco.Text) & "', CEPUSUARIO = '" & UCase(txtCep.Text) & "', BAIRROUSUARIO = '" & UCase(txtBairro.Text) & "', CIDADEUSUARIO = '" & UCase(txtCidade.Text) & "', UFUSUARIO = '" & UCase(cboUF.Text) & "', TELEFONEUSUARIO = '" & UCase(txtTelefone.Text) & "', CELULARUSUARIO = '" & UCase(txtCel.Text) & "', LOGINUSUARIO = '" & txtLogin.Text & "', SENHAUSUARIO = '" & txtSenha.Text & "', NIVELACESSOUSUARIO = '" & cboNivelAcesso.Text & "', DATACADASTRO = '" & Date.Parse(dtpDataCadastro.Text).ToString("MM/dd/yyyy") & "' WHERE CODIGOUSUARIO = '" & CDbl(txtCodigo.Text) & "'")
            'vlRegistros.Close()
        End If

            MsgBox("Usuário salvo com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
            Me.Close()
    End Sub

End Class