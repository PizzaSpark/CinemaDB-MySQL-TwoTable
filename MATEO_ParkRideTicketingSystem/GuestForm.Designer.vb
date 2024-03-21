<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestForm
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
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.homebtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.guestagetxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.guestnametxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchguestbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.guestIDtxt = New System.Windows.Forms.TextBox()
        Me.guestweighttxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.guestheighttxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deletebtn
        '
        Me.deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.Location = New System.Drawing.Point(413, 485)
        Me.deletebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(139, 32)
        Me.deletebtn.TabIndex = 58
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'homebtn
        '
        Me.homebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homebtn.Location = New System.Drawing.Point(613, 485)
        Me.homebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Size = New System.Drawing.Size(139, 32)
        Me.homebtn.TabIndex = 57
        Me.homebtn.Text = "Home"
        Me.homebtn.UseVisualStyleBackColor = True
        '
        'updatebtn
        '
        Me.updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.Location = New System.Drawing.Point(266, 485)
        Me.updatebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(139, 32)
        Me.updatebtn.TabIndex = 56
        Me.updatebtn.Text = "Update"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'savebtn
        '
        Me.savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.Location = New System.Drawing.Point(154, 485)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(100, 32)
        Me.savebtn.TabIndex = 55
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'addbtn
        '
        Me.addbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.Location = New System.Drawing.Point(46, 485)
        Me.addbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(100, 32)
        Me.addbtn.TabIndex = 54
        Me.addbtn.Text = "Add"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 287)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(706, 185)
        Me.DataGridView1.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(362, 176)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 25)
        Me.Label5.TabIndex = 52
        '
        'guestagetxt
        '
        Me.guestagetxt.Enabled = False
        Me.guestagetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestagetxt.Location = New System.Drawing.Point(46, 208)
        Me.guestagetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.guestagetxt.Name = "guestagetxt"
        Me.guestagetxt.Size = New System.Drawing.Size(189, 30)
        Me.guestagetxt.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 25)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Age"
        '
        'guestnametxt
        '
        Me.guestnametxt.Enabled = False
        Me.guestnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestnametxt.Location = New System.Drawing.Point(46, 122)
        Me.guestnametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.guestnametxt.Name = "guestnametxt"
        Me.guestnametxt.Size = New System.Drawing.Size(706, 30)
        Me.guestnametxt.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 25)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Guest Name"
        '
        'searchguestbtn
        '
        Me.searchguestbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchguestbtn.Location = New System.Drawing.Point(385, 37)
        Me.searchguestbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.searchguestbtn.Name = "searchguestbtn"
        Me.searchguestbtn.Size = New System.Drawing.Size(100, 32)
        Me.searchguestbtn.TabIndex = 45
        Me.searchguestbtn.Text = "Search"
        Me.searchguestbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Guest ID"
        '
        'guestIDtxt
        '
        Me.guestIDtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestIDtxt.Location = New System.Drawing.Point(197, 37)
        Me.guestIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.guestIDtxt.Name = "guestIDtxt"
        Me.guestIDtxt.Size = New System.Drawing.Size(132, 30)
        Me.guestIDtxt.TabIndex = 43
        '
        'guestweighttxt
        '
        Me.guestweighttxt.Enabled = False
        Me.guestweighttxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestweighttxt.Location = New System.Drawing.Point(297, 208)
        Me.guestweighttxt.Margin = New System.Windows.Forms.Padding(4)
        Me.guestweighttxt.Name = "guestweighttxt"
        Me.guestweighttxt.Size = New System.Drawing.Size(189, 30)
        Me.guestweighttxt.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(292, 176)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Weight"
        '
        'guestheighttxt
        '
        Me.guestheighttxt.Enabled = False
        Me.guestheighttxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestheighttxt.Location = New System.Drawing.Point(563, 208)
        Me.guestheighttxt.Margin = New System.Windows.Forms.Padding(4)
        Me.guestheighttxt.Name = "guestheighttxt"
        Me.guestheighttxt.Size = New System.Drawing.Size(189, 30)
        Me.guestheighttxt.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(558, 176)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 25)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Height"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(628, 176)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 25)
        Me.Label7.TabIndex = 61
        '
        'GuestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 552)
        Me.Controls.Add(Me.guestheighttxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.guestweighttxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.homebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.guestagetxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.guestnametxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.searchguestbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.guestIDtxt)
        Me.Name = "GuestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GuestForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents deletebtn As Button
    Friend WithEvents homebtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents addbtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents guestagetxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents guestnametxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents searchguestbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents guestIDtxt As TextBox
    Friend WithEvents guestweighttxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents guestheighttxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
