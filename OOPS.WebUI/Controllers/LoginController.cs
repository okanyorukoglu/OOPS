using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract;
using OOPS.DTO.ProjectBase;
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
        public LoginController(IUserService _userService, IRoleService _roleService)
        {
            userService = _userService;
            roleService = _roleService;
        }

        public ActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserLogin(UserDTO userModel)
        {
            // username = anet  
            var user = userService.LoginUser(userModel);

            if (user != null)
            {
                user.Role = roleService.GetById((int)user.RoleId);
                var userClaims = new List<Claim>()
                {
                    new Claim("UserName", user.UserName),
                    new Claim(ClaimTypes.Name, user.FullName),
                    new Claim(ClaimTypes.Email, user.EMail),
                    new Claim(ClaimTypes.Role, user.Role.Name),
                    new Claim("RoleName", user.Role.Name),
                    new Claim("CompanyId", user.CompanyId.ToString()),
                    new Claim("EmpId", user.EmployeeId.ToString()),
                 };

                var userIdentity = new ClaimsIdentity(userClaims, "User Identity");

                var userPrincipal = new ClaimsPrincipal(new[] { userIdentity });
                HttpContext.SignInAsync(userPrincipal);

                return RedirectToAction("Index", "Home");
            }

            return View(user);
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
    }
}
