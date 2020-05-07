using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using OOPS.Model.ProjectBaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.CompanyModels
{
    public class Company : Entity<int>
    {
        public Company()
        {
            Employees = new HashSet<Employee>();
            UserCompanies = new HashSet<UserCompany>();
        }
        public string CompanyName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<UserCompany> UserCompanies { get; set; }
    }
}
