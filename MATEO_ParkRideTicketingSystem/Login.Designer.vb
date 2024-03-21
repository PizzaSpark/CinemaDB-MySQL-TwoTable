<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.passwordEye = New System.Windows.Forms.PictureBox()
        Me.adminName = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.adminPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.passwordEye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'passwordEye
        '
        Me.passwordEye.BackColor = System.Drawing.Color.Transparent
        Me.passwordEye.ImageLocation = ""
        Me.passwordEye.Location = New System.Drawing.Point(536, 192)
        Me.passwordEye.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordEye.Name = "passwordEye"
        Me.passwordEye.Size = New System.Drawing.Size(49, 36)
        Me.passwordEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passwordEye.TabIndex = 36
        Me.passwordEye.TabStop = False
        '
        'adminName
        '
        Me.adminName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminName.Location = New System.Drawing.Point(278, 112)
        Me.adminName.Margin = New System.Windows.Forms.Padding(4)
        Me.adminName.Name = "adminName"
        Me.adminName.Size = New System.Drawing.Size(249, 34)
        Me.adminName.TabIndex = 33
        '
        'btnLogin
        '
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLogin.Location = New System.Drawing.Point(307, 316)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(195, 32)
        Me.btnLogin.TabIndex = 35
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(143, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 29)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Login :"
        '
        'adminPass
        '
        Me.adminPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminPass.Location = New System.Drawing.Point(278, 192)
        Me.adminPass.Margin = New System.Windows.Forms.Padding(4)
        Me.adminPass.Name = "adminPass"
        Me.adminPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.adminPass.Size = New System.Drawing.Size(249, 34)
        Me.adminPass.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(143, 193)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 29)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Password :"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-closed-eye-90.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-eye-90.png")
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.passwordEye)
        Me.Controls.Add(Me.adminName)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.adminPass)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.passwordEye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents passwordEye As PictureBox
    Friend WithEvents adminName As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents adminPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ImageList1 As ImageList
End Class
