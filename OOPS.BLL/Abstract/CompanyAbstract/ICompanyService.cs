using OOPS.Core.Business;
using OOPS.DTO.Company;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Abstract.CompanyAbstract
{
    public interface ICompanyService : IServiceBase
    {
        CompanyDTO getCompany(int Id);
        CompanyDTO updateCompany(CompanyDTO Company);
        bool deleteCompany(int CompanyId);
    }
}
