using OOPS.Core.Entities;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class DebitCategory : Entity<int>
    {
        public DebitCategory()
        {
            Debits = new HashSet<Debit>();
        }

        public string Name { get; set; }

        public virtual ICollection<Debit> Debits { get; set; }
    }
}
