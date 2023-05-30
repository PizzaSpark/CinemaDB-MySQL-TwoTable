<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieForm
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
        Me.homebtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.moviegenrecmb = New System.Windows.Forms.ComboBox()
        Me.moviedurationtxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.movienametxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchmoviebtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.movieIDtxt = New System.Windows.Forms.TextBox()
        Me.deletebtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'homebtn
        '
        Me.homebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.homebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.homebtn.Location = New System.Drawing.Point(837, 484)
        Me.homebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Size = New System.Drawing.Size(139, 32)
        Me.homebtn.TabIndex = 39
        Me.homebtn.Text = "Home"
        Me.homebtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.updatebtn.Location = New System.Drawing.Point(261, 484)
        Me.updatebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(139, 32)
        Me.updatebtn.TabIndex = 38
        Me.updatebtn.Text = "Update"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.savebtn.Location = New System.Drawing.Point(149, 484)
        Me.savebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(100, 32)
        Me.savebtn.TabIndex = 37
        Me.savebtn.Text = "Save"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.addbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.addbtn.Location = New System.Drawing.Point(41, 484)
        Me.addbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(100, 32)
        Me.addbtn.TabIndex = 36
        Me.addbtn.Text = "Add"
        Me.addbtn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 286)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(935, 185)
        Me.DataGridView1.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(316, 175)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 25)
        Me.Label5.TabIndex = 30
        '
        'moviegenrecmb
        '
        Me.moviegenrecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.moviegenrecmb.Enabled = False
        Me.moviegenrecmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moviegenrecmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.moviegenrecmb.FormattingEnabled = True
        Me.moviegenrecmb.Items.AddRange(New Object() {"Action", "Adventure", "Comedy", "Drama", "Fantasy", "Horror", "Science Fiction (Sci-fi)", "Thriller", "Romance", "Animation"})
        Me.moviegenrecmb.Location = New System.Drawing.Point(41, 204)
        Me.moviegenrecmb.Margin = New System.Windows.Forms.Padding(4)
        Me.moviegenrecmb.Name = "moviegenrecmb"
        Me.moviegenrecmb.Size = New System.Drawing.Size(312, 33)
        Me.moviegenrecmb.TabIndex = 29
        '
        'moviedurationtxt
        '
        Me.moviedurationtxt.Enabled = False
        Me.moviedurationtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moviedurationtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.moviedurationtxt.Location = New System.Drawing.Point(380, 207)
        Me.moviedurationtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.moviedurationtxt.Name = "moviedurationtxt"
        Me.moviedurationtxt.Size = New System.Drawing.Size(189, 30)
        Me.moviedurationtxt.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(375, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 25)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Duration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(36, 175)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Movie Genre"
        '
        'movienametxt
        '
        Me.movienametxt.Enabled = False
        Me.movienametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movienametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.movienametxt.Location = New System.Drawing.Point(41, 121)
        Me.movienametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.movienametxt.Name = "movienametxt"
        Me.movienametxt.Size = New System.Drawing.Size(528, 30)
        Me.movienametxt.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(36, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Movie Name"
        '
        'searchmoviebtn
        '
        Me.searchmoviebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.searchmoviebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchmoviebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.searchmoviebtn.Location = New System.Drawing.Point(380, 36)
        Me.searchmoviebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.searchmoviebtn.Name = "searchmoviebtn"
        Me.searchmoviebtn.Size = New System.Drawing.Size(100, 32)
        Me.searchmoviebtn.TabIndex = 22
        Me.searchmoviebtn.Text = "Search"
        Me.searchmoviebtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(36, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Movie ID"
        '
        'movieIDtxt
        '
        Me.movieIDtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movieIDtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.movieIDtxt.Location = New System.Drawing.Point(192, 36)
        Me.movieIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.movieIDtxt.Name = "movieIDtxt"
        Me.movieIDtxt.Size = New System.Drawing.Size(132, 30)
        Me.movieIDtxt.TabIndex = 20
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.deletebtn.Location = New System.Drawing.Point(408, 484)
        Me.deletebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(139, 32)
        Me.deletebtn.TabIndex = 42
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'MovieForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1011, 554)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.homebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.moviegenrecmb)
        Me.Controls.Add(Me.moviedurationtxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.movienametxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.searchmoviebtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.movieIDtxt)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MovieForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MovieForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents homebtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents addbtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents moviegenrecmb As ComboBox
    Friend WithEvents moviedurationtxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents movienametxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents searchmoviebtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents movieIDtxt As TextBox
    Friend WithEvents deletebtn As Button
End Class
