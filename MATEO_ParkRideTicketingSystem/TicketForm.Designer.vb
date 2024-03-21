<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketForm
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
        Me.guestheighttxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.guestweighttxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.guestagetxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.guestnametxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.searchguestbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.guestIDtxt = New System.Windows.Forms.TextBox()
        Me.ridewaittimetxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ridedurationtxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rideseatcapacitytxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ridenametxt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.searchridebtn = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rideIDtxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.homebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.addnewbtn = New System.Windows.Forms.Button()
        Me.buyticketbtn = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ridetickettypecmb = New System.Windows.Forms.ComboBox()
        Me.searchticketbtn = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ticketIDtxt = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'guestheighttxt
        '
        Me.guestheighttxt.Enabled = False
        Me.guestheighttxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestheighttxt.Location = New System.Drawing.Point(569, 213)
        Me.guestheighttxt.Margin = New System.Windows.Forms.Padding(4)
        Me.guestheighttxt.Name = "guestheighttxt"
        Me.guestheighttxt.Size = New System.Drawing.Size(189, 30)
        Me.guestheighttxt.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(564, 181)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 25)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Height"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(634, 181)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 25)
        Me.Label7.TabIndex = 74
        '
        'guestweighttxt
        '
        Me.guestweighttxt.Enabled = False
        Me.guestweighttxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestweighttxt.Location = New System.Drawing.Point(303, 213)
        Me.guestweighttxt.Margin = New System.Windows.Forms.Padding(4)
        Me.guestweighttxt.Name = "guestweighttxt"
        Me.guestweighttxt.Size = New System.Drawing.Size(189, 30)
        Me.guestweighttxt.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(298, 181)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Weight"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(368, 181)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 25)
        Me.Label5.TabIndex = 71
        '
        'guestagetxt
        '
        Me.guestagetxt.Enabled = False
        Me.guestagetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestagetxt.Location = New System.Drawing.Point(52, 213)
        Me.guestagetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.guestagetxt.Name = "guestagetxt"
        Me.guestagetxt.Size = New System.Drawing.Size(189, 30)
        Me.guestagetxt.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 181)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 25)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Age"
        '
        'guestnametxt
        '
        Me.guestnametxt.Enabled = False
        Me.guestnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestnametxt.Location = New System.Drawing.Point(52, 127)
        Me.guestnametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.guestnametxt.Name = "guestnametxt"
        Me.guestnametxt.Size = New System.Drawing.Size(706, 30)
        Me.guestnametxt.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 25)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Guest Name"
        '
        'searchguestbtn
        '
        Me.searchguestbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchguestbtn.Location = New System.Drawing.Point(321, 40)
        Me.searchguestbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.searchguestbtn.Name = "searchguestbtn"
        Me.searchguestbtn.Size = New System.Drawing.Size(100, 32)
        Me.searchguestbtn.TabIndex = 66
        Me.searchguestbtn.Text = "Search"
        Me.searchguestbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Guest ID"
        '
        'guestIDtxt
        '
        Me.guestIDtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guestIDtxt.Location = New System.Drawing.Point(157, 40)
        Me.guestIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.guestIDtxt.Name = "guestIDtxt"
        Me.guestIDtxt.Size = New System.Drawing.Size(132, 30)
        Me.guestIDtxt.TabIndex = 64
        '
        'ridewaittimetxt
        '
        Me.ridewaittimetxt.Enabled = False
        Me.ridewaittimetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ridewaittimetxt.Location = New System.Drawing.Point(569, 463)
        Me.ridewaittimetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.ridewaittimetxt.Name = "ridewaittimetxt"
        Me.ridewaittimetxt.Size = New System.Drawing.Size(189, 30)
        Me.ridewaittimetxt.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(564, 431)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 25)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Wait Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(634, 431)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 25)
        Me.Label9.TabIndex = 93
        '
        'ridedurationtxt
        '
        Me.ridedurationtxt.Enabled = False
        Me.ridedurationtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ridedurationtxt.Location = New System.Drawing.Point(303, 463)
        Me.ridedurationtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.ridedurationtxt.Name = "ridedurationtxt"
        Me.ridedurationtxt.Size = New System.Drawing.Size(189, 30)
        Me.ridedurationtxt.TabIndex = 92
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(298, 431)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 25)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Duration"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(368, 431)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 25)
        Me.Label11.TabIndex = 90
        '
        'rideseatcapacitytxt
        '
        Me.rideseatcapacitytxt.Enabled = False
        Me.rideseatcapacitytxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rideseatcapacitytxt.Location = New System.Drawing.Point(52, 463)
        Me.rideseatcapacitytxt.Margin = New System.Windows.Forms.Padding(4)
        Me.rideseatcapacitytxt.Name = "rideseatcapacitytxt"
        Me.rideseatcapacitytxt.Size = New System.Drawing.Size(189, 30)
        Me.rideseatcapacitytxt.TabIndex = 89
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(47, 431)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 25)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Seat Capacity"
        '
        'ridenametxt
        '
        Me.ridenametxt.Enabled = False
        Me.ridenametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ridenametxt.Location = New System.Drawing.Point(52, 377)
        Me.ridenametxt.Margin = New System.Windows.Forms.Padding(4)
        Me.ridenametxt.Name = "ridenametxt"
        Me.ridenametxt.Size = New System.Drawing.Size(706, 30)
        Me.ridenametxt.TabIndex = 87
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(47, 348)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 25)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Ride Name"
        '
        'searchridebtn
        '
        Me.searchridebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchridebtn.Location = New System.Drawing.Point(321, 292)
        Me.searchridebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.searchridebtn.Name = "searchridebtn"
        Me.searchridebtn.Size = New System.Drawing.Size(100, 32)
        Me.searchridebtn.TabIndex = 85
        Me.searchridebtn.Text = "Search"
        Me.searchridebtn.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(47, 295)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 25)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "Ride ID"
        '
        'rideIDtxt
        '
        Me.rideIDtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rideIDtxt.Location = New System.Drawing.Point(157, 292)
        Me.rideIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.rideIDtxt.Name = "rideIDtxt"
        Me.rideIDtxt.Size = New System.Drawing.Size(132, 30)
        Me.rideIDtxt.TabIndex = 83
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(52, 511)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(706, 203)
        Me.DataGridView1.TabIndex = 96
        '
        'homebtn
        '
        Me.homebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homebtn.Location = New System.Drawing.Point(619, 722)
        Me.homebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Size = New System.Drawing.Size(139, 32)
        Me.homebtn.TabIndex = 99
        Me.homebtn.Text = "Home"
        Me.homebtn.UseVisualStyleBackColor = True
        '
        'deletebtn
        '
        Me.deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.Location = New System.Drawing.Point(350, 722)
        Me.deletebtn.Margin = New System.Windows.Forms.Padding(4)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(127, 32)
        Me.deletebtn.TabIndex = 98
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'addnewbtn
        '
        Me.addnewbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addnewbtn.Location = New System.Drawing.Point(52, 722)
        Me.addnewbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addnewbtn.Name = "addnewbtn"
        Me.addnewbtn.Size = New System.Drawing.Size(127, 32)
        Me.addnewbtn.TabIndex = 97
        Me.addnewbtn.Text = "Add New"
        Me.addnewbtn.UseVisualStyleBackColor = True
        '
        'buyticketbtn
        '
        Me.buyticketbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buyticketbtn.Location = New System.Drawing.Point(187, 722)
        Me.buyticketbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.buyticketbtn.Name = "buyticketbtn"
        Me.buyticketbtn.Size = New System.Drawing.Size(155, 32)
        Me.buyticketbtn.TabIndex = 100
        Me.buyticketbtn.Text = "Buy Ticket"
        Me.buyticketbtn.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(564, 270)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 25)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Ticket Type"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Enabled = False
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(634, 270)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 25)
        Me.Label16.TabIndex = 101
        '
        'ridetickettypecmb
        '
        Me.ridetickettypecmb.Enabled = False
        Me.ridetickettypecmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ridetickettypecmb.FormattingEnabled = True
        Me.ridetickettypecmb.Items.AddRange(New Object() {"Regular Pass", "Exclusive Pass"})
        Me.ridetickettypecmb.Location = New System.Drawing.Point(569, 298)
        Me.ridetickettypecmb.Name = "ridetickettypecmb"
        Me.ridetickettypecmb.Size = New System.Drawing.Size(189, 33)
        Me.ridetickettypecmb.TabIndex = 103
        '
        'searchticketbtn
        '
        Me.searchticketbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchticketbtn.Location = New System.Drawing.Point(690, 40)
        Me.searchticketbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.searchticketbtn.Name = "searchticketbtn"
        Me.searchticketbtn.Size = New System.Drawing.Size(100, 32)
        Me.searchticketbtn.TabIndex = 106
        Me.searchticketbtn.Text = "Search"
        Me.searchticketbtn.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(545, 9)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 25)
        Me.Label17.TabIndex = 105
        Me.Label17.Text = "Ticket ID"
        '
        'ticketIDtxt
        '
        Me.ticketIDtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ticketIDtxt.Location = New System.Drawing.Point(550, 40)
        Me.ticketIDtxt.Margin = New System.Windows.Forms.Padding(4)
        Me.ticketIDtxt.Name = "ticketIDtxt"
        Me.ticketIDtxt.Size = New System.Drawing.Size(132, 30)
        Me.ticketIDtxt.TabIndex = 104
        '
        'TicketForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 777)
        Me.Controls.Add(Me.searchticketbtn)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ticketIDtxt)
        Me.Controls.Add(Me.ridetickettypecmb)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.buyticketbtn)
        Me.Controls.Add(Me.homebtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.addnewbtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ridewaittimetxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ridedurationtxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.rideseatcapacitytxt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ridenametxt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.searchridebtn)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.rideIDtxt)
        Me.Controls.Add(Me.guestheighttxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.guestweighttxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.guestagetxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.guestnametxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.searchguestbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.guestIDtxt)
        Me.Name = "TicketForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TicketForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents guestheighttxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents guestweighttxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents guestagetxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents guestnametxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents searchguestbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents guestIDtxt As TextBox
    Friend WithEvents ridewaittimetxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ridedurationtxt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents rideseatcapacitytxt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ridenametxt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents searchridebtn As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents rideIDtxt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents homebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents addnewbtn As Button
    Friend WithEvents buyticketbtn As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ridetickettypecmb As ComboBox
    Friend WithEvents searchticketbtn As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents ticketIDtxt As TextBox
End Class
