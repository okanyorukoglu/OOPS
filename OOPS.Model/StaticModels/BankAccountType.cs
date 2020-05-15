using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class BankAccountType : Entity<int>
    {
        public string BankAccountTypeName { get; set; }
    }
}
