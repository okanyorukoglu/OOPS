using OOPS.DTO.Employee;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Models
{
    public class StaticTypesViewModel
    {
        public List<BloodGroupDTO> BloodGroupList { get; set; }
        public List<GenderDTO> GenderList { get; set; }
        public List<VisaTypeDTO> VisaTypeList { get; set; }
        public List<AccessTypeDTO> AccessTypeList { get; set; }
        public List<ContractTypeDTO> ContractTypeList { get; set; }
        public List<MaritalStatusDTO> MaritalStatusList { get; set; }
        public List<EducationLevelDTO> EducationLevelList { get; set; }
        public List<BankAccountTypeDTO> BankAccountTypeList { get; set; }
        public List<PermitTypeDTO> PermitTypeList { get; set; }
        public List<DisabilitySituationDTO> DisabilitySituationList { get; set; }
        public List<EducationStatusDTO> EducationStatusList { get; set; }
        public List<EmploymentTypeDTO> EmploymentTypeList { get; set; }
        public List<CityDTO> CityList { get; set; }
        public List<CountryDTO> CountryList { get; set; }
        public List<DistrictDTO> DistrictsList { get; set; }
        public virtual EmployeeDTO Employee { get; set; }
    }
}
