using OOPS.Core.Entities;
using OOPS.Model.CompanyModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class Employee : Entity<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }

        [ForeignKey("Company")]
        public Nullable<int> CompanyID { get; set; }
        public virtual Company Company { get; set; }
    }
}
