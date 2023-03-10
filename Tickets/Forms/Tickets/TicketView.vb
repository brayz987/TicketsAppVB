﻿Public Class TicketView
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

    End Sub

End Class