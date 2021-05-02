using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Address;
using Module.Repository.Model.Address;

namespace Module.Repository.Address
{
    public class StateRepository : BaseCrudRepository<StateModel>, IStateRepository
    {
        public StateRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }
    }
}