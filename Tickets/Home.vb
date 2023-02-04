
Public Class Home
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fr As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = "Login").SingleOrDefault()
        If fr Is Nothing Then
            Dim fmLogin As New Login
            fmLogin.MdiParent = Me
            fmLogin.Width = Me.ClientSize.Width
            fmLogin.Height = Me.ClientSize.Height
            fmLogin.Dock = DockStyle.Fill
            fmLogin.Show()
        End If
    End Sub


    'Esta funcion carga algun formulario solo pasando el nombre
    Private Sub LoadForm(formName As String)
        Dim fr As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = formName).SingleOrDefault()
        If fr Is Nothing Then
            Dim fmLoad As Form = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(ProductName & "." & formName)
            fmLoad.MdiParent = Me
            fmLoad.Show()
        End If
    End Sub


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
        Me.Close()
    End Sub
End Class
