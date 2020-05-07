using OOPS.DTO.ProjectBaseDTO;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.ProjectBaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Mapping
{
    public class UserProfile : ProfileBase
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
