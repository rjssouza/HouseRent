using Module.Dto.Advert;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Advert
{
    public interface IAdvertHouseService : IBaseService
    {
        void Insert(AdvertHouseDto advertHouseDto);

        void Update(AdvertHouseDto advertHouseDto);

        AdvertHouseDto GetById(Guid id);
    }
}