using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.DTO.ProjectBase;

namespace OOPS.WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService service;
        public EmployeeController(IEmployeeService _service)
        {
            service = _service;
        }
        public IActionResult Index()
        {
            var EmpId = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "EmpId")?.Value;
          
            //Giriş yapan kullanıcının EMployee Id boş degılse = ? Detail sayfasını çapırmak lazım.
            if (true)
            {

            }
            else
            {
                service.getCompanyEmployees(new UserDTO());
            }
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}