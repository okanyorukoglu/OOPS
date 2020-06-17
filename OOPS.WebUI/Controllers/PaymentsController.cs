﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.EmployeeAbstract;
using OOPS.DTO.Employee;

namespace OOPS.WebUI.Controllers
{
    public class PaymentsController : BaseController
    {
        private IPaymentsService paymentsService;
        private IEmployeeService employeeService;
        public PaymentsController(IPaymentsService _paymentsService, IEmployeeService _employeeService)
        {
            paymentsService = _paymentsService;
            employeeService = _employeeService;
        }

        [HttpPost]
        public IActionResult PaymentAdd(PaymentDTO payment)
        {
            var emp = employeeService.getEmployeeUser(CurrentUser.Id);
            payment.EmployeeId = emp.Id;
            string Name = emp.Name;
            string LastName = emp.Surname;
            payment.EmployeeFullName= String.Concat(Name, LastName);
            paymentsService.newPayment(payment);
            return RedirectToAction("Index", "Home");
        }



    }
}
