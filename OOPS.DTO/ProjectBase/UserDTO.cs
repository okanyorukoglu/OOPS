using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.ProjectBase
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public virtual EmployeeDTO Employee { get; set; }

        public virtual List<UserCompanyDTO> UserCompanies { get; set; }
    }
}
