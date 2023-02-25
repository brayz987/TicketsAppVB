Public Class AdminUsers
    Private Sub btnQueryUsers_Click(sender As Object, e As EventArgs) Handles btnQueryUsers.Click
        Try
            Dim queryUser As String = "SELECT id, name, lastname, email, rol FROM ticketsbd.users"
            Consulta(queryUser, dgvUsers)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try


    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick

        Dim id As String = dgvUsers.CurrentRow.Cells(0).Value
        txtName.Text = dgvUsers.CurrentRow.Cells(1).Value
        txtLastName.Text = dgvUsers.CurrentRow.Cells(2).Value
        txtCorreo.Text = dgvUsers.CurrentRow.Cells(3).Value
        cbRol.DropDownStyle = ComboBoxStyle.DropDownList
        Dim tipo As String = dgvUsers.CurrentRow.Cells(4).Value
        If (tipo = 1) Then
            cbRol.SelectedIndex = 0
        ElseIf (tipo = 2) Then
            cbRol.SelectedIndex = 1
        Else
            cbRol.SelectedIndex = 2
        End If


    End Sub
End Class