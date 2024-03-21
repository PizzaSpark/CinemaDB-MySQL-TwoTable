<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtLoading = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtLoad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'txtLoading
        '
        Me.txtLoading.AutoSize = True
        Me.txtLoading.BackColor = System.Drawing.Color.Transparent
        Me.txtLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoading.Location = New System.Drawing.Point(35, 159)
        Me.txtLoading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtLoading.Name = "txtLoading"
        Me.txtLoading.Size = New System.Drawing.Size(26, 36)
        Me.txtLoading.TabIndex = 5
        Me.txtLoading.Text = "-"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(41, 199)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(725, 28)
        Me.ProgressBar1.TabIndex = 4
        '
        'txtLoad
        '
        Me.txtLoad.AutoSize = True
        Me.txtLoad.BackColor = System.Drawing.Color.Transparent
        Me.txtLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoad.Location = New System.Drawing.Point(478, 244)
        Me.txtLoad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtLoad.Name = "txtLoad"
        Me.txtLoad.Size = New System.Drawing.Size(288, 36)
        Me.txtLoad.TabIndex = 3
        Me.txtLoad.Text = "loading please wait"
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtLoading)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtLoad)
        Me.Name = "Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtLoading As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents txtLoad As Label
End Class
