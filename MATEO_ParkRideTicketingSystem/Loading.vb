Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Loading

    Public Shared value As Integer = 0
    Public Shared loadingScreenText As String = ""

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        value += 1

        ProgressBar1.Value += 1

        If value > 90 Then
            loadingScreenText = "Loading Complete"
        ElseIf value > 60 Then
            loadingScreenText = "Loading Modules"
        ElseIf value > 30 Then
            loadingScreenText = "Loading Forms"
        Else
            loadingScreenText = "Loading"
        End If

        txtLoad.Text = String.Format("Loading {0}%", value)
        txtLoading.Text = String.Format("{0}", loadingScreenText)

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