using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EmployeeDebit
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int DebitId { get; set; }
        public virtual Debit Debit { get; set; }
    }
}
