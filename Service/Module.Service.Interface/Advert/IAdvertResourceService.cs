using Module.Dto.Advert;
using Module.Service.Interface.Base;
using System;
using System.Collections.Generic;

namespace Module.Service.Interface.Advert
{
    public interface IAdvertResourceService : IBaseService
    {
        void Insert(AdvertResourceDto advertResourceDto);

        void Update(AdvertResourceDto advertResourceDto);

        void Delete(Guid id);

        AdvertResourceDto GetById(Guid id);

        IEnumerable<AdvertResourceDto> GetAdvertHouseResourceList(Guid adverHouseId);
    }
}