using Microsoft.AspNetCore.Mvc;
using OOPS.BLL.Abstract.StaticAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class PaymentRequestsViewComponent : ViewComponent
    {
        private readonly IPaymentRequestsService  paymentRequestsService;

        public PaymentRequestsViewComponent(IPaymentRequestsService _paymentRequestsService)
        {
            paymentRequestsService = _paymentRequestsService;
        }

        public IViewComponentResult Invoke()
        {
            return View(paymentRequestsService.getAll());
        }
    }
}
