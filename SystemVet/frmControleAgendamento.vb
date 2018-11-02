Public Class frmControleAgendamento

    'Public Property ColorirHeader As Boolean
    Private Sub frmControleAgendamento_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfBuscaAgenda()
        pfBuscaVeterinario()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub pfBuscaAgenda()
        ' If cboVeterinario.Text = "" Then Exit Sub
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM AGENDA WHERE DATAAGENDA = '" & Date.Parse(dtpData.Value).ToString("MM/dd/yyyy") & "' ORDER BY VETERINARIOAGENDA, CODIGOAGENDA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    If vlRegistros("STATUSAGENDA").Value = "CONFIRMADO" Then
                        vfItem.ForeColor = Color.White
                        vfItem.BackColor = Color.Green
                        vfItem.Font = New System.Drawing.Font(vfItem.Font, FontStyle.Bold)
                    ElseIf vlRegistros("STATUSAGENDA").Value = "FINALIZADO" Then
                        vfItem.BackColor = Color.LightGray
                        vfItem.Font = New System.Drawing.Font(vfItem.Font, FontStyle.Bold)
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
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpData.ValueChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM AGENDA WHERE DATAAGENDA = '" & Date.Parse(dtpData.Value).ToString("MM/dd/yyyy") & "'", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        End If
        While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
            Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
            With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                If vlRegistros("STATUSAGENDA").Value = "CONFIRMADO" Then
                    vfItem.ForeColor = Color.White
                    vfItem.BackColor = Color.Green
                    vfItem.Font = New System.Drawing.Font(vfItem.Font, FontStyle.Bold)

                ElseIf vlRegistros("STATUSAGENDA").Value = "FINALIZADO" Then
                    vfItem.BackColor = Color.LightGray
                    vfItem.Font = New System.Drawing.Font(vfItem.Font, FontStyle.Bold)
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

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If lsvDados.SelectedItems(0).SubItems(6).Text = "CONFIRMADO" Then
            frmAtendimento.ShowDialog()
            pfBuscaAgenda()
            Exit Sub
        End If
        If lsvDados.SelectedItems(0).SubItems(6).Text = "FINALIZADO" Then
            MsgBox("Atendimento já finalizado! Não pode ser alterado.", MsgBoxStyle.Information)
            If MsgBox("Deseja visualizar o atendimento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            vfTestaStatus = "FINALIZADO"
            frmAtendimento.ShowDialog()
            vfTestaStatus = ""
        Else
            frmCadastroAgendamento.ShowDialog()
        End If
        pfBuscaAgenda()
    End Sub

    Private Sub txtDono_TextChanged(sender As Object, e As EventArgs) Handles txtDono.TextChanged
        If txtDono.Text = "" Then pfBuscaAgenda() : Exit Sub
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM AGENDA WHERE CLIENTEAGENDA LIKE '" & UCase(txtDono.Text) & "%' ORDER BY CLIENTEAGENDA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
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
                    .SubItems.Add("" & vlRegistros("ANIMALAGENDA").Value)
                    .SubItems.Add(vlRegistros("STATUSAGENDA").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If
    End Sub

    Private Sub txtAnimal_TextChanged(sender As Object, e As EventArgs) Handles txtAnimal.TextChanged
        If txtDono.Text = "" Then pfBuscaAgenda() : Exit Sub
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM AGENDA WHERE ANIMALAGENDA LIKE '" & UCase(txtAnimal.Text) & "%' ORDER BY ANIMALAGENDA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
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
                    .SubItems.Add("" & vlRegistros("ANIMALAGENDA").Value)
                    .SubItems.Add(vlRegistros("STATUSAGENDA").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If
    End Sub

    Private Sub pfBuscaVeterinario()
        cboVeterinario.Items.Clear()
        cboVeterinario.Text = ""
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM PROFISSIONAL ORDER BY NOMEPROFISSIONAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                cboVeterinario.Items.Add(vlRegistros("NOMEPROFISSIONAL").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        End If
        cboVeterinario.Items.Add("TODOS")
    End Sub

    Private Sub cboVeterinario_TextChanged(sender As Object, e As EventArgs) Handles cboVeterinario.TextChanged
        If cboVeterinario.Text = "" Then pfBuscaAgenda()
        If cboVeterinario.Text = "TODOS" Then pfBuscaAgenda() : Exit Sub
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM AGENDA WHERE DATAAGENDA = '" & Date.Parse(dtpData.Value).ToString("MM/dd/yyyy") & "'  AND VETERINARIOAGENDA = '" & UCase(cboVeterinario.Text) & "' ORDER BY VETERINARIOAGENDA", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
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
                    .SubItems.Add("" & vlRegistros("CLIENTEAGENDA").Value)
                    .SubItems.Add("" & vlRegistros("ANIMALAGENDA").Value)
                    .SubItems.Add(vlRegistros("STATUSAGENDA").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Deseja realmente cancelar o atendimento? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("UPDATE AGENDA SET CODIGOCLIENTEAGENDA = null, CLIENTEAGENDA = null, CODIGOANIMALAGENDA = null, ANIMALAGENDA = null, SERVICOS = null, STATUSAGENDA = 'DÍSPONIVEL' WHERE CODIGOAGENDA = '" & CDbl(lsvDados.SelectedItems(0).Text) & "'")
        pfBuscaAgenda()
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        frmPesquisaAgendamento.ShowDialog()
    End Sub
    'Procedimento para pintar o Header do List View
    'Precisa colocar a propriedade  Owner Draw do list view como true!
    'Private Sub lsvDados_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lsvDados.DrawColumnHeader
    '   e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds)
    '  e.DrawText()
    'End Sub

    Private Sub recuaData_Click(sender As Object, e As EventArgs) Handles recuaData.Click
        If lsvDados.Items.Count = 0 Then
            If cboVeterinario.Text = "" Then
                MsgBox("Teste")
                Exit Sub
            End If
        End If
        dtpData.Value = DateAdd("d", -1, dtpData.Value)
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM AGENDA WHERE VETERINARIOAGENDA = '" & cboVeterinario.Text & "' AND DATAAGENDA = '" & Date.Parse(dtpData.Text).ToString("MM/dd/yyyy") & "'", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        End If
        While Not vlRegistros.EOF
            Dim vfitem As New ListViewItem
            With lsvDados.Items.Add(vfitem)
                If vlRegistros("STATUSAGENDA").Value = "CONFIRMADO" Then
                    vfitem.ForeColor = Color.White
                    vfitem.BackColor = Color.Green
                    vfitem.Font = New System.Drawing.Font(vfitem.Font, FontStyle.Bold)
                ElseIf vlRegistros("STATUSAGENDA").Value = "FINALIZADO" Then
                    vfitem.BackColor = Color.LightGray
                    vfitem.Font = New System.Drawing.Font(vfitem.Font, FontStyle.Bold)
                Else
                    vfitem.ForeColor = Color.Black
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

    Private Sub avancaData_Click(sender As Object, e As EventArgs) Handles avancaData.Click
        If lsvDados.Items.Count = 0 Then
            If cboVeterinario.Text = "" Then
                MsgBox("Teste")
                Exit Sub
            End If
        End If
        dtpData.Value = DateAdd("d", +1, dtpData.Value)
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM AGENDA WHERE VETERINARIOAGENDA = '" & cboVeterinario.Text & "' AND DATAAGENDA = '" & Date.Parse(dtpData.Text).ToString("MM/dd/yyyy") & "'", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            Exit Sub
        End If
        While Not vlRegistros.EOF
            Dim vfitem As New ListViewItem
            With lsvDados.Items.Add(vfitem)
                If vlRegistros("STATUSAGENDA").Value = "CONFIRMADO" Then
                    vfitem.ForeColor = Color.White
                    vfitem.BackColor = Color.Green
                    vfitem.Font = New System.Drawing.Font(vfitem.Font, FontStyle.Bold)
                ElseIf vlRegistros("STATUSAGENDA").Value = "FINALIZADO" Then
                    vfitem.BackColor = Color.LightGray
                    vfitem.Font = New System.Drawing.Font(vfitem.Font, FontStyle.Bold)
                Else
                    vfitem.ForeColor = Color.Black
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

End Class