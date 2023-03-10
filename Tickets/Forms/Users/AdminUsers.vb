Imports System.Text.RegularExpressions

Public Class AdminUsers



    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick

        txtIdUser.Text = dgvUsers.CurrentRow.Cells(0).Value
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

    Private Sub AdminUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReLoadUsers()
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click


        'Primero hacemos validaciones

        Dim valido As Boolean = True

        If txtName.Text = "" Then
            MsgBox("Debe ingresar un nombre")
            valido = False
        End If

        If txtLastName.Text = "" Then
            MsgBox("Debe ingresar un apellido")
            valido = False
        End If


        If cbRol.SelectedIndex = -1 Then
            MsgBox("Debe de escoger un rol")
            valido = False
        End If

        If Not Regex.IsMatch(txtCorreo.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            MsgBox("Debe ingresar un correo valido")
            valido = False
        End If

        If valido Then
            Try
                Dim queryEditUser As String = "UPDATE gticket.usuario SET USUARIO_Nombre='" & txtName.Text & "',USUARIO_Apellido='" & txtLastName.Text & "',USUARIO_Correo='" & txtCorreo.Text & "',USUARIO_Rol='" & cbRol.SelectedIndex + 1 & "' WHERE USUARIO_Id='" & txtIdUser.Text & "'"
                Dim res As Integer = ConsultaNonQuery(queryEditUser)
                If res > 0 Then
                    MsgBox("Se edito el usuario correctamente")
                    ReLoadUsers()
                Else
                    MsgBox("Hubo un error al editar el usuario")
                End If

            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End If

    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Dim answerMB As Integer
        answerMB = MsgBox("Seguro que desea eliminar el usuario con el correo " & txtCorreo.Text, vbYesNo + vbExclamation + vbDefaultButton2)
        If answerMB = vbYes Then
            Try
                Dim queryEditUser As String = "UPDATE gticket.usuario SET USUARIO_Eliminado = 1 WHERE USUARIO_Id='" & txtIdUser.Text & "'"
                Dim res As Integer = ConsultaNonQuery(queryEditUser)
                If res > 0 Then
                    MsgBox("Se ha eliminado el usuario exitosamente")
                    ReLoadUsers()
                Else
                    MsgBox("Hubo un error al eliminar el usuario")
                End If

            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End If
    End Sub


    Private Sub ReLoadUsers()
        Try
            Dim queryUser As String = "SELECT USUARIO_Id, USUARIO_Nombre, USUARIO_Apellido, USUARIO_Correo, USUARIO_Rol FROM gticket.usuario WHERE USUARIO_Eliminado = 0"
            Dim tempDt As DataTable = New DataTable
            ConsultaDataTable(queryUser, tempDt)
            dgvUsers.DataSource = tempDt
            tempDt.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        cleanText()
    End Sub

    Private Sub cleanText()
        txtIdUser.Text = ""
        txtName.Text = ""
        txtLastName.Text = ""
        txtCorreo.Text = ""
        cbRol.SelectedValue = -1
    End Sub

End Class