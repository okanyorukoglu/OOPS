﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OOPS.WebUI.Controllers
{
    public class PermitLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}