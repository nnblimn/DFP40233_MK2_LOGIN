<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOG
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnLogin = New Button()
        txtKataLaluan = New TextBox()
        txtId = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = SystemColors.GradientActiveCaption
        BtnLogin.Location = New Point(76, 252)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(94, 29)
        BtnLogin.TabIndex = 0
        BtnLogin.Text = "LOG IN"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtKataLaluan
        ' 
        txtKataLaluan.Location = New Point(50, 198)
        txtKataLaluan.Name = "txtKataLaluan"
        txtKataLaluan.Size = New Size(162, 27)
        txtKataLaluan.TabIndex = 1
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(50, 130)
        txtId.Name = "txtId"
        txtId.Size = New Size(162, 27)
        txtId.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(76, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 17)
        Label1.TabIndex = 3
        Label1.Text = "ID PENGGUNA "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(76, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 17)
        Label2.TabIndex = 4
        Label2.Text = "KATA LALUAN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(39, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(200, 41)
        Label3.TabIndex = 5
        Label3.Text = "LOG MASUK "
        Label3.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' LOG
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(247, 319)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtId)
        Controls.Add(txtKataLaluan)
        Controls.Add(BtnLogin)
        Name = "LOG"
        Text = "LOGIN "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents txtKataLaluan As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
