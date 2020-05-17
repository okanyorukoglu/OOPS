using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EducationsType : Entity<int>
    {
        public EducationsType()
        {
            Educations = new HashSet<Education>();
        }
     
        public string Name { get; set; }

        public virtual ICollection<Education> Educations { get; set; }
    }
}
