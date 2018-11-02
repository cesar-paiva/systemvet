Public Class frmCadastroCliente

    Private Sub frmCadastroClienteFisico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pfPreenchecboSexo()
        'pfPreenchecboUF() esta comentado porque essa private esta sendo chamada na private pfLimpaTela
        pfLimpaTela()
        txtNome.Focus()
        If frmBuscaCliente.lsvDados.SelectedIndices.Count = 0 Then
            Exit Sub
        Else
            txtCodigo.Text = frmBuscaCliente.lsvDados.SelectedItems(0).Text
            txtNome.Text = frmBuscaCliente.lsvDados.SelectedItems(0).SubItems(1).Text
            If txtCodigo.Text = "" Then Exit Sub
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            vlRegistros.Open("SELECT * FROM CLIENTES WHERE CODIGOPESSOAFISICA = '" & CDbl(txtCodigo.Text) & "'", vgDados)
            If vlRegistros.RecordCount = 0 Then
                vlRegistros.Close()
                Exit Sub
            Else
                txtNascimento.Text = vlRegistros("DATANASCIMENTOPESSOAFISICA").Value
                txtEndereco.Text = "" & vlRegistros("ENDERECOPESSOAFISICA").Value
                txtNumero.Text = "" & vlRegistros("NUMEROPESSOAFISICA").Value
                txtCep.Text = "" & vlRegistros("CEPPESSOAFISICA").Value
                cboUF.Text = "" & vlRegistros("UFPESSOAFISICA").Value
                txtBairro.Text = "" & vlRegistros("BAIRROPESSOAFISICA").Value
                txtCidade.Text = "" & vlRegistros("CIDADEPESSOAFISICA").Value
                txtTelefone.Text = "" & vlRegistros("TELEFONEPESSOAFISICA").Value
                txtCelular.Text = "" & vlRegistros("CELULARPESSOAFISICA").Value
                txtEmail.Text = "" & vlRegistros("EMAILPESSOAFISICA").Value
                txtComplemento.Text = "" & vlRegistros("COMPLEMENTOPESSOAFISICA").Value
                txtCPF.Text = "" & vlRegistros("CPFPESSOAFISICA").Value
                txtRG.Text = "" & vlRegistros("RGPESSOAFISICA").Value
                txtCNPJ.Text = "" & vlRegistros("CNPJ").Value
                txtInscEstadual.Text = "" & vlRegistros("INSESTADUAL").Value
                dtpCadastro.Text = "" & vlRegistros("DATACADASTRO").Value
                cboSexo.Text = vlRegistros("SEXOPESSOAFISICA").Value
                If vlRegistros("SEXOPESSOAFISICA").Value = "MASCULINO" Then
                    cboSexo.Text = "MASCULINO"
                Else
                    cboSexo.Text = "FEMININO"
                End If
                txtSenha.Text = "" & vlRegistros("SENHACLIENTE").Value
                vlRegistros.Close()
            End If
        End If
    End Sub

    Private Sub pfPreenchecboSexo()
        cboSexo.Text = ""
        cboSexo.Items.Clear()
        cboSexo.Items.Add("MASCULINO")
        cboSexo.Items.Add("FEMININO")
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

    Private Sub pfLimpaTela()
        txtCodigo.Clear() : txtNome.Clear() : txtNascimento.Clear() : txtEndereco.Clear() : txtNumero.Clear() : txtCep.Clear() : txtBairro.Clear()
        txtCidade.Clear() : txtTelefone.Clear() : txtCelular.Clear() : txtComplemento.Clear() : txtEmail.Clear()
        txtCPF.Clear() : txtRG.Clear() : txtSenha.Clear()
        pfPreenchecboUF()
        pfPreenchecboSexo()
        ' aqui seria se o nivel fosse radio button
        'optTotal.Checked = False : optRestrito.Checked = False
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        ' teste de preenchimento do nome
        If txtNome.Text = "" Then
            MsgBox("Campo NOME em branco!", MsgBoxStyle.Information, "SystemVet :: Informação")
            txtNome.Focus()
            Exit Sub
        End If
        If txtNascimento.Text = "" Then
            MsgBox("Campo DATA DE NASCIMENTO em branco!", MsgBoxStyle.Information, "SystemVet :: Informação")
            txtNascimento.Focus()
            Exit Sub
        End If
        'If txtSenha.Text = "" Then
        '    MsgBox("Campo SENHA em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
        '    txtSenha.Focus()
        '    Exit Sub
        'End If
        If txtEndereco.Text = "" Then txtEndereco.Text = "-" ' aqui é pra poder passar do endereço e colocar um hifen se for em branco
        If txtBairro.Text = "" Then txtBairro.Text = "-"
        If txtCidade.Text = "" Then txtCidade.Text = "-"
        If txtCep.Text = "" Then txtCep.Text = "-"
        If cboUF.Text = "" Then cboUF.Text = ""
        If txtTelefone.Text = "" Then txtTelefone.Text = ""
        If txtCelular.Text = "" Then txtCelular.Text = ""
        If txtComplemento.Text = "" Then txtComplemento.Text = "-"
        If txtCNPJ.Text = "" Then txtCNPJ.Text = "-"
        If txtInscEstadual.Text = "" Then txtCidade.Text = "-"
        If txtCPF.Text = "" Then txtCidade.Text = "-"
        If txtEmail.Text = "" Then txtEmail.Text = "-"
        If cboSexo.Text = "" Then
            MsgBox("Selecione o SEXO do cliente", MsgBoxStyle.Information, "SystemVet :: Informação")
            cboSexo.Focus()
            Exit Sub
        End If
        If txtCodigo.Text = "" Then
            'aqui ira inserir no banco de dados
            vgDados.Execute("INSERT INTO CLIENTES (NOMEPESSOAFISICA, DATANASCIMENTOPESSOAFISICA, ENDERECOPESSOAFISICA, NUMEROPESSOAFISICA, CEPPESSOAFISICA, UFPESSOAFISICA, BAIRROPESSOAFISICA, CIDADEPESSOAFISICA, TELEFONEPESSOAFISICA, CELULARPESSOAFISICA, COMPLEMENTOPESSOAFISICA, EMAILPESSOAFISICA, SEXOPESSOAFISICA, CPFPESSOAFISICA, RGPESSOAFISICA, CNPJ, INSESTADUAL, DATACADASTRO, SENHACLIENTE) VALUES ('" & UCase(txtNome.Text) & "', '" & txtNascimento.Text & "', '" & UCase(txtEndereco.Text) & "', '" & txtNumero.Text & "', '" & txtCep.Text & "', '" & cboUF.Text & "', '" & UCase(txtBairro.Text) & "', '" & UCase(txtCidade.Text) & "', '" & txtTelefone.Text & "', '" & txtCelular.Text & "', '" & UCase(txtComplemento.Text) & "', '" & UCase(txtEmail.Text) & "', '" & cboSexo.Text & "', '" & txtCPF.Text & "', '" & txtRG.Text & "','" & txtCNPJ.Text & "','" & txtInscEstadual.Text & "','" & dtpCadastro.Text & "', '" & txtSenha.Text & "')")
            'Dim vfsenha As String = ""
            'Dim vfurl As String = ""
            'vfsenha = Convert.ToBase64String(New System.Text.ASCIIEncoding().GetBytes(txtSenha.Text))
            'vfurl = "http://www.glaucosantos.com.br/cwc/envio_email_cadastro.php?emailcliente=" & txtEmail.Text & "&senhacliente=" & vfsenha
            'Diagnostics.Process.Start(vfurl)
        Else
            'aqui altera no banco de dados
            vgDados.Execute("UPDATE CLIENTES SET NOMEPESSOAFISICA = '" & UCase(txtNome.Text) & "', DATANASCIMENTOPESSOAFISICA = '" & txtNascimento.Text & "', ENDERECOPESSOAFISICA = '" & UCase(txtEndereco.Text) & "', NUMEROPESSOAFISICA = '" & txtNumero.Text & "', CEPPESSOAFISICA = '" & txtCep.Text & "', UFPESSOAFISICA = '" & cboUF.Text & "', BAIRROPESSOAFISICA = '" & UCase(txtBairro.Text) & "', CIDADEPESSOAFISICA = '" & UCase(txtCidade.Text) & "', TELEFONEPESSOAFISICA = '" & txtTelefone.Text & "', CELULARPESSOAFISICA = '" & txtCelular.Text & "', COMPLEMENTOPESSOAFISICA = '" & UCase(txtComplemento.Text) & "', EMAILPESSOAFISICA = '" & UCase(txtEmail.Text) & "', SEXOPESSOAFISICA = '" & cboSexo.Text & "', CPFPESSOAFISICA = '" & txtCPF.Text & "', RGPESSOAFISICA = '" & txtRG.Text & "', CNPJ = '" & txtCNPJ.Text & "', INSESTADUAL = '" & txtInscEstadual.Text & "', DATACADASTRO = '" & dtpCadastro.Text & "', SENHACLIENTE = '" & txtSenha.Text & "' WHERE CODIGOPESSOAFISICA = '" & CDbl(txtCodigo.Text) & "'")
            'Dim vfsenha As String = ""
            'Dim vfurl As String = ""
            'vfsenha = Convert.ToBase64String(New System.Text.ASCIIEncoding().GetBytes(txtSenha.Text))
            ''mudar o corpo do arquivo envio_email_cadastro
            'vfurl = "http://www.glaucosantos.com.br/cwc/envio_email_cadastro.php?emailcliente=" & txtEmail.Text & "&senhacliente=" & vfsenha
            'Diagnostics.Process.Start(vfurl)
        End If
        MsgBox("Cliente salvo com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        Me.Close()
    End Sub

End Class