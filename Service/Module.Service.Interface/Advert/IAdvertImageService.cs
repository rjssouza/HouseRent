using Module.Dto.Advert;
using Module.Service.Interface.Base;
using System;
using System.Collections.Generic;

namespace Module.Service.Interface.Advert
{
    public interface IAdvertImageService : IBaseService
    {
        IEnumerable<AdvertImageDto> GetAdvertHousePictureList(Guid advertHouseId);

        void Insert(AdvertImageDto advertImageDto);

        void Update(AdvertImageDto advertImageDto);

        void Delete(Guid id);

        AdvertImageDto GetById(Guid id);
    }
}