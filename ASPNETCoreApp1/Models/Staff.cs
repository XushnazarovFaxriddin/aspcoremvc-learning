using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreApp1.Models
{
    public class Staff
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string  LastName { get; set; }

        public string  Email { get; set; }

        public Departments  Department { get; set; }
    }
}
