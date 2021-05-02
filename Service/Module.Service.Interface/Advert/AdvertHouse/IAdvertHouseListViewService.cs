using Module.Dto.Advert;
using Module.Service.Interface.Base;
using System.Collections.Generic;

namespace Module.Service.Interface.Advert
{
    public interface IAdvertHouseListViewService : IBaseService
    {
        IEnumerable<AdvertHouseListItemDto> GetAdvertHouseList(AdvertHouseFilterDto advertHouseFilter);

        AdvertHouseListViewDto GetAdvertListView();
    }
}