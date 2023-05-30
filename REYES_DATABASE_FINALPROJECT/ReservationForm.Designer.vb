<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReservationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.customeremailtxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.customerfirstnametxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchcustomerbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchcustomertxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.agetxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.moviedurationtxt = New System.Windows.Forms.TextBox()
        Me.moviegenretxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.movienametxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.searchmoviebtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.searchmovietxt = New System.Windows.Forms.TextBox()
        Me.reserveticketbtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.addnewbtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.homebtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.customermiddlenametxt = New System.Windows.Forms.TextBox()
        Me.customerlastnametxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.searchreservationbtn = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.searchreservationtxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tickettypecmb = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'customeremailtxt
        '
        Me.customeremailtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customeremailtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.customeremailtxt.Location = New System.Drawing.Point(41, 205)
        Me.customeremailtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.customeremailtxt.Name = "customeremailtxt"
        Me.customeremailtxt.ReadOnly = True
        Me.customeremailtxt.Size = New System.Drawing.Size(248, 30)
        Me.customeremailtxt.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(36, 177)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Email"
        '
        'customerfirstnametxt
        '
        Me.customerfirstnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerfirstnametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.customerfirstnametxt.Location = New System.Drawing.Point(41, 119)
        Me.customerfirstnametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.customerfirstnametxt.Name = "customerfirstnametxt"
        Me.customerfirstnametxt.ReadOnly = True
        Me.customerfirstnametxt.Size = New System.Drawing.Size(248, 30)
        Me.customerfirstnametxt.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(36, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name"
        '
        'searchcustomerbtn
        '
        Me.searchcustomerbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.searchcustomerbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchcustomerbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.searchcustomerbtn.Location = New System.Drawing.Point(380, 34)
        Me.searchcustomerbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.searchcustomerbtn.Name = "searchcustomerbtn"
        Me.searchcustomerbtn.Size = New System.Drawing.Size(100, 32)
        Me.searchcustomerbtn.TabIndex = 15
        Me.searchcustomerbtn.Text = "Search"
        Me.searchcustomerbtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(36, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Customer ID"
        '
        'searchcustomertxt
        '
        Me.searchcustomertxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchcustomertxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.searchcustomertxt.Location = New System.Drawing.Point(192, 34)
        Me.searchcustomertxt.Margin = New System.Windows.Forms.Padding(4)
        Me.searchcustomertxt.Name = "searchcustomertxt"
        Me.searchcustomertxt.Size = New System.Drawing.Size(132, 30)
        Me.searchcustomertxt.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(317, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 25)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Age"
        '
        'agetxt
        '
        Me.agetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agetxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.agetxt.Location = New System.Drawing.Point(322, 205)
        Me.agetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.agetxt.Name = "agetxt"
        Me.agetxt.ReadOnly = True
        Me.agetxt.Size = New System.Drawing.Size(148, 30)
        Me.agetxt.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(597, 316)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 25)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Duration"
        '
        'moviedurationtxt
        '
        Me.moviedurationtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moviedurationtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.moviedurationtxt.Location = New System.Drawing.Point(603, 344)
        Me.moviedurationtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.moviedurationtxt.Name = "moviedurationtxt"
        Me.moviedurationtxt.ReadOnly = True
        Me.moviedurationtxt.Size = New System.Drawing.Size(148, 30)
        Me.moviedurationtxt.TabIndex = 31
        '
        'moviegenretxt
        '
        Me.moviegenretxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moviegenretxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.moviegenretxt.Location = New System.Drawing.Point(321, 344)
        Me.moviegenretxt.Margin = New System.Windows.Forms.Padding(4)
        Me.moviegenretxt.Name = "moviegenretxt"
        Me.moviegenretxt.ReadOnly = True
        Me.moviegenretxt.Size = New System.Drawing.Size(248, 30)
        Me.moviegenretxt.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(316, 316)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 25)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Genre"
        '
        'movienametxt
        '
        Me.movienametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movienametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.movienametxt.Location = New System.Drawing.Point(41, 344)
        Me.movienametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.movienametxt.Name = "movienametxt"
        Me.movienametxt.ReadOnly = True
        Me.movienametxt.Size = New System.Drawing.Size(248, 30)
        Me.movienametxt.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(36, 316)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 25)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Movie Name"
        '
        'searchmoviebtn
        '
        Me.searchmoviebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchmoviebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.searchmoviebtn.Location = New System.Drawing.Point(380, 259)
        Me.searchmoviebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.searchmoviebtn.Name = "searchmoviebtn"
        Me.searchmoviebtn.Size = New System.Drawing.Size(100, 32)
        Me.searchmoviebtn.TabIndex = 26
        Me.searchmoviebtn.Text = "Search"
        Me.searchmoviebtn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(36, 263)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 25)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Movie ID"
        '
        'searchmovietxt
        '
        Me.searchmovietxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchmovietxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.searchmovietxt.Location = New System.Drawing.Point(192, 259)
        Me.searchmovietxt.Margin = New System.Windows.Forms.Padding(4)
        Me.searchmovietxt.Name = "searchmovietxt"
        Me.searchmovietxt.Size = New System.Drawing.Size(132, 30)
        Me.searchmovietxt.TabIndex = 24
        '
        'reserveticketbtn
        '
        Me.reserveticketbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.reserveticketbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reserveticketbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.reserveticketbtn.Location = New System.Drawing.Point(878, 320)
        Me.reserveticketbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.reserveticketbtn.Name = "reserveticketbtn"
        Me.reserveticketbtn.Size = New System.Drawing.Size(155, 64)
        Me.reserveticketbtn.TabIndex = 37
        Me.reserveticketbtn.Text = "RESERVE TICKET"
        Me.reserveticketbtn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 407)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(992, 319)
        Me.DataGridView1.TabIndex = 38
        '
        'addnewbtn
        '
        Me.addnewbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.addnewbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addnewbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.addnewbtn.Location = New System.Drawing.Point(41, 752)
        Me.addnewbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addnewbtn.Name = "addnewbtn"
        Me.addnewbtn.Size = New System.Drawing.Size(127, 32)
        Me.addnewbtn.TabIndex = 39
        Me.addnewbtn.Text = "Add New"
        Me.addnewbtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.deletebtn.Location = New System.Drawing.Point(176, 752)
        Me.deletebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(127, 32)
        Me.deletebtn.TabIndex = 40
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'homebtn
        '
        Me.homebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.homebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homebtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.homebtn.Location = New System.Drawing.Point(895, 752)
        Me.homebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Size = New System.Drawing.Size(139, 32)
        Me.homebtn.TabIndex = 41
        Me.homebtn.Text = "Home"
        Me.homebtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(599, 91)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 25)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "M.I"
        '
        'customermiddlenametxt
        '
        Me.customermiddlenametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customermiddlenametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.customermiddlenametxt.Location = New System.Drawing.Point(604, 119)
        Me.customermiddlenametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.customermiddlenametxt.Name = "customermiddlenametxt"
        Me.customermiddlenametxt.ReadOnly = True
        Me.customermiddlenametxt.Size = New System.Drawing.Size(80, 30)
        Me.customermiddlenametxt.TabIndex = 44
        '
        'customerlastnametxt
        '
        Me.customerlastnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerlastnametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.customerlastnametxt.Location = New System.Drawing.Point(323, 119)
        Me.customerlastnametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.customerlastnametxt.Name = "customerlastnametxt"
        Me.customerlastnametxt.ReadOnly = True
        Me.customerlastnametxt.Size = New System.Drawing.Size(248, 30)
        Me.customerlastnametxt.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(317, 91)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 25)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Last Name"
        '
        'searchreservationbtn
        '
        Me.searchreservationbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.searchreservationbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchreservationbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.searchreservationbtn.Location = New System.Drawing.Point(910, 51)
        Me.searchreservationbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.searchreservationbtn.Name = "searchreservationbtn"
        Me.searchreservationbtn.Size = New System.Drawing.Size(100, 32)
        Me.searchreservationbtn.TabIndex = 48
        Me.searchreservationbtn.Text = "Search"
        Me.searchreservationbtn.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(717, 18)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 25)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Reservation ID"
        '
        'searchreservationtxt
        '
        Me.searchreservationtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchreservationtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.searchreservationtxt.Location = New System.Drawing.Point(878, 13)
        Me.searchreservationtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.searchreservationtxt.Name = "searchreservationtxt"
        Me.searchreservationtxt.Size = New System.Drawing.Size(132, 30)
        Me.searchreservationtxt.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(822, 177)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 25)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Ticket Type"
        '
        'tickettypecmb
        '
        Me.tickettypecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tickettypecmb.Enabled = False
        Me.tickettypecmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tickettypecmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.tickettypecmb.FormattingEnabled = True
        Me.tickettypecmb.Items.AddRange(New Object() {"2D", "3D"})
        Me.tickettypecmb.Location = New System.Drawing.Point(827, 205)
        Me.tickettypecmb.Name = "tickettypecmb"
        Me.tickettypecmb.Size = New System.Drawing.Size(130, 33)
        Me.tickettypecmb.TabIndex = 51
        '
        'ReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 799)
        Me.Controls.Add(Me.tickettypecmb)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.searchreservationbtn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.searchreservationtxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.customermiddlenametxt)
        Me.Controls.Add(Me.customerlastnametxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.homebtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.addnewbtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.reserveticketbtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.moviedurationtxt)
        Me.Controls.Add(Me.moviegenretxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.movienametxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.searchmoviebtn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.searchmovietxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.agetxt)
        Me.Controls.Add(Me.customeremailtxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.customerfirstnametxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.searchcustomerbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.searchcustomertxt)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ReservationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReservationForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents customeremailtxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents customerfirstnametxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents searchcustomerbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchcustomertxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents agetxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents moviedurationtxt As TextBox
    Friend WithEvents moviegenretxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents movienametxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents searchmoviebtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents searchmovietxt As TextBox
    Friend WithEvents reserveticketbtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents addnewbtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents homebtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents customermiddlenametxt As TextBox
    Friend WithEvents customerlastnametxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents searchreservationbtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents searchreservationtxt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tickettypecmb As ComboBox
End Class
