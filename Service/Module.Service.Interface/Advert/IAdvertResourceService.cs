using Module.Dto.Advert;
using Module.Service.Interface.Base;
using System;
using System.Collections.Generic;

namespace Module.Service.Interface.Advert
{
    public interface IAdvertResourceService : IBaseEntityService<AdvertResourceDto, Guid>
    {
        IEnumerable<AdvertResourceDto> GetAdvertHouseResourceList(Guid adverHouseId);
    }
}