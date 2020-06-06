using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.DTO.Employee;


namespace OOPS.WebUI.Controllers
{
    public class SettingsController : BaseController
    {

        private ISystemEducationService service;
        private IEmployeeService employeeservice;
        public SettingsController(ISystemEducationService _service, IEmployeeService _employeeservice)
        {
            service = _service;
            employeeservice = _employeeservice;
        }
        public IActionResult Index()
        {

            SystemEducationDTO model = new SystemEducationDTO();
            model.CompanyID = CurrentUser.CompanyID;
            return View(model);
        }

        [HttpPost]
        public IActionResult AddSystemEducation(SystemEducationDTO systemEducation)
        {
            systemEducation.CompanyID = CurrentUser.CompanyID;
            service.newSystemEducation(systemEducation);
            return RedirectToAction("Index");
        }

        public IActionResult ListSystemEducation()
        {
            int companyId =(int) CurrentUser.CompanyID;
            List<SystemEducationDTO> systemEducation = service.getAllSystemEducations(companyId);
            return View(systemEducation);
        }

        //[HttpPost]
        //public IActionResult ListSystemEducation(SystemEducationDTO systemEducation)
        //{

        //    service.getSystemEducation(systemEducation.Id);
        //    return RedirectToAction("Index");
        //}
    }
}
