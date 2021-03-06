using ASPNETCoreApp1.Models;
using ASPNETCoreApp1.ViewModels;
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
            HomeIndexViewModel viewModel = new HomeIndexViewModel()
            {
                Staffs = _staffRepository.GetAll()
            };
            return View(viewModel);
        } 
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel viewModel = new HomeDetailsViewModel()
            {
                Staff = _staffRepository.Get((id%(_staffRepository.GetAll().Count()+1)??1)==0?1:(id % (_staffRepository.GetAll().Count() + 1) ?? 1)),
                Title = $"SELECTED USER"
            };
            return View(viewModel);
        }
        public ViewResult Ruyhat()
        {
            List<Staff> staffs=new List<Staff>();
            for(int i=0; i<3; i++)
            {
                staffs.Add(_staffRepository.Get(i+1));
            }
            ViewData["staff"]=staffs;
            ViewBag.title = "Birinchi ASP.NET Core MVC dasturim";
            return View();
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Staff staff)
        {
            if (ModelState.IsValid) {
                var newStaff = _staffRepository.Create(staff);
                return RedirectToAction("details", new { id = newStaff.Id });
            }
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
