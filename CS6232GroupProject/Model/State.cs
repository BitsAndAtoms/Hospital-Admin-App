using System;
using System.Collections.Generic;

namespace CS6232GroupProject.Model
{
    /// <summary>
    /// This class creates a State object.
    /// </summary>
    class State
    {
        /// <summary>
        /// This method creates a list of States to choose from.
        /// </summary>
        /// <returns>A list of states.</returns>
        public static List<String> GetStates()
        {
            List<String> StateList = new List<String>
            {
                "Alabama",
                "Alaska",
                "Arizona",
                "Arkansas",
                "California",
                "Colorado",
                "Connecticut",
                "Delaware",
                "Florida",
                "Georgia",
                "Hawaii",
                "Idaho",
                "Illinois",
                "Indiana",
                "Iowa",
                "Kansas",
                "Kentucky",
                "Louisiana",
                "Maine",
                "Maryland",
                "Massachusetts",
                "Michigan",
                "Minnesota",
                "Mississippi",
                "Missouri",
                "Montana",
                "Nebraska",
                "Nevada",
                "New Hampshire",
                "New Jersey",
                "New Mexico",
                "New York",
                "North Carolina",
                "North Dakota",
                "Ohio",
                "Oklahoma",
                "Oregon",
                "Pennsylvania",
                "Rhode Island",
                "South Carolina",
                "South Dakota",
                "Tennessee",
                "Texas",
                "Utah",
                "Vermont",
                "Virginia",
                "Washington",
                "West Virginia",
               "Wisconsin",
                "Wyoming"
            };
            return StateList;
        }

    }
}
