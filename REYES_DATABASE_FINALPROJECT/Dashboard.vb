Imports System.Windows

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connectDB()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Dim frm As New CustomerForm
        frm.Show()
        Me.Close()
    End Sub

    Private Sub MovieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovieToolStripMenuItem.Click
        Dim frm As New MovieForm
        frm.Show()
        Me.Close()
    End Sub

    Private Sub ReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationToolStripMenuItem.Click
        Dim frm As New ReservationForm
        frm.Show()
        Me.Close()
    End Sub
End Class