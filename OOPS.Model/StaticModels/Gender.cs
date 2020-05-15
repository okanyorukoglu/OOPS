using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class Gender : Entity<int>
    {
        public string GenderName { get; set; }
    }
}
