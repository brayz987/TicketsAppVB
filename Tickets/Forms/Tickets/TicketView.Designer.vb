<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicketView
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
<<<<<<< Updated upstream
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDownloadFile2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDownloadFile1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbAssignedUser = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Texto = New System.Windows.Forms.DataGridViewTextBoxColumn()
=======
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDownloadFile2 = New System.Windows.Forms.Button()
        Me.btnDownloadFile1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
>>>>>>> Stashed changes
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox3
        '
<<<<<<< Updated upstream
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 4, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDownloadFile2, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDownloadFile1, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cbAssignedUser, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox2, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DataGridView1, 0, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(776, 473)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
=======
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(948, 88)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(208, 28)
        Me.ComboBox3.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(948, 608)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(210, 35)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
>>>>>>> Stashed changes
        '
        Me.Button2.Location = New System.Drawing.Point(792, 608)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 35)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Nuevo Adjunto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(620, 608)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 35)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Nuevo Comentario"
        Me.Button1.UseVisualStyleBackColor = True
        '
<<<<<<< Updated upstream
        'TextBox2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox2, 2)
        Me.TextBox2.Location = New System.Drawing.Point(94, 3)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(429, 22)
        Me.TextBox2.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(414, 438)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Nuevo Comentario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(529, 438)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Nuevo Adjunto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(633, 438)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
=======
        'TextBox3
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox3, 3)
        Me.TextBox3.Location = New System.Drawing.Point(4, 88)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(778, 110)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox2, 2)
        Me.TextBox2.Location = New System.Drawing.Point(140, 5)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(642, 32)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox1, 3)
        Me.TextBox1.Location = New System.Drawing.Point(4, 243)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TableLayoutPanel1.SetRowSpan(Me.TextBox1, 3)
        Me.TextBox1.Size = New System.Drawing.Size(778, 344)
        Me.TextBox1.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(797, 314)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Nombre Adjunto 2"
>>>>>>> Stashed changes
        '
        'btnDownloadFile2
        '
<<<<<<< Updated upstream
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Comentarios"
        '
        'TextBox3
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TextBox3, 3)
        Me.TextBox3.Location = New System.Drawing.Point(3, 57)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TableLayoutPanel1.SetRowSpan(Me.TextBox3, 2)
        Me.TextBox3.Size = New System.Drawing.Size(520, 109)
        Me.TextBox3.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(532, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Nombre Adjunto 2"
        '
        'btnDownloadFile2
        '
        Me.btnDownloadFile2.Location = New System.Drawing.Point(633, 226)
        Me.btnDownloadFile2.Name = "btnDownloadFile2"
        Me.btnDownloadFile2.Size = New System.Drawing.Size(140, 23)
        Me.btnDownloadFile2.TabIndex = 16
        Me.btnDownloadFile2.Text = "Descargar"
        Me.btnDownloadFile2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(532, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Nombre Adjunto 1"
        '
        'btnDownloadFile1
        '
        Me.btnDownloadFile1.Location = New System.Drawing.Point(633, 195)
        Me.btnDownloadFile1.Name = "btnDownloadFile1"
        Me.btnDownloadFile1.Size = New System.Drawing.Size(140, 23)
        Me.btnDownloadFile1.TabIndex = 14
        Me.btnDownloadFile1.Text = "Descargar"
        Me.btnDownloadFile1.UseVisualStyleBackColor = True
=======
        Me.btnDownloadFile2.Location = New System.Drawing.Point(948, 300)
        Me.btnDownloadFile2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDownloadFile2.Name = "btnDownloadFile2"
        Me.btnDownloadFile2.Size = New System.Drawing.Size(210, 35)
        Me.btnDownloadFile2.TabIndex = 16
        Me.btnDownloadFile2.Text = "Descargar"
        Me.btnDownloadFile2.UseVisualStyleBackColor = True
        '
        'btnDownloadFile1
        '
        Me.btnDownloadFile1.Location = New System.Drawing.Point(948, 243)
        Me.btnDownloadFile1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDownloadFile1.Name = "btnDownloadFile1"
        Me.btnDownloadFile1.Size = New System.Drawing.Size(210, 35)
        Me.btnDownloadFile1.TabIndex = 14
        Me.btnDownloadFile1.Text = "Descargar"
        Me.btnDownloadFile1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(948, 5)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(208, 28)
        Me.ComboBox1.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(797, 256)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Nombre Adjunto 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 203)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Comentarios"
>>>>>>> Stashed changes
        '
        'Label7
        '
        Me.Label7.AutoSize = True
<<<<<<< Updated upstream
        Me.Label7.Location = New System.Drawing.Point(529, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
=======
        Me.Label7.Location = New System.Drawing.Point(792, 203)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
>>>>>>> Stashed changes
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Adjuntos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
<<<<<<< Updated upstream
        Me.Label5.Location = New System.Drawing.Point(529, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Usuario Asignado"
        '
        'cbAssignedUser
        '
        Me.cbAssignedUser.FormattingEnabled = True
        Me.cbAssignedUser.Location = New System.Drawing.Point(633, 87)
        Me.cbAssignedUser.Name = "cbAssignedUser"
        Me.cbAssignedUser.Size = New System.Drawing.Size(140, 21)
        Me.cbAssignedUser.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(529, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cola"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(633, 57)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox2.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(529, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estado"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(633, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(529, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "ID"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(633, 3)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(140, 20)
        Me.TextBox4.TabIndex = 21
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Usuario, Me.Texto})
        Me.TableLayoutPanel1.SetColumnSpan(Me.DataGridView1, 3)
        Me.DataGridView1.Location = New System.Drawing.Point(3, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.TableLayoutPanel1.SetRowSpan(Me.DataGridView1, 3)
        Me.DataGridView1.Size = New System.Drawing.Size(520, 237)
        Me.DataGridView1.TabIndex = 22
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        '
        'Texto
        '
        Me.Texto.HeaderText = "Texto"
        Me.Texto.Name = "Texto"
        Me.Texto.Width = 275
=======
        Me.Label5.Location = New System.Drawing.Point(792, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Usuario Asignado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(792, 43)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cola"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(792, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titulo"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(948, 48)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(208, 28)
        Me.ComboBox2.TabIndex = 12
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox2, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox1, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDownloadFile1, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDownloadFile2, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 4, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBox3, 4, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 18)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1169, 655)
        Me.TableLayoutPanel1.TabIndex = 0
>>>>>>> Stashed changes
        '
        'TicketView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< Updated upstream
        Me.ClientSize = New System.Drawing.Size(800, 497)
=======
        Me.ClientSize = New System.Drawing.Size(1200, 692)
>>>>>>> Stashed changes
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "TicketView"
        Me.ShowIcon = False
        Me.Text = "TicketView"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
<<<<<<< Updated upstream
    Friend WithEvents cbAssignedUser As ComboBox
    Friend WithEvents btnDownloadFile1 As Button
    Friend WithEvents btnDownloadFile2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Texto As DataGridViewTextBoxColumn
=======
    Friend WithEvents btnDownloadFile1 As Button
    Friend WithEvents btnDownloadFile2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
>>>>>>> Stashed changes
End Class
