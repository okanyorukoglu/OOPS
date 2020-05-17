using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DTO.Employee
{
    public class EmployeeOtherInfoDTO
    {
        public Nullable<int> Id { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
        public string AdressInfo { get; set; }
        public string AdressFull { get; set; }
        public Nullable<int> HomePhone { get; set; }
        public string ContactNameforEmergency { get; set; }
        public string RelationshipforEmergencyContact { get; set; }
        public string NumberforEmergencyContact { get; set; }
        public string SocialMediaConnectionName { get; set; }
        public string SocialMediaConnectionAddress { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public virtual DistrictDTO District { get; set; }
    }
}
