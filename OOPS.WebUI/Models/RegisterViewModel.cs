using OOPS.DTO.Company;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Models
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneBusiness { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
}
