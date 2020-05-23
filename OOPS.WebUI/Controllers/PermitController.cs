using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;
using OOPS.WebUI.Models;

namespace OOPS.WebUI.Controllers
{
    public class PermitController : BaseController
    {
        private IPermitService service;
        private IEmployeeService employeeservice;
        public PermitController(IPermitService _service, IEmployeeService _employeeservice)
        {
            service = _service;
            employeeservice = _employeeservice;
        }
        //public IActionResult Index()
        //{
        //    var RoleName = CurrentUser.Role.Name;
        //    int companyId =(int)CurrentUser.CompanyID;

        //    //Giriş yapan kullanıcının EMployee Id boş degılse = ? Detail sayfasını çapırmak lazım.
        //    if (RoleName == "Admin")
        //    {
        //        return RedirectToAction(nameof(List));
        //    }
        //    else
        //    {
        //        return RedirectToAction(nameof(DetailEmployee));
        //    }
        //}

        //public IActionResult List()
        //{
        //    int companyId = (int)CurrentUser.CompanyID;
        //    List<EmployeeDTO> employee = service.getCompanyEmployees(companyId);
        //    //o firmadli çalışanlar lsitelenecek
        //    return View(employee);
        //}


        //[HttpPost]
        //public IActionResult EditEmployee(EmployeeDTO employee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        service.updateEmployee(employee);
        //        return View();
        //    }
        //    else
        //    {
        //      var errors=  ModelState.Select(x => x.Value.Errors)
        //                   .Where(y => y.Count > 0)
        //                   .ToList();
        //        return View();
        //    }
        //}

        //public IActionResult DetailEmployee()
        //{
        //    //Giriş yapan Employee ise 
        //    int userID = CurrentUser.Id;
        //    var empInfo = service.getEmployeeUser(userID);
        //    return View(empInfo);
        //}
       
        public IActionResult AddEmployee()
        {
            EmployeeDTO emp = new EmployeeDTO();
            return View(emp);
        }

        [HttpPost]
        public IActionResult AddPermit(PermitDTO permitDto)
        {
            if (permitDto.EmployeeId == 0)
            {
                var emp = employeeservice.getEmployeeUser(CurrentUser.Id);
                permitDto.EmployeeId = emp.Id;
            }
            service.newPermit(permitDto);
            return RedirectToAction("Index","Home");
        }

        //public IActionResult DeleteEmployee(int Id)
        //{
        //    service.deleteEmployee(Id);
        //    return RedirectToAction("List");
        //}

    }
}