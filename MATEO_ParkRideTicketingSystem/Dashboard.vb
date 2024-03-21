Public Class Dashboard
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim frm As New Login
        frm.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GuestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuestToolStripMenuItem.Click
        Dim frm As New GuestForm
        frm.Show()
        Me.Close()
    End Sub

    Private Sub RideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RideToolStripMenuItem.Click
        Dim frm As New RideForm
        frm.Show()
        Me.Close()
    End Sub

    Private Sub TicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketToolStripMenuItem.Click
        Dim frm As New TicketForm
        frm.Show()
        Me.Close()
    End Sub

    Private Sub AuthorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuthorToolStripMenuItem.Click
        MessageBox.Show("Student: Donna Madelene Mateo")
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ehe
    End Sub
End Class