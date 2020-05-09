using OOPS.BLL.Abstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;
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

        public List<EmployeeDTO> getCompanyEmployees(UserCompanyDTO usercompany)
        {
            //var companyEmployee = uow.GetRepository<UserCompany>().GetAll().Where(z => z.CompanyId == usercompany.CompanyId
            //                                                                       && z.RoleId == usercompany.RoleId
            //                                                                       && z.UserId == usercompany.UserId).ToList();
            //return  
            throw new NotImplementedException();
        }

        public EmployeeDTO getEmployee(int Id)
        {
            throw new NotImplementedException();
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
