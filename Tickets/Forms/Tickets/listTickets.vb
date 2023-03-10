Public Class listTickets
    Public ticketId As String
    Public tituloTicket As String
    Public idTicketSelect As String
    Private Sub listTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As DataTable = New DataTable
        Dim sql As String = "SELECT TICKET_Id,TICKET_Titulo,TICKET_Estado FROM gticket.ticket "
        If ticketId <> "" Then
            sql += "WHERE TICKET_Id=" & ticketId
        Else
            If tituloTicket <> "" Then
                sql += "WHERE TICKET_Titulo LIKE '%" & tituloTicket & "%'"
            End If
        End If

        sql += " LIMIT 10"

        ConsultaDataTable(sql, data)

        'Como sabemos que solo retorna una columna entonces obtenemos la primera fila
        Dim row As DataRow = data.Select().FirstOrDefault()

        'Aqui se valida si no esta vacio
        If Not row Is Nothing Then
            dataTicket.DataSource = data
        Else
            MsgBox("No se encontraron tickets")

        End If

        data.Dispose()
    End Sub

    Private Sub dataTicket_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataTicket.CellClick
        Home.showForm("TicketView")
        idTicketSelect = dataTicket.CurrentRow.Cells(0).Value
        Me.Hide()
    End Sub
End Class