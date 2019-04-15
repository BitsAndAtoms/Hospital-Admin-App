using CS6232GroupProject.DAL;
using System.Collections.Generic;

namespace CS6232GroupProject.Controller
{
    /// <summary>
    /// This class creates a LoginController object to access the
    /// LoginDBDAL methods.
    /// </summary>
    public class LoginController
    {
        private LoginDBDAL loginDetails;

        /// <summary>
        /// Constructor to intialize data source
        /// </summary>
        public LoginController()
        {
            this.loginDetails = new LoginDBDAL();
        }

        /// <summary>
        /// method to check login
        /// </summary>
        /// <param name="inputPassword">is the password of user</param>
        /// <returns>true/false</returns>
        public bool DoCheckLogin(string inputPassword, string inputUserName)
        {
            return this.loginDetails.CheckLogin(inputPassword, inputUserName);
        }

        /// <summary>
        /// method to check user name and role of the person logging in
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>user name and role as list</returns>
        internal List<string> GETUserNameAndRole(string userName)
        {
           List<string> newNameAndRole = this.loginDetails.FindUserNameAndRole(userName);
            return newNameAndRole;
        }

        /// <summary>
        /// This method calls on the LoginDAL method that checks 
        /// if a login username is taken or not.
        /// </summary>
        /// <param name="username"></param>
        ///  <param name="nurseID"></param>
        /// <returns>True or false</returns>
        public bool CheckIfUsernameExists(string username, int nurseID)
        {
            return this.loginDetails.CheckNurseUsername(username, nurseID);
        }

        /// <summary>
        /// This method calls on the LoginDAL method that checks 
        /// if a login username is taken or not.
        /// </summary>
        /// <param name="username"></param>
        /// <returns>True or false</returns>
        public bool CheckIfUsernameExists(string username)
        {
            return this.loginDetails.CheckNurseUsername(username);
        }

    }
}
