Public Class frmContasPagar
    Public Class Utils
        ' Método que formata para moeda o conteúdo de um TextBox
        ' <param name="txt">Controle a ser formatado</param>
        Public Shared Sub formatoMoeda(ByRef txt As TextBox)
            Dim n As String = String.Empty
            Dim v As Double = 0
            Try
                n = txt.Text.Replace(",", "").Replace(".", "")
                If n.Equals("") Then n = "000"
                n = n.PadLeft(3, "0")
                If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
                v = Convert.ToDouble(n) / 100
                txt.Text = String.Format("{0:N}", v)
                txt.SelectionStart = txt.Text.Length
            Catch ex As Exception
                MessageBox.Show(ex.Message, "")
            End Try
        End Sub
    End Class
    ' Metodo que aplica o formato de moeda ao mudar o texto do TextBox de saldo
    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        Utils.formatoMoeda(txtValor)
        txtValor.Font = New System.Drawing.Font(txtValor.Font, FontStyle.Bold)
        txtValor.ForeColor = Color.Green
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub pfBuscaContas()
        vlRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vlRegistros.Open("SELECT * FROM CONTAS ORDER BY NOMECONTA", vgDados)
        cboContas.Items.Clear()
        If vlRegistros.RecordCount = 0 Then
            cboContas.Items.Add("NOVA CONTA")
            vlRegistros.Close()
            Exit Sub
        End If
        While Not vlRegistros.EOF
            cboContas.Items.Add(vlRegistros("NOMECONTA").Value)
            vlRegistros.MoveNext()
        End While
        vlRegistros.Close()
        cboContas.Items.Add("-------------------------------------------------------------------------------")
        cboContas.Items.Add("Cadastrar Nova Conta")
    End Sub

    Private Sub frmContasPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        pfLimpaTela()
        pfBuscaContas()
        cboContas.Focus()
    End Sub

    Private Sub pfLimpaTela()
        txtData.Clear() : txtOBS.Clear() : txtValor.Text = "0,00"
    End Sub

    Private Sub cmdNovo_Click(sender As Object, e As EventArgs)
        pfLimpaTela()
        pfBuscaContas()
        cboContas.Focus()
    End Sub

    Private Sub cboContas_TextChanged(sender As Object, e As EventArgs) Handles cboContas.TextChanged
        If cboContas.Text = "NOVA CONTA" Then
            frmCadastroContasaPagar.ShowDialog()
            pfBuscaContas()
        End If

    End Sub

    Private Sub txtValor_LostFocus(sender As Object, e As EventArgs) Handles txtValor.LostFocus
        If Not IsNumeric(txtValor.Text) Then
            txtValor.Text = ""
            txtValor.Focus()
            Exit Sub
        Else
            txtValor.Text = FormatNumber(txtValor.Text, 2)
        End If
    End Sub

    Private Sub txtData_GotFocus(sender As Object, e As EventArgs) Handles txtData.GotFocus
        txtData.SelectionStart = 0 : txtData.SelectionLength = Len(txtData.Text)
    End Sub

    Private Sub txtData_LostFocus(sender As Object, e As EventArgs) Handles txtData.LostFocus
        If Not IsDate(txtData.Text) Then
            txtData.Text = FormatDateTime(Now, DateFormat.ShortDate)
            txtData.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        If cboContas.Text = "" Then
            MsgBox("Você deve escolher uma conta primeiro!", MsgBoxStyle.Information, "SystemVet :: Informação")
            cboContas.Focus()
            Exit Sub
        End If
        If txtObs.Text = "" Then txtObs.Text = "-"
        If Not IsDate(txtData.Text) Then
            MsgBox("Favor inserir uma data válida!", MsgBoxStyle.Information, "SystemVet :: Informação")
            txtData.Focus()
            Exit Sub
        End If
        If txtValor.Text = "" Or txtValor.Text = "0,00" Then
            MsgBox("Favor inserir um valor para a conta!", MsgBoxStyle.Critical, "SystemVet :: Informação")
            txtValor.Focus()
            Exit Sub
        End If
        If MsgBox("Confirma inclusão da conta " & cboContas.Text & " no valor de R$ " & txtValor.Text & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("INSERT INTO CONTASPAGAR (NOMECONTA, VALORCONTA, DATACONTA, OBSCONTA) VALUES ('" & UCase(cboContas.Text) & "', '" & UCase(txtValor.Text) & "', '" & Date.Parse(txtData.Text).ToString("MM/dd/yyyy") & "', '" & UCase(txtObs.Text) & "')")
        MsgBox("Conta salva com sucesso!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
        pfLimpaTela()
        cboContas.Focus()
        Me.Close()
    End Sub

End Class