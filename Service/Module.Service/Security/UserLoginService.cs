using Module.Dto.User.Security;
using Module.Repository.Interface;
using Module.Repository.Model.User;
using Module.Service.Base;
using System;

namespace Module.Service.Security
{
    public class UserLoginService : BaseEntityService<UserLoginModel, UserLoginDto, Guid, IUserLoginRepository>
    {
        public override IUserLoginRepository CrudRepository { get; set; }
    }
}