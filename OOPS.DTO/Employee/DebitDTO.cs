using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class DebitDTO
    {
        public int SerialNumber { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Description { get; set; }
        public int DebitCategoryID { get; set; }
        public virtual DebitCategoryDTO DebitCategory { get; set; }
        public List<EmployeeDebitDTO> EmployeeDebits { get; set; }
    }
}
