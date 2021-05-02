using Module.Dto.Security;
using Module.Service.Interface.Base;

namespace Module.Service.Interface.Security
{
    public interface ILoginService : IBaseService
    {
        string FazerLogin(LoginRequestDto loginRequestDto);
    }
}