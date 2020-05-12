using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;

namespace OOPS.WebUI.Controllers
{
    public class EmployeeController : BaseController
    {
        private IEmployeeService service;
        public EmployeeController(IEmployeeService _service)
        {
            service = _service;
        }
        public IActionResult Index()
        {
            var RoleName = CurrentUser.Role.Name;
            int companyId = CurrentUser.CompanyId;
            
            //Giriş yapan kullanıcının EMployee Id boş degılse = ? Detail sayfasını çapırmak lazım.
            if (RoleName == "Admin")
            {
                return RedirectToAction(nameof(List)); 
            }
            else
            {
                //int empID = CurrentUser.EmployeeId;
                return View(nameof(Detail));
            }
        }

        public IActionResult List()
        {
            int companyId = CurrentUser.CompanyId;
            var employee = service.getCompanyEmployees(companyId);
            //o firmadli çalışanlar lsitelenecek
            return View(employee);
        }
      
        public IActionResult Detail(int id)
        {
            var emp = service.getEmployee(id);
            //kullanıcının detayı
            return View(emp);
        }
        //[HttpPost]
        //public IActionResult Detail(EmployeeDTO employee)
        //{
        //    //kullanıcının detayı
        //    return RedirectToAction(nameof(Detail));
        //}
    }
}