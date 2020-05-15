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
        public UserDTO User { get; set; }
        public EmployeeDTO Employee { get; set; }
        public CompanyDTO Company { get; set; }

    }
}
