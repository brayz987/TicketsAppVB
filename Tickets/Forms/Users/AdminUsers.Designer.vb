<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminUsers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.USUARIO_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO_Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO_Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO_Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbRol = New System.Windows.Forms.ComboBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.txtIdUser = New System.Windows.Forms.TextBox()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.USUARIO_Id, Me.USUARIO_Nombre, Me.USUARIO_Apellido, Me.USUARIO_Correo, Me.USUARIO_Rol})
        Me.dgvUsers.Location = New System.Drawing.Point(458, 11)
        Me.dgvUsers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.RowHeadersWidth = 62
        Me.dgvUsers.Size = New System.Drawing.Size(814, 314)
        Me.dgvUsers.TabIndex = 0
        '
        'USUARIO_Id
        '
        Me.USUARIO_Id.DataPropertyName = "USUARIO_Id"
        Me.USUARIO_Id.HeaderText = "ID"
<<<<<<< Updated upstream
        Me.USUARIO_Id.Name = "USUARIO_Id"
=======
        Me.USUARIO_Id.MinimumWidth = 8
        Me.USUARIO_Id.Name = "USUARIO_Id"
        Me.USUARIO_Id.Width = 150
>>>>>>> Stashed changes
        '
        'USUARIO_Nombre
        '
        Me.USUARIO_Nombre.DataPropertyName = "USUARIO_Nombre"
        Me.USUARIO_Nombre.HeaderText = "Nombre"
<<<<<<< Updated upstream
        Me.USUARIO_Nombre.Name = "USUARIO_Nombre"
=======
        Me.USUARIO_Nombre.MinimumWidth = 8
        Me.USUARIO_Nombre.Name = "USUARIO_Nombre"
        Me.USUARIO_Nombre.Width = 150
>>>>>>> Stashed changes
        '
        'USUARIO_Apellido
        '
        Me.USUARIO_Apellido.DataPropertyName = "USUARIO_Apellido"
        Me.USUARIO_Apellido.HeaderText = "Apellido"
<<<<<<< Updated upstream
        Me.USUARIO_Apellido.Name = "USUARIO_Apellido"
=======
        Me.USUARIO_Apellido.MinimumWidth = 8
        Me.USUARIO_Apellido.Name = "USUARIO_Apellido"
        Me.USUARIO_Apellido.Width = 150
>>>>>>> Stashed changes
        '
        'USUARIO_Correo
        '
        Me.USUARIO_Correo.DataPropertyName = "USUARIO_Correo"
        Me.USUARIO_Correo.HeaderText = "Correo"
<<<<<<< Updated upstream
        Me.USUARIO_Correo.Name = "USUARIO_Correo"
=======
        Me.USUARIO_Correo.MinimumWidth = 8
        Me.USUARIO_Correo.Name = "USUARIO_Correo"
        Me.USUARIO_Correo.Width = 150
>>>>>>> Stashed changes
        '
        'USUARIO_Rol
        '
        Me.USUARIO_Rol.DataPropertyName = "USUARIO_Rol"
        Me.USUARIO_Rol.HeaderText = "Rol"
<<<<<<< Updated upstream
        Me.USUARIO_Rol.Name = "USUARIO_Rol"
=======
        Me.USUARIO_Rol.MinimumWidth = 8
        Me.USUARIO_Rol.Name = "USUARIO_Rol"
        Me.USUARIO_Rol.Width = 150
>>>>>>> Stashed changes
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbRol, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLastName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCorreo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 18)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(414, 226)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'cbRol
        '
        Me.cbRol.FormattingEnabled = True
        Me.cbRol.Items.AddRange(New Object() {"Super Administrador", "Administrador", "Colaborador"})
        Me.cbRol.Location = New System.Drawing.Point(176, 173)
        Me.cbRol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbRol.Name = "cbRol"
        Me.cbRol.Size = New System.Drawing.Size(230, 28)
        Me.cbRol.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(176, 59)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(230, 26)
        Me.txtLastName.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(176, 5)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(230, 26)
        Me.txtName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(176, 113)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(230, 26)
        Me.txtCorreo.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 168)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Rol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres"
        '
        'btnEditUser
        '
        Me.btnEditUser.Location = New System.Drawing.Point(309, 254)
        Me.btnEditUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(123, 71)
        Me.btnEditUser.TabIndex = 8
        Me.btnEditUser.Text = "Editar"
        Me.btnEditUser.UseVisualStyleBackColor = True
        '
        'txtIdUser
        '
        Me.txtIdUser.Location = New System.Drawing.Point(27, -17)
        Me.txtIdUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIdUser.Name = "txtIdUser"
        Me.txtIdUser.Size = New System.Drawing.Size(148, 26)
        Me.txtIdUser.TabIndex = 9
        Me.txtIdUser.Visible = False
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Location = New System.Drawing.Point(177, 254)
        Me.btnDeleteUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(123, 71)
        Me.btnDeleteUser.TabIndex = 10
        Me.btnDeleteUser.Text = "Eliminar"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'AdminUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 351)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.txtIdUser)
        Me.Controls.Add(Me.btnEditUser)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.dgvUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AdminUsers"
        Me.Text = "AdminUsers"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cbRol As ComboBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditUser As Button
    Friend WithEvents txtIdUser As TextBox
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents USUARIO_Id As DataGridViewTextBoxColumn
    Friend WithEvents USUARIO_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents USUARIO_Apellido As DataGridViewTextBoxColumn
    Friend WithEvents USUARIO_Correo As DataGridViewTextBoxColumn
    Friend WithEvents USUARIO_Rol As DataGridViewTextBoxColumn
End Class
