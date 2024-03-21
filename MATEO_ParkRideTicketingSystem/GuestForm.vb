Imports Google.Protobuf.WellKnownTypes
Imports Mysqlx.XDevAPI.Common

Public Class GuestForm
    Private Sub GuestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
        DataGridView1.DataSource = RetrieveDataFromTable("tbl_guest")
    End Sub

    Private Sub GuestForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        closeDB()
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
                disableTxtBoxes()
            End If
        End If
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        clearTxtBoxes()
        enableTxtBoxes()
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Dim gusID As String = guestIDtxt.Text
        Dim name As String = guestnametxt.Text
        Dim age As String = guestagetxt.Text
        Dim weight As String = guestweighttxt.Text
        Dim height As String = guestheighttxt.Text

        Dim gusIdInt As Integer
        Dim gusAgeInt As Integer
        Dim gusWeightInt As Integer
        Dim gusHeightInt As Integer

        If Integer.TryParse(gusID, gusIdInt) = False Then
            MessageBox.Show("Conversion of Int GuestID failed")
        ElseIf Integer.TryParse(age, gusAgeInt) = False Then
            MessageBox.Show("Conversion of Int Age failed")
        ElseIf Integer.TryParse(weight, gusWeightInt) = False Then
            MessageBox.Show("Conversion of Int Weight failed")
        ElseIf Integer.TryParse(height, gusHeightInt) = False Then
            MessageBox.Show("Conversion of Int Height failed")
        Else
            AddGuestData(
            gusIdInt,
            name,
            gusAgeInt,
            gusWeightInt,
            gusHeightInt
            )

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_guest")
        End If
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Dim gusID As String = guestIDtxt.Text
        Dim name As String = guestnametxt.Text
        Dim age As String = guestagetxt.Text
        Dim weight As String = guestweighttxt.Text
        Dim height As String = guestheighttxt.Text

        Dim gusIdInt As Integer
        Dim gusAgeInt As Integer
        Dim gusWeightInt As Integer
        Dim gusHeightInt As Integer

        If Integer.TryParse(gusID, gusIdInt) = False Then
            MessageBox.Show("Conversion of Int GuestID failed")
        ElseIf Integer.TryParse(age, gusAgeInt) = False Then
            MessageBox.Show("Conversion of Int Age failed")
        ElseIf Integer.TryParse(weight, gusWeightInt) = False Then
            MessageBox.Show("Conversion of Int Weight failed")
        ElseIf Integer.TryParse(height, gusHeightInt) = False Then
            MessageBox.Show("Conversion of Int Height failed")
        Else
            UpdateGuestData(
            gusIdInt,
            name,
            gusAgeInt,
            gusWeightInt,
            gusHeightInt
            )

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_guest")
        End If
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        Dim gusID As String = guestIDtxt.Text
        Dim gusIDInt As Integer

        If Integer.TryParse(gusID, gusIDInt) = False Then
            MessageBox.Show("Conversion of Int GuestID failed")
        Else
            DeleteData("tbl_guest", "GuestID", gusIDInt)

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_guest")
        End If
    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        Dim frm As New Dashboard
        frm.Show()
        Me.Close()
    End Sub

    Private Sub enableTxtBoxes()
        guestnametxt.Enabled = True
        guestagetxt.Enabled = True
        guestweighttxt.Enabled = True
        guestheighttxt.Enabled = True
    End Sub
    Private Sub disableTxtBoxes()
        guestnametxt.Enabled = False
        guestagetxt.Enabled = False
        guestweighttxt.Enabled = False
        guestheighttxt.Enabled = False
    End Sub

    Private Sub clearTxtBoxes()
        guestIDtxt.Text = String.Empty
        guestnametxt.Text = String.Empty
        guestagetxt.Text = String.Empty
        guestweighttxt.Text = String.Empty
        guestheighttxt.Text = String.Empty
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                ' Retrieve the values from the selected row
                Dim id As Integer = selectedRow.Cells("GuestID").Value.ToString()
                Dim name As String = selectedRow.Cells("GuestName").Value.ToString()
                Dim age As String = selectedRow.Cells("GuestAge").Value.ToString()
                Dim weight As String = selectedRow.Cells("GuestWeight").Value.ToString()
                Dim height As String = selectedRow.Cells("GuestHeight").Value.ToString()

                ' Populate the text boxes with the retrieved values
                guestIDtxt.Text = id
                guestnametxt.Text = name
                guestagetxt.Text = age
                guestweighttxt.Text = weight
                guestheighttxt.Text = height
            End If
        Catch ex As Exception
            MessageBox.Show("Cell is blank")
        End Try
    End Sub
End Class