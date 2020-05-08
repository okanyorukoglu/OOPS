using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.DTO.ProjectBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private IUserService service;
        public LoginController(IUserService _service)
        {
            service = _service;
        }
        public ActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserLogin(UserDTO userModel)
        {
            //Kullanıcı girişi kontrolü yapılacak
            //true ise adrese gidecek.
            if (ModelState.IsValid)
            {
                UserDTO selectedUser = service.LoginUser(userModel);
                if (selectedUser == null)
                {
                    return new BadRequestObjectResult("Kullanıcı adı veya Parola doğrulanmadı");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
                
            }
            else
            {
                return View("UserLogin");
            }
            
        }
    }
}
