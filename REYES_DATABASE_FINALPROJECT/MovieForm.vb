Imports Google.Protobuf.Collections

Public Class MovieForm
    Private Sub MovieForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
        DataGridView1.DataSource = RetrieveDataFromTable("tbl_movie")
    End Sub

    Private Sub MovieForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        closeDB()
    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        Dim frm As New Dashboard
        frm.Show()
        Me.Close()
    End Sub

    Private Sub searchmoviebtn_Click(sender As Object, e As EventArgs) Handles searchmoviebtn.Click
        Dim movID As String = movieIDtxt.Text
        Dim movIDInt As Integer

        If Integer.TryParse(movID, movIDInt) = False Then
            MessageBox.Show("Conversion of Int MovieID failed")
        Else
            Dim result As Tuple(Of Integer, String, String, Integer) = SearchDataMovie(movIDInt)

            If result.Item2 <> "" Then
                movieIDtxt.Text = result.Item1
                movienametxt.Text = result.Item2
                moviegenrecmb.Text = result.Item3
                moviedurationtxt.Text = result.Item4
                disableTxtBoxes()
            End If
        End If
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        clearTxtBoxes()
        enableTxtBoxes()

    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        Dim movID As String = movieIDtxt.Text
        Dim name As String = movienametxt.Text
        Dim genre As String = moviegenrecmb.Text
        Dim duration As String = moviedurationtxt.Text

        Dim movIdInt As Integer
        Dim durationInt As Integer

        If Integer.TryParse(movID, movIdInt) = False Then
            MessageBox.Show("Conversion of Int MovieID failed")
        ElseIf Integer.TryParse(duration, durationInt) = False Then
            MessageBox.Show("Conversion of Int Duration failed")
        Else
            AddMovieData(
            movIdInt,
            name,
            genre,
            durationInt
            )

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_movie")
        End If
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Dim movID As String = movieIDtxt.Text
        Dim name As String = movienametxt.Text
        Dim genre As String = moviegenrecmb.Text
        Dim duration As String = moviedurationtxt.Text

        Dim movIdInt As Integer
        Dim durationInt As Integer

        If Integer.TryParse(movID, movIdInt) = False Then
            MessageBox.Show("Conversion of Int MovieID failed")
        ElseIf Integer.TryParse(duration, durationInt) = False Then
            MessageBox.Show("Conversion of Int Duration failed")
        Else
            UpdateMovieData(
            movIdInt,
            name,
            genre,
            durationInt
            )

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_movie")
        End If
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        Dim movID As String = movieIDtxt.Text
        Dim movIdInt As Integer

        If Integer.TryParse(movID, movIdInt) = False Then
            MessageBox.Show("Conversion of Int MovieID failed")
        Else
            DeleteData("tbl_movie", "MovieID", movIdInt)

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_movie")
        End If
    End Sub

    Private Sub enableTxtBoxes()
        movienametxt.Enabled = True
        moviegenrecmb.Enabled = True
        moviedurationtxt.Enabled = True
    End Sub
    Private Sub disableTxtBoxes()
        movienametxt.Enabled = False
        moviegenrecmb.Enabled = False
        moviedurationtxt.Enabled = False
    End Sub

    Private Sub clearTxtBoxes()
        movienametxt.Text = String.Empty
        moviegenrecmb.SelectedIndex = -1
        moviedurationtxt.Text = String.Empty
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Retrieve the values from the selected row
            Dim id As Integer = selectedRow.Cells("MovieID").Value.ToString()
            Dim name As String = selectedRow.Cells("MovieName").Value.ToString()
            Dim genre As String = selectedRow.Cells("MovieGenre").Value.ToString()
            Dim duration As String = selectedRow.Cells("MovieDuration").Value.ToString()

            ' Populate the text boxes with the retrieved values
            movieIDtxt.Text = id
            movienametxt.Text = name
            moviegenrecmb.Text = genre
            moviedurationtxt.Text = duration
        End If
    End Sub
End Class