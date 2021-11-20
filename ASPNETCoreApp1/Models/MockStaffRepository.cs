using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreApp1.Models
{
    public class MockStaffRepository : IStaffRepository
    {
        private List<Staff> _staffs = null;
        public MockStaffRepository()
        {
            _staffs = new List<Staff>()
            {
                new Staff(){Id=1, FirstName="Faxriddin", LastName="Xushnazarov", Email="xushnazarov155@gmailcom", Department=Departments.Admin},

                new Staff(){Id=2, FirstName="Ramziddin", LastName="Tolibov", Email="tolibov_r1304@gmail.com", Department=Departments.Dekan},

                new Staff(){Id=3, FirstName="Dilnoza", LastName="To'yboyeva", Email="dilnoza_t@gmail.com", Department=Departments.Oqituvchi}
            };
        }

        public Staff Create(Staff staff)
        {
            staff.Id = _staffs.Max(s => s.Id) + 1;
            _staffs.Add(staff);
            return staff;
        }

        public Staff Get(int id)
        {
            return _staffs.FirstOrDefault(staff => staff.Id.Equals(id));
        }

        public IEnumerable<Staff> GetAll()
        {
            return _staffs;
        }
    }
}
