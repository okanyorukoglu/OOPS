using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.ProjectBaseModel
{
    public class Role : Entity<int>
    {
        public Role()
        {
            UserCompanies = new HashSet<UserCompany>();
        }

        public string Name { get; set; }
        public ICollection<UserCompany> UserCompanies { get; set; }
    }
}
