Public Class frmCadastroProfissionais


    Private Sub frmCadastroProfissionais_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfLimpaTela()
        pfPreencheProfissao()
        pfPreenchecboUF()
        pfPreenchecboSexo()
        pfBuscaProfissional()
    End Sub
    Private Sub pfBuscaProfissional()
        If frmBuscaProfissionais.lsvDados.SelectedIndices.Count = 0 Then
            Exit Sub
        Else
            txtCodigo.Text = frmBuscaProfissionais.lsvDados.SelectedItems(0).Text
            txtNome.Text = frmBuscaProfissionais.lsvDados.SelectedItems(0).SubItems(1).Text
            If txtCodigo.Text = "" Then Exit Sub
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            vlRegistros.Open("SELECT * FROM PROFISSIONAL WHERE CODIGOPROFISSIONAL = '" & CDbl(txtCodigo.Text) & "'", vgDados)
            If vlRegistros.RecordCount = 0 Then
                vlRegistros.Close()
                Exit Sub
            Else
                txtNascimento.Text = vlRegistros("NASCIMENTOPROFISSIONAL").Value
                txtEndereco.Text = "" & vlRegistros("ENDERECOPROFISSIONAL").Value
                cboProfissao.Text = "" & vlRegistros("TIPOPROFISSIONAL").Value
                txtCep.Text = "" & vlRegistros("CEPPROFISSIONAL").Value
                cboUF.Text = "" & vlRegistros("UFPROFISSIONAL").Value
                txtBairro.Text = "" & vlRegistros("BAIRROPROFISSIONAL").Value
                txtCidade.Text = "" & vlRegistros("CIDADEPROFISSIONAL").Value
                txtTelefone.Text = "" & vlRegistros("TELEFONEPROFISSIONAL").Value
                txtCel.Text = "" & vlRegistros("CELULARPROFISSIONAL").Value
                cboSexo.Text = vlRegistros("SEXOPROFISSIONAL").Value
                txtAdmissao.Text = vlRegistros("ADMISSAOPROFISSIONAL").Value
                vlRegistros.Close()
            End If
        End If

    End Sub
    Private Sub pfPreencheProfissao()

        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM PROFISSAO ORDER BY NOMEPROFISSAO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        'cboProfissao.Text = ""
        cboProfissao.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            cboProfissao.Items.Add("----------------------------------------------------------")
            cboProfissao.Items.Add("Cadastrar profissão")
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                cboProfissao.Items.Add(vlRegistros("NOMEPROFISSAO").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If
        cboProfissao.Items.Add("----------------------------------------------------------")
        cboProfissao.Items.Add("Cadastrar profissão")
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
    Private Sub pfPreenchecboSexo()
        cboSexo.Text = ""
        cboSexo.Items.Clear()
        cboSexo.Items.Add("MASCULINO")
        cboSexo.Items.Add("FEMININO")
    End Sub


    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub pfLimpaTela()
        txtCodigo.Clear() : txtNome.Clear() : txtNascimento.Clear() : txtEndereco.Clear() : txtCep.Clear() : txtBairro.Clear() : txtCidade.Clear()
        txtTelefone.Clear() : txtCel.Clear() : txtAdmissao.Clear()
        pfPreenchecboUF()
        pfPreenchecboSexo()

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
        If cboProfissao.Text = "" Then
            MsgBox("Campo PROFISSÃO em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            cboProfissao.Focus()
            Exit Sub
        End If
        If txtNascimento.Text = "  /  /" Then
            MsgBox("Campo DATA DE NASCIMENTO em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtNascimento.Focus()
            Exit Sub
        End If
        If txtEndereco.Text = "" Then txtEndereco.Text = "-" ' aqui é pra poder passar do endereço e colocar um hifen se for em branco
        If txtBairro.Text = "" Then txtBairro.Text = "-"
        If txtCidade.Text = "" Then txtCidade.Text = "-"
        If cboUF.Text = "" Then cboUF.Text = ""
        If txtTelefone.Text = "" Then txtTelefone.Text = ""
        If txtCel.Text = "(  )      -" Then
            MsgBox("Campo CELULAR em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtCel.Focus()
            Exit Sub
        End If
        If cboSexo.Text = "" Then
            MsgBox("Campo SEXO em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            cboSexo.Focus()
            Exit Sub
        End If
        If txtCodigo.Text = "" Then
            'aqui ira inserir no banco de dados
            vgDados.Execute("INSERT INTO PROFISSIONAL (TIPOPROFISSIONAL, NOMEPROFISSIONAL, NASCIMENTOPROFISSIONAL, ENDERECOPROFISSIONAL, CEPPROFISSIONAL, UFPROFISSIONAL, BAIRROPROFISSIONAL, CIDADEPROFISSIONAL, TELEFONEPROFISSIONAL, CELULARPROFISSIONAL, SEXOPROFISSIONAL,ADMISSAOPROFISSIONAL) VALUES ('" & cboProfissao.Text & "', '" & UCase(txtNome.Text) & "', '" & txtNascimento.Text & "', '" & UCase(txtEndereco.Text) & "', '" & txtCep.Text & "', '" & cboUF.Text & "', '" & UCase(txtBairro.Text) & "', '" & UCase(txtCidade.Text) & "', '" & txtTelefone.Text & "', '" & txtCel.Text & "', '" & cboSexo.Text & "','" & txtAdmissao.Text & "')")
        Else
            'aqui altera no banco de dados
            vgDados.Execute("UPDATE PROFISSIONAL SET NOMEPROFISSIONAL = '" & UCase(txtNome.Text) & "',TIPOPROFISSIONAL = '" & cboProfissao.Text & "', NASCIMENTOPROFISSIONAL = '" & txtNascimento.Text & "', ENDERECOPROFISSIONAL = '" & UCase(txtEndereco.Text) & "', CEPPROFISSIONAL = '" & txtCep.Text & "', UFPROFISSIONAL = '" & cboUF.Text & "', BAIRROPROFISSIONAL = '" & UCase(txtBairro.Text) & "', CIDADEPROFISSIONAL = '" & UCase(txtCidade.Text) & "', TELEFONEPROFISSIONAL = '" & txtTelefone.Text & "', CELULARPROFISSIONAL = '" & txtCel.Text & "', SEXOPROFISSIONAL = '" & cboSexo.Text & "', ADMISSAOPROFISSIONAL = '" & txtAdmissao.Text & "' WHERE CODIGOPROFISSIONAL = '" & CDbl(txtCodigo.Text) & "'")
        End If

        MsgBox("Profissional salvo com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        Me.Close()
    End Sub

    Private Sub cboProfissao_TextChanged(sender As Object, e As EventArgs) Handles cboProfissao.TextChanged
        If cboProfissao.Text = "Cadastrar profissão" Then
            frmCadastroProfissao.ShowDialog()
            pfPreencheProfissao()
        End If
    End Sub
End Class