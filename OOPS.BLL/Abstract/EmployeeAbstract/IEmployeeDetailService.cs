using OOPS.Core.Business;
using OOPS.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.EmployeeAbstract
{
   public interface IEmployeeDetailService : IServiceBase
    {
        List<EmployeeDetailDTO> getAll();
        List<EmployeeDetailDTO> getEmployeeDetail(int companyId);
        
    }
}
