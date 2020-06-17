using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.BLL.Abstract.Employee;
using OOPS.DTO.Employee;

namespace OOPS.WebUI.Controllers
{
    public class AdvanceController : BaseController
    {
        private IAdvanceService advanceService;

        public AdvanceController(IAdvanceService _advanceService)
        {
            advanceService = _advanceService;
        }
        
        public IActionResult AddAdvance(AdvanceDTO advanceDTO)
        {
            advanceService.newAdvance(advanceDTO);
            return RedirectToAction("Index","Home");
        }
    }
}