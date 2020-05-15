using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class BloodGroup : Entity<int>
    {
        public string BloodKind { get; set; }

    }
}
