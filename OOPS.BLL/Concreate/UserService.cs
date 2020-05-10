using OOPS.BLL.Abstract;
using OOPS.Core.Data.UnitOfWork;
using OOPS.DTO.ProjectBase;
using OOPS.MapConfig.ConfigProfile;
using OOPS.Model.ProjectBaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.BLL.Concreate
{
    public class UserService : IUserService
    {
        private readonly IUnitofWork uow;
        public UserService(IUnitofWork _uow)
        {
            uow = _uow;
        }

        public bool deleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public UserDTO FindwithMail(string mail)
        {
            throw new NotImplementedException();
        }

        public UserDTO FindwithUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public UserDTO FindwithUsernameandMail(UserDTO loginUser)
        {
            var getUser = uow.GetRepository<User>().Get(z => (z.EMail == loginUser.EMail ||
                                            z.UserName == loginUser.UserName) &&
                                            z.Password == loginUser.Password);
            return MapperFactory.CurrentMapper.Map<UserDTO>(getUser);
        }

        public UserDTO FindwithUsernameandMail(string mailorUserName, string password)
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> getAll()
        {
            throw new NotImplementedException();
        }

        public List<UserDTO> getAllUserinRole(int RoleID)
        {
            throw new NotImplementedException();
        }

        public UserDTO getUser(int Id)
        {
            throw new NotImplementedException();
        }

        public UserDTO LoginUser(UserDTO loginUser)
        {
            var getUser = uow.GetRepository<User>().Get(z => (z.EMail == loginUser.EMail || 
                                                        z.UserName == loginUser.UserName) &&
                                                        z.Password == loginUser.Password);
            return MapperFactory.CurrentMapper.Map<UserDTO>(getUser);
        }

        public UserDTO newUser(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public UserDTO updateUser(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public UserDTO updateUserCompany(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public UserDTO updateUserRole(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
