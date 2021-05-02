using Module.Dto.Security;
using Module.Service.Validation.Interface.Base;

namespace Module.Service.Validation.Interface.Security
{
    public interface ILoginValidation : IBaseValidation
    {
        void ValidateLogin(LoginRequestDto loginRequestDto);
    }
}