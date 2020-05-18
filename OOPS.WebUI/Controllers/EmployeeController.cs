using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;
using OOPS.WebUI.Models;

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
            int companyId =(int)CurrentUser.CompanyID;

            //Giriş yapan kullanıcının EMployee Id boş degılse = ? Detail sayfasını çapırmak lazım.
            if (RoleName == "Admin")
            {
                return RedirectToAction(nameof(List));
            }
            else
            {
                return RedirectToAction(nameof(DetailEmployee));
            }
        }

        public IActionResult List()
        {
            int companyId = (int)CurrentUser.CompanyID;
            List<EmployeeDTO> employee = service.getCompanyEmployees(companyId);
            //o firmadli çalışanlar lsitelenecek
            return View(employee);
        }

        public IActionResult EditEmployee(int id)
        {
            EmployeeDTO emp = service.getEmployee(id);
            //kullanıcının detayı ve update işlemi
            StaticTypesViewModel model = new StaticTypesViewModel();
            model.Employee = emp;
            return View(model);
        }

        [HttpPost]
        public IActionResult EditEmployee(EmployeeDTO employee)
        {
            service.updateEmployee(employee);
            return View();
        }

        public IActionResult DetailEmployee()
        {
            //Giriş yapan Employee ise 
            int userID = CurrentUser.Id;
            var empInfo = service.getEmployeeUser(userID);
            return View(empInfo);
        }

        public IActionResult AddEmployee()
        {
            EmployeeDTO emp = new EmployeeDTO();
            return View(emp);
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeDTO employee)
        {
            employee.CompanyID = (int)CurrentUser.CompanyID;
            service.newEmployee(employee);
            return RedirectToAction("List");
        }

        public IActionResult DeleteEmployee(int Id)
        {
            service.deleteEmployee(Id);
            return RedirectToAction("List");
        }

    }
}