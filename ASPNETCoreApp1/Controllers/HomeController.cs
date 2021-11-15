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

        public ViewResult ViewOne()
        {
            return View("View1");
        }
        public ViewResult ViewTwo()
        {
            return View("../Others/View2");
        }
        public ViewResult ViewThree()
        {
            return View("~/Pages/View3.cshtml");
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
