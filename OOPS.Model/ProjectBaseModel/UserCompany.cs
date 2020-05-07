using OOPS.Model.CompanyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.ProjectBaseModel
{
    public class UserCompany
    {
        [ForeignKey("User")]
        [Key]
        [Column(Order = 1)]
        public Nullable<int> UserId { get; set; }
        [ForeignKey("Role")]
        [Key]
        [Column(Order = 3)]
        public Nullable<int> RoleId { get; set; }
        [ForeignKey("Company")]
        [Key]
        [Column(Order = 2)]
        public Nullable<int> CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
