﻿using OOPS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Model.EmployeeModel
{
    public class SystemEducation : Entity<int>
    {
        public SystemEducation()
        {
        
        }

        public string Name { get; set; }
        public string EducatorName { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan EndTime { get; set; }

        public string EducatorCompany { get; set; }
        public string EducationLocation { get; set; }
        public string ValidityPeriodMonth { get; set; }
        public string Description { get; set; }


    }
}
