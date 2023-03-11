Public Class TicketView
    Private Sub TicketView_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim sql As String = "SELECT USUARIO_Id, CONCAT(USUARIO_Nombre, ' ', USUARIO_Apellido) as nombre  FROM gticket.usuario"
            Dim dt As DataTable = New DataTable
            ConsultaDataTable(sql, dt)
            cbAssignedUser.ValueMember = "USUARIO_Id"
            cbAssignedUser.DisplayMember = "nombre"
            cbAssignedUser.DataSource = dt
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try

        Me.getTicket(listTickets.idTicketSelect)
    End Sub

    Public Sub getTicket(idThisTicket As String)
        Try
            Dim sqlGet As String = "SELECT TICKET_Id,TICKET_Titulo,TICKET_Asunto,TICKET_Estado,TICKET_Cola,TICKET_IdUsuarioAsignado FROM gticket.ticket WHERE TICKET_Id=" & idThisTicket
            Dim data As DataTable = New DataTable
            ConsultaDataTable(sqlGet, data)
            'Como sabemos que solo retorna un registro entonces obtenemos la primera fila
            Dim row As DataRow = data.Select().FirstOrDefault()

            'Aqui se valida si no esta vacio
            If Not row Is Nothing Then
                'Asignamos valores a los campos del ticket
                Console.WriteLine(row("TICKET_Titulo"))
                Console.WriteLine(row("TICKET_Asunto"))
                txtDescripcionView.Text = row("TICKET_Asunto")
                txtIdView.Text = row("TICKET_Id")
            Else
                MsgBox("No se encontro el ticket")
            End If

            data.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
    End Sub

End Class