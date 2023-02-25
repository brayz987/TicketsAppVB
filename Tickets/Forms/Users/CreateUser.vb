Public Class CreateUser

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click

        Dim queryCreateUser As String = "INSERT INTO ticketsbd.users(name, lastname, email, password,rol) 
                                        VALUES ('" & tbNameUser.Text & "','" & tbLastNameUser.Text & "','" & tbEmailUser.Text & "','" & tbPasswordUser.Text & "','" & cbBoxUser.SelectedIndex + 1 & "')"

        createNew(queryCreateUser)



    End Sub
End Class