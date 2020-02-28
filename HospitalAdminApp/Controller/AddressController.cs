using HospitalAdminApp.DAL;
using HospitalAdminApp.Model;

namespace HospitalAdminApp.Controller
{
    /// <summary>
    /// This class creates an AddressController object to call 
    /// methods from the AddressDAL.
    /// </summary>
    class AddressController
    {

        private readonly AddressDAL addressSource;

        /// <summary>
        /// This constructs the Appointment Controller object and 
        /// initialises the AppointmentDAL variable.
        /// </summary>
        public AddressController()
        {
            this.addressSource = new AddressDAL();
        }

        /// <summary>
        /// This method gets an Address object by its ID.
        /// </summary>
        /// <param name="addressID"></param>
        /// <returns>An Address object. </returns>
        public Address GetAddressByID(int addressID)
        {
            return this.addressSource.GetAddressByID(addressID);
        }
    }
}
