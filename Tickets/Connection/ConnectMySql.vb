Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Module ConnectMySql

    Dim conex As String = "server=localhost; Port=3306; user id=root;password=;"
    Dim MySqlConex As MySqlConnection = New MySqlConnection(conex)

    Private result As Integer
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


    Public Function ConsultaNonQuery(query As String) As Integer
        Try
            openConn()
            With command
                .Connection = MySqlConex
                .CommandText = query
                result = command.ExecuteNonQuery
            End With
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        closeConn()

        Return result
    End Function


    ' Esta consulta llena los datos en un dataTable el cual se puede reutilizar en cualquier momento
    Public Sub ConsultaDataTable(query As String, dataTable As DataTable)

        Try
            adapter = New MySqlDataAdapter
            openConn()
            With command
                .Connection = MySqlConex
                .CommandText = query
            End With

            adapter.SelectCommand = command
            adapter.Fill(dataTable)

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        closeConn()

    End Sub


    'Este metodo ayuda con el hash de la contrase;a
    Public Function Hash512(password As String) As String
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & "TicketsApp")
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function

End Module
