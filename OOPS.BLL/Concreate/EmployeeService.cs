using OOPS.BLL.Abstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.CompanyModels;
using OOPS.Model.EmployeeModel;
using OOPS.Model.ProjectBaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitofWork uow;
        public EmployeeService(IUnitofWork _uow)
        {
            uow = _uow;
        }
        public bool deleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeDTO> getCompanyEmployees(int companyId)
        {
            var companyEmployee = uow.GetRepository<Employee>().GetAll().Where(a => a.Company.Id == companyId);
            return MapperFactory.CurrentMapper.Map<List<EmployeeDTO>>(companyEmployee);
        }

        public EmployeeDTO getEmployee(int Id)
        {
            var emp = uow.GetRepository<Employee>().Get(z=>z.Id==Id);
            return MapperFactory.CurrentMapper.Map<EmployeeDTO>(emp);
        }

        public EmployeeDTO newEmployee(EmployeeDTO employee)
        {
            throw new NotImplementedException();
        }

        public EmployeeDTO updateEmployee(EmployeeDTO employee)
        {
            throw new NotImplementedException();
        }
    }
}
