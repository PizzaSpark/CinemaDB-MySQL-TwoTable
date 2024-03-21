Public Class Login

    Private isLoggedIn As String
    Public passwordHide As Boolean = True

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordEye.Image = ImageList1.Images(0)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If adminName.Text = "admin" And adminPass.Text = "12345" Then
            Dim frm As New Loading
            frm.Show()
            Me.Close()

        Else
            MsgBox("Invalid Username or Password")
        End If
    End Sub

    Private Sub passwordEye_Click(sender As Object, e As EventArgs) Handles passwordEye.Click
        If passwordHide Then
            passwordEye.Image = ImageList1.Images(1)
            passwordHide = False
            adminPass.PasswordChar = ""
        Else
            passwordEye.Image = ImageList1.Images(0)
            passwordHide = True
            adminPass.PasswordChar = "*"
        End If
    End Sub
End Class
