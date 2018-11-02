Imports System.Data.SqlClient
Imports FirebirdSql.Data.FirebirdClient
Public Class frmBackup

    Private Sub pctboxBackup_Click(sender As Object, e As EventArgs) Handles pctboxBackup.Click
        Dim iCnt As Integer = 0
        ProgressBar1.Value = 0
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = 500000

        For iCnt = 1 To 499999
            Me.ProgressBar1.Value = Me.ProgressBar1.Value + 1
        Next


        '-------------------------------------------------------------SQL SERVER -----------------------------------------------------------------------

        Dim conexaoSQLServer As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProjetoSenac"
        Dim conexao As New SqlConnection(conexaoSQLServer)

        Try
            ' comando para fazer o backup do Banco de dados
            Dim nomeDB As String = "ProjetoSenac"
            Dim backupFile As String = "C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\Backup\SYSTEMVET.bak"
            Dim cmdBackup As New SqlCommand("BACKUP DATABASE [" & nomeDB & "] TO DISK = '" & backupFile & "'", conexao)
            conexao.Open()
            cmdBackup.ExecuteNonQuery()
            MsgBox("Backup realizado com sucesso em " & FormatDateTime(Date.Now, DateFormat.ShortDate) & "!", MsgBoxStyle.Information, "SystemVet :: Sucesso")
            conexao.Close()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao fazer cópia de segurança.Tente novamente, se o erro persistir reinicie o sistema.", MsgBoxStyle.Information, "SystemVet :: Erro")
        Finally
            conexao.Close()
        End Try

        '-------------------------------------------------------------SQL SERVER -----------------------------------------------------------------------

        '-------------------------------------------------------------FIREBIRD -----------------------------------------------------------------------



        Dim conn As New FbConnection
        Dim csb As FbConnectionStringBuilder

        csb = New FbConnectionStringBuilder
        csb.UserID = "SYSDBA"
        csb.Password = "masterkey"
        csb.Database = "f:\test\testdb.fdb"
        csb.ServerType = 1
        conn = New FbConnection(csb.ToString())
        conn.Open()

        '-------------------------------------------------------------FIREBIRD -----------------------------------------------------------------------
    End Sub
End Class