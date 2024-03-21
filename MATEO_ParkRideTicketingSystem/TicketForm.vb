Public Class TicketForm
    Private Sub TicketForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
        DataGridView1.DataSource = RetrieveDataFromTable("tbl_ticket")
    End Sub

    Private Sub TicketForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        closeDB()
    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        Dim frm As New Dashboard
        frm.Show()
        Me.Close()
    End Sub

    Private Sub searchguestbtn_Click(sender As Object, e As EventArgs) Handles searchguestbtn.Click
        Dim gusID As String = guestIDtxt.Text
        Dim gusIDInt As Integer

        If Integer.TryParse(gusID, gusIDInt) = False Then
            MessageBox.Show("Conversion of Int GuestID failed")
        Else
            Dim result As Tuple(Of Integer, String, Integer, Integer, Integer) = SearchDataGuest(gusIDInt)

            If result.Item2 <> "" Then
                guestIDtxt.Text = result.Item1
                guestnametxt.Text = result.Item2
                guestagetxt.Text = result.Item3
                guestweighttxt.Text = result.Item4
                guestheighttxt.Text = result.Item5
            End If
        End If
    End Sub

    Private Sub searchridebtn_Click(sender As Object, e As EventArgs) Handles searchridebtn.Click
        Dim rideID As String = rideIDtxt.Text
        Dim rideIDInt As Integer

        If Integer.TryParse(rideID, rideIDInt) = False Then
            MessageBox.Show("Conversion of Int GuestID failed")
        Else
            Dim result As Tuple(Of Integer, String, Integer, Integer, Integer) = SearchDataRide(rideIDInt)

            If result.Item2 <> "" Then
                rideIDtxt.Text = result.Item1
                ridenametxt.Text = result.Item2
                rideseatcapacitytxt.Text = result.Item3
                ridedurationtxt.Text = result.Item4
                ridewaittimetxt.Text = result.Item5
            End If
        End If
    End Sub

    Private Sub addnewbtn_Click(sender As Object, e As EventArgs) Handles addnewbtn.Click
        ridetickettypecmb.Enabled = True
    End Sub

    Private Sub buyticketbtn_Click(sender As Object, e As EventArgs) Handles buyticketbtn.Click
        Dim ticketPass As String = ridetickettypecmb.Text
        Dim gusID As String = guestIDtxt.Text
        Dim rideID As String = rideIDtxt.Text

        Dim gusIDInt As Integer
        Dim rideIDInt As Integer

        If Integer.TryParse(gusID, gusIDInt) = False Then
            MessageBox.Show("Conversion of Int GuestID failed")
        ElseIf Integer.TryParse(rideID, rideIDInt) = False Then
            MessageBox.Show("Conversion of Int RideID failed")
        ElseIf ridetickettypecmb.Text = "" Then
            MessageBox.Show("Must specify what ticket type")
        Else
            AddTicketData(
            ticketPass,
            gusIDInt,
            rideIDInt
            )
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_ticket")
            clearTxtBoxes()
        End If
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        Dim tixID As String = ticketIDtxt.Text
        Dim tixIDInt As Integer

        If Integer.TryParse(tixID, tixIDInt) = False Then
            MessageBox.Show("Conversion of Int TicketID failed")
        Else
            DeleteData("tbl_ticket", "TicketID", tixIDInt)

            DataGridView1.DataSource = RetrieveDataFromTable("tbl_ticket")
            clearTxtBoxes()
        End If
    End Sub

    Private Sub clearTxtBoxes()
        guestIDtxt.Text = String.Empty
        guestnametxt.Text = String.Empty
        guestagetxt.Text = String.Empty
        guestweighttxt.Text = String.Empty
        guestheighttxt.Text = String.Empty
        rideIDtxt.Text = String.Empty
        ridenametxt.Text = String.Empty
        rideseatcapacitytxt.Text = String.Empty
        ridedurationtxt.Text = String.Empty
        ridewaittimetxt.Text = String.Empty
        ridetickettypecmb.SelectedIndex = -1
        ridetickettypecmb.Enabled = False
    End Sub

    Private Sub searchticketbtn_Click(sender As Object, e As EventArgs) Handles searchticketbtn.Click
        Dim tixID As String = ticketIDtxt.Text
        Dim tixIDInt As Integer

        If Integer.TryParse(tixID, tixIDInt) = False Then
            MessageBox.Show("Conversion of Int TicketID failed")
        Else
            Dim result As Tuple(Of Integer, String, Integer, Integer) = SearchDataTicket(tixIDInt)

            If result.Item2 <> "" Then
                ticketIDtxt.Text = result.Item1
                ridetickettypecmb.Text = result.Item2
                guestIDtxt.Text = result.Item3
                rideIDtxt.Text = result.Item4


                Dim gusIDInt As Integer = Integer.Parse(guestIDtxt.Text)
                Dim rideIDInt As Integer = Integer.Parse(rideIDtxt.Text)

                Dim resultg As Tuple(Of Integer, String, Integer, Integer, Integer) = SearchDataGuest(gusIDInt)

                guestIDtxt.Text = resultg.Item1
                guestnametxt.Text = resultg.Item2
                guestagetxt.Text = resultg.Item3
                guestweighttxt.Text = resultg.Item4
                guestheighttxt.Text = resultg.Item5

                Dim resultr As Tuple(Of Integer, String, Integer, Integer, Integer) = SearchDataRide(rideIDInt)

                rideIDtxt.Text = resultr.Item1
                ridenametxt.Text = resultr.Item2
                rideseatcapacitytxt.Text = resultr.Item3
                ridedurationtxt.Text = resultr.Item4
                ridewaittimetxt.Text = resultr.Item5
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                ' Retrieve the values from the selected row
                Dim tixID As Integer = selectedRow.Cells("TicketID").Value
                Dim tixType As String = selectedRow.Cells("TicketType").Value.ToString()
                Dim gusIDInt As Integer = selectedRow.Cells("GuestID").Value
                Dim rideIDInt As Integer = selectedRow.Cells("RideID").Value

                ' Populate the text boxes with the retrieved values
                ticketIDtxt.Text = tixID
                ridetickettypecmb.Text = tixType
                guestIDtxt.Text = gusIDInt
                rideIDtxt.Text = rideIDInt

                Dim resultg As Tuple(Of Integer, String, Integer, Integer, Integer) = SearchDataGuest(gusIDInt)

                guestIDtxt.Text = resultg.Item1
                guestnametxt.Text = resultg.Item2
                guestagetxt.Text = resultg.Item3
                guestweighttxt.Text = resultg.Item4
                guestheighttxt.Text = resultg.Item5

                Dim resultr As Tuple(Of Integer, String, Integer, Integer, Integer) = SearchDataRide(rideIDInt)

                rideIDtxt.Text = resultr.Item1
                ridenametxt.Text = resultr.Item2
                rideseatcapacitytxt.Text = resultr.Item3
                ridedurationtxt.Text = resultr.Item4
                ridewaittimetxt.Text = resultr.Item5
            End If
        Catch ex As Exception
            MessageBox.Show("Cell is blank")
        End Try
    End Sub
End Class