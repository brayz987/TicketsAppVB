<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginNuevo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbUserNew = New System.Windows.Forms.TextBox()
        Me.tbPasswordNew = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbUserNew
        '
        Me.tbUserNew.Location = New System.Drawing.Point(26, 111)
        Me.tbUserNew.Name = "tbUserNew"
        Me.tbUserNew.Size = New System.Drawing.Size(183, 20)
        Me.tbUserNew.TabIndex = 0
        '
        'tbPasswordNew
        '
        Me.tbPasswordNew.Location = New System.Drawing.Point(26, 162)
        Me.tbPasswordNew.Name = "tbPasswordNew"
        Me.tbPasswordNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPasswordNew.Size = New System.Drawing.Size(183, 20)
        Me.tbPasswordNew.TabIndex = 1
        '
        'LoginNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 298)
        Me.Controls.Add(Me.tbPasswordNew)
        Me.Controls.Add(Me.tbUserNew)
        Me.Name = "LoginNuevo"
        Me.Text = "LoginNuevo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUserNew As TextBox
    Friend WithEvents tbPasswordNew As TextBox
End Class
