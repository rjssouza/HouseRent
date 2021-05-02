using Module.Dto.Advert;
using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Advert;
using Module.Repository.Model.Advert;
using System.Collections.Generic;

namespace Module.Repository.Advert
{
    public class AdvertHouseRepository : BaseCrudRepository<AdvertHouseModel>, IAdvertHouseRepository
    {
        public AdvertHouseRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }

        public IEnumerable<AdvertHouseListItemDto> GetAdvertHouseList(AdvertHouseFilterDto advertHouseFilter)
        {
            throw new System.NotImplementedException();
        }
    }
}