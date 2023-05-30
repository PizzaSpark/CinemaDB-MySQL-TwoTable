Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LOADING

    Public Shared value As Integer = 0
    Public Shared loadingScreenText As String = ""
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        value += 1

        ProgressBar1.Value += 1

        If value > 90 Then
            loadingScreenText = "complete"
        ElseIf value > 60 Then
            loadingScreenText = "database"
        ElseIf value > 30 Then
            loadingScreenText = "dashboard"
        Else
            loadingScreenText = "forms"
        End If

        loading_txt.Text = String.Format("Loading {0}", loadingScreenText)

        If value >= ProgressBar1.Maximum Then
            Timer1.Enabled = False
            value = 0
            Dim frm As New Dashboard
            frm.Show()
            Me.Close()
            Exit Sub
        End If
    End Sub




End Class