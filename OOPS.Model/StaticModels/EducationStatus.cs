using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class EducationStatus : Entity<int>
    {
        public string StatusName { get; set; }
    }
}
