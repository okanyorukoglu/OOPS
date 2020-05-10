using OOPS.Core.Entities;
using OOPS.Model.CompanyModels;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.ProjectBaseModel
{
    public class User : Entity<int>
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public Nullable<int> EmployeeId { get; set; }

        [ForeignKey("Role")]
        public Nullable<int> RoleId { get; set; }
        public virtual Role Role { get; set; }

        [ForeignKey("Company")]
        public Nullable<int> CompanyId { get; set; }
        public virtual Company Company { get; set; }

    }
}
