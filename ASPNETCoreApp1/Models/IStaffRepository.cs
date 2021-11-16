using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreApp1.Models
{
    public interface IStaffRepository
    {
        Staff Get(int id);
        IEnumerable<Staff> GetAll();
    }
}
