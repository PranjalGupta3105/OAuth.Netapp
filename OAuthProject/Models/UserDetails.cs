using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationService.Models
{
    public class UserDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Gender { get; set; }
        public long Salary { get; set; }
    }
}