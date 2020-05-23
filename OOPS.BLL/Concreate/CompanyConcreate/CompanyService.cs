using OOPS.BLL.Abstract.CompanyAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Company;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.CompanyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Concreate.CompanyConcreate
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitofWork uow;
        public CompanyService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public bool deleteCompany(int CompanyId)
        {
            try
            {
                var getCompany = uow.GetRepository<Company>().Get(z => z.Id == CompanyId);
                uow.GetRepository<Company>().Delete(getCompany);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public CompanyDTO getCompany(int Id)
        {
            var getCompany = uow.GetRepository<Company>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<CompanyDTO>(getCompany);
        }


        public CompanyDTO updateCompany(CompanyDTO Company)
        {
            var selectedCompany = uow.GetRepository<Company>().Get(z => z.Id == Company.Id);
            selectedCompany = MapperFactory.CurrentMapper.Map(Company, selectedCompany);
            uow.GetRepository<Company>().Update(selectedCompany);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<CompanyDTO>(selectedCompany);
        }
    }
}
