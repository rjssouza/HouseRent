using Module.Dto.Advert.AdvertHouse;
using Module.Service.Validation.Interface.Base;
using System;

namespace Module.Service.Validation.Interface.Advert.AdvertHouse
{
    public interface IAdvertHouseManagerValidation : IBaseValidation
    {
        void ValidateAdvertCreationRequest(CreateAdvertHouseRequestDto createAdvertHouseRequestDto);

        void ValidateAdvertSellRequest(Guid advertHouseId, Guid contactRequestId);
    }
}