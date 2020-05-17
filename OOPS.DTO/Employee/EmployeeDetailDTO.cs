using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EmployeeDetailDTO
    {
        public int Id { get; set; }
        public string TCKN { get; set; }
        public string BirthDate { get; set; }
        public string LastCompletedEducationalInstitution { get; set; }
    }
}
