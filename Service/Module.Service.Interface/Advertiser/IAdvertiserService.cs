using Module.Dto.Advertiser;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Advertiser
{
    public interface IAdvertiserService : IBaseService
    {
        AdvertiserDto GetById(Guid id);

        void Insert(AdvertiserDto advertiserDto);

        void Update(AdvertiserDto advertiserDto);

        void Delete(Guid id);
    }
}