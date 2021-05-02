using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface;
using Module.Repository.Model.User;

namespace Module.Repository
{
    public class UserLoginRepository : BaseCrudRepository<UserLoginModel>, IUserLoginRepository
    {
        public UserLoginRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }
    }
}