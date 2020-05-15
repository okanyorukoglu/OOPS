using System;
using System.Collections.Generic;
using System.Text;
using OOPS.DTO.Company;
using OOPS.DTO.ProjectBase;

namespace OOPS.DTO.Employee
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string PhonePersonal { get; set; }
        public string PhoneBusiness { get; set; }
        public string EmailBusiness { get; set; }
        public string EmailPersonal { get; set; }

        public Nullable<int> CompanyID { get; set; }
        public virtual CompanyDTO Company { get; set; }

        public Nullable<int> UserID { get; set; }
        public virtual UserDTO User { get; set; }
    }
}
