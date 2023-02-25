Imports MySql.Data.MySqlClient

Module ConnectMySql

    Dim conex As String = "server=localhost; Port=3306; user id=root;password=;"
    Dim MySqlConex As MySqlConnection = New MySqlConnection(conex)

    Private result As String
    Private command As New MySqlCommand
    Private adapter As MySqlDataAdapter
    Private dataTable As DataTable

    Sub openConn()
        Try
            If MySqlConex.State = 0 Then
                MySqlConex.Open()
                Console.WriteLine("Se conecto la base de datos")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Sub closeConn()
        MySqlConex.Close()
        Console.WriteLine("Se cerro la conexion de la base de datos")
    End Sub


    Public Sub createNew(query As String)
        Try
            openConn()
            With command
                .Connection = MySqlConex
                .CommandText = query
                result = command.ExecuteNonQuery
                If result > 0 Then
                    MsgBox("Success")
                Else
                    MsgBox("Not Success")
                End If
            End With
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
        closeConn()
    End Sub


    Public Sub Consulta(query As String, data As Object)

        Try
            dataTable = New DataTable
            adapter = New MySqlDataAdapter
            openConn()
            With command
                .Connection = MySqlConex
                .CommandText = query
            End With

            adapter.SelectCommand = command
            adapter.Fill(dataTable)
            data.datasource = dataTable

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        closeConn()
        dataTable.Dispose()

    End Sub

End Module
