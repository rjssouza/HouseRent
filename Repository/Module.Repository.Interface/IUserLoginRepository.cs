using Module.Repository.Interface.Base;
using Module.Repository.Model.User;

namespace Module.Repository.Interface
{
    public interface IUserLoginRepository : IBaseCrudRepository<UserLoginModel>
    {
    }
}