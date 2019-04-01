using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232GroupProject.Model
{
    class Gender
    {
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
