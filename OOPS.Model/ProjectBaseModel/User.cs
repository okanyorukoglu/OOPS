using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.ProjectBaseModel
{
    public class User : Entity<int>
    {
        public User()
        {
            UserCompanies = new HashSet<UserCompany>();
        }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }

        [ForeignKey("Employee")]
        public Nullable<int> EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual ICollection<UserCompany> UserCompanies { get; set; }
    }
}
