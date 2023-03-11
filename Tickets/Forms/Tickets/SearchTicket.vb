Public Class SearchTicket
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        listTickets.ticketId = txtId.Text
        listTickets.tituloTicket = txtTitulo.Text
        Home.showForm("listTickets")
        Me.Close()
    End Sub
End Class