using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
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
            var EmpId = CurrentUser.EmployeeId;
            int companyId = CurrentUser.CompanyId;
            //Giriş yapan kullanıcının EMployee Id boş degılse = ? Detail sayfasını çapırmak lazım.
            if (EmpId != null)
            {
                return View(nameof(Detail), EmpId);
            }
            else
            {
                return RedirectToAction(nameof(List), companyId);
            }
        }

        public IActionResult List(int companyId)
        {
            //o firmadli çalışanlar lsitelenecek
            return View();
        }
        public IActionResult Detail(int id)
        {
            //kullanıcının detayı
            return View();
        }
    }
}