using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class EmployeeOtherInfo
    {
        [ForeignKey("Employee")]
        public Nullable<int> Id { get; set; }
        public virtual Employee Employee { get; set; }
        public string AdressInfo { get; set; }
        public string AdressFull { get; set; }
        public Nullable<int> HomePhone { get; set; }
        public string ContactNameforEmergency { get; set; }
        public string RelationshipforEmergencyContact { get; set; }
        public string NumberforEmergencyContact { get; set; }
        public string SocialMediaConnectionName { get; set; }
        public string SocialMediaConnectionAddress { get; set; }

        [ForeignKey("District")]
        public Nullable<int> DistrictId { get; set; }
        public virtual District District { get; set; }
        // department

    }
}
