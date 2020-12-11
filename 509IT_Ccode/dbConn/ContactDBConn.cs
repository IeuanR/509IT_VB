using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _509IT_Ccode

{
   
  

    class ContactDBconn : dbConn
    {
        public void insertContact(string Firstname, string Lastname, string Phone, string Mail, string Address, string Postcode, string contType)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `contact` (`ID`, `Firstname`, `Lastname`, `Phone`, `Mail`, `Address`, `Postcode`, `contType`) VALUES (NULL, @Firstname, @Lastname, @Phone, @Mail, @Address, @Postcode, @contType);";
            comm.Parameters.AddWithValue("@Firstname", Firstname);
            comm.Parameters.AddWithValue("@Lastname", Lastname);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Mail", Mail);
            comm.Parameters.AddWithValue("@Address", Address);
            comm.Parameters.AddWithValue("@Postcode", Postcode);
            comm.Parameters.AddWithValue("@contType", contType);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void updateContact(string ID, string Firstname, string Lastname, string Phone, string Mail, string Address, string Postcode, string contType)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `contact` SET `Firstname`=@Firstname ,`Lastname`=@Lastname,`Phone`=@Phone, `Mail` =@Mail, `Address` =@Address, `Postcode` =@Postcode, `contType` =@contType WHERE `ID` =@ID;";
            comm.Parameters.AddWithValue("ID", ID);
            comm.Parameters.AddWithValue("@Firstname", Firstname);
            comm.Parameters.AddWithValue("@Lastname", Lastname);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Mail", Mail);
            comm.Parameters.AddWithValue("@Address", Address);
            comm.Parameters.AddWithValue("@Postcode", Postcode);
            comm.Parameters.AddWithValue("@contType", contType);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void deleteContact(string ID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `contact` WHERE ID = @ID";
            comm.Parameters.AddWithValue("@ID", ID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }

}
