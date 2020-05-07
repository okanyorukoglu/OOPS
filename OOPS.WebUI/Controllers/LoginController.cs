using Microsoft.AspNetCore.Mvc;
using OOPS.DTO.ProjectBaseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserLogin(UserDTO userModel)
        {
            //Kullanıcı girişi kontrolü yapılacak
            //true ise adrese gidecek.
            return RedirectToAction("Index", "Home");
        }
    }
}
