using OOPS.DTO.ProjectBase;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Company
{
    public class CompanyDTO
    {
        public string CompanyName { get; set; }
        public virtual List<EmployeeDTO> Employees { get; set; }
        public virtual List<UserCompanyDTO> UserCompanies { get; set; }

    }
}
