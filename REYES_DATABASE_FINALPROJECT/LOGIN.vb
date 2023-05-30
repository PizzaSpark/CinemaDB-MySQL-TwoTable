Public Class LOGIN
    Public passwordHide As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordEye.Image = ImageList1.Images(0)
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        If username_txt.Text = "admin" And password_txt.Text = "12345" Then
            Dim frm As New LOADING
            frm.Show()
            Me.Close()

        Else
            MessageBox.Show("Incorrect username or password. Please try again.")
        End If
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Close()
    End Sub

    Private Sub passwordEye_Click(sender As Object, e As EventArgs) Handles passwordEye.Click
        If passwordHide Then
            passwordEye.Image = ImageList1.Images(1)
            passwordHide = False
            password_txt.PasswordChar = ""
        Else
            passwordEye.Image = ImageList1.Images(0)
            passwordHide = True
            password_txt.PasswordChar = "*"
        End If
    End Sub
End Class
