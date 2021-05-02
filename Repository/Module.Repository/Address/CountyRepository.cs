using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Address;
using Module.Repository.Model.Address;

namespace Module.Repository.Address
{
    public class CountyRepository : BaseCrudRepository<CountyModel>, ICountyRepository
    {
        public CountyRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }
    }
}