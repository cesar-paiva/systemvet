Public Class frmCadastroAnimais
    Public vfURLfoto As String = ""

    Private Sub frmCadastroAnimais_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtAnimal.Select()
        pfLimpaTela()
        pfPreenchecboSexo()
        pfPreenchecboPorte()
        pfPreenchecboTemperamento()
        pfPreenchecboEstado()
        pfPreenchecboEspecie()
        pfPreenchecboPelagem()
        pfPreenchecboRaca()
        pfBuscaCliente()
        pfCalculaIdade()
        If frmBuscaAnimal.lsvDados.SelectedIndices.Count > 0 Then
            txtCodigo.Text = frmBuscaAnimal.lsvDados.SelectedItems(0).Text
            txtAnimal.Text = frmBuscaAnimal.lsvDados.SelectedItems(0).SubItems(1).Text
            cboSexo.Text = frmBuscaAnimal.lsvDados.SelectedItems(0).SubItems(2).Text
            cboRaca.Text = frmBuscaAnimal.lsvDados.SelectedItems(0).SubItems(3).Text
            cboEspecie.Text = frmBuscaAnimal.lsvDados.SelectedItems(0).SubItems(4).Text
            txtNascimento.Text = frmBuscaAnimal.lsvDados.SelectedItems(0).SubItems(6).Text
            pfBuscaAnimal()
        End If
    End Sub

    Private Sub pfCalculaIdade()

        If txtNascimento.Text = "  /  /" Then Exit Sub

        Dim birthdate As Date = txtNascimento.Text

        Dim years As Integer = DateTime.Now.Year - birthdate.Year

        If DateTime.Now.Month < birthdate.Month Or (DateTime.Now.Month = birthdate.Month And DateTime.Now.Day < birthdate.Day) Then

            years = years - 1

        End If
        If years = 1 Then
            txtIdade.Text = years & "ANO"
        Else
            txtIdade.Text = years & " ANOS"
        End If


    End Sub
    Private Sub pfBuscaAnimal() ' esse procedimento que atualiza o list view
        If txtCodigo.Text = "" Then Exit Sub
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM ANIMAL WHERE CODIGOANIMAL = '" & CDbl(txtCodigo.Text) & "' ORDER BY NOMEANIMAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            txtAnimal.Text = vlRegistros("NOMEANIMAL").Value
            If vlRegistros("SEXOANIMAL").Value = "MACHO" Then
                cboSexo.Text = "MACHO"
            Else
                cboSexo.Text = "FÊMEA"
            End If
            cboCliente.Text = "" & vlRegistros("NOMEDONOANIMAL").Value
            txtNascimento.Text = "" & vlRegistros("NASCIMENTOANIMAL").Value
            txtIdade.Text = "" & vlRegistros("IDADEANIMAL").Value
            txtPeso.Text = "" & vlRegistros("PESOANIMAL").Value
            txtChip.Text = "" & vlRegistros("CHIPANIMAL").Value
            cboEspecie.Text = "" & vlRegistros("ESPECIEANIMAL").Value
            cboRaca.Text = "" & vlRegistros("RACAANIMAL").Value
            cboPelagem.Text = "" & vlRegistros("PELAGEMANIMAL").Value
            cboRaca.Text = "" & vlRegistros("RACAANIMAL").Value
            chkboxDisponivel.Text = "" & vlRegistros("DISPONIVELTOSAANIMAL").Value
            chkboxPedigree.Text = "" & vlRegistros("PEDIGREEANIMAL").Value
            chkboxRestricoes.Text = "" & vlRegistros("RESTRICOESANIMAL").Value
            chkboxObito.Text = "" & vlRegistros("OBITOANIMAL").Value
            txtAlimentacao.Text = "" & vlRegistros("ALIMENTACAOANIMAL").Value
            txtCor.Text = "" & vlRegistros("CORANIMAL").Value
            cboTemperamento.Text = "" & vlRegistros("TEMPERAMENTOANIMAL").Value
            cboEstado.Text = "" & vlRegistros("ESTADOANIMAL").Value
            cboPorte.Text = "" & vlRegistros("PORTEANIMAL").Value
            txtDataObito.Text = "" & vlRegistros("DATAOBITOANIMAL").Value
            txtObito.Text = "" & vlRegistros("MOTIVOOBITOANIMAL").Value
            txtDescricao.Text = "" & vlRegistros("DESCRICAOOBITOANIMAL").Value
            dtpCadastro.Value = "" & vlRegistros("DATACADASTRO").Value
            pctboxFoto.ImageLocation = "" & vlRegistros("FOTO").Value
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros

        End If
    End Sub

    Private Sub pfPreenchecboSexo()

        cboSexo.Text = ""
        cboSexo.Items.Clear()
        cboSexo.Items.Add("MACHO")
        cboSexo.Items.Add("FÊMEA")

    End Sub

    Private Sub pfPreenchecboPorte()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM PORTE ORDER BY CODIGOPORTE", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        cboPorte.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            cboPorte.Items.Add("--------------------------------------------------")
            cboPorte.Items.Add("Cadastrar porte")
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                cboPorte.Items.Add(vlRegistros("TIPOPORTE").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            cboPorte.Items.Add("--------------------------------------------------")
            cboPorte.Items.Add("Cadastrar porte")

        End If
    End Sub

    Private Sub pfPreenchecboTemperamento()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM TEMPERAMENTO ORDER BY TIPOTEMPERAMENTO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        cboTemperamento.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            cboTemperamento.Items.Add("--------------------------------------------------")
            cboTemperamento.Items.Add("Cadastrar temperamento")
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                cboTemperamento.Items.Add(vlRegistros("TIPOTEMPERAMENTO").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            cboTemperamento.Items.Add("--------------------------------------------------")
            cboTemperamento.Items.Add("Cadastrar temperamento")

        End If
    End Sub

    Private Sub pfPreenchecboEstado()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM ESTADOANIMAL ORDER BY NOMEESTADO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        cboEstado.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            cboEstado.Items.Add("--------------------------------------------------")
            cboEstado.Items.Add("Cadastrar estado")
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                cboEstado.Items.Add(vlRegistros("NOMEESTADO").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            cboEstado.Items.Add("--------------------------------------------------")
            cboEstado.Items.Add("Cadastrar estado")

        End If
    End Sub

    Private Sub pfPreenchecboEspecie()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM ESPECIE ORDER BY TIPOESPECIE", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        cboEspecie.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            cboEspecie.Items.Add("--------------------------------------------------")
            cboEspecie.Items.Add("Cadastrar espécie")
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                cboEspecie.Items.Add(vlRegistros("TIPOESPECIE").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            cboEspecie.Items.Add("--------------------------------------------------")
            cboEspecie.Items.Add("Cadastrar espécie")
        End If
    End Sub
    Private Sub pfPreenchecboRaca()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM RACA ORDER BY NOMERACA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        cboRaca.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            cboRaca.Items.Add("--------------------------------------------------")
            cboRaca.Items.Add("Cadastrar raça")
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                cboRaca.Items.Add(vlRegistros("NOMERACA").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            cboRaca.Items.Add("---------------------------------------------------")
            cboRaca.Items.Add("Cadastrar raça")
        End If
    End Sub
    Private Sub pfPreenchecboPelagem()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM PELAGEM ORDER BY TIPOPELAGEM", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        cboPelagem.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            cboPelagem.Items.Add("--------------------------------------------------")
            cboPelagem.Items.Add("Cadastrar pelagem")
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                cboPelagem.Items.Add(vlRegistros("TIPOPELAGEM").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            cboPelagem.Items.Add("--------------------------------------------------")
            cboPelagem.Items.Add("Cadastrar pelagem")
        End If

    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedIndex = 1 Then
            ToolStrip1.Visible = False
        Else
            ToolStrip1.Visible = True
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        ' teste de preenchimento do nome
        If txtAnimal.Text = "" Then
            MsgBox("Campo NOME DO ANIMAL em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtAnimal.Focus()
            Exit Sub
        End If

        If cboSexo.Text = "" Then
            MsgBox("Campo SEXO em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            cboSexo.Focus()
            Exit Sub
        End If
        If txtNascimento.Text = "  /  /" Then
            MsgBox("Campo DATA DE NASCIMENTO em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            txtNascimento.Focus()
            Exit Sub
        End If
        If cboCliente.Text = "" Then
            MsgBox("Campo CLIENTE/DONO  em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            cboCliente.Focus()
            Exit Sub
        End If
        If txtPeso.Text = "" Then txtPeso.Text = "-" ' aqui é pra poder passar do endereço e colocar um hifen se for em branco
        If txtChip.Text = "" Then txtChip.Text = "Sem número"
        If cboEspecie.Text = "" Then cboEspecie.Text = "-"
        If cboRaca.Text = "" Then cboRaca.Text = ""
        If cboPelagem.Text = "" Then cboPelagem.Text = ""
        If txtAlimentacao.Text = "" Then txtAlimentacao.Text = ""
        If txtCor.Text = "" Then txtCor.Text = ""
        If cboTemperamento.Text = "" Then cboTemperamento.Text = ""
        If cboEstado.Text = "" Then cboEstado.Text = ""
        If cboPorte.Text = "" Then cboPorte.Text = ""
        If txtDataObito.Text = "  /  /" Then txtDataObito.Text = "  /  /"
        If txtObito.Text = "" Then txtObito.Text = ""
        If txtDescricao.Text = "" Then txtDescricao.Text = ""
        Dim checaobito As String
        If chkboxObito.Checked = True Then
            checaobito = "SIM"
        Else
            checaobito = "NAO"
        End If
        Dim checaRestricoes As String
        If chkboxRestricoes.Checked = True Then
            checaRestricoes = "SIM"
        Else
            checaRestricoes = "NAO"
        End If
        If testaCadastro = 0 Then
            'aqui ira inserir no banco de dados
            vgDados.Execute("INSERT INTO ANIMAL (NOMEANIMAL, NOMEDONOANIMAL, SEXOANIMAL, NASCIMENTOANIMAL, IDADEANIMAL, PESOANIMAL, CHIPANIMAL, ESPECIEANIMAL, RACAANIMAL, PELAGEMANIMAL, ALIMENTACAOANIMAL, CORANIMAL, TEMPERAMENTOANIMAL, ESTADOANIMAL, PORTEANIMAL, DISPONIVELTOSAANIMAL, PEDIGREEANIMAL, RESTRICOESANIMAL, OBITOANIMAL, DATACADASTRO, FOTO) VALUES ('" & UCase(txtAnimal.Text) & "', '" & cboCliente.Text & "','" & cboSexo.Text & "', '" & UCase(txtNascimento.Text) & "', '" & txtIdade.Text & "', '" & txtPeso.Text & "','" & txtChip.Text & "', '" & cboEspecie.Text & "','" & cboRaca.Text & "','" & cboPelagem.Text & "', '" & UCase(txtAlimentacao.Text) & "', '" & UCase(txtCor.Text) & "','" & cboTemperamento.Text & "','" & cboEstado.Text & "','" & cboPorte.Text & "', '" & chkboxDisponivel.Text & "', '" & chkboxPedigree.Text & "', '" & checaRestricoes & "', '" & checaobito & "','" & dtpCadastro.Text & "', '" & pctboxFoto.ImageLocation & "' )")
        Else
            'aqui altera no banco de dados
            vgDados.Execute("UPDATE ANIMAL SET NOMEANIMAL = '" & UCase(txtAnimal.Text) & "', NOMEDONOANIMAL = '" & cboCliente.Text & "', SEXOANIMAL = '" & cboSexo.Text & "', NASCIMENTOANIMAL = '" & UCase(txtNascimento.Text) & "', IDADEANIMAL = '" & txtIdade.Text & "', PESOANIMAL = '" & txtPeso.Text & "', CHIPANIMAL = '" & txtChip.Text & "', ESPECIEANIMAL = '" & cboEspecie.Text & "', RACAANIMAL = '" & cboRaca.Text & "', PELAGEMANIMAL = '" & cboPelagem.Text & "', ALIMENTACAOANIMAL = '" & UCase(txtAlimentacao.Text) & "', CORANIMAL = '" & UCase(txtCor.Text) & "', TEMPERAMENTOANIMAL = '" & cboTemperamento.Text & "', ESTADOANIMAL = '" & cboEstado.Text & "', PORTEANIMAL = '" & cboPorte.Text & "', DISPONIVELTOSAANIMAL = '" & chkboxDisponivel.Text & "', PEDIGREEANIMAL = '" & chkboxPedigree.Text & "', RESTRICOESANIMAL = '" & checaRestricoes & "', OBITOANIMAL = '" & checaobito & "', DATAOBITOANIMAL = '" & txtDataObito.Text & "', MOTIVOOBITOANIMAL = '" & txtObito.Text & "', DESCRICAOOBITOANIMAL = '" & txtDescricao.Text & "',DATACADASTRO = '" & dtpCadastro.Text & "', FOTO = '" & pctboxFoto.ImageLocation & "' WHERE CODIGOANIMAL = '" & txtCodigo.Text & "'")
        End If

        MsgBox("Animal salvo com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        Me.Close()
    End Sub


    Private Sub chkboxObito_CheckedChanged(sender As Object, e As EventArgs) Handles chkboxObito.CheckedChanged
        If chkboxObito.Checked = True Then
            txtDataObito.Enabled = True
            txtObito.Enabled = True
            txtDescricao.Enabled = True
        Else
            txtDataObito.Enabled = False
            txtObito.Enabled = False
            txtDescricao.Enabled = False
        End If

    End Sub

    Private Sub pfLimpaTela()
        txtCodigo.Clear() : txtAnimal.Clear() : txtNascimento.Clear() : txtIdade.Clear() : txtPeso.Clear() : txtChip.Clear() : cboEspecie.Text = "" : cboRaca.Text = ""
        cboPelagem.Text = "" : cboRaca.Text = "" : chkboxDisponivel.Checked = False : chkboxPedigree.Checked = False : chkboxRestricoes.Checked = False
        chkboxObito.Checked = False : txtAlimentacao.Clear() : txtCor.Clear() : cboTemperamento.Text = "" : cboEstado.Text = "" : cboPorte.Text = "" : txtDataObito.Clear()
        txtObito.Clear() : txtDescricao.Clear()
    End Sub


    Private Sub cboEspecie_TextChanged(sender As Object, e As EventArgs) Handles cboEspecie.TextChanged
        If cboEspecie.Text = "Cadastrar espécie" Then
            frmCadastroEspecie.ShowDialog()
            pfPreenchecboEspecie()
        End If
    End Sub

    Private Sub cboEstado_TextChanged(sender As Object, e As EventArgs) Handles cboEstado.TextChanged
        If cboEstado.Text = "Cadastrar estado" Then
            frmCadastroEstado.ShowDialog()
            pfPreenchecboEstado()

        End If
    End Sub


    Private Sub cboPelagem_TextChanged(sender As Object, e As EventArgs) Handles cboPelagem.TextChanged
        If cboPelagem.Text = "Cadastrar pelagem" Then
            frmCadastroPelagem.ShowDialog()
            pfPreenchecboPelagem()
        End If
    End Sub

    Private Sub cboPorte_TextChanged(sender As Object, e As EventArgs) Handles cboPorte.TextChanged
        If cboPorte.Text = "Cadastrar porte" Then
            frmCadastroPorte.ShowDialog()
            pfPreenchecboPorte()
        End If
    End Sub

    Private Sub cboRaca_TextChanged(sender As Object, e As EventArgs) Handles cboRaca.TextChanged
        If cboRaca.Text = "Cadastrar raça" Then
            frmCadastroRaca.ShowDialog()
            pfPreenchecboRaca()
        End If
    End Sub

    Private Sub cboTemperamento_TextChanged(sender As Object, e As EventArgs) Handles cboTemperamento.TextChanged
        If cboTemperamento.Text = "Cadastrar temperamento" Then
            frmCadastroTemperamento.ShowDialog()
            pfPreenchecboTemperamento()
        End If
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

    Private Sub txtNascimento_LostFocus(sender As Object, e As EventArgs) Handles txtNascimento.LostFocus
        pfCalculaIdade()
    End Sub

    Private Sub pctboxFoto_Click(sender As Object, e As EventArgs) Handles pctboxFoto.Click
        vfURLfoto = ofd_animal.ShowDialog
        vfURLfoto = ofd_animal.FileName
        pctboxFoto.ImageLocation = ofd_animal.FileName
    End Sub


End Class