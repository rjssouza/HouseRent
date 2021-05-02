using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Advertiser;
using Module.Repository.Model.Advertiser;

namespace Module.Repository.Advertiser
{
    public class AdvertiserRepository : BaseCrudRepository<AdvertiserModel>, IAdvertiserRepository
    {
        public AdvertiserRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }
    }
}