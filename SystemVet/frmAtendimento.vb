Public Class frmAtendimento

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub frmAtendimento_Load(sender As Object, e As EventArgs) Handles Me.Load
        If vfTestaStatus = "FINALIZADO" Then
            txtAtendimento.Enabled = False
            txtVeterinario.Enabled = False
            dtpEntrada.Enabled = False
            txtHoraEntrada.Enabled = False
            dtpSaida.Enabled = False
            txtHoraSaida.Enabled = False
            txtCliente.Enabled = False
            txtTelefone.Enabled = False
            txtVeterinario.Enabled = False
            txtTotalProduto.Enabled = False
            txtTotalServico.Enabled = False
            txtDesconto.Enabled = False
            txtValorTotal.Enabled = False
            btnNovoProduto.Enabled = False
            btnExcluir.Enabled = False
            btnFinalizar.Enabled = False
            lblAtendimento.Select()

        Else
            txtAtendimento.Enabled = True
            txtVeterinario.Enabled = True
            dtpEntrada.Enabled = True
            txtHoraEntrada.Enabled = True
            dtpSaida.Enabled = True
            txtHoraSaida.Enabled = True
            txtCliente.Enabled = True
            txtTelefone.Enabled = True
            txtVeterinario.Enabled = True
            txtTotalProduto.Enabled = True
            txtTotalServico.Enabled = True
            txtDesconto.Enabled = True
            txtValorTotal.Enabled = True
            btnNovoProduto.Enabled = True
            btnExcluir.Enabled = True
        End If
        txtAtendimento.Text = frmControleAgendamento.lsvDados.SelectedItems(0).Text
        txtVeterinario.Text = frmControleAgendamento.lsvDados.SelectedItems(0).SubItems(1).Text
        txtVeterinario.Enabled = False
        txtVeterinario.BorderStyle = BorderStyle.None
        dtpEntrada.Value = frmControleAgendamento.lsvDados.SelectedItems(0).SubItems(2).Text
        txtHoraEntrada.Text = frmControleAgendamento.lsvDados.SelectedItems(0).SubItems(3).Text
        txtCliente.Text = frmControleAgendamento.lsvDados.SelectedItems(0).SubItems(4).Text
        txtCliente.Enabled = False
        txtCliente.BorderStyle = BorderStyle.None
        lblAnimal.Text = frmControleAgendamento.lsvDados.SelectedItems(0).SubItems(5).Text
        lblAtendimento.Select()
        txtDesconto.Text = "0,00"
        pfBuscaTelefone()
        pfBuscaAnimal()
        pfAtualiza()

        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM ATENDIMENTO WHERE CODATENDIMENTO = '" & txtAtendimento.Text & "'", vgDados)
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
            If MsgBox("Deseja criar um Novo Atendimento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'aqui ira inserir no banco de dados
                vgDados.Execute("INSERT INTO ATENDIMENTO (CODATENDIMENTO, DATAATENDIMENTO, HORAATENDIMENTO, CLIENTEATENDIMENTO, ANIMALATENDIMENTO, TOTALATENDIMENTO, DESCONTOATENDIMENTO, VETERINARIOATENDIMENTO) VALUES ('" & txtAtendimento.Text & "', '" & Date.Parse(dtpEntrada.Value).ToString("MM/dd/yyyy") & "', '" & txtHoraEntrada.Text & "', '" & UCase(txtCliente.Text) & "', '" & lblAnimal.Text & "', '" & txtValorTotal.Text & "', '" & txtDesconto.Text & "', '" & txtVeterinario.Text & "')")
            Else
                Me.Close()
            End If
        Else
            txtDesconto.Text = vlRegistros("DESCONTOATENDIMENTO").Value
            vlRegistros.Close()
        End If
        pfbuscaItens()
        pfAtualiza()
    End Sub

    Private Sub pfAtualiza()
        Dim vfTotalProdutos As Double = 0
        Dim vfTotalServicos As Double = 0
        For x = 0 To lsvDados.Items.Count - 1
            If lsvDados.Items(x).SubItems(5).Text = "PRODUTO" Then
                vfTotalProdutos = vfTotalProdutos + (lsvDados.Items(x).SubItems(2).Text * lsvDados.Items(x).SubItems(3).Text)
            Else
                vfTotalServicos = vfTotalServicos + (lsvDados.Items(x).SubItems(2).Text * lsvDados.Items(x).SubItems(3).Text)
            End If
        Next
        txtTotalProduto.Text = FormatNumber(vfTotalProdutos, 2)
        txtTotalServico.Text = FormatNumber(vfTotalServicos, 2)
        If txtDesconto.Text = "" Then
            txtDesconto.Text = "0,00"
        End If
        txtValorTotal.Text = FormatNumber(vfTotalProdutos + vfTotalServicos - CDbl(txtDesconto.Text), 2)
        vgDados.Execute("UPDATE ATENDIMENTO SET TOTALATENDIMENTO = '" & txtValorTotal.Text & "' WHERE CODATENDIMENTO = '" & txtAtendimento.Text & "' ")
    End Sub

    Private Sub pfBuscaTelefone()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CLIENTES WHERE NOMEPESSOAFISICA = '" & txtCliente.Text & "'", vgDados)
        If vlRegistros.RecordCount <> 0 Then
            txtTelefone.Text = vlRegistros("TELEFONEPESSOAFISICA").Value
        End If
        vlRegistros.Close()
        txtTelefone.Enabled = False
        txtTelefone.BorderStyle = BorderStyle.None
    End Sub

    Private Sub pfBuscaAnimal()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM ANIMAL WHERE NOMEANIMAL = '" & lblAnimal.Text & "'", vgDados)
        If vlRegistros.RecordCount <> 0 Then
            lblEspecie.Text = vlRegistros("ESPECIEANIMAL").Value
            lblSexo.Text = vlRegistros("SEXOANIMAL").Value
            lblPelagem.Text = vlRegistros("PELAGEMANIMAL").Value
            lblNascimento.Text = vlRegistros("NASCIMENTOANIMAL").Value
            lblPeso.Text = vlRegistros("PESOANIMAL").Value
            lblRaca.Text = vlRegistros("RACAANIMAL").Value
            lblPorte.Text = vlRegistros("PORTEANIMAL").Value
            lblEstado.Text = vlRegistros("ESTADOANIMAL").Value
        End If
        vlRegistros.Close()
    End Sub

    Private Sub btnNovoProduto_Click(sender As Object, e As EventArgs) Handles btnNovoProduto.Click
        frmIncluiProduto.ShowDialog()
        pfbuscaItens()
        pfAtualiza()
    End Sub

    Private Sub pfbuscaItens()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM ITEMATENDIMENTO WHERE CODATENDIMENTO = '" & txtAtendimento.Text & "'", vgDados)
        lsvDados.Items.Clear()
        If vlRegistros.RecordCount <> 0 Then
            While Not vlRegistros.EOF
                Dim vfitem As New ListViewItem
                With lsvDados.Items.Add(vfitem)
                    .Text = vlRegistros("CODITEM").Value
                    .SubItems.Add(vlRegistros("DESCRICAOITEM").Value)
                    .SubItems.Add(vlRegistros("VALORITEM").Value)
                    .SubItems.Add(vlRegistros("QUANTIDADEITEM").Value)
                    .SubItems.Add(vlRegistros("CODITENSATENDIMENTO").Value)
                    .SubItems.Add("" & vlRegistros("TIPO").Value)
                End With
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        Else
            vlRegistros.Close()
        End If

    End Sub
    Private Sub Alterar_Click(sender As Object, e As EventArgs)
        frmInserirItem.ShowDialog()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If lsvDados.Items.Count = 0 Then Exit Sub
        If lsvDados.SelectedIndices.Count = 0 Then Exit Sub
        If MsgBox("Deseja excluir" & lsvDados.SelectedItems(0).SubItems(1).Text & "da lista?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("DELETE FROM ITEMATENDIMENTO WHERE CODITENSATENDIMENTO = '" & lsvDados.SelectedItems(0).SubItems(4).Text & "'")
        pfbuscaItens()
        pfAtualiza()
    End Sub

    Private Sub txtDesconto_LostFocus(sender As Object, e As EventArgs) Handles txtDesconto.LostFocus
        If Not IsNumeric(txtDesconto.Text) Then
            txtDesconto.Text = "0,00"
            txtDesconto.Focus()
        Else
            txtDesconto.Text = FormatNumber(txtDesconto.Text, 2)
            vgDados.Execute("UPDATE ATENDIMENTO SET DESCONTOATENDIMENTO = '" & txtDesconto.Text & "' WHERE CODATENDIMENTO = '" & txtAtendimento.Text & "' ")
            pfAtualiza()
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If MsgBox("Deseja finalizar o atendimento ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Dim vfEstoque As Integer = 0
        For x = 0 To lsvDados.Items.Count - 1
            If lsvDados.Items(x).SubItems(5).Text = "PRODUTO" Then
                vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                vlRegistros.Open("SELECT * FROM PRODUTO WHERE CODIGO = '" & lsvDados.Items(x).Text & "'", vgDados)
                vfEstoque = vlRegistros("ESTOQUEATUAL").Value - lsvDados.Items(x).SubItems(3).Text
                vlRegistros.Close()
                vgDados.Execute("UPDATE PRODUTO SET ESTOQUEATUAL = '" & vfEstoque & "' WHERE CODIGO = '" & lsvDados.Items(x).Text & "'")
            End If
        Next
        vgDados.Execute("UPDATE AGENDA SET STATUSAGENDA = 'FINALIZADO' WHERE CODIGOAGENDA = '" & txtAtendimento.Text & "'")
        MsgBox("Atendimento Finalizado com Sucesso!", MsgBoxStyle.Information)
        Me.Close()
    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs)
    '    dtpSaida.Value = Now
    '    txtHoraSaida.Text = Format(Now, "HH:mm:ss")
    'End Sub
End Class