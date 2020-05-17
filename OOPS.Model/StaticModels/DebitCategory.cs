using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class DebitCategory
    {
        public DebitCategory()
        {
            Debits = new HashSet<Debit>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Debit> Debits { get; set; }
    }
}
