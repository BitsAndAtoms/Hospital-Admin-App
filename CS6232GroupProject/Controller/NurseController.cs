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


        //Below from rchesser

        /// <summary>
        /// Get Nurse
        /// </summary>
        /// <param name="newNurse"></param>
        /// <returns></returns>
        public List<Nurse> GetSearchNurseByNameDOB(Nurse newNurse)
        {
            return this.nurseSource.GetSearchNurseByNameDOB(newNurse);
        }

        /// <summary>
        /// Register a nurse
        /// </summary>
        /// <param name="newNurse"></param>
        /// <param name="newAddress"></param>
        internal void registerNurse(Nurse newNurse, Address newAddress, Login newLogin)
        {
            this.nurseSource.registerNurseInDB(newNurse, newAddress, newLogin);
        }

        /// <summary>
        /// Update a nurse
        /// </summary>
        /// <param name="newNurse"></param>
        /// <param name="newAddress"></param>
        internal void updateNurse(Nurse newNurse, Address newAddress, Login newLogin)
        {
            this.nurseSource.updateNurse(newNurse, newAddress, newLogin);
        }
    }
}
