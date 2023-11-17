<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        Me.customerIDtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchcustomerbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.firstNametxt = New System.Windows.Forms.TextBox()
        Me.lastNametxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.middlenametxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.agetxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.homebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'customerIDtxt
        '
        Me.customerIDtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerIDtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.customerIDtxt.Location = New System.Drawing.Point(193, 48)
        Me.customerIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.customerIDtxt.Name = "customerIDtxt"
        Me.customerIDtxt.Size = New System.Drawing.Size(132, 30)
        Me.customerIDtxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(37, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer ID"
        '
        'searchcustomerbtn
        '
        Me.searchcustomerbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.searchcustomerbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchcustomerbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.searchcustomerbtn.Location = New System.Drawing.Point(381, 48)
        Me.searchcustomerbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.searchcustomerbtn.Name = "searchcustomerbtn"
        Me.searchcustomerbtn.Size = New System.Drawing.Size(100, 32)
        Me.searchcustomerbtn.TabIndex = 2
        Me.searchcustomerbtn.Text = "Search"
        Me.searchcustomerbtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(37, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First Name"
        '
        'firstNametxt
        '
        Me.firstNametxt.Enabled = False
        Me.firstNametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.firstNametxt.Location = New System.Drawing.Point(43, 133)
        Me.firstNametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.firstNametxt.Name = "firstNametxt"
        Me.firstNametxt.Size = New System.Drawing.Size(248, 30)
        Me.firstNametxt.TabIndex = 4
        '
        'lastNametxt
        '
        Me.lastNametxt.Enabled = False
        Me.lastNametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lastNametxt.Location = New System.Drawing.Point(323, 133)
        Me.lastNametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.lastNametxt.Name = "lastNametxt"
        Me.lastNametxt.Size = New System.Drawing.Size(248, 30)
        Me.lastNametxt.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(317, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name"
        '
        'emailtxt
        '
        Me.emailtxt.Enabled = False
        Me.emailtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.emailtxt.Location = New System.Drawing.Point(43, 215)
        Me.emailtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(248, 30)
        Me.emailtxt.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(37, 187)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email"
        '
        'middlenametxt
        '
        Me.middlenametxt.Enabled = False
        Me.middlenametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlenametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.middlenametxt.Location = New System.Drawing.Point(604, 133)
        Me.middlenametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.middlenametxt.Name = "middlenametxt"
        Me.middlenametxt.Size = New System.Drawing.Size(80, 30)
        Me.middlenametxt.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(599, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "M.I"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(318, 187)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Age"
        '
        'agetxt
        '
        Me.agetxt.Enabled = False
        Me.agetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.agetxt.Location = New System.Drawing.Point(323, 215)
        Me.agetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.agetxt.Name = "agetxt"
        Me.agetxt.Size = New System.Drawing.Size(80, 30)
        Me.agetxt.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 298)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(643, 185)
        Me.DataGridView1.TabIndex = 15
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.addbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.addbtn.Location = New System.Drawing.Point(43, 496)
        Me.addbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(100, 32)
        Me.addbtn.TabIndex = 16
        Me.addbtn.Text = "Add"
        Me.addbtn.UseVisualStyleBackColor = False
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.savebtn.Location = New System.Drawing.Point(151, 496)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(100, 32)
        Me.savebtn.TabIndex = 17
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.updatebtn.Location = New System.Drawing.Point(263, 496)
        Me.updatebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(111, 32)
        Me.updatebtn.TabIndex = 18
        Me.updatebtn.Text = "Update"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'homebtn
        '
        Me.homebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.homebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.homebtn.Location = New System.Drawing.Point(583, 496)
        Me.homebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Size = New System.Drawing.Size(103, 32)
        Me.homebtn.TabIndex = 19
        Me.homebtn.Text = "Home"
        Me.homebtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.deletebtn.Location = New System.Drawing.Point(381, 496)
        Me.deletebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(131, 32)
        Me.deletebtn.TabIndex = 20
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(728, 554)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.homebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.agetxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.middlenametxt)
        Me.Controls.Add(Me.emailtxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lastNametxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.firstNametxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.searchcustomerbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.customerIDtxt)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CustomerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents customerIDtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents searchcustomerbtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents firstNametxt As TextBox
    Friend WithEvents lastNametxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents middlenametxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents agetxt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents addbtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents homebtn As Button
    Friend WithEvents deletebtn As Button
End Class
