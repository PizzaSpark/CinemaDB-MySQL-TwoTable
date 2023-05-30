<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.passwordEye = New System.Windows.Forms.PictureBox()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.passwordEye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'passwordEye
        '
        Me.passwordEye.Location = New System.Drawing.Point(578, 182)
        Me.passwordEye.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.passwordEye.Name = "passwordEye"
        Me.passwordEye.Size = New System.Drawing.Size(29, 30)
        Me.passwordEye.TabIndex = 9
        Me.passwordEye.TabStop = False
        '
        'cancel_btn
        '
        Me.cancel_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.cancel_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cancel_btn.Location = New System.Drawing.Point(416, 243)
        Me.cancel_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(93, 42)
        Me.cancel_btn.TabIndex = 8
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = False
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.login_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.login_btn.Location = New System.Drawing.Point(316, 243)
        Me.login_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(94, 42)
        Me.login_btn.TabIndex = 7
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'password_txt
        '
        Me.password_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.password_txt.Location = New System.Drawing.Point(316, 182)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.password_txt.MaxLength = 50
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.Size = New System.Drawing.Size(251, 30)
        Me.password_txt.TabIndex = 6
        '
        'username_txt
        '
        Me.username_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.username_txt.Location = New System.Drawing.Point(316, 146)
        Me.username_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.username_txt.MaxLength = 50
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(251, 30)
        Me.username_txt.TabIndex = 5
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-closed-eye-90.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-eye-90.png")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 48)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "MOVIE TICKET RESERVATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(109, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 30)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ADMIN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(109, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 30)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "PASSWORD"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passwordEye)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.username_txt)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN "
        CType(Me.passwordEye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents passwordEye As PictureBox
    Friend WithEvents cancel_btn As Button
    Friend WithEvents login_btn As Button
    Friend WithEvents password_txt As TextBox
    Friend WithEvents username_txt As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
