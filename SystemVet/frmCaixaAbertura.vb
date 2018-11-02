Public Class frmCaixaAbertura

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
    Private Sub txtSaldo_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged
        Utils.formatoMoeda(txtSaldo)
        txtSaldo.Font = New System.Drawing.Font(txtSaldo.Font, FontStyle.Bold)
        txtSaldo.ForeColor = Color.Green
    End Sub

    Private Sub frmCaixa_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtData.Text = FormatDateTime(Now, DateFormat.ShortDate)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("Deseja cancelar lançamento do saldo inicial?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        vgDados.Close()
        End
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If MsgBox("Confirma lançamento do saldo inicial do dia?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SystemVet :: Pergunta") = MsgBoxResult.No Then Exit Sub
        vgDados.Execute("INSERT INTO CAIXA (DATACAIXA, SALDOINICIALCAIXA, CODIGOUSUARIO, NOMEUSUARIO, STATUSCAIXA) VALUES ('" & Date.Parse(txtData.Text).ToString("MM/dd/yyyy") & "', '" & txtSaldo.Text & "', '" & vfCodigoUsuario & "', '" & vfNomeUsuario & "', 'ABERTO')")
        MsgBox("Caixa iniciado com sucesso!", MsgBoxStyle.Information, "SYstemVet :: Sucesso")
        Me.Close()
    End Sub
End Class