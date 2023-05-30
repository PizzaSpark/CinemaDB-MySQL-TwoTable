Imports System.Diagnostics.Tracing
Imports Mysqlx.XDevAPI.Common

Public Class ReservationForm

    Private Sub ReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
        DataGridView1.DataSource = RetrieveDataFromTable("tbl_reservation")
    End Sub

    Private Sub ReservationForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        closeDB()
    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        Dim frm As New Dashboard
        frm.Show()
        Me.Close()
    End Sub

    Private Sub searchcustomerbtn_Click(sender As Object, e As EventArgs) Handles searchcustomerbtn.Click
        Dim cusID As String = searchcustomertxt.Text
        Dim cusIdInt As Integer

        If Integer.TryParse(cusID, cusIdInt) = False Then
            MessageBox.Show("Conversion of Int Customer failed")
        Else
            Dim result As Tuple(Of Integer, String, String, String, String, Integer) = SearchDataCustomer(cusIdInt)

            If result.Item2 <> "" Then
                searchcustomertxt.Text = result.Item1
                customerfirstnametxt.Text = result.Item2
                customerlastnametxt.Text = result.Item3
                customermiddlenametxt.Text = result.Item4
                customeremailtxt.Text = result.Item5
                agetxt.Text = result.Item6
            End If
        End If
    End Sub

    Private Sub searchmoviebtn_Click(sender As Object, e As EventArgs) Handles searchmoviebtn.Click
        Dim movID As String = searchmovietxt.Text
        Dim movIDInt As Integer

        If Integer.TryParse(movID, movIDInt) = False Then
            MessageBox.Show("Conversion of Int MovieID failed")
        Else
            Dim result As Tuple(Of Integer, String, String, Integer) = SearchDataMovie(movIDInt)

            If result.Item2 <> "" Then
                searchmovietxt.Text = result.Item1
                movienametxt.Text = result.Item2
                moviegenretxt.Text = result.Item3
                moviedurationtxt.Text = result.Item4
            End If
        End If
    End Sub

    Private Sub searchreservationbtn_Click(sender As Object, e As EventArgs) Handles searchreservationbtn.Click
        Dim resID As String = searchreservationtxt.Text
        Dim resIDInt As Integer

        If Integer.TryParse(resID, resIDInt) = False Then
            MessageBox.Show("Conversion of Int MovieID failed")
        Else
            Dim result As Tuple(Of Integer, String, Integer, Integer) = SearchDataReservation(resIDInt)

            If result.Item2 <> "" Then
                searchreservationtxt.Text = result.Item1
                tickettypecmb.Text = result.Item2
                searchcustomertxt.Text = result.Item3
                searchmovietxt.Text = result.Item4


                Dim cusID As Integer = Integer.Parse(searchcustomertxt.Text)
                Dim movID As Integer = Integer.Parse(searchmovietxt.Text)

                Dim resultc As Tuple(Of Integer, String, String, String, String, Integer) = SearchDataCustomer(cusID)

                searchcustomertxt.Text = resultc.Item1
                customerfirstnametxt.Text = resultc.Item2
                customerlastnametxt.Text = resultc.Item3
                customermiddlenametxt.Text = resultc.Item4
                customeremailtxt.Text = resultc.Item5
                agetxt.Text = resultc.Item6

                Dim resultm As Tuple(Of Integer, String, String, Integer) = SearchDataMovie(movID)

                searchmovietxt.Text = resultm.Item1
                movienametxt.Text = resultm.Item2
                moviegenretxt.Text = resultm.Item3
                moviedurationtxt.Text = resultm.Item4
            End If
        End If
    End Sub

    Private Sub reserveticketbtn_Click(sender As Object, e As EventArgs) Handles reserveticketbtn.Click
        Dim cusID As String = searchcustomertxt.Text
        Dim movID As String = searchmovietxt.Text
        Dim ticketType As String = tickettypecmb.Text

        Dim cusIDInt As Integer
        Dim movIdInt As Integer

        If Integer.TryParse(cusID, cusIDInt) = False Then
            MessageBox.Show("Conversion of Int CustomerID failed")
        ElseIf Integer.TryParse(movID, movIdInt) = False Then
            MessageBox.Show("Conversion of Int MovieID failed")
        ElseIf tickettypecmb.SelectedIndex = -1 Then
            MessageBox.Show("Select Ticket Type")
        Else
            AddReservationData(
            ticketType,
            cusIDInt,
            movIdInt
            )
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_reservation")
            clearTxtBoxes()
            tickettypecmb.Enabled = False
        End If

    End Sub



    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        Dim resID As String = searchreservationtxt.Text
        Dim resIDInt As Integer

        If Integer.TryParse(resID, resIDInt) = False Then
            MessageBox.Show("Conversion of Int ReservationID failed")
        Else
            DeleteData("tbl_reservation", "ReservationID", resIDInt)

            DataGridView1.DataSource = RetrieveDataFromTable("tbl_reservation")
            clearTxtBoxes()
        End If
    End Sub




    Private Sub clearTxtBoxes()
        searchreservationtxt.Text = String.Empty
        searchmovietxt.Text = String.Empty
        searchcustomertxt.Text = String.Empty

        movienametxt.Text = String.Empty
        moviegenretxt.Text = String.Empty
        moviedurationtxt.Text = String.Empty

        customerfirstnametxt.Text = String.Empty
        customerlastnametxt.Text = String.Empty
        customermiddlenametxt.Text = String.Empty
        customeremailtxt.Text = String.Empty
        agetxt.Text = String.Empty

        tickettypecmb.SelectedIndex = -1
    End Sub

    Private Sub addnewbtn_Click(sender As Object, e As EventArgs) Handles addnewbtn.Click
        tickettypecmb.Enabled = True
    End Sub
End Class