Imports System.Text.RegularExpressions

Public Class CreateUser

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click

        'Primero hacemos validaciones

        Dim valido As Boolean = True

        If tbNameUser.Text = "" Then
            MsgBox("Debe ingresar un nombre")
            valido = False
        End If

        If tbLastNameUser.Text = "" Then
            MsgBox("Debe ingresar un apellido")
            valido = False
        End If


        If cbBoxUser.SelectedIndex = -1 Then
            MsgBox("Debe de escoger un rol")
            valido = False
        End If

        If Not Regex.IsMatch(tbEmailUser.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            MsgBox("Debe ingresar un correo valido")
            valido = False
        End If


        If Not Regex.IsMatch(tbPasswordUser.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$") Then
            MsgBox("La contraseña debe de contener como minimo 8 caracteres, una letra mayuscula, una letra minuscula, un numero y un caracter especial")
            valido = False
        End If


        If tbPasswordUser.Text <> tbRPasswordUser.Text Then
            MsgBox("Las constraseñas no coinciden")
            valido = False
        End If

        Dim strPassword = Hash512(tbPasswordUser.Text)

        If valido Then
            Dim queryCreateUser As String = "INSERT INTO ticketsbd.users(name, lastname, email, password,rol) 
                                        VALUES ('" & tbNameUser.Text & "','" & tbLastNameUser.Text & "','" & tbEmailUser.Text & "','" & strPassword & "','" & cbBoxUser.SelectedIndex + 1 & "')"

            Dim res As Integer = ConsultaNonQuery(queryCreateUser)

            If res > 0 Then
                MsgBox("Se creo el usuario satisfactoriamente")
                Me.Close()
            Else
                MsgBox("Hubo un error al crear el usuario")
            End If
        End If



    End Sub
End Class