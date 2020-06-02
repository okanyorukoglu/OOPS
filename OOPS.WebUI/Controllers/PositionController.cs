﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.DTO.Employee;
using OOPS.WebUI.Models;

namespace OOPS.WebUI.Controllers
{
    public class PositionController : BaseController
    {
        private IPositionService service;
        private IEmployeeService employeeservice;

        public PositionController(IPositionService _service, IEmployeeService _employeeservice)
        {
            service = _service;
            employeeservice = _employeeservice;
        }

        [HttpPost]
        public IActionResult AddPosition(EmployeeModel emp)
        {

            emp.Position.EmployeeId = emp.Employee.Id;
            service.newPosition(emp.Position);
            


            return RedirectToAction("List", "Employee");
        }
    }
}