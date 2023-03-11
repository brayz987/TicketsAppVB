
Public Class Home
    Private Sub Home_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    'Esta funcion carga algun formulario solo pasando el nombre
    Private Function LoadForm(formName As String) As Form
        Dim fr As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = formName).SingleOrDefault()
        If fr Is Nothing Then
            Dim fmLoad As Form = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(ProductName & "." & formName)
            fmLoad.MdiParent = Me
            fmLoad.Show()
            fr = fmLoad
        End If
        Return fr
    End Function


    Private Sub CreateUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateUserToolStripMenuItem.Click
        LoadForm("CreateUser")
    End Sub

    Private Sub CreateTicketToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CreateTicketToolStripMenuItem2.Click
        LoadForm("CreateTicket")
    End Sub

    Private Sub SearchTicketToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchTicketToolStripMenuItem1.Click
        LoadForm("SearchTicket")
    End Sub

    Private Sub ChangePassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePassToolStripMenuItem.Click
        LoadForm("ChangePassword")
    End Sub

    Private Sub CloseSessionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CloseSessionToolStripMenuItem1.Click
        End
    End Sub

    Private Sub AdminUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminUsersToolStripMenuItem.Click
        LoadForm("AdminUsers")
    End Sub

    Public Function showForm(form As String) As Form
        Return LoadForm(form)
    End Function

End Class
