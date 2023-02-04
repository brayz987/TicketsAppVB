Public Class SearchTicket
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadForm("TicketView")
        Me.Close()
    End Sub

    'Esta funcion carga algun formulario solo pasando el nombre
    Private Sub LoadForm(formName As String)
        Dim fr As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = formName).SingleOrDefault()
        If fr Is Nothing Then
            Dim fmLoad As Form = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(ProductName & "." & formName)
            fmLoad.MdiParent = Home
            fmLoad.Show()
        End If
    End Sub

End Class