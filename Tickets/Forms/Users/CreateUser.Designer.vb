<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNameUser = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbBoxUser = New System.Windows.Forms.ComboBox()
        Me.tbPasswordUser = New System.Windows.Forms.TextBox()
        Me.tbLastNameUser = New System.Windows.Forms.TextBox()
        Me.tbRPasswordUser = New System.Windows.Forms.TextBox()
        Me.tbEmailUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Repetir Contraseña"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contraseña"
        '
        'tbNameUser
        '
        Me.tbNameUser.Location = New System.Drawing.Point(118, 3)
        Me.tbNameUser.Name = "tbNameUser"
        Me.tbNameUser.Size = New System.Drawing.Size(155, 20)
        Me.tbNameUser.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbBoxUser, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbPasswordUser, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbLastNameUser, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbNameUser, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbRPasswordUser, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tbEmailUser, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(24, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(276, 247)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'cbBoxUser
        '
        Me.cbBoxUser.FormattingEnabled = True
        Me.cbBoxUser.Items.AddRange(New Object() {"Super Administrador", "Administrador", "Colaborador"})
        Me.cbBoxUser.Location = New System.Drawing.Point(118, 118)
        Me.cbBoxUser.Name = "cbBoxUser"
        Me.cbBoxUser.Size = New System.Drawing.Size(155, 21)
        Me.cbBoxUser.TabIndex = 8
        '
        'tbPasswordUser
        '
        Me.tbPasswordUser.Location = New System.Drawing.Point(118, 156)
        Me.tbPasswordUser.Name = "tbPasswordUser"
        Me.tbPasswordUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPasswordUser.Size = New System.Drawing.Size(155, 20)
        Me.tbPasswordUser.TabIndex = 9
        '
        'tbLastNameUser
        '
        Me.tbLastNameUser.Location = New System.Drawing.Point(118, 41)
        Me.tbLastNameUser.Name = "tbLastNameUser"
        Me.tbLastNameUser.Size = New System.Drawing.Size(155, 20)
        Me.tbLastNameUser.TabIndex = 6
        '
        'tbRPasswordUser
        '
        Me.tbRPasswordUser.Location = New System.Drawing.Point(118, 196)
        Me.tbRPasswordUser.Name = "tbRPasswordUser"
        Me.tbRPasswordUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbRPasswordUser.Size = New System.Drawing.Size(155, 20)
        Me.tbRPasswordUser.TabIndex = 7
        '
        'tbEmailUser
        '
        Me.tbEmailUser.Location = New System.Drawing.Point(118, 79)
        Me.tbEmailUser.Name = "tbEmailUser"
        Me.tbEmailUser.Size = New System.Drawing.Size(155, 20)
        Me.tbEmailUser.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Rol"
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(214, 277)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(86, 28)
        Me.btnCreateUser.TabIndex = 7
        Me.btnCreateUser.Text = "Crear"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'CreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 335)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CreateUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Usuario"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbNameUser As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tbPasswordUser As TextBox
    Friend WithEvents tbEmailUser As TextBox
    Friend WithEvents tbRPasswordUser As TextBox
    Friend WithEvents tbLastNameUser As TextBox
    Friend WithEvents btnCreateUser As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbBoxUser As ComboBox
End Class
