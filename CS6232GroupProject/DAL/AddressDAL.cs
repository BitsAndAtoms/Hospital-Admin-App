using CS6232GroupProject.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232GroupProject.DAL
{
    class AddressDAL
    {
        public Address GetAddressByID(int addressID)
        {

            Address address = new Address();

            string selectStatement =
                "SELECT AddressID, State, Zip,  Street " +
                "FROM Address " +
                "WHERE AddressID = @AddressID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AddressID", addressID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            address.AddressID = (int)reader["AddressID"];
                            address.State = reader["State"].ToString();
                            address.Zip = Convert.ToInt32(reader["Zip"].ToString());
                            address.Street = reader["Street"].ToString();
                        }
                    }
                }
            }
            return address;
        }
    }
}
