'Imports MySql.Data.MySqlClient

Module mdlSystemVet



    'definicao variavel de conexao com o banco de dados
    'Public cnn As New MySqlConnection
    'Public cmd As New MySqlCommand


    ' definição das variavéis de conexão com o banco de dados
    Public vgDados As New ADODB.Connection 'aqui declara a variavel vgDados(variavel global) como conexao

    ' definicao da variavel de registros
    Public vlRegistros As New ADODB.Recordset ' aqui declara a variavel vlRegistros(varaivel local) que seria o select no banco.

    Public vfCodigoUsuario As Integer
    Public vfNomeUsuario As String = ""
    Public testaCadastro As Integer
    Public vftestaProduto As String = ""
    Public vfTestaStatus As String = ""
    Public vfTestaNivelAcesso As String = ""
    Public vfUsuarioLogado As String = ""
    Public vfverificaTela As String = ""
    Public foto As String = ""
    Public vfTestaForm As Integer

    'Public Sub verificaVariavelReg()
    '    If (vlRegistros.State = 0) Then 'estado 0 = aberto estado 1 = fechado
    '        vlRegistros.Close()
    '    Else
    '        vlRegistros.Open()
    '    End If
    'End Sub


    Public Sub conecta()
        Dim arquivo As String
        On Error GoTo error_handler
        ' arquivo txt para conexão com o Firebird
        arquivo = My.Computer.FileSystem.ReadAllText("C:\SystemVet\SystemVet\conexao.txt")
        vgDados.Open("DRIVER=Firebird/Interbase(r) driver; UID=SYSDBA;PWD=masterkey; DBNAME=" & arquivo & "SYSTEMVET.FDB")

        'arquivo txt para conexão com o SQL SERVER
        'arquivo = My.Computer.FileSystem.ReadAllText("C:\- SISTEMAS\ProjetoSenac\ProjetoSenac\conexaoSQLSERVER.txt")
        'sintaxe de conexao com PROVIDER do SQL SERVER
        'vgDados.Open("Driver={SQL Server Native Client 11.0};Uid=systemvet;Pwd=Pa$$w0rd;" & arquivo & ";Database=ProjetoSenac;")
        Exit Sub

error_handler:
        MsgBox("Erro de conexão! " & vbCrLf & Err.Description, MsgBoxStyle.Critical, "SystemVet : Erro")
        End

    End Sub
    'Public Sub desconecta()
    '    If vgDados.State = 1 Then
    '        vgDados.Close()
    '    End If
    'End Sub

    'conecta banco remoto
    'Public Sub conectaweb()
    '    Try
    '        cnn.ConnectionString = ("Server=192.185.216.45;Database=glauc751_cwc;uid=glauc751_cwc;pwd='cWc2014';")
    '        cnn.Open()
    '        MsgBox("Conexão web bem sucedida!", MsgBoxStyle.Information)
    '        Exit Sub
    '    Catch ex As Exception
    '        MsgBox("Falha na conexão!" & Err.Description, MsgBoxStyle.Critical)
    '        Exit Sub
    '    End Try
    'End Sub
End Module
