<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.pctboxPassword = New System.Windows.Forms.PictureBox()
        Me.pctboxUser = New System.Windows.Forms.PictureBox()
        Me.pctboxLogo = New System.Windows.Forms.PictureBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        CType(Me.pctboxPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctboxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(164, 189)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(58, 25)
        Me.btnFechar.TabIndex = 19
        Me.btnFechar.Text = "&Sair"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'lblLogin
        '
        Me.lblLogin.BackColor = System.Drawing.Color.White
        Me.lblLogin.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Green
        Me.lblLogin.Location = New System.Drawing.Point(10, 7)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(377, 29)
        Me.lblLogin.TabIndex = 18
        Me.lblLogin.Text = "Seja bem vindo, entre com seu login!"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pctboxPassword
        '
        Me.pctboxPassword.Image = CType(resources.GetObject("pctboxPassword.Image"), System.Drawing.Image)
        Me.pctboxPassword.Location = New System.Drawing.Point(42, 140)
        Me.pctboxPassword.Name = "pctboxPassword"
        Me.pctboxPassword.Size = New System.Drawing.Size(33, 30)
        Me.pctboxPassword.TabIndex = 17
        Me.pctboxPassword.TabStop = False
        '
        'pctboxUser
        '
        Me.pctboxUser.Image = CType(resources.GetObject("pctboxUser.Image"), System.Drawing.Image)
        Me.pctboxUser.Location = New System.Drawing.Point(42, 101)
        Me.pctboxUser.Name = "pctboxUser"
        Me.pctboxUser.Size = New System.Drawing.Size(33, 30)
        Me.pctboxUser.TabIndex = 16
        Me.pctboxUser.TabStop = False
        '
        'pctboxLogo
        '
        Me.pctboxLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pctboxLogo.Image = CType(resources.GetObject("pctboxLogo.Image"), System.Drawing.Image)
        Me.pctboxLogo.Location = New System.Drawing.Point(238, 45)
        Me.pctboxLogo.Name = "pctboxLogo"
        Me.pctboxLogo.Size = New System.Drawing.Size(200, 183)
        Me.pctboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctboxLogo.TabIndex = 15
        Me.pctboxLogo.TabStop = False
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEntrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.Location = New System.Drawing.Point(92, 189)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(67, 25)
        Me.btnEntrar.TabIndex = 14
        Me.btnEntrar.Text = "&Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.ForeColor = System.Drawing.Color.Black
        Me.txtSenha.Location = New System.Drawing.Point(75, 140)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(152, 29)
        Me.txtSenha.TabIndex = 1
        Me.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtUsuario.Location = New System.Drawing.Point(75, 101)
        Me.txtUsuario.Multiline = True
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(152, 30)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(463, 260)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.pctboxPassword)
        Me.Controls.Add(Me.pctboxUser)
        Me.Controls.Add(Me.pctboxLogo)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(479, 294)
        Me.MinimumSize = New System.Drawing.Size(479, 294)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SystemVet :: Login"
        CType(Me.pctboxPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctboxUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents pctboxPassword As System.Windows.Forms.PictureBox
    Friend WithEvents pctboxUser As System.Windows.Forms.PictureBox
    Friend WithEvents pctboxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
End Class
