﻿using OOPS.DTO.Company;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.ProjectBase
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }

        public int RoleId { get; set; }
        public virtual RoleDTO Role { get; set; }

        public int CompanyId { get; set; }
        public virtual CompanyDTO Company { get; set; }

        public Nullable<int> EmployeeId { get; set; }

    }
}
