Public Class frmCadastroAgendamento
    Private Sub frmCadastroAgendamento_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboAnimal.Text = ""
        cboAnimal.Items.Clear()
        txtCelular.Clear()
        txtTelefone.Clear()
        If frmControleAgendamento.lsvDados.SelectedIndices.Count > 0 Then
            txtAtendimento.Text = frmControleAgendamento.lsvDados.SelectedItems(0).Text
            txtVeterinario.Text = frmControleAgendamento.lsvDados.SelectedItems(0).SubItems(1).Text
            txtData.Text = FormatDateTime(frmControleAgendamento.dtpData.Value, DateFormat.ShortDate)
            txtHora.Text = frmControleAgendamento.lsvDados.SelectedItems(0).SubItems(3).Text
            Dim data As New DateTime
            data = txtData.Text
            txtDiaSemana.Text = WeekdayName(Weekday(data))
            cboAnimal.Enabled = False

        End If
        pfBuscaServicos()
        pfbuscaClientes()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub pfbuscaClientes()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CLIENTES ORDER BY NOMEPESSOAFISICA", vgDados)
        cboCLientes.Items.Clear()
        cboCLientes.Text = ""
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        Else
            While Not vlRegistros.EOF
                cboCLientes.Items.Add(Format(CDbl(vlRegistros("CODIGOPESSOAFISICA").Value), "0#####") & " - " & vlRegistros("NOMEPESSOAFISICA").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        End If
    End Sub
   
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If cboServicos.Text = "" Then
            MsgBox("Campo SERVIÇOS em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro ")
            cboServicos.Select()
            Exit Sub
        End If
        If cboCLientes.Text = "" Then
            MsgBox("Campo CLIENTES em branco!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            cboCLientes.Select()
            Exit Sub
        End If
        If MsgBox("Confirma agendamento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pergunta") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("UPDATE AGENDA SET CODIGOCLIENTEAGENDA = '" & Mid(cboCLientes.Text, 1, 6) & "', CLIENTEAGENDA = '" & Mid(cboCLientes.Text, 10, 100) & "', CODIGOANIMALAGENDA = '" & Mid(cboAnimal.Text, 1, 6) & "', ANIMALAGENDA = '" & Mid(cboAnimal.Text, 10, 100) & "', SERVICOS = '" & UCase(cboServicos.Text) & "', STATUSAGENDA = 'CONFIRMADO' WHERE CODIGOAGENDA = '" & CDbl(frmControleAgendamento.lsvDados.SelectedItems(0).Text) & "'")
        Me.Close()
    End Sub

    'Private Sub pfBuscaCliente()
    '    vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
    '    vlRegistros.Open("SELECT * FROM CLIENTES ORDER BY NOMEPESSOAFISICA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
    '    cboCLientes.Items.Clear()
    '    cboCLientes.Text = ""
    '    If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
    '        vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
    '        Exit Sub
    '    Else ' aqui é se quantidade de registros dor maior que zero
    '        While Not vlRegistros.EOF
    '            cboCLientes.Items.Add(vlRegistros("NOMEPESSOAFISICA").Value)
    '            vlRegistros.MoveNext()
    '        End While
    '        vlRegistros.Close()
    '    End If

    'End Sub

    Private Sub pfBuscaServicos()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM SERVICO ORDER BY DESCRICAO", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        cboServicos.Items.Clear()
        cboServicos.Text = ""
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF
                cboServicos.Items.Add(vlRegistros("DESCRICAO").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        End If

    End Sub

    Private Sub cboCLientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCLientes.SelectedIndexChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM ANIMAL WHERE NOMEDONOANIMAL = '" & Mid(cboCLientes.Text, 10, 100) & "' ORDER BY NOMEANIMAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        cboAnimal.Enabled = True
        cboAnimal.Items.Clear()
        cboAnimal.Text = ""
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            cboAnimal.Text = "NÃO POSSUI ANIMAL"
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF
                cboAnimal.Items.Add(Format(vlRegistros("CODIGOANIMAL").Value, "0#####") & " - " & vlRegistros("NOMEANIMAL").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        End If
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM CLIENTES WHERE NOMEPESSOAFISICA = '" & Mid(cboCLientes.Text, 10, 100) & "' ORDER BY NOMEPESSOAFISICA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            txtTelefone.Clear() : txtCelular.Clear()
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            txtTelefone.Text = (vlRegistros("TELEFONEPESSOAFISICA").Value)
            txtCelular.Text = (vlRegistros("CELULARPESSOAFISICA").Value)
            vlRegistros.Close()
        End If
    End Sub

End Class