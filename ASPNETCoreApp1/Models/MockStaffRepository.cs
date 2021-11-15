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
                new Staff(){Id=1, FirstName="MuhammadAli", LastName="Safoyev", Email="safoyevma@gmailcom", Department="Admin"},

                new Staff(){Id=2, FirstName="Ramziddin", LastName="Tolibov", Email="tolibov_r1304@gmail.com", Department="Dekan"},

                new Staff(){Id=3, FirstName="Dilnoza", LastName="To'yboyeva", Email="dilnoza_t@gmail.com", Department="O'qituvchi"}
            };
        }
        public Staff Get(int id)
        {
            return _staffs.FirstOrDefault(staff => staff.Id.Equals(id));
        }
    }
}
