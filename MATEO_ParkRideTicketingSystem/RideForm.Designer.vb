<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RideForm
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
        Me.ridewaittimetxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ridedurationtxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.homebtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rideseatcapacitytxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ridenametxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchridebtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rideIDtxt = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ridewaittimetxt
        '
        Me.ridewaittimetxt.Enabled = False
        Me.ridewaittimetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ridewaittimetxt.Location = New System.Drawing.Point(567, 207)
        Me.ridewaittimetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.ridewaittimetxt.Name = "ridewaittimetxt"
        Me.ridewaittimetxt.Size = New System.Drawing.Size(189, 30)
        Me.ridewaittimetxt.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(562, 175)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 25)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Wait Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(632, 175)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 25)
        Me.Label7.TabIndex = 80
        '
        'ridedurationtxt
        '
        Me.ridedurationtxt.Enabled = False
        Me.ridedurationtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ridedurationtxt.Location = New System.Drawing.Point(301, 207)
        Me.ridedurationtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.ridedurationtxt.Name = "ridedurationtxt"
        Me.ridedurationtxt.Size = New System.Drawing.Size(189, 30)
        Me.ridedurationtxt.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 175)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Duration"
        '
        'deletebtn
        '
        Me.deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.Location = New System.Drawing.Point(417, 484)
        Me.deletebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(139, 32)
        Me.deletebtn.TabIndex = 77
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'homebtn
        '
        Me.homebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homebtn.Location = New System.Drawing.Point(617, 484)
        Me.homebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Size = New System.Drawing.Size(139, 32)
        Me.homebtn.TabIndex = 76
        Me.homebtn.Text = "Home"
        Me.homebtn.UseVisualStyleBackColor = True
        '
        'updatebtn
        '
        Me.updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.Location = New System.Drawing.Point(270, 484)
        Me.updatebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(139, 32)
        Me.updatebtn.TabIndex = 75
        Me.updatebtn.Text = "Update"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'savebtn
        '
        Me.savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.Location = New System.Drawing.Point(158, 484)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(100, 32)
        Me.savebtn.TabIndex = 74
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'addbtn
        '
        Me.addbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.Location = New System.Drawing.Point(50, 484)
        Me.addbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(100, 32)
        Me.addbtn.TabIndex = 73
        Me.addbtn.Text = "Add"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(50, 286)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(706, 185)
        Me.DataGridView1.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(366, 175)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 25)
        Me.Label5.TabIndex = 71
        '
        'rideseatcapacitytxt
        '
        Me.rideseatcapacitytxt.Enabled = False
        Me.rideseatcapacitytxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rideseatcapacitytxt.Location = New System.Drawing.Point(50, 207)
        Me.rideseatcapacitytxt.Margin = New System.Windows.Forms.Padding(4)
        Me.rideseatcapacitytxt.Name = "rideseatcapacitytxt"
        Me.rideseatcapacitytxt.Size = New System.Drawing.Size(189, 30)
        Me.rideseatcapacitytxt.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 25)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Seat Capacity"
        '
        'ridenametxt
        '
        Me.ridenametxt.Enabled = False
        Me.ridenametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ridenametxt.Location = New System.Drawing.Point(50, 121)
        Me.ridenametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.ridenametxt.Name = "ridenametxt"
        Me.ridenametxt.Size = New System.Drawing.Size(706, 30)
        Me.ridenametxt.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 25)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Ride Name"
        '
        'searchridebtn
        '
        Me.searchridebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchridebtn.Location = New System.Drawing.Point(389, 36)
        Me.searchridebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.searchridebtn.Name = "searchridebtn"
        Me.searchridebtn.Size = New System.Drawing.Size(100, 32)
        Me.searchridebtn.TabIndex = 66
        Me.searchridebtn.Text = "Search"
        Me.searchridebtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 25)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Ride ID"
        '
        'rideIDtxt
        '
        Me.rideIDtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rideIDtxt.Location = New System.Drawing.Point(201, 36)
        Me.rideIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.rideIDtxt.Name = "rideIDtxt"
        Me.rideIDtxt.Size = New System.Drawing.Size(132, 30)
        Me.rideIDtxt.TabIndex = 64
        '
        'RideForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 552)
        Me.Controls.Add(Me.ridewaittimetxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ridedurationtxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.homebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rideseatcapacitytxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ridenametxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.searchridebtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rideIDtxt)
        Me.Name = "RideForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RideForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ridewaittimetxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ridedurationtxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents deletebtn As Button
    Friend WithEvents homebtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents addbtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents rideseatcapacitytxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ridenametxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents searchridebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents rideIDtxt As TextBox
End Class
