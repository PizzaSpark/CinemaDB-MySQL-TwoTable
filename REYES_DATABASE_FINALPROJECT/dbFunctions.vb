Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Module dbFunctions
    Dim connectionConfig As String = "server=localhost; user=root; password=12345; database=db_cinematicket;"
    Dim connection As New MySqlConnection(connectionConfig)

    Public Sub connectDB()
        connection.Open()
        MessageBox.Show("Successful connection")

    End Sub

    Public Sub closeDB()
        connection.Close()
        MessageBox.Show("Closed connection")
    End Sub

    Public Sub DeleteData(tableName As String, primaryKeyColumnName As String, primaryKeyValue As Integer)

        Try
            Dim query As String = $"DELETE FROM {tableName} WHERE {primaryKeyColumnName} = @primaryKeyValue"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue)

            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Failed to delete data: " & ex.Message)
        End Try
    End Sub

    Public Function RetrieveDataFromTable(tableName As String) As DataTable
        Dim dataTable As New DataTable()
        Try
            Dim adapter As New MySqlDataAdapter($"SELECT * FROM {tableName}", connection)

            ' Fill the data table with data from the adapter
            adapter.Fill(dataTable)

        Catch ex As Exception
            ' Handle error
            MessageBox.Show("Failed to retrieve data: " & ex.Message)
        End Try

        Return dataTable
    End Function

    Public Function SearchDataCustomer(primaryKeyValue As Integer)
        Dim id As Integer
        Dim firstname As String
        Dim lastname As String
        Dim middlename As String
        Dim email As String
        Dim age As Integer

        Dim query As String = $"SELECT * FROM tbl_customer WHERE CustomerID = @primaryKeyValue"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue)

        ' Execute the command and retrieve a data reader
        Dim reader As MySqlDataReader = command.ExecuteReader()

        ' Read the data from the reader
        If reader.Read() Then
            ' Get the values from the reader for each column
            id = reader("CustomerID")
            firstname = reader("CustomerFirstName").ToString()
            lastname = reader("CustomerLastName").ToString()
            middlename = reader("CustomerMiddleName").ToString()
            email = reader("CustomerEmail").ToString()
            age = reader("CustomerAge")

        Else
            MessageBox.Show("No data found for the given primary key.")
        End If

        reader.Close()

        Return Tuple.Create(id, firstname, lastname, middlename, email, age)
    End Function

    Public Function SearchDataMovie(primaryKeyValue As Integer)
        Dim id As Integer
        Dim name As String
        Dim genre As String
        Dim duration As Integer

        Dim query As String = $"SELECT * FROM tbl_movie WHERE MovieID = @primaryKeyValue"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue)

        ' Execute the command and retrieve a data reader
        Dim reader As MySqlDataReader = command.ExecuteReader()

        ' Read the data from the reader
        If reader.Read() Then
            ' Get the values from the reader for each column
            id = reader("MovieID")
            name = reader("MovieName").ToString()
            genre = reader("MovieGenre").ToString()
            duration = reader("MovieDuration")
        Else
            MessageBox.Show("No data found for the given primary key.")
        End If

        reader.Close()

        Return Tuple.Create(id, name, genre, duration)
    End Function

    Public Function SearchDataReservation(primaryKeyValue As Integer)
        Dim resID As Integer
        Dim ticketType As String
        Dim cusID As Integer
        Dim movID As Integer

        Dim query As String = $"SELECT * FROM tbl_reservation WHERE ReservationID = @primaryKeyValue"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue)

        Dim reader As MySqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            resID = reader("ReservationID")
            ticketType = reader("TicketType")
            cusID = reader("CustomerID")
            movID = reader("MovieID")


        Else
            MessageBox.Show("No data found for the given primary key.")

        End If

        reader.Close()
        Return Tuple.Create(resID, ticketType, cusID, movID)
    End Function

    Public Sub AddCustomerData(id As Integer, firstname As String, lastname As String, middlename As String, email As String, age As Integer)
        Try
            Dim query As String = "INSERT INTO tbl_customer (CustomerID, CustomerFirstName, CustomerLastName, CustomerMiddleName, CustomerEmail, CustomerAge) VALUES (@id, @firstname, @lastname, @middlename, @email, @age)"
            Dim command As New MySqlCommand(query, connection)

            ' Set parameter values
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@firstname", firstname)
            command.Parameters.AddWithValue("@lastname", lastname)
            command.Parameters.AddWithValue("@middlename", middlename)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@age", age)

            ' Execute the command
            command.ExecuteNonQuery()


        Catch ex As Exception
            ' Handle error
            MessageBox.Show("Failed to insert data: " & ex.Message)
        End Try
    End Sub

    Public Sub AddMovieData(id As Integer, name As String, genre As String, duration As Integer)
        Try
            Dim query As String = "INSERT INTO tbl_movie (MovieID, MovieName, MovieGenre, MovieDuration) VALUES (@id, @name, @genre, @duration)"
            Dim command As New MySqlCommand(query, connection)

            ' Set parameter values
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@genre", genre)
            command.Parameters.AddWithValue("@duration", duration)

            ' Execute the command
            command.ExecuteNonQuery()

        Catch ex As Exception
            ' Handle error
            MessageBox.Show("Failed to insert data: " & ex.Message)
        End Try
    End Sub

    Public Sub AddReservationData(ticketType As String, customerID As Integer, movieID As Integer)
        Try
            Dim query As String = "INSERT INTO tbl_reservation (ReservationID, TicketType, CustomerID, MovieID) VALUES (@rid, @tickettype, @cid, @mid)"
            Dim command As New MySqlCommand(query, connection)

            Dim idcombine As String = customerID.ToString() + movieID.ToString()
            ' Set parameter values
            command.Parameters.AddWithValue("@rid", idcombine)
            command.Parameters.AddWithValue("@tickettype", ticketType)
            command.Parameters.AddWithValue("@cid", customerID)
            command.Parameters.AddWithValue("@mid", movieID)

            ' Execute the command
            command.ExecuteNonQuery()


        Catch ex As Exception
            ' Handle error
            MessageBox.Show("Failed to insert data: " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateCustomerData(primaryKeyValue As Integer, newFirstName As String, newLastName As String, newMiddleName As String, newEmail As String, newAge As Integer)
        Dim query As String = "UPDATE tbl_customer SET CustomerFirstName = @NewFirstName, CustomerLastName = @NewLastName, CustomerMiddleName = @NewMiddleName, CustomerEmail = @NewEmail, CustomerAge = @NewAge WHERE CustomerID = @PrimaryKeyValue"
        Dim command As New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@NewFirstName", newFirstName)
        command.Parameters.AddWithValue("@NewLastName", newLastName)
        command.Parameters.AddWithValue("@NewMiddleName", newMiddleName)
        command.Parameters.AddWithValue("@NewEmail", newEmail)
        command.Parameters.AddWithValue("@NewAge", newAge)
        command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue)
        Dim rowsAffected As Integer = command.ExecuteNonQuery()

        If rowsAffected > 0 Then
            Console.WriteLine("Data updated successfully.")
        Else
            Console.WriteLine("No data found for the given primary key.")
        End If
    End Sub

    Public Sub UpdateMovieData(primaryKeyValue As Integer, newName As String, newGenre As String, newDuration As Integer)
        Dim query As String = "UPDATE tbl_movie SET MovieName = @NewName, MovieGenre = @NewGenre, MovieDuration = @NewDuration WHERE MovieID = @PrimaryKeyValue"
        Dim command As New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@NewName", newName)
        command.Parameters.AddWithValue("@NewGenre", newGenre)
        command.Parameters.AddWithValue("@NewDuration", newDuration)
        command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue)
        Dim rowsAffected As Integer = command.ExecuteNonQuery()

        If rowsAffected > 0 Then
            Console.WriteLine("Data updated successfully.")
        Else
            Console.WriteLine("No data found for the given primary key.")
        End If
    End Sub

End Module
