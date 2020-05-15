using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class Advance : Entity<int>
    {
        public int Sum { get; set; }
        public DateTime Date { get; set; }
        public string Installment { get; set; }
        public string Description { get; set; }

    }
}
