﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;

namespace OOPS.WebUI.Controllers
{
    public class MyProfileController : BaseController
    {
        public MyProfileController()
        {
           
        }
        public IActionResult Index()
        {
            return View(CurrentUser);
        }
    }


}
