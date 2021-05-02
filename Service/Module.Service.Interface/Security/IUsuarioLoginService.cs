using Module.Dto.User.Security;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Security
{
    public interface IUsuarioLoginService : IBaseService
    {
        UserLoginDto GetById(Guid id);

        Guid Insert(UserLoginDto userLoginDto);

        void Update(UserLoginDto userLoginDto);

        void Delete(Guid id);
    }
}