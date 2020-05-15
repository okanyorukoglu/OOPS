using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class EducationLevel : Entity<int>
    {
        public string EducationLevelName { get; set; }
    }
}
