Imports MySql.Data.MySqlClient

Class ContactDBconn
    Inherits dbConn
    Public Sub insertContact(ByVal Firstname As String, ByVal Lastname As String, ByVal Phone As String, ByVal Mail As String, ByVal Address As String, ByVal Postcode As String, ByVal contType As String)
        Dim comm As MySqlCommand = conn.CreateCommand()
        comm.CommandText = "INSERT INTO `contact` (`ID`, `Firstname`, `Lastname`, `Phone`, `Mail`, `Address`, `Postcode`, `contType`) VALUES (NULL,@Firstname, @Lastname, @Phone, @Mail, @Address, @Postcode, @contType);"
        comm.Parameters.AddWithValue("@Firstname", Firstname)
        comm.Parameters.AddWithValue("@Lastname", Lastname)
        comm.Parameters.AddWithValue("@Phone", Phone)
        comm.Parameters.AddWithValue("@Mail", Mail)
        comm.Parameters.AddWithValue("@Address", Address)
        comm.Parameters.AddWithValue("@Postcode", Postcode)
        comm.Parameters.AddWithValue("@contType", contType)
        comm.ExecuteNonQuery()
        connClose()
    End Sub

    Public Sub updateContact(ByVal ID As String, ByVal Firstname As String, ByVal Lastname As String, ByVal Phone As String, ByVal Mail As String, ByVal Address As String, ByVal Postcode As String, ByVal contType As String)
        Dim comm As MySqlCommand = conn.CreateCommand()
        comm.CommandText = "UPDATE `contact` SET `Firstname`=@Firstname ,`Lastname`=@Lastname,`Phone`=@Phone, `Mail` =@Mail, `Address` =@Address, `Postcode` =@Postcode, `contType` =@contType WHERE `ID` =@ID;"
        comm.Parameters.AddWithValue("ID", ID)
        comm.Parameters.AddWithValue("@Firstname", Firstname)
        comm.Parameters.AddWithValue("@Lastname", Lastname)
        comm.Parameters.AddWithValue("@Phone", Phone)
        comm.Parameters.AddWithValue("@Mail", Mail)
        comm.Parameters.AddWithValue("@Address", Address)
        comm.Parameters.AddWithValue("@Postcode", Postcode)
        comm.Parameters.AddWithValue("@contType", contType)
        comm.ExecuteNonQuery()
        connClose()
    End Sub

    Public Sub deleteContact(ByVal ID As String)
        Dim comm As MySqlCommand = conn.CreateCommand()
        comm.CommandText = "DELETE FROM `contact` WHERE ID = @ID"
        comm.Parameters.AddWithValue("@ID", ID)
        comm.ExecuteNonQuery()
        connClose()
    End Sub
End Class
