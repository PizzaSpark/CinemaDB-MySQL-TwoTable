Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Module dbModule
    Dim connectionConfig As String = "server=localhost; user=root; password=12345; database=db_parkrideticketing;"
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

    Public Function SearchDataGuest(primaryKeyValue As Integer)
        Dim id As Integer
        Dim name As String
        Dim age As Integer
        Dim weight As Integer
        Dim height As Integer

        Dim query As String = $"SELECT * FROM tbl_guest WHERE GuestID = @primaryKeyValue"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue)

        Dim reader As MySqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            id = reader("GuestID")
            name = reader("GuestName").ToString()
            age = reader("GuestAge")
            weight = reader("GuestWeight")
            height = reader("GuestHeight")
        Else
            MessageBox.Show("No data found for the given primary key.")
        End If

        reader.Close()

        Return Tuple.Create(id, name, age, weight, height)
    End Function

    Public Function SearchDataRide(primaryKeyValue As Integer)
        Dim id As Integer
        Dim name As String
        Dim seatCapacity As Integer
        Dim duration As Integer
        Dim waitTime As Integer

        Dim query As String = $"SELECT * FROM tbl_ride WHERE RideID = @primaryKeyValue"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue)

        ' Execute the command and retrieve a data reader
        Dim reader As MySqlDataReader = command.ExecuteReader()

        ' Read the data from the reader
        If reader.Read() Then
            ' Get the values from the reader for each column
            id = reader("RideId")
            name = reader("RideName").ToString()
            seatCapacity = reader("RideSeatCapacity")
            duration = reader("RideDuration")
            waitTime = reader("RideWaitTime")
        Else
            MessageBox.Show("No data found for the given primary key.")
        End If

        reader.Close()

        Return Tuple.Create(id, name, seatCapacity, duration, waitTime)
    End Function

    Public Function SearchDataTicket(primaryKeyValue As Integer)
        Dim tixID As Integer
        Dim ticketType As String
        Dim guestID As Integer
        Dim rideID As Integer

        Dim query As String = $"SELECT * FROM tbl_ticket WHERE TicketID = @primaryKeyValue"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@primaryKeyValue", primaryKeyValue)

        Dim reader As MySqlDataReader = command.ExecuteReader()

        If reader.Read() Then
            tixID = reader("TicketID")
            ticketType = reader("TicketType")
            guestID = reader("GuestID")
            rideID = reader("RideID")


        Else
            MessageBox.Show("No data found for the given primary key.")

        End If

        reader.Close()
        Return Tuple.Create(tixID, ticketType, guestID, rideID)
    End Function

    Public Sub AddGuestData(id As Integer, name As String, age As Integer, weight As Integer, height As Integer)
        Try
            Dim query As String = "INSERT INTO tbl_guest (GuestID, GuestName, GuestAge, GuestWeight, GuestHeight) VALUES (@id, @name, @age, @weight, @height)"
            Dim command As New MySqlCommand(query, connection)

            ' Set parameter values
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@age", age)
            command.Parameters.AddWithValue("@weight", weight)
            command.Parameters.AddWithValue("@height", height)

            ' Execute the command
            command.ExecuteNonQuery()


        Catch ex As Exception
            ' Handle error
            MessageBox.Show("Failed to insert data: " & ex.Message)
        End Try
    End Sub

    Public Sub AddRideData(id As Integer, name As String, seatcapacity As Integer, duration As Integer, waittime As Integer)
        Try
            Dim query As String = "INSERT INTO tbl_ride (RideID, RideName, RideSeatCapacity, RideDuration, RideWaitTime) VALUES (@id, @name, @seatcapacity, @duration, @waittime)"
            Dim command As New MySqlCommand(query, connection)

            ' Set parameter values
            command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@name", name)
            command.Parameters.AddWithValue("@seatcapacity", seatcapacity)
            command.Parameters.AddWithValue("@duration", duration)
            command.Parameters.AddWithValue("@waittime", waittime)

            ' Execute the command
            command.ExecuteNonQuery()

        Catch ex As Exception
            ' Handle error
            MessageBox.Show("Failed to insert data: " & ex.Message)
        End Try
    End Sub

    Public Sub AddTicketData(ticketType As String, guestID As Integer, rideID As Integer)
        Try
            Dim query As String = "INSERT INTO tbl_ticket (TicketID, TicketType, GuestID, RideID) VALUES (@tid, @type, @gid, @rid)"
            Dim command As New MySqlCommand(query, connection)

            Dim idcombine As String = guestID.ToString() + rideID.ToString()
            ' Set parameter values
            command.Parameters.AddWithValue("@tid", idcombine)
            command.Parameters.AddWithValue("@type", ticketType)
            command.Parameters.AddWithValue("@gid", guestID)
            command.Parameters.AddWithValue("@rid", rideID)

            ' Execute the command
            command.ExecuteNonQuery()


        Catch ex As Exception
            ' Handle error
            MessageBox.Show("Failed to insert data: " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateGuestData(primaryKeyValue As Integer, newName As String, newAge As Integer, newWeight As Integer, newHeight As Integer)
        Dim query As String = "UPDATE tbl_guest SET GuestName = @NewName, GuestAge = @NewAge, GuestWeight = @NewWeight, GuestHeight = @NewHeight WHERE GuestID = @PrimaryKeyValue"
        Dim command As New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@NewName", newName)
        command.Parameters.AddWithValue("@NewAge", newAge)
        command.Parameters.AddWithValue("@NewWeight", newWeight)
        command.Parameters.AddWithValue("@NewHeight", newHeight)
        command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue)
        Dim rowsAffected As Integer = command.ExecuteNonQuery()

        If rowsAffected > 0 Then
            Console.WriteLine("Data updated successfully.")
        Else
            Console.WriteLine("No data found for the given primary key.")
        End If
    End Sub

    Public Sub UpdateRideData(primaryKeyValue As Integer, newName As String, newSeatCapacity As Integer, newDuration As Integer, newWaitTime As Integer)
        Dim query As String = "UPDATE tbl_ride SET RideName = @NewName, RideSeatCapacity = @NewSeatCapacity, RideDuration = @NewDuration, RideWaitTime = @NewWaitTime WHERE RideID = @PrimaryKeyValue"
        Dim command As New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@NewName", newName)
        command.Parameters.AddWithValue("@NewSeatCapacity", newSeatCapacity)
        command.Parameters.AddWithValue("@NewDuration", newDuration)
        command.Parameters.AddWithValue("@NewWaitTime", newWaitTime)
        command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue)
        Dim rowsAffected As Integer = command.ExecuteNonQuery()

        If rowsAffected > 0 Then
            Console.WriteLine("Data updated successfully.")
        Else
            Console.WriteLine("No data found for the given primary key.")
        End If
    End Sub
End Module
