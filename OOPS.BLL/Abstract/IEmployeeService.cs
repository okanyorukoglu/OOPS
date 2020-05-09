using OOPS.Core.Business;
using OOPS.DTO.Employee;
using OOPS.DTO.ProjectBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract
{
    public interface IEmployeeService : IServiceBase
    {
        List<EmployeeDTO> getCompanyEmployees(UserDTO user);
        EmployeeDTO getEmployee(int Id);
        EmployeeDTO newEmployee(EmployeeDTO employee);
        EmployeeDTO updateEmployee(EmployeeDTO employee);
        bool deleteEmployee(int employeeId);
    }
}
