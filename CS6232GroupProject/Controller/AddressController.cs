using CS6232GroupProject.DAL;
using CS6232GroupProject.Model;

namespace CS6232GroupProject.Controller
{
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

        public Address GetAddressByID(int addressID)
        {
            return this.addressSource.GetAddressByID(addressID);
        }
    }
}
