using ASPNETCoreApp1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreApp1.Controllers
{
    public class HomeController:Controller
    {
        private readonly IStaffRepository _staffRepository;

        public HomeController(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }
        public ViewResult Index()
        {
            return View();
        }
        public JsonResult Data()
        {
            return Json(new {id=20, firstName="Faxriddin", lastName="Xushnazarov"});
        }
        public string Staff()
        {
            return _staffRepository.Get(3)?.FirstName;
        }
    }
}
