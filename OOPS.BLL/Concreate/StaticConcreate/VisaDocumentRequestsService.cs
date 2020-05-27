using OOPS.BLL.Abstract.StaticAbstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.Static;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.StaticModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPS.BLL.Concreate.StaticConcreate
{
    public class VisaDocumentRequestsService : IVisaDocumentRequestsService
    {
        private readonly IUnitofWork uow;
        public VisaDocumentRequestsService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public List<VisaDocumentRequestDTO> getAll()
        {
            var VisaDocument = uow.GetRepository<VisaDocumentRequests>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<VisaDocumentRequestDTO>>(VisaDocument);
        }
    }
}
