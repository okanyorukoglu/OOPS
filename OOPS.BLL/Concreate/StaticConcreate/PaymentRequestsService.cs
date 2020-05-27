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
    public class PaymentRequestsService : IPaymentRequestsService
    {
        private readonly IUnitofWork uow;
        public PaymentRequestsService(IUnitofWork uow)
        {
            this.uow = uow;
        }
        public List<PaymentRequestsDTO> getAll()
        {
            var PaymentRequests = uow.GetRepository<PaymentRequests>().GetAll().ToList();
            return MapperFactory.CurrentMapper.Map<List<PaymentRequestsDTO>>(PaymentRequests);
        }
    }
}
