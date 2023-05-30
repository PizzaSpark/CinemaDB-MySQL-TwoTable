Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes

Public Class CustomerForm
    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDB()
        DataGridView1.DataSource = RetrieveDataFromTable("tbl_customer")
    End Sub

    Private Sub CustomerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        closeDB()
    End Sub

    Private Sub homebtn_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        Dim frm As New Dashboard
        frm.Show()
        Me.Close()
    End Sub

    Private Sub searchcustomerbtn_Click(sender As Object, e As EventArgs) Handles searchcustomerbtn.Click
        Dim cusID As String = customerIDtxt.Text
        Dim cusIdInt As Integer

        If Integer.TryParse(cusID, cusIdInt) = False Then
            MessageBox.Show("Conversion of Int Customer failed")
        Else
            Dim result As Tuple(Of Integer, String, String, String, String, Integer) = SearchDataCustomer(cusIdInt)

            If result.Item2 <> "" Then
                customerIDtxt.Text = result.Item1
                firstNametxt.Text = result.Item2
                lastNametxt.Text = result.Item3
                middlenametxt.Text = result.Item4
                emailtxt.Text = result.Item5
                agetxt.Text = result.Item6

                disableTxtBoxes()
            End If
        End If
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        clearTxtBoxes()
        enableTxtBoxes()
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        'insert database code here to add shit
        Dim cusID As String = customerIDtxt.Text
        Dim firstn As String = firstNametxt.Text
        Dim lastn As String = lastNametxt.Text
        Dim middlen As String = middlenametxt.Text
        Dim email As String = emailtxt.Text
        Dim age As String = agetxt.Text

        Dim cusIdInt As Integer
        Dim ageInt As Integer

        If Integer.TryParse(cusID, cusIdInt) = False Then
            MessageBox.Show("Conversion of Int Customer failed")
        ElseIf Integer.TryParse(age, ageInt) = False Then
            MessageBox.Show("Conversion of Int Age failed")
        Else
            AddCustomerData(
            cusID,
            firstn,
            lastn,
            middlen,
            email,
            age
            )

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_customer")
        End If

    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        'update info by setting new values for that ID
        Dim cusID As String = customerIDtxt.Text
        Dim firstn As String = firstNametxt.Text
        Dim lastn As String = lastNametxt.Text
        Dim middlen As String = middlenametxt.Text
        Dim email As String = emailtxt.Text
        Dim age As String = agetxt.Text

        Dim cusIdInt As Integer
        Dim ageInt As Integer

        If Integer.TryParse(cusID, cusIdInt) = False Then
            MessageBox.Show("Conversion of Int Customer failed")
        ElseIf Integer.TryParse(age, ageInt) = False Then
            MessageBox.Show("Conversion of Int Age failed")
        Else
            UpdateCustomerData(
            cusID,
            firstn,
            lastn,
            middlen,
            email,
            age
            )

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_customer")
        End If


        disableTxtBoxes()
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        'delete info for the selected id
        Dim cusID As String = customerIDtxt.Text
        Dim cusIdInt As Integer

        If Integer.TryParse(cusID, cusIdInt) = False Then
            MessageBox.Show("Conversion of Int Customer failed")
        Else
            DeleteData("tbl_customer", "CustomerID", cusIdInt)

            disableTxtBoxes()
            clearTxtBoxes()
            DataGridView1.DataSource = RetrieveDataFromTable("tbl_customer")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Retrieve the values from the selected row
            Dim id As Integer = selectedRow.Cells("CustomerID").Value.ToString()
            Dim firstname As String = selectedRow.Cells("CustomerFirstName").Value.ToString()
            Dim lastname As String = selectedRow.Cells("CustomerLastName").Value.ToString()
            Dim middlename As String = selectedRow.Cells("CustomerMiddleName").Value.ToString()
            Dim email As String = selectedRow.Cells("CustomerEmail").Value.ToString()
            Dim age As Integer = selectedRow.Cells("CustomerAge").Value.ToString()




            ' Populate the text boxes with the retrieved values
            customerIDtxt.Text = id
            firstNametxt.Text = firstname
            lastNametxt.Text = lastname
            middlenametxt.Text = middlename
            emailtxt.Text = email
            agetxt.Text = age
        End If
    End Sub

    Private Sub enableTxtBoxes()
        firstNametxt.Enabled = True
        lastNametxt.Enabled = True
        middlenametxt.Enabled = True
        emailtxt.Enabled = True
        agetxt.Enabled = True
    End Sub

    Private Sub disableTxtBoxes()
        firstNametxt.Enabled = False
        lastNametxt.Enabled = False
        middlenametxt.Enabled = False
        emailtxt.Enabled = False
        agetxt.Enabled = False
    End Sub

    Private Sub clearTxtBoxes()
        firstNametxt.Text = String.Empty
        lastNametxt.Text = String.Empty
        middlenametxt.Text = String.Empty
        emailtxt.Text = String.Empty
        agetxt.Text = String.Empty
    End Sub
End Class