Public Class frmBuscaAnimal
    Private Sub frmBuscaAnimal_Load(sender As Object, e As EventArgs) Handles Me.Load
        pfBuscaAnimal()
        pfPreenchecboTipoFiltro()

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
            testaCadastro = 0
            frmCadastroAnimais.ShowDialog()
            testaCadastro = 0
            pfBuscaAnimal()
    End Sub

    Private Sub pfBuscaAnimal() ' esse procedimento que atualiza o list view
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM ANIMAL ORDER BY NOMEANIMAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOANIMAL").Value, "0##")
                    .SubItems.Add(vlRegistros("NOMEANIMAL").Value)
                    .SubItems.Add(vlRegistros("SEXOANIMAL").Value)
                    .SubItems.Add(vlRegistros("RACAANIMAL").Value)
                    .SubItems.Add(vlRegistros("ESPECIEANIMAL").Value)
                    .SubItems.Add("" & vlRegistros("NOMEDONOANIMAL").Value)
                    .SubItems.Add(vlRegistros("NASCIMENTOANIMAL").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Deseja  excluir o animal " & lsvDados.SelectedItems(0).SubItems(1).Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet  :: Pergunta ") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM ANIMAL WHERE CODIGOANIMAL = '" & lsvDados.SelectedItems(0).Text & "'")

        MsgBox("Animal excluído com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfBuscaAnimal()
    End Sub


    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        If lsvDados.Items.Count = 0 Then Exit Sub
        testaCadastro = 1
        frmCadastroAnimais.ShowDialog()
        'frmCadastroAnimais.txtCodigo.Text = lsvDados.SelectedItems(0).Text
        'frmCadastroAnimais.txtAnimal.Text = lsvDados.SelectedItems(0).SubItems(1).Text
        'frmCadastroAnimais.cboSexo.Text = lsvDados.SelectedItems(0).SubItems(2).Text
        'frmCadastroAnimais.cboRaca.Text = lsvDados.SelectedItems(0).SubItems(3).Text
        'frmCadastroAnimais.cboEspecie.Text = lsvDados.SelectedItems(0).SubItems(4).Text
        'frmCadastroAnimais.txtNascimento.Text = lsvDados.SelectedItems(0).SubItems(6).Text
        testaCadastro = 0
        pfBuscaAnimal()

    End Sub

    Private Sub txtBuscaAnimal_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaAnimal.TextChanged
         vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM ANIMAL WHERE NOMEANIMAL LIKE '" & UCase(txtBuscaAnimal.Text) & "%' ORDER BY NOMEANIMAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOANIMAL").Value, "0##")
                    .SubItems.Add(vlRegistros("NOMEANIMAL").Value)
                    .SubItems.Add(vlRegistros("SEXOANIMAL").Value)
                    .SubItems.Add(vlRegistros("RACAANIMAL").Value)
                    .SubItems.Add(vlRegistros("ESPECIEANIMAL").Value)
                    .SubItems.Add("" & vlRegistros("NOMEDONOANIMAL").Value)
                    .SubItems.Add(vlRegistros("NASCIMENTOANIMAL").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If
    End Sub

    Private Sub txtBuscaDono_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaDono.TextChanged
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
        vlRegistros.Open("SELECT * FROM ANIMAL WHERE NOMEDONOANIMAL LIKE '" & UCase(txtBuscaDono.Text) & "%' ORDER BY NOMEDONOANIMAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
            vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
            Exit Sub
        Else ' aqui é se quantidade de registros dor maior que zero
            While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                    .Text = Format(vlRegistros("CODIGOANIMAL").Value, "0##")
                    .SubItems.Add(vlRegistros("NOMEANIMAL").Value)
                    .SubItems.Add(vlRegistros("SEXOANIMAL").Value)
                    .SubItems.Add(vlRegistros("RACAANIMAL").Value)
                    .SubItems.Add(vlRegistros("ESPECIEANIMAL").Value)
                    .SubItems.Add("" & vlRegistros("NOMEDONOANIMAL").Value)
                    .SubItems.Add(vlRegistros("NASCIMENTOANIMAL").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
        End If
    End Sub

    Private Sub pfPreenchecboTipoFiltro()
        cboTipoFiltro.Text = ""
        cboTipoFiltro.Items.Clear()
        cboTipoFiltro.Items.Add("Ordenar por Dono")
        cboTipoFiltro.Items.Add("Ordenar por Animal")
        cboTipoFiltro.Items.Add("Ordenar por Código")
        cboTipoFiltro.Items.Add("Ordenar por Espécie")
        cboTipoFiltro.Items.Add("Ordenar por Raça")
        cboTipoFiltro.Items.Add("Ordenar por Sexo")
    End Sub

    Private Sub cboTipoFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoFiltro.SelectedIndexChanged
        If cboTipoFiltro.Text = "Ordenar por Dono" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM ANIMAL ORDER BY NOMEDONOANIMAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGOANIMAL").Value, "0##")
                        .SubItems.Add(vlRegistros("NOMEANIMAL").Value)
                        .SubItems.Add(vlRegistros("SEXOANIMAL").Value)
                        .SubItems.Add(vlRegistros("RACAANIMAL").Value)
                        .SubItems.Add(vlRegistros("ESPECIEANIMAL").Value)
                        .SubItems.Add("" & vlRegistros("NOMEDONOANIMAL").Value)
                        .SubItems.Add(vlRegistros("NASCIMENTOANIMAL").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        ElseIf cboTipoFiltro.Text = "Ordenar por Animal" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM ANIMAL ORDER BY NOMEANIMAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGOANIMAL").Value, "0##")
                        .SubItems.Add(vlRegistros("NOMEANIMAL").Value)
                        .SubItems.Add(vlRegistros("SEXOANIMAL").Value)
                        .SubItems.Add(vlRegistros("RACAANIMAL").Value)
                        .SubItems.Add(vlRegistros("ESPECIEANIMAL").Value)
                        .SubItems.Add("" & vlRegistros("NOMEDONOANIMAL").Value)
                        .SubItems.Add(vlRegistros("NASCIMENTOANIMAL").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        ElseIf cboTipoFiltro.Text = "Ordenar por Código" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM ANIMAL ORDER BY CODIGOANIMAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGOANIMAL").Value, "0##")
                        .SubItems.Add(vlRegistros("NOMEANIMAL").Value)
                        .SubItems.Add(vlRegistros("SEXOANIMAL").Value)
                        .SubItems.Add(vlRegistros("RACAANIMAL").Value)
                        .SubItems.Add(vlRegistros("ESPECIEANIMAL").Value)
                        .SubItems.Add("" & vlRegistros("NOMEDONOANIMAL").Value)
                        .SubItems.Add(vlRegistros("NASCIMENTOANIMAL").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        ElseIf cboTipoFiltro.Text = "Ordenar por Espécie" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM ANIMAL ORDER BY ESPECIEANIMAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGOANIMAL").Value, "0##")
                        .SubItems.Add(vlRegistros("NOMEANIMAL").Value)
                        .SubItems.Add(vlRegistros("SEXOANIMAL").Value)
                        .SubItems.Add(vlRegistros("RACAANIMAL").Value)
                        .SubItems.Add(vlRegistros("ESPECIEANIMAL").Value)
                        .SubItems.Add("" & vlRegistros("NOMEDONOANIMAL").Value)
                        .SubItems.Add(vlRegistros("NASCIMENTOANIMAL").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        ElseIf cboTipoFiltro.Text = "Ordenar por Raça" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM ANIMAL ORDER BY RACAANIMAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGOANIMAL").Value, "0##")
                        .SubItems.Add(vlRegistros("NOMEANIMAL").Value)
                        .SubItems.Add(vlRegistros("SEXOANIMAL").Value)
                        .SubItems.Add(vlRegistros("RACAANIMAL").Value)
                        .SubItems.Add(vlRegistros("ESPECIEANIMAL").Value)
                        .SubItems.Add("" & vlRegistros("NOMEDONOANIMAL").Value)
                        .SubItems.Add(vlRegistros("NASCIMENTOANIMAL").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        ElseIf cboTipoFiltro.Text = "Ordenar por Sexo" Then
            vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient 'define que a busca será executada na maquina cliente
            vlRegistros.Open("SELECT * FROM ANIMAL ORDER BY SEXOANIMAL", vgDados) ' aqui vai abrir a variavel de registros vlRegistros através da variavel de conexão vgDados
            lsvDados.Items.Clear()
            If vlRegistros.RecordCount = 0 Then 'aqui testa se a quantidade de registros é igual a zero
                vlRegistros.Close() ' se for igual a zero fecha a variavel de registros
                Exit Sub
            Else ' aqui é se quantidade de registros dor maior que zero
                While Not vlRegistros.EOF ' aqui enquanto não for fim de arquivo executa a instrução dentro do while
                    Dim vfItem As New ListViewItem ' aqui cria as linhas do list view
                    With lsvDados.Items.Add(vfItem) ' aqui adiciona as colunas 
                        .Text = Format(vlRegistros("CODIGOANIMAL").Value, "0##")
                        .SubItems.Add(vlRegistros("NOMEANIMAL").Value)
                        .SubItems.Add(vlRegistros("SEXOANIMAL").Value)
                        .SubItems.Add(vlRegistros("RACAANIMAL").Value)
                        .SubItems.Add(vlRegistros("ESPECIEANIMAL").Value)
                        .SubItems.Add("" & vlRegistros("NOMEDONOANIMAL").Value)
                        .SubItems.Add(vlRegistros("NASCIMENTOANIMAL").Value)
                    End With
                    vlRegistros.MoveNext()
                End While
                vlRegistros.Close() ' aqui quando chega no fim do arquivo fecha a variavel de registros
            End If
        End If
    End Sub


End Class