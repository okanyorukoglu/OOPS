using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class District : Entity<int>
    {

        public string Name { get; set; }
        public string Code { get; set; }

        [ForeignKey("City")]
        public Nullable<int> CityId { get; set; }
        public virtual City City { get; set; }

    }
}
