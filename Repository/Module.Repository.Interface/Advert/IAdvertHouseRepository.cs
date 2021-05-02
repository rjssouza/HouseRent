using Module.Dto.Advert;
using Module.Repository.Interface.Base;
using Module.Repository.Model.Advert;
using System.Collections.Generic;

namespace Module.Repository.Interface.Advert
{
    public interface IAdvertHouseRepository : IBaseCrudRepository<AdvertHouseModel>
    {
        IEnumerable<AdvertHouseListItemDto> GetAdvertHouseList(AdvertHouseFilterDto advertHouseFilter);
    }
}