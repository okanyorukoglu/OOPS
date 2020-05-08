using System;
using System.Collections.Generic;
using System.Text;
using OOPS.DTO.Company;

namespace OOPS.DTO.Employee
{
    public class EmployeeDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Nullable<int> CompanyID { get; set; }
        public virtual CompanyDTO Company { get; set; }
    }
}
