Imports System.Text.RegularExpressions

Public Class ChangePassword

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Obtenemos el id del usuario {0}", Login.idUserLogin)
    End Sub

    Private Sub btnResetPass_Click(sender As Object, e As EventArgs) Handles btnResetPass.Click
        Dim valido As Boolean = True

        'Validamos si la nueva contraseñas contienen lo necesario
        If Not Regex.IsMatch(tbNewPass.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$") Then
            MsgBox("La contraseña debe de contener como minimo 8 caracteres, una letra mayuscula, una letra minuscula, un numero y un caracter especial")
            valido = False
        End If

        If tbNewPass.Text <> tbNewPassR.Text Then
            MsgBox("Las constraseñas nuevas no coinciden")
            valido = False
        End If


        If valido Then
            Dim strNewPassword = Hash512(tbNewPass.Text)
            Dim strActualPassword = Hash512(tbActualPass.Text)
            Dim passValido As Boolean = False

            Try
                'Validamos si la contraseña actual coincide
                Dim queryValidPass As String = "SELECT * FROM ticketsbd.users WHERE id = '" & Login.idUserLogin & "' AND password = '" & strActualPassword & "' LIMIT 1"
                Dim dt As DataTable = New DataTable
                ConsultaDataTable(queryValidPass, dt)

                'Como sabemos que solo retorna una columna entonces obtenemos la primera fila
                Dim row As DataRow = dt.Select().FirstOrDefault()

                'Aqui se valida si no esta vacio
                If Not row Is Nothing Then
                    passValido = True
                Else
                    MsgBox("La contraseña actual no coincide")
                End If

                'Liberamos los recursos del datatable

                dt.Dispose()

            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try

            'Si el pass actual es valido entonces hacemos el update
            If passValido Then
                Try
                    Dim queryUpdatePass As String = "UPDATE ticketsbd.users SET password='" & strNewPassword & "' WHERE id='" & Login.idUserLogin & "'"
                    Dim res As Integer = ConsultaNonQuery(queryUpdatePass)
                    If res > 0 Then
                        Dim resMsgBox = MsgBox("Se actualizo correctamente la contraseña")
                        If resMsgBox = 1 Then
                            Me.Close()
                        End If
                    Else
                        MsgBox("Hubo un error al actualizar la contraseña")
                    End If

                Catch ex As Exception
                    Console.WriteLine(ex.ToString())
                End Try
            End If
        End If

    End Sub
End Class