using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.StaticModels
{
    public class City : Entity<int>
    {
        public City()
        {
            Districts = new HashSet<District>();
        }

        public string Name { get; set; }
        public string Code { get; set; }

        [ForeignKey("Country")]
        public Nullable<int> CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<District> Districts { get; set; }
    }
}
