using Module.Dto.Advert;
using Module.Dto.Advert.AdvertHouse;
using Module.Dto.Sell;
using Module.Service.Base;
using Module.Service.Interface.Advert;
using System;

namespace Module.Service.Advert.AdvertHouse
{
    public class AdvertHouseManagerViewService : BaseService, IAdvertHouseManagerViewService
    {
        public void CreateAdvertHouse(CreateAdvertHouseRequestDto createAdvertHouseRequestDto)
        {
            throw new NotImplementedException();
        }

        public AdvertHouseViewDto GetAdvertView()
        {
            throw new NotImplementedException();
        }

        public AdvertHouseViewDto GetAdvertView(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SellAdvert(Guid advertId, Guid contactRequestId)
        {
            throw new NotImplementedException();
        }

        public void SendContactRequest(ContactRequestDto contactRequest)
        {
            throw new NotImplementedException();
        }

        public void UpdateAdvertHouse(CreateAdvertHouseRequestDto createAdvertHouseRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}