Imports Mysqlx.XDevAPI.Common

Public Class RideForm
    Private Sub RideForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
        DataGridView1.DataSource = RetrieveDataFromTable("tbl_ride")
    End Sub

    Private Sub RideForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        closeDB()
    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        Dim frm As New Dashboard
        frm.Show()
        Me.Close()
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
                disableTxtBoxes()
            End If
        End If
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        clearTxtBoxes()
        enableTxtBoxes()
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Dim rideID As String = rideIDtxt.Text
        Dim name As String = ridenametxt.Text
        Dim seatcapacity As String = rideseatcapacitytxt.Text
        Dim duration As String = ridedurationtxt.Text
        Dim waittime As String = ridewaittimetxt.Text

        Dim rideIDInt As Integer
        Dim rideSeatCapacityInt As Integer
        Dim rideDurationInt As Integer
        Dim rideWaitTimeInt As Integer

        If Integer.TryParse(rideID, rideIDInt) = False Then
            MessageBox.Show("Conversion of Int GuestID failed")
        ElseIf Integer.TryParse(seatcapacity, rideSeatCapacityInt) = False Then
            MessageBox.Show("Conversion of Int Age failed")
        ElseIf Integer.TryParse(duration, rideDurationInt) = False Then
            MessageBox.Show("Conversion of Int Weight failed")
        ElseIf Integer.TryParse(waittime, rideWaitTimeInt) = False Then
            MessageBox.Show("Conversion of Int Height failed")
        Else
            AddRideData(
            rideIDInt,
            name,
            rideSeatCapacityInt,
            rideDurationInt,
            rideWaitTimeInt
            )

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_ride")
        End If
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Dim rideID As String = rideIDtxt.Text
        Dim name As String = ridenametxt.Text
        Dim seatcapacity As String = rideseatcapacitytxt.Text
        Dim duration As String = ridedurationtxt.Text
        Dim waittime As String = ridewaittimetxt.Text

        Dim rideIDInt As Integer
        Dim rideSeatCapacityInt As Integer
        Dim rideDurationInt As Integer
        Dim rideWaitTimeInt As Integer

        If Integer.TryParse(rideID, rideIDInt) = False Then
            MessageBox.Show("Conversion of Int GuestID failed")
        ElseIf Integer.TryParse(seatcapacity, rideSeatCapacityInt) = False Then
            MessageBox.Show("Conversion of Int Age failed")
        ElseIf Integer.TryParse(duration, rideDurationInt) = False Then
            MessageBox.Show("Conversion of Int Weight failed")
        ElseIf Integer.TryParse(waittime, rideWaitTimeInt) = False Then
            MessageBox.Show("Conversion of Int Height failed")
        Else
            UpdateRideData(
            rideIDInt,
            name,
            rideSeatCapacityInt,
            rideDurationInt,
            rideWaitTimeInt
            )

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_ride")
        End If
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        Dim rideID As String = rideIDtxt.Text
        Dim rideIDInt As Integer

        If Integer.TryParse(rideID, rideIDInt) = False Then
            MessageBox.Show("Conversion of Int RideID failed")
        Else
            DeleteData("tbl_ride", "RideID", rideIDInt)

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_ride")
        End If
    End Sub

    Private Sub enableTxtBoxes()
        ridenametxt.Enabled = True
        rideseatcapacitytxt.Enabled = True
        ridedurationtxt.Enabled = True
        ridewaittimetxt.Enabled = True
    End Sub
    Private Sub disableTxtBoxes()
        ridenametxt.Enabled = False
        rideseatcapacitytxt.Enabled = False
        ridedurationtxt.Enabled = False
        ridewaittimetxt.Enabled = False
    End Sub

    Private Sub clearTxtBoxes()
        rideIDtxt.Text = String.Empty
        ridenametxt.Text = String.Empty
        rideseatcapacitytxt.Text = String.Empty
        ridedurationtxt.Text = String.Empty
        ridewaittimetxt.Text = String.Empty
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                ' Retrieve the values from the selected row
                Dim id As Integer = selectedRow.Cells("RideID").Value.ToString()
                Dim name As String = selectedRow.Cells("RideName").Value.ToString()
                Dim seatCapacity As String = selectedRow.Cells("RideSeatCapacity").Value.ToString()
                Dim duration As String = selectedRow.Cells("RideDuration").Value.ToString()
                Dim waitTime As String = selectedRow.Cells("RideWaitTime").Value.ToString()

                ' Populate the text boxes with the retrieved values

                rideIDtxt.Text = id
                ridenametxt.Text = name
                rideseatcapacitytxt.Text = seatCapacity
                ridedurationtxt.Text = duration
                ridewaittimetxt.Text = waitTime
            End If
        Catch ex As Exception
            MessageBox.Show("Cell is blank")
        End Try
    End Sub
End Class