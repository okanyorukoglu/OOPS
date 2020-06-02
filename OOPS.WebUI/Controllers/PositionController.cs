using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.DTO.Employee;
using OOPS.WebUI.Models;

namespace OOPS.WebUI.Controllers
{
    public class PositionController : BaseController
    {
        private IPositionService service;
        private IEmployeePositionService employeePositionService;

        public PositionController(IPositionService _service, IEmployeePositionService _employeePositionService)
        {
            service = _service;
            employeePositionService = _employeePositionService;
        }

        [HttpPost]
        public IActionResult AddPosition(EmployeeModel emp)
        {
            emp.Position.EmployeeId = emp.Employee.Id;
            emp.EmployeePosition.EmployeeId = emp.Employee.Id;
            emp.EmployeePosition.PositionId = emp.Position.Id;
            service.newPosition(emp.Position);
            employeePositionService.newEmployeePosition(emp.EmployeePosition);

            return RedirectToAction("List", "Employee");
        }
    }
}