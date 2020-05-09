using OOPS.DTO.Company;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.ProjectBase
{
    public class UserCompanyDTO
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public virtual CompanyDTO Company { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual RoleDTO Role { get; set; }
    }
}
