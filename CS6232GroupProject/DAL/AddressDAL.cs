using CS6232GroupProject.Model;
using System;
using System.Data.SqlClient;

namespace CS6232GroupProject.DAL
{
    /// <summary>
    /// This class creates an AddressDAL object to get data from 
    /// the DB.
    /// </summary>
    class AddressDAL
    {
        /// <summary>
        /// Gets an address by the PK address ID
        /// </summary>
        /// <param name="addressID"></param>
        /// <returns>address</returns>
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
