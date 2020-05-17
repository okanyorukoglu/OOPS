using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class BankInformationDTO
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
    }
}
