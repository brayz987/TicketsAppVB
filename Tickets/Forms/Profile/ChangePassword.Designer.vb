<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNewPassR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNewPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbActualPass = New System.Windows.Forms.TextBox()
        Me.btnResetPass = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.57367!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.42633!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbNewPassR, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbNewPass, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbActualPass, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(319, 87)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Repetir Contraseña"
        '
        'tbNewPassR
        '
        Me.tbNewPassR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbNewPassR.Location = New System.Drawing.Point(142, 62)
        Me.tbNewPassR.Name = "tbNewPassR"
        Me.tbNewPassR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbNewPassR.Size = New System.Drawing.Size(174, 20)
        Me.tbNewPassR.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nueva Contraseña"
        '
        'tbNewPass
        '
        Me.tbNewPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbNewPass.Location = New System.Drawing.Point(142, 33)
        Me.tbNewPass.Name = "tbNewPass"
        Me.tbNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbNewPass.Size = New System.Drawing.Size(174, 20)
        Me.tbNewPass.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña Actual"
        '
        'tbActualPass
        '
        Me.tbActualPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbActualPass.Location = New System.Drawing.Point(142, 4)
        Me.tbActualPass.Name = "tbActualPass"
        Me.tbActualPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbActualPass.Size = New System.Drawing.Size(174, 20)
        Me.tbActualPass.TabIndex = 1
        '
        'btnResetPass
        '
        Me.btnResetPass.Location = New System.Drawing.Point(253, 110)
        Me.btnResetPass.Name = "btnResetPass"
        Me.btnResetPass.Size = New System.Drawing.Size(75, 23)
        Me.btnResetPass.TabIndex = 1
        Me.btnResetPass.Text = "Actualizar"
        Me.btnResetPass.UseVisualStyleBackColor = True
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 145)
        Me.Controls.Add(Me.btnResetPass)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ChangePassword"
        Me.ShowIcon = False
        Me.Text = "ChangePassword"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNewPassR As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNewPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbActualPass As TextBox
    Friend WithEvents btnResetPass As Button
End Class
