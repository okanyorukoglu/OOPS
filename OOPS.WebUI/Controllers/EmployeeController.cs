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
            int user = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(z => z.Type == "CompanyId").Value); 
            //Giriş yapan kullanıcının EMployee Id boş degılse = ? Detail sayfasını çapırmak lazım.
            if (EmpId !=null)
            {
                return View(service.getCompanyEmployees(user));
            }
            else
            {
                return RedirectToAction("Detail");
            }
            
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}