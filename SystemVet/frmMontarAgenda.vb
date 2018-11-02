Public Class frmMontarAgenda

    Dim tamanhos As New List(Of Integer)


    Private Sub frmMontarAgenda_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboHoraInicial.Focus()
        lsvDados.Items.Clear()
        pfPreencheHorarioInicial()
        pfPreencheHorarioFinal()
        pfPreencheIntervalo()
        pfBuscaVeterinarios()
        Dim data As New DateTime
        data = dtpInicial.Value
        txtDiaInicial.Text = WeekdayName(Weekday(data))
        'Percorre as colunas do list view e fixa o tamanho original das colunas
        For Each ch As ColumnHeader In lsvDados.Columns
            tamanhos.Add(ch.Width)
        Next
        AddHandler lsvDados.ColumnWidthChanged, AddressOf MudouTamanho
    End Sub
    'Procedimento para manter tamanho da coluna do list view fixo
    Private Sub MudouTamanho(ByVal sender As Object, ByVal e As ColumnWidthChangedEventArgs)
        ' Tenho que cancelar a assinatura aqui, senão o evento vai ser disparado
        ' pela alteração que eu faço no tamanho aqui e o evento entraria em loop
        RemoveHandler lsvDados.ColumnWidthChanged, AddressOf MudouTamanho
        lsvDados.Columns(e.ColumnIndex).Width = tamanhos(e.ColumnIndex)
        AddHandler lsvDados.ColumnWidthChanged, AddressOf MudouTamanho
    End Sub

    'Procedimento que inicilializo o list view sortido(zebra)
    'Private Sub InicializaListView()
    '   lsvDados.Sorting = SortOrder.Ascending
    'End Sub
    'Procedimento para colorir linhas (zebra)
    'Public Shared Sub zebrarListView(ByVal lv As ListView, ByVal color1 As Color, ByVal color2 As Color)
    '   For i As Integer = 0 To lv.Items.Count - 1
    '     If i Mod 2 = 0 Then 'Linhas pares
    '          lv.Items(i).BackColor = Color.White
    '        lv.Items(i).ForeColor = color1
    '   Else 'Linhas ímpares
    '      lv.Items(i).BackColor = color2
    '     lv.Items(i).ForeColor = color1
    'End If
    'Next
    'End Sub

    Private Sub pfPreencheHorarioInicial()
        cboHoraInicial.Text = ""
        cboHoraInicial.Items.Clear()
        cboHoraInicial.Items.Add("07:00")
        cboHoraInicial.Items.Add("08:00")
        cboHoraInicial.Items.Add("09:00")
        cboHoraInicial.Items.Add("10:00")
        cboHoraInicial.Items.Add("11:00")
        cboHoraInicial.Items.Add("12:00")
        cboHoraInicial.Items.Add("13:00")
        cboHoraInicial.Items.Add("14:00")
        cboHoraInicial.Items.Add("15:00")
        cboHoraInicial.Items.Add("16:00")
        cboHoraInicial.Items.Add("17:00")
        cboHoraInicial.Items.Add("18:00")
        cboHoraInicial.Items.Add("19:00")
        cboHoraInicial.Items.Add("20:00")
    End Sub

    Private Sub pfPreencheHorarioFinal()
        cboHoraFinal.Text = ""
        cboHoraFinal.Items.Clear()
        cboHoraFinal.Items.Add("07:00")
        cboHoraFinal.Items.Add("08:00")
        cboHoraFinal.Items.Add("09:00")
        cboHoraFinal.Items.Add("10:00")
        cboHoraFinal.Items.Add("11:00")
        cboHoraFinal.Items.Add("12:00")
        cboHoraFinal.Items.Add("13:00")
        cboHoraFinal.Items.Add("14:00")
        cboHoraFinal.Items.Add("15:00")
        cboHoraFinal.Items.Add("16:00")
        cboHoraFinal.Items.Add("17:00")
        cboHoraFinal.Items.Add("18:00")
        cboHoraFinal.Items.Add("19:00")
        cboHoraFinal.Items.Add("20:00")
    End Sub

    Private Sub pfPreencheIntervalo()
        cboIntervalo.Text = ""
        cboIntervalo.Items.Clear()
        cboIntervalo.Items.Add("00:20")
        cboIntervalo.Items.Add("00:30")
        cboIntervalo.Items.Add("00:45")
        cboIntervalo.Items.Add("01:00")
    End Sub

    Private Sub dtpinicial_ValueChanged(sender As Object, e As EventArgs) Handles dtpInicial.ValueChanged
        Dim data As New DateTime
        data = dtpInicial.Value
        txtDiaInicial.Text = WeekdayName(Weekday(data))
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub pfBuscaVeterinarios()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM PROFISSIONAL ORDER BY NOMEPROFISSIONAL", vgDados)
        cboVeterinario.Text = ""
        cboVeterinario.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            vlRegistros.Close()
        Else
            While Not vlRegistros.EOF
                cboVeterinario.Items.Add(vlRegistros("NOMEPROFISSIONAL").Value)
                vlRegistros.MoveNext()
            End While
            vlRegistros.Close()
        End If
    End Sub

    Private Sub btnGerar_Click(sender As Object, e As EventArgs) Handles btnGerar.Click
        If cboVeterinario.Text = "" Then
            MsgBox("Nenhum veterinário selecionado!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            cboVeterinario.Focus()
            Exit Sub
        End If

        If cboHoraInicial.Text = "" Then
            MsgBox("Nenhum horario inicial selecionado!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            cboHoraInicial.Focus()
            Exit Sub
        End If

        If cboHoraFinal.Text = "" Then
            MsgBox("Nenhum horario final selecionado!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            cboHoraFinal.Focus()
            Exit Sub
        End If

        If cboIntervalo.Text = "" Then
            MsgBox("Nenhum intervalo selecionado!", MsgBoxStyle.Critical, "SystemVet :: Erro")
            cboIntervalo.Focus()
            Exit Sub
        End If

        Dim vfinicial As Integer = 0
        Dim vffinal As Integer = 0
        Dim vfintervalo As Integer = 0

        If Mid(cboIntervalo.Text, 1, 2) = "01" Then
            vfintervalo = "0060"
        Else
            vfintervalo = Replace(cboIntervalo.Text, ":", "")
        End If

        lsvDados.Items.Clear()

        vfinicial = Replace(cboHoraInicial.Text, ":", "")
        vffinal = Replace(cboHoraFinal.Text, ":", "")


        Dim vfdata As Date = cboHoraInicial.Text

        While TimeValue(vfdata) <= TimeValue(CDate(cboHoraFinal.Text))

            Dim vfitem As New ListViewItem
            With lsvDados.Items.Add(vfitem)
                .Text = dtpInicial.Text
                .SubItems.Add(Format(vfdata, "HH:mm:ss"))
                .SubItems.Add(cboVeterinario.Text)
                .SubItems.Add("DISPONÍVEL")
                'zebrarListView(lsvDados, Color.Black, Color.LightGreen) 'Rotina para zebrar ListView
                'lsvDados.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent) 'Ajustar colunas
            End With

            vfdata = CDate(vfdata).AddMinutes(vfintervalo)
        End While

        If cboIntervalo.Text = "00:60" Then cboIntervalo.Text = "01:00"
        'Apos clicar no botao ele chama o procedimento que zebra o list view
        'Try
        'If btnGerar.CheckOnClick = True Then
        'InicializaListView()
        'End If
        'Finally
        'End Try
    End Sub

    Private Sub btnSalvarAgenda_Click(sender As Object, e As EventArgs) Handles btnSalvarAgenda.Click
        Dim vlConsulta As String
        If lsvDados.Items.Count = 0 Then Exit Sub
        If MsgBox("Confirma criacao da agenda?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM AGENDA WHERE VETERINARIOAGENDA = '" & cboVeterinario.Text & "' AND DATAAGENDA = '" & Date.Parse(dtpInicial.Text).ToString("MM/dd/yyyy") & "'", vgDados)
        If vlRegistros.RecordCount > 0 Then
            If MsgBox("Agenda já existe. Confirma Exclusao?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then vlRegistros.Close() : Exit Sub
            vgDados.Execute(" DELETE FROM AGENDA WHERE VETERINARIOAGENDA = '" & cboVeterinario.Text & "' AND DATAAGENDA = '" & Date.Parse(dtpInicial.Text).ToString("MM/dd/yyyy") & "'")
            vlRegistros.Close()
        End If
        vlRegistros.Close()
        For x = 0 To lsvDados.Items.Count - 1
            vlConsulta = "INSERT INTO AGENDA (VETERINARIOAGENDA, DATAAGENDA, HORARIOAGENDA, STATUSAGENDA) VALUES ('" & cboVeterinario.Text & "', '" & Date.Parse(dtpInicial.Value).ToString("MM/dd/yyyy") & "', '" & lsvDados.Items(x).SubItems(1).Text & "', 'DISPONIVEL')"
            vgDados.Execute(vlConsulta)
            ' vgDados.Execute("INSERT INTO COMANDOS (COMANDO, UPLOAD) VALUES ('" & Replace(vlConsulta, "'", "§") & "', 'NAO')")
        Next
        MsgBox("Agenda criada com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        Me.Close()
        frmControleAgendamento.ShowDialog()
    End Sub

End Class