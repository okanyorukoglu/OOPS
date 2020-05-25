using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.CompanyAbstract;
using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;
using OOPS.WebUI.Models;

namespace OOPS.WebUI.Controllers
{
    public class EmployeeController : BaseController
    {
        private IEmployeeService service;
        private IEmployeeDetailService employeeDetailService;
        private IEmployeeOtherInfoService employeeOtherInfoService;
       
        public EmployeeController(IEmployeeService _service, IEmployeeDetailService _employeeDetailService, IEmployeeOtherInfoService _employeeOtherInfoService)
        {
            service = _service;
            employeeDetailService = _employeeDetailService;
            employeeOtherInfoService = _employeeOtherInfoService;
           
        }
        public IActionResult Index()
        {
            var RoleName = CurrentUser.Role.Name;
            int companyId = (int)CurrentUser.CompanyID;

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
            EmployeeModel model = new EmployeeModel();
            model.Employee = service.getEmployee(id);
            var empDetail = employeeDetailService.getEmployeeDetail(id);
            var empOtherInfo = employeeOtherInfoService.getEmployeeOtherInfo(id);
            if (empDetail == null)
            {
                model.EmployeeDetail = new EmployeeDetailDTO();
            }
            else
            {
                model.EmployeeDetail = empDetail;
            }
            if (empOtherInfo==null)
            {
                model.EmployeeOtherInfo = new EmployeeOtherInfoDTO();
            }
            else
            {
                model.EmployeeOtherInfo = empOtherInfo;
            }
            //kullanıcının detayı ve update işlemi

            return View(model);
        }

        [HttpPost]
        public IActionResult EditEmployee(EmployeeModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                service.updateEmployee(employeeModel.Employee);

                return RedirectToAction("List");
            }
            else
            {
                var errors = ModelState.Select(x => x.Value.Errors)
                             .Where(y => y.Count > 0)
                             .ToList();
                return View();
            }
        }

        //EmployeeDetail Update and Add
        public IActionResult EditEmployeedetail(EmployeeModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                if (employeeModel.EmployeeDetail.Id == null)
                {
                    //employeeModel.EmployeeDetail.Employee = service.getEmployee(employeeModel.Employee.Id);
                    employeeModel.EmployeeDetail.EmployeeID =employeeModel.Employee.Id;
                    employeeDetailService.newEmployeeDetail(employeeModel.EmployeeDetail);
                    //employeeModel.EmployeeDetail.Employee = service.getEmployee(employeeModel.Employee.Id);
                    //employeeDetailService.updateEmployeeDetail(employeeModel.EmployeeDetail);
                }
                else
                {
                    employeeModel.EmployeeDetail.Employee = service.getEmployee(employeeModel.Employee.Id);
                    employeeDetailService.updateEmployeeDetail(employeeModel.EmployeeDetail);
                }
                
               
                return RedirectToAction("List");
            }
            else
            {
                var errors = ModelState.Select(x => x.Value.Errors)
                             .Where(y => y.Count > 0)
                             .ToList();
                return View();
            }
        }

        //EmployeeOtherInfo Update and Add
        public IActionResult EditEmployeeOtherInfo(EmployeeModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                if (employeeModel.EmployeeOtherInfo.Id == null)
                {          
                    employeeModel.EmployeeOtherInfo.EmployeeID = employeeModel.Employee.Id;
                    employeeOtherInfoService.newEmployeeOtherInfo(employeeModel.EmployeeOtherInfo);
                }
                else
                {
                    employeeModel.EmployeeOtherInfo.Employee = service.getEmployee(employeeModel.Employee.Id);
                    employeeOtherInfoService.updateEmployeeOtherInfo(employeeModel.EmployeeOtherInfo);
                }


                return RedirectToAction("List");
            }
            else
            {
                var errors = ModelState.Select(x => x.Value.Errors)
                             .Where(y => y.Count > 0)
                             .ToList();
                return View();
            }
        }



        //Giriş yapan Employee ise 
        public IActionResult DetailEmployee()
        {
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
            //employeeDetailService.newEmployeeDetail(newEmp.EmployeeDetail);

            return RedirectToAction("List");
        }

        public IActionResult DeleteEmployee(int Id)
        {
            service.deleteEmployee(Id);
            return RedirectToAction("List");
        }

        
    }
}