using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Advert;
using Module.Repository.Model.Advert;

namespace Module.Repository.Advert
{
    public class AdvertStatusRepository : BaseCrudRepository<AdvertStatusModel>, IAdvertStatusRepository
    {
        public AdvertStatusRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }
    }
}