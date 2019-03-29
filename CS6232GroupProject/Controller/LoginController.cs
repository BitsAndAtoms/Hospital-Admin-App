﻿using CS6232GroupProject.DAL;
using System.Collections.Generic;

namespace CS6232GroupProject.Controller
{
    
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

        internal List<string> GETUserNameAndRole(string userName)
        {
           List<string> newNameAndRole = this.loginDetails.FindUserNameAndRole(userName);
            return newNameAndRole;
        }
    }
}