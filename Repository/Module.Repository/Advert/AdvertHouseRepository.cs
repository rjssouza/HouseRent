using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Advert;
using Module.Repository.Model.Advert;

namespace Module.Repository.Advert
{
    public class AdvertHouseRepository : BaseCrudRepository<AdvertHouseModel>, IAdvertHouseRepository
    {
        public AdvertHouseRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }
    }
}