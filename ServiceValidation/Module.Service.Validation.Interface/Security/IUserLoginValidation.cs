using Module.Repository.Model.User;
using Module.Service.Validation.Interface.Base;

namespace Module.Service.Validation.Interface.Security
{
    public interface IUserLoginValidation : IBaseCrudValidation<UserLoginModel>
    {
    }
}