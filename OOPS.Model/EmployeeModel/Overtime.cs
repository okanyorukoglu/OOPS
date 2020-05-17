using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class Overtime
    {
        public Overtime()
        {
            EmployeeOverTimes = new HashSet<EmployeeOverTime>();
        }
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan Hour { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EmployeeOverTime> EmployeeOverTimes { get; set; }
    }
}
