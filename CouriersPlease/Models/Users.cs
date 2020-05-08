using System;
using System.Collections.Generic;

namespace CouriersPlease.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
    }
}
