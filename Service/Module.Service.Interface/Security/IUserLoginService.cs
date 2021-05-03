using Module.Dto.User.Security;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Security
{
    public interface IUserLoginService : IBaseEntityService<UserLoginDto, Guid>
    {
        UserLoginDto GetByMail(string mail);
    }
}