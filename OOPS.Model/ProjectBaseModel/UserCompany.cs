using OOPS.Model.CompanyModels;
using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.ProjectBaseModel
{
    public class UserCompany : Entity<int>
    {
        [ForeignKey("User")]
        [Column(Order = 1)]
        public Nullable<int> UserId { get; set; }
        [ForeignKey("Role")]
        [Column(Order = 3)]
        public Nullable<int> RoleId { get; set; }
        [ForeignKey("Company")]
        [Column(Order = 2)]
        public Nullable<int> CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
