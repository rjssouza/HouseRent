using Module.Dto.Advert;
using Module.Dto.Advert.AdvertHouse;
using Module.Dto.Sell;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Advert
{
    public interface IAdvertHouseManagerViewService : IBaseService
    {
        AdvertHouseViewDto GetAdvertView();

        AdvertHouseViewDto GetAdvertView(Guid id);

        void CreateAdvertHouse(CreateAdvertHouseRequestDto createAdvertHouseRequestDto);

        void UpdateAdvertHouse(CreateAdvertHouseRequestDto createAdvertHouseRequestDto);

        void SellAdvert(Guid advertId, Guid contactRequestId);

        void SendContactRequest(ContactRequestDto contactRequest);
    }
}