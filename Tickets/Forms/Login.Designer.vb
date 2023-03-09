<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbEmailLogin = New System.Windows.Forms.TextBox()
        Me.tbPassLogin = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 364)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Constraseña"
        '
        'tbEmailLogin
        '
        Me.tbEmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbEmailLogin.Location = New System.Drawing.Point(88, 320)
        Me.tbEmailLogin.Name = "tbEmailLogin"
        Me.tbEmailLogin.Size = New System.Drawing.Size(196, 13)
        Me.tbEmailLogin.TabIndex = 3
        '
        'tbPassLogin
        '
        Me.tbPassLogin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPassLogin.Location = New System.Drawing.Point(88, 361)
        Me.tbPassLogin.Name = "tbPassLogin"
        Me.tbPassLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassLogin.Size = New System.Drawing.Size(196, 13)
        Me.tbPassLogin.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(269, 266)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(239, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(260, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(88, 333)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(196, 3)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(88, 374)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(196, 3)
        Me.Panel2.TabIndex = 10
        '
        'btnLogin
        '
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.Location = New System.Drawing.Point(239, 393)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(51, 36)
        Me.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(302, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbPassLogin)
        Me.Controls.Add(Me.tbEmailLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbEmailLogin As TextBox
    Friend WithEvents tbPassLogin As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogin As PictureBox
End Class
