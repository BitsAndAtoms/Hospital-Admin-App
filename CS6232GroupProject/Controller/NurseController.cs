using CS6232GroupProject.DAL;
using CS6232GroupProject.Model;
using System.Collections.Generic;

namespace CS6232GroupProject.Controller
{
    class NurseController
    {
        private readonly NurseDAL nurseSource;

        public NurseController()
        {
            this.nurseSource = new NurseDAL();
        }

        public List<Nurse> GetSearchNurseByNameDOB(Nurse newNurse)
        {
            return this.nurseSource.GetSearchNurseByNameDOB(newNurse);
        }

        internal void registerNurse(Nurse newNurse, Address newAddress)
        {
            this.nurseSource.registerNurseInDB(newNurse, newAddress);
        }
    }
}
