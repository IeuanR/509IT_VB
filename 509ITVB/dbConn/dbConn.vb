Imports System.Configuration
Imports MySql.Data.MySqlClient

Class dbConn
    Public Property varConfigServer As String
    Public Property varConfigDatabase As String
    Public Property varConfigUser As String
    Public Property varConfigPass As String
    Private connString As String
    Public conn As MySqlConnection
    Public mySQLda As MySqlDataAdapter

    Public Sub connect()
        connString = ConfigurationManager.ConnectionStrings("MyKey").ConnectionString
        conn = New MySqlConnection(connString)
    End Sub

    Public Function connOpen() As Boolean
        Try
            conn.Open()
            Return True
        Catch err As MySqlException

            Select Case err.Number
                Case 0
                    MessageBox.Show("Server connection failure")
                Case 1045
                    MessageBox.Show("User/Password Error")
                Case Else
                    MessageBox.Show(err.Message)
            End Select

            Return False
        End Try
    End Function

    Public Function connClose() As Boolean
        Try
            conn.Close()
            Return True
        Catch err As MySqlException
            MessageBox.Show("Error: " & err.Message)
            Return False
        End Try
    End Function

    Public Function qry(ByVal sql As String) As DataSet
        mySQLda = New MySqlDataAdapter(sql, conn)
        Dim ds As DataSet = New DataSet()
        mySQLda.Fill(ds)
        connClose()
        Return ds
    End Function
End Class
