using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class AccessType : Entity<int>
    {
        public string AccessTypeName { get; set; }
    }
}
