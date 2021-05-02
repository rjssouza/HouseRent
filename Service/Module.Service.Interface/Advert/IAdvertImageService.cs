using Module.Dto.Advert;
using Module.Service.Interface.Base;
using System;
using System.Collections.Generic;

namespace Module.Service.Interface.Advert
{
    public interface IAdvertImageService : IBaseEntityService<AdvertImageDto, Guid>
    {
        IEnumerable<AdvertImageDto> GetAdvertHousePictureList(Guid advertHouseId);
    }
}