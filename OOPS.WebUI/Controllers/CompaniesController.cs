using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.CompanyAbstract;
using OOPS.DTO.Company;
using OOPS.WebUI.Models;

namespace OOPS.WebUI.Controllers
{
    public class CompaniesController : Controller
    {
        private ICompanyBranchService companyBranchService;
        private ICompanyDepartmentService companyDepartmentService;
        public CompaniesController(ICompanyBranchService _companyBranchService, ICompanyDepartmentService _companyDepartmentService)
        {
            companyBranchService = _companyBranchService;
            companyDepartmentService = _companyDepartmentService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CompanyBranchAdd(SettingsModel settingsModel)
        {
            //settingsModel.CompanyBranch.Company.Id =(int) settingsModel.CompanyBranch.CompanyID;
            settingsModel.CompanyBranch.Company = null;
            companyBranchService.newCompanyBranch(settingsModel.CompanyBranch);
            return RedirectToAction("Index","Settings");
        }
    }
}