using Microsoft.AspNetCore.Mvc;
using OOPS.DTO.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Components
{
    public class AccessTypesViewComponent : ViewComponent
    {
        public AccessTypesViewComponent()
        {
            
        }

        public IViewComponentResult Invoke()
        {
            List<AccessTypeDTO> acces = new List<AccessTypeDTO>() {
                new AccessTypeDTO
                {
                    Id = 1,
                    AccessTypeName = "Yönetici"
                },
                new AccessTypeDTO
                {
                    Id = 2,
                    AccessTypeName = "Çalışan"
                }};
            return View(acces);
        }

    }
}
