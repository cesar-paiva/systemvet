Public Class frmPesquisaAgendamento

    Private Sub frmPesquisaAtendimento_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfBuscaAgenda()
        pfBuscaCliente()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub pfBuscaAgenda()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM AGENDA WHERE DATAAGENDA = '" & Date.Parse(dtpDataInicial.Value).ToString("MM/dd/yyyy") & "' ORDER BY VETERINARIOAGENDA, CODIGOAGENDA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOAGENDA").Value, "0##")
                    .SubItems.Add(vlRegistros("VETERINARIOAGENDA").Value)
                    .SubItems.Add(vlRegistros("DATAAGENDA").Value)
                    .SubItems.Add(vlRegistros("HORARIOAGENDA").Value)
                    .SubItems.Add(vlRegistros("CLIENTEAGENDA").Value)
                    .SubItems.Add(vlRegistros("ANIMALAGENDA").Value)
                    .SubItems.Add(vlRegistros("STATUSAGENDA").Value)
                End With

                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
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

    Private Sub dtpDataInicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataInicial.ValueChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM AGENDA WHERE DATAAGENDA = '" & Date.Parse(dtpDataInicial.Value).ToString("MM/dd/yyyy") & "'", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        End If
        While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
            Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
            With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                If vlRegistros("STATUSAGENDA").Value = "CONFIRMADO" Then
                    vfItem.ForeColor = Color.Green
                Else
                    vfItem.ForeColor = Color.Black
                End If
                .Text = Format(vlRegistros("CODIGOAGENDA").Value, "0##")
                .SubItems.Add(vlRegistros("VETERINARIOAGENDA").Value)
                .SubItems.Add(vlRegistros("DATAAGENDA").Value)
                .SubItems.Add(vlRegistros("HORARIOAGENDA").Value)
                If IsDBNull(vlRegistros("CLIENTEAGENDA").Value) Then
                    .SubItems.Add("")
                Else
                    .SubItems.Add(vlRegistros("CLIENTEAGENDA").Value)
                End If
                If IsDBNull(vlRegistros("ANIMALAGENDA").Value) Then
                    .SubItems.Add("")
                Else
                    .SubItems.Add(vlRegistros("ANIMALAGENDA").Value)
                End If
                .SubItems.Add(vlRegistros("STATUSAGENDA").Value)
            End With

            vlRegistros.MoveNext()
        End While
        vlRegistros.Close()
    End Sub

    Private Sub cboCliente_TextChanged(sender As Object, e As EventArgs) Handles cboCliente.TextChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM AGENDA WHERE CLIENTEAGENDA = '" & UCase(cboCliente.Text) & "' ", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOAGENDA").Value, "0##")
                    .SubItems.Add(vlRegistros("VETERINARIOAGENDA").Value)
                    .SubItems.Add(vlRegistros("DATAAGENDA").Value)
                    .SubItems.Add(vlRegistros("HORARIOAGENDA").Value)
                    .SubItems.Add(vlRegistros("CLIENTEAGENDA").Value)
                    .SubItems.Add(vlRegistros("ANIMALAGENDA").Value)
                    .SubItems.Add(vlRegistros("STATUSAGENDA").Value)
                End With

                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If
    End Sub

    Private Sub btnFechar_Click_1(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class