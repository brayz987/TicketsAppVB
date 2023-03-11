<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class listTickets
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dataTicket = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dataTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataTicket
        '
        Me.dataTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataTicket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.titulo, Me.estado})
        Me.dataTicket.Location = New System.Drawing.Point(58, 88)
        Me.dataTicket.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dataTicket.Name = "dataTicket"
        Me.dataTicket.RowHeadersWidth = 62
        Me.dataTicket.RowTemplate.Height = 28
        Me.dataTicket.Size = New System.Drawing.Size(648, 131)
        Me.dataTicket.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "TICKET_Id"
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 8
        Me.id.Name = "id"
        Me.id.Width = 150
        '
        'titulo
        '
        Me.titulo.DataPropertyName = "TICKET_Titulo"
        Me.titulo.HeaderText = "titulo"
        Me.titulo.MinimumWidth = 8
        Me.titulo.Name = "titulo"
        Me.titulo.Width = 600
        '
        'estado
        '
        Me.estado.DataPropertyName = "TICKET_Estado"
        Me.estado.HeaderText = "estado"
        Me.estado.MinimumWidth = 8
        Me.estado.Name = "estado"
        Me.estado.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Resultados de búsqueda"
        '
        'listTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 292)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dataTicket)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "listTickets"
        Me.Text = "listTickets"
        CType(Me.dataTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataTicket As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents titulo As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
End Class
