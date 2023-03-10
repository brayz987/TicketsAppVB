Public Class CreateTicket
    Private Sub CreateTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreateTicket.Click
        Dim validate As Boolean = True
        Dim titulo As String = txtTitulo.Text
        Dim descripcion As String = txtDescripcion.Text
        Dim cola As Integer = listCola.SelectedIndex + 1
        Dim estado As Integer = listEstado.SelectedIndex + 1

        If titulo = "" Then
            MsgBox("Debe ingresar un titulo")
            validate = False
            Exit Sub
        End If

        If descripcion = "" Then
            MsgBox("Debe ingresar una descripción")
            validate = False
            Exit Sub
        End If

        If listCola.SelectedIndex = -1 Then
            MsgBox("Debe asignar una cola al ticket")
            validate = False
            Exit Sub
        End If

        If listEstado.SelectedIndex = -1 Then
            MsgBox("Debe asignar una estado al ticket")
            validate = False
            Exit Sub
        End If

        If validate Then
            Dim sql As String = "INSERT INTO gticket.ticket (TICKET_IdProyecto,TICKET_IdUsuarioCreo,TICKET_Titulo,TICKET_Asunto,TICKET_Cola,TICKET_Estado) VALUES(1," & Login.idUserLogin & ",'" & titulo & "','" & descripcion & "'," & cola & "," & estado & ")"
            Dim res As Integer = ConsultaNonQuery(sql)

            If res > 0 Then
                MsgBox("Se creo el ticket satisfactoriamente")
                Me.Close()
            Else
                MsgBox("Hubo un error al crear el ticket")
            End If
        End If
    End Sub
End Class

