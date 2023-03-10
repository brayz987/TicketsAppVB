Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class Login


    Public idUserLogin As Integer
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim valido As Boolean = True

        If Not Regex.IsMatch(tbEmailLogin.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            MsgBox("Debe ingresar un correo valido")
            valido = False
            Exit Sub
        End If

        If valido Then
            Try
                Dim queryLogin As String = "SELECT * FROM gticket.usuario WHERE USUARIO_Correo = '" & tbEmailLogin.Text & "' AND USUARIO_Password = '" & Hash512(tbPassLogin.Text) & "' LIMIT 1"
                Dim dt As DataTable = New DataTable
                ConsultaDataTable(queryLogin, dt)

                'Como sabemos que solo retorna una columna entonces obtenemos la primera fila
                Dim row As DataRow = dt.Select().FirstOrDefault()

                'Aqui se valida si no esta vacio
                If Not row Is Nothing Then
                    'Guardamos el id del usuario que se logeo
                    idUserLogin = row("USUARIO_Id")
                    Home.Show()
                    Me.Hide()
                Else
                    MsgBox("Email o contraseña invalidos")

                End If

                dt.Dispose()

            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End If

    End Sub
End Class