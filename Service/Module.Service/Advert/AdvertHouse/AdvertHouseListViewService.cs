using Module.Dto.Advert;
using Module.Service.Base;
using Module.Service.Interface.Advert;
using System.Collections.Generic;

namespace Module.Service.Advert.AdvertHouse
{
    public class AdvertHouseListViewService : BaseService, IAdvertHouseListViewService
    {
        public IEnumerable<AdvertHouseListItemDto> GetAdvertHouseList(AdvertHouseFilterDto advertHouseFilter)
        {
            throw new System.NotImplementedException();
        }

        public AdvertHouseListViewDto GetAdvertListView()
        {
            throw new System.NotImplementedException();
        }
    }
}