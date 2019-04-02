using System;
using System.Collections.Generic;

namespace CS6232GroupProject.Model
{
    /// <summary>
    /// This class creates the Gender object.
    /// </summary>
    class Gender
    {
        /// <summary>
        /// This method sets a list of genders to choose from.
        /// </summary>
        /// <returns>A list of Genders</returns>
        public static List<String> GetGender()
        {
            List<String> GenderList = new List<String>
            {
                "M",
                "F"
            };
            return GenderList;

        }
    }
}
