Public Class frmCadastroFornecedor

    Private Sub frmCadastroFornecedor_Load(sender As Object, e As EventArgs) Handles Me.Load
        'pfPreenchecboUF() esta comentado porque essa private esta sendo chamada na private pfLimpaTela
        pfLimpaTela()
        txtRazaoSocial.Focus()
        If frmBuscaFornecedor.lsvDados.SelectedIndices.Count = 0 Then
            Exit Sub
        Else
            txtCodigo.Text = frmBuscaFornecedor.lsvDados.SelectedItems(0).Text
            txtRazaoSocial.Text = frmBuscaFornecedor.lsvDados.SelectedItems(0).SubItems(1).Text
            txtTelefone.Text = frmBuscaFornecedor.lsvDados.SelectedItems(0).SubItems(2).Text
            txtEmail.Text = frmBuscaFornecedor.lsvDados.SelectedItems(0).SubItems(3).Text

            If txtCodigo.Text = "" Then Exit Sub
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            vlRegistros.Open("SELECT * FROM FORNECEDOR WHERE CODIGO = '" & CDbl(txtCodigo.Text) & "'", vgDados)
            If vlRegistros.RecordCount = 0 Then
                vlRegistros.Close()
                Exit Sub
            Else
                dtpDataCadastro.Text = vlRegistros("DATACADASTRO").Value
                txtNomeFantasia.Text = vlRegistros("NOMEFANTASIA").Value
                txtCNPJ.Text = "" & vlRegistros("CNPJ").Value
                txtInsEstadual.Text = "" & vlRegistros("INSCESTADUAL").Value
                txtObservações.Text = "" & vlRegistros("OBSERVACAO").Value
                txtEntrega.Text = "" & vlRegistros("PRAZOENTREGA").Value
                If vlRegistros("TIPO").Value = "FISICA" Then
                    optPessoaFisica.Checked = True
                End If
                If vlRegistros("TIPO").Value = "JURIDICA" Then
                    optPessoaJuridica.Checked = False
                End If
                If vlRegistros("CATEGORIA").Value = "ATACADISTA" Then
                    optAtacadista.Checked = True
                End If
                If vlRegistros("CATEGORIA").Value = "DISTRIBUIDOR" Then
                    optDistribuidor.Checked = True
                End If
                If vlRegistros("CATEGORIA").Value = "FABRICANTE" Then
                    optFabricante.Checked = True
                End If
                If vlRegistros("CATEGORIA").Value = "OUTROS" Then
                    optOutros.Checked = True
                End If
                If vlRegistros("ISENTO").Value = "ESTADUAL" Then
                    optInscEstadual.Checked = True
                End If
                If vlRegistros("ISENTO").Value = "MUNICIPAL" Then
                    optInscMunicipal.Checked = True
                End If
                txtEndereco.Text = "" & vlRegistros("ENDERECO").Value
                txtComplemento.Text = "" & vlRegistros("COMPLEMENTO").Value
                txtNumero.Text = "" & vlRegistros("NUMERO").Value
                txtBairro.Text = "" & vlRegistros("BAIRRO").Value
                txtCep.Text = "" & vlRegistros("CEP").Value
                txtCidade.Text = "" & vlRegistros("CIDADE").Value
                txtTelefone.Text = "" & vlRegistros("TELEFONE1").Value
                cboEstado.Text = "" & vlRegistros("ESTADO").Value
                txtEmail.Text = "" & vlRegistros("EMAIL").Value
                txtSite.Text = "" & vlRegistros("SITE").Value
                txtNomeRepresentante.Text = "" & vlRegistros("NOMEREPRESENTANTE").Value
                txtCelularRepresentante.Text = "" & vlRegistros("CELULARREPRESENTANTE").Value
                txtEmailRepresentante.Text = "" & vlRegistros("EMAILREPRESENTANTE").Value
                txtDiaVisita.Text = "" & vlRegistros("DIAVISITA").Value
                vlRegistros.Close()

            End If
        End If

    End Sub

    Private Sub pfPreencheEstado()
        cboEstado.Text = ""
        cboEstado.Items.Clear()
        cboEstado.Items.Add("Acre")
        cboEstado.Items.Add("Alagoas")
        cboEstado.Items.Add("Amapá")
        cboEstado.Items.Add("Amazonas")
        cboEstado.Items.Add("Bahia")
        cboEstado.Items.Add("Ceará")
        cboEstado.Items.Add("Distrito Federal")
        cboEstado.Items.Add("Espírito Santo")
        cboEstado.Items.Add("Goiás")
        cboEstado.Items.Add("Maranhão")
        cboEstado.Items.Add("Mato Grosso")
        cboEstado.Items.Add("Mato Grosso do Sul")
        cboEstado.Items.Add("Minas Gerais")
        cboEstado.Items.Add("Pará")
        cboEstado.Items.Add("Paraíba")
        cboEstado.Items.Add("Paraná")
        cboEstado.Items.Add("Pernambuco")
        cboEstado.Items.Add("Piauí")
        cboEstado.Items.Add("Roraima")
        cboEstado.Items.Add("Rondônia")
        cboEstado.Items.Add("Rio de Janeiro")
        cboEstado.Items.Add("Rio Grande do Norte")
        cboEstado.Items.Add("Rio Grande do Sul")
        cboEstado.Items.Add("Santa Catarina")
        cboEstado.Items.Add("São Paulo")
        cboEstado.Items.Add("Sergipe")
        cboEstado.Items.Add("Tocantins")

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        ' teste de preenchimento do nome
        If txtRazaoSocial.Text = "" Then
            MsgBox("Campo RAZÃO SOCIAL em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtRazaoSocial.Focus()
            Exit Sub
        End If
        If txtTelefone.Text = "" Then
            MsgBox("CampoTELEFONE em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtTelefone.Focus()
            Exit Sub
        End If
        If txtNomeFantasia.Text = "" Then txtNomeFantasia.Text = "" ' aqui é pra poder passar do nome fantasia e colocar um hifen se for em branco
        If txtCNPJ.Text = "" Then txtCNPJ.Text = "-"
        If txtInsEstadual.Text = "" Then txtInsEstadual.Text = "-"
        If txtObservações.Text = "" Then txtObservações.Text = "-"
        If txtEntrega.Text = "" Then txtEntrega.Text = "-"

        Dim vfTipo As String = ""
        If optPessoaFisica.Checked = True Then vfTipo = "FISICA"
        If optPessoaJuridica.Checked = True Then vfTipo = "JURIDICA"

        Dim vfCategoria As String = ""
        If optAtacadista.Checked = True Then vfCategoria = "ATACADISTA"
        If optDistribuidor.Checked = True Then vfCategoria = "DISTRIBUIDOR"
        If optFabricante.Checked = True Then vfCategoria = "FABRICANTE"
        If optOutros.Checked = True Then vfCategoria = "OUTROS"

        Dim vfIsento As String = ""
        If optInscEstadual.Checked = True Then vfIsento = "ESTADUAL"
        If optInscMunicipal.Checked = True Then vfIsento = "MUNICIPAL"

        If txtEndereco.Text = "" Then txtEndereco.Text = "-"
        If txtComplemento.Text = "" Then txtComplemento.Text = "-"
        If txtNumero.Text = "" Then txtNumero.Text = "-"
        If txtBairro.Text = "" Then txtBairro.Text = "-"
        If txtCep.Text = "" Then txtCep.Text = "-"
        If txtCidade.Text = "" Then txtCidade.Text = "-"
        If txtTelefone.Text = "" Then txtTelefone.Text = "-"
        If cboEstado.Text = "" Then cboEstado.Text = "-"
        If txtEmail.Text = "" Then txtEmail.Text = "-"
        If txtSite.Text = "" Then txtSite.Text = "-"

        If txtNomeRepresentante.Text = "" Then txtNomeRepresentante.Text = "-"
        If txtCelularRepresentante.Text = "" Then txtCelularRepresentante.Text = "-"
        If txtEmailRepresentante.Text = "" Then txtEmailRepresentante.Text = "-"
        If txtDiaVisita.Text = "" Then txtDiaVisita.Text = "-"

        If txtCodigo.Text = "" Then
            'aqui ira inserir no banco de dados
            vgDados.Execute("INSERT INTO FORNECEDOR (DATACADASTRO, RAZAOSOCIAL, NOMEFANTASIA, CNPJ, INSCESTADUAL, OBSERVACAO, PRAZOENTREGA, TIPO, CATEGORIA, ISENTO, ENDERECO, COMPLEMENTO, NUMERO, BAIRRO, CEP, CIDADE, TELEFONE1, ESTADO, EMAIL, SITE, NOMEREPRESENTANTE, CELULARREPRESENTANTE, EMAILREPRESENTANTE, DIAVISITA) VALUES ('" & dtpDataCadastro.Text & "', '" & UCase(txtRazaoSocial.Text) & "', '" & UCase(txtNomeFantasia.Text) & "', '" & txtCNPJ.Text & "', '" & txtInsEstadual.Text & "', '" & UCase(txtObservações.Text) & "', '" & txtEntrega.Text & "', '" & vfTipo & "', '" & vfCategoria & "', '" & vfIsento & "', '" & UCase(txtEndereco.Text) & "', '" & UCase(txtComplemento.Text) & "', '" & txtNumero.Text & "', '" & UCase(txtBairro.Text) & "', '" & txtCep.Text & "', '" & UCase(txtCidade.Text) & "', '" & txtTelefone.Text & "', '" & cboEstado.Text & "','" & UCase(txtEmail.Text) & "','" & UCase(txtSite.Text) & "','" & UCase(txtNomeRepresentante.Text) & "', '" & UCase(txtCelularRepresentante.Text) & "', '" & UCase(txtEmailRepresentante.Text) & "', '" & UCase(txtDiaVisita.Text) & "')")
        Else
            'aqui altera no banco de dados
            vgDados.Execute("UPDATE FORNECEDOR SET DATACADASTRO = '" & dtpDataCadastro.Text & "', RAZAOSOCIAL = '" & UCase(txtRazaoSocial.Text) & "', NOMEFANTASIA = '" & UCase(txtNomeFantasia.Text) & "', CNPJ = '" & txtCNPJ.Text & "', INSCESTADUAL = '" & txtInsEstadual.Text & "', OBSERVACAO = '" & UCase(txtObservações.Text) & "', PRAZOENTREGA = '" & txtEntrega.Text & "', TIPO = '" & vfTipo & "', CATEGORIA = '" & vfCategoria & "', ISENTO = '" & vfIsento & "', ENDERECO = '" & UCase(txtEndereco.Text) & "', COMPLEMENTO = '" & UCase(txtComplemento.Text) & "', NUMERO = '" & txtNumero.Text & "', BAIRRO = '" & UCase(txtBairro.Text) & "', CEP = '" & txtCep.Text & "', CIDADE = '" & UCase(txtCidade.Text) & "', TELEFONE1 = '" & txtTelefone.Text & "', ESTADO = '" & cboEstado.Text & "', EMAIL = '" & UCase(txtEmail.Text) & "', SITE = '" & UCase(txtSite.Text) & "', NOMEREPRESENTANTE = '" & UCase(txtNomeRepresentante.Text) & "', CELULARREPRESENTANTE = '" & UCase(txtCelularRepresentante.Text) & "', EMAILREPRESENTANTE = '" & UCase(txtEmailRepresentante.Text) & "', DIAVISITA = '" & UCase(txtDiaVisita.Text) & "' WHERE CODIGO = '" & CDbl(txtCodigo.Text) & "'")
        End If

        MsgBox("Fornecedor salvo com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        Me.Close()
    End Sub

    Private Sub pfLimpaTela()
        txtCodigo.Clear() : txtRazaoSocial.Clear() : txtNomeFantasia.Clear() : txtCNPJ.Clear() : txtInsEstadual.Clear() : txtObservações.Clear()
        optPessoaFisica.Checked = False : optPessoaJuridica.Checked = False
        optAtacadista.Checked = False : optDistribuidor.Checked = False : optFabricante.Checked = False : optOutros.Checked = False
        optInscEstadual.Checked = False : optInscMunicipal.Checked = False
        txtEndereco.Clear() : txtComplemento.Clear() : txtNumero.Clear() : txtBairro.Clear() : txtCep.Clear() : txtCidade.Clear() : txtTelefone.Clear()
        txtEmail.Clear() : txtSite.Clear() : txtNomeRepresentante.Clear() : txtCelularRepresentante.Clear() : txtEmailRepresentante.Clear() : txtDiaVisita.Clear()
        pfPreencheEstado()

        ' aqui seria se o nivel fosse radio button
        'optTotal.Checked = False : optRestrito.Checked = False
    End Sub
End Class