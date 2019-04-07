using CS6232GroupProject.DAL;
using CS6232GroupProject.Model;
using System.Collections.Generic;

namespace CS6232GroupProject.Controller
{
    /// <summary>
    /// This class allows the calling of methods in the NurseDAL, to 
    /// get Nurse data from the DB.
    /// </summary>
    class NurseController
    {
        private readonly NurseDAL nurseSource;

        /// <summary>
        /// This constructs the NurseController.
        /// </summary>
        public NurseController()
        {
            this.nurseSource = new NurseDAL();
        }

        /// <summary>
        /// This method returns a list of all Nurse objects.
        /// </summary>
        /// <returns>A list of Nurse objects. </returns>
        public List<Nurse> GetNurses()
        {
            return this.nurseSource.GetNurses();
        }
    }
}
