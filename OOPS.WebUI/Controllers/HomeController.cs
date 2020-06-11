using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.Employee;
using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.WebUI.Models;

namespace OOPS.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPermitService _permitService;
        //private readonly IVisaDocumentRequestsService _visaDocumentRequestsService;
        
        public HomeController(IPermitService permitService/*, IVisaDocumentRequestsService visaDocumentRequestsService*/)
        {
            _permitService = permitService;
            //_visaDocumentRequestsService = visaDocumentRequestsService;
        }

        public IActionResult Index()
        {
            var permits = _permitService.getAllEmployeePermits();
            //var visas = _visaDocumentRequestsService.getAllEmployeeVisaDocumentRequests();
            return View();
        }
    }
}
