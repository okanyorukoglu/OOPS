using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class ContractType : Entity<int>
    {
        public string ContractName { get; set; }
    }
}
