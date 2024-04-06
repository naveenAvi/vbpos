Imports MySqlConnector

Public Class DBConnection
    Private Sub Connect()
        Dim connStr As String = "server=localhost;user=root;database=posvb;port=3306;password=;"
        Dim conn As New MySqlConnection(connStr)
        Try
            Console.WriteLine("Connecting to MySQL...")
            conn.Open()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try
        conn.Close()
        Console.WriteLine("Done.")
    End Sub
    Public Function addData(str_carSql As String)
        Dim connStr As String = "server=localhost;user=root;database=posvb;port=3306;password=;"
        Dim conn As New MySqlConnection(connStr)
        conn.Open()
        Dim sqlCommand As New MySqlCommand

        Try
            sqlCommand.Connection = conn
            sqlCommand.CommandText = str_carSql
            sqlCommand.ExecuteScalar()

            Return sqlCommand.LastInsertedId
        Catch ex As Exception
            Return "False"
            MsgBox("Error occured: Could not insert record")
        End Try
    End Function

    Public Function getData(ByVal id As String, ByVal tableName As String)
        Dim idFilter As String = ""

        If (Not id = "") Then

            idFilter = "AND id='" + id + "'"
        End If

        Dim sql_connection As New MySqlConnection
        Dim sql_query As New MySqlCommand
        Dim sql_result As MySqlDataReader
        sql_connection.ConnectionString = "server=localhost;user=root;database=posvb;port=3306;password=;"
        sql_query.Connection = sql_connection
        sql_connection.Open()
        sql_query.CommandText = "SELECT * FROM " + tableName + " where status=1 " + idFilter
        sql_result = sql_query.ExecuteReader
        If sql_result.HasRows Then
            Return sql_result
        Else
            Return False
        End If
    End Function

    Public Function getDataSearch(ByVal searchStr As String, ByVal tableName As String)
        Dim sql_connection As New MySqlConnection
        Dim sql_query As New MySqlCommand
        Dim sql_result As MySqlDataReader
        sql_connection.ConnectionString = "server=localhost;user=root;database=posvb;port=3306;password=;"
        sql_query.Connection = sql_connection
        sql_connection.Open()
        sql_query.CommandText = "SELECT * FROM " + tableName + " where status=1 " + searchStr
        sql_result = sql_query.ExecuteReader
        If sql_result.HasRows Then
            Return sql_result
        Else
            Return False
        End If
    End Function

    Public Function delete(id)
        Dim sql_connection As New MySqlConnection
        Dim sql_query As New MySqlCommand
        Dim sql_result As MySqlDataReader
        sql_connection.ConnectionString = "server=localhost;user=root;database=posvb;port=3306;password=;"
        sql_query.Connection = sql_connection
        sql_connection.Open()
        sql_query.CommandText = "UPDATE customers SET status=0 WHERE id='" + id + "'"
        sql_query.ExecuteNonQuery()
        sql_connection.Close()
    End Function
End Class
