using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;

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
            return View();
        }
    }
}