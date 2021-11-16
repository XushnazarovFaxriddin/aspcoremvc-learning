using ASPNETCoreApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreApp1.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Staff> Staffs { get; set; }
    }
}
