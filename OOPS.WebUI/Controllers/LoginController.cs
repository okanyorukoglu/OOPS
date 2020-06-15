using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OOPS.BLL.Abstract;
using OOPS.DTO.Company;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;
using OOPS.WebUI.Core;
using OOPS.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OOPS.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService userService;
        private readonly IRoleService roleService;
        private readonly IEmployeeService employeeService;
        public LoginController(IUserService _userService, IRoleService _roleService, IEmployeeService _employeeService)
        {
            userService = _userService;
            roleService = _roleService;
            employeeService = _employeeService;
        }

        public ActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLoginViewModel userModel)
        {
            if (!ModelState.IsValid)
            { // re-render the view when validation failed.
                return View("UserLogin", userModel);
            }
            var user = userService.LoginUser(new UserDTO() { EMail = userModel.Email, Password = userModel.Password });

            if (user != null)
            {
                user.Role = roleService.GetById((int)user.RoleID);
                var userClaims = new List<Claim>()
                {
                    new Claim("UserDTO",OOPSConvert.OOPSJsonSerialize(user))
                };

                var userIdentity = new ClaimsIdentity(userClaims, "User Identity");

                var userPrincipal = new ClaimsPrincipal(new[] { userIdentity });
                HttpContext.SignInAsync(userPrincipal);

                return RedirectToAction("Index", "Home");
            }

            return View("UserLogin", userModel);
        }

        [HttpGet]
        public ActionResult UserAccessDenied()
        {
            return View();
        }

        public ActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("UserLogin");
        }
        public ActionResult Register()
        {
            RegisterViewModel user = new RegisterViewModel();
            return View(user);
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel RegisterUser)
        {
            if (!ModelState.IsValid)
            { // re-render the view when validation failed.
                return View("Register", RegisterUser);
            }
            var CheckUser = userService.CheckRegistration(RegisterUser.Username, RegisterUser.Email);
            if (CheckUser == null)
            {
                //userService.newUser(new UserDTO() { }, RegisterUser.Company, RegisterUser.Employee);
                return RedirectToAction("UserLogin");
            }
            else
            {
                throw new InvalidOperationException(" Kullanıcı adı veya Email Kullanılmaktadır.");
            }

        }

    }
}
