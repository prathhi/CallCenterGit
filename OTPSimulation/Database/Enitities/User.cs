using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTPSimulation.Database.Enitities
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
        public string MobileNumber { get; set; }

             

    }
}
