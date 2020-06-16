using OOPS.BLL.Abstract.Employee;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Employee;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate.EmployeConcreate
{
    public class AdvanceService : IAdvanceService
    {
        private readonly IUnitofWork uow;

        public AdvanceService(IUnitofWork uow)
        {
            this.uow = uow;
        }

        public bool deleteAdvance(int advanceId)
        {
            try
            {
                var getAdvance = uow.GetRepository<Advance>().Get(z => z.Id == advanceId);
                uow.GetRepository<Advance>().Delete(getAdvance);
                uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public AdvanceDTO getAdvance(int Id)
        {
            var getAdvance = uow.GetRepository<Advance>().Get(z => z.Id == Id);
            return MapperFactory.CurrentMapper.Map<AdvanceDTO>(getAdvance);
        }

        public List<AdvanceDTO> getAll()
        {
            var getAdvanceList = uow.GetRepository<Advance>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<AdvanceDTO>>(getAdvanceList);
        }

        public AdvanceDTO newAdvance(AdvanceDTO advance)
        {
            var adedAdvance = MapperFactory.CurrentMapper.Map<Advance>(advance);
            adedAdvance = uow.GetRepository<Advance>().Add(adedAdvance);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<AdvanceDTO>(adedAdvance);
        }

        public AdvanceDTO updateAdvance(AdvanceDTO advance)
        {
            var selectedAdvance = uow.GetRepository<Advance>().Get(z => z.Id == advance.Id);
            selectedAdvance = MapperFactory.CurrentMapper.Map(advance, selectedAdvance);
            uow.GetRepository<Advance>().Update(selectedAdvance);
            uow.SaveChanges();
            return MapperFactory.CurrentMapper.Map<AdvanceDTO>(selectedAdvance);
        }
    }
}
