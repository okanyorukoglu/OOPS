using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class DisabilitySituation : Entity<int>
    {
        public string DisabilityName { get; set; }
    }
}
