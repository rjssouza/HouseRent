using Module.Dto.Advert.AdvertHouse;
using Module.Service.Interface.Advert;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface.Advert.AdvertHouse;
using System;

namespace Module.Service.Validation.Advert.AdvertHouse
{
    public class AdvertHouseManagerValidation : BaseValidation, IAdvertHouseManagerValidation
    {
        private const string PUBLISHED = "9E37FB70-3EC7-4E60-8BF3-1BD4E942C7DE";

        public IAdvertHouseService AdvertHouseService { get; set; }

        public void ValidateAdvertCreationRequest(CreateAdvertHouseRequestDto createAdvertHouseRequestDto)
        {
            this.Title_AdvertHouseMustHaveTitle(createAdvertHouseRequestDto);
            this.Description_AdvertHouseMustHaveDescription(createAdvertHouseRequestDto);
            this.Address_AdvertHouseMustHaveAddress(createAdvertHouseRequestDto);

            this.OnValidated();
        }

        public void ValidateAdvertSellRequest(Guid advertHouseId)
        {
            this.AdvertStatus_AdvertMustBeOnPublishedStatus(advertHouseId);

            this.OnValidated();
        }

        private void Title_AdvertHouseMustHaveTitle(CreateAdvertHouseRequestDto createAdvertHouseRequestDto)
        {
            var message = "É obrigatório informar o título deste anúncio";

            if (string.IsNullOrEmpty(createAdvertHouseRequestDto.Title))
                this.summary.AddError("AdvertRequest", message);
        }

        private void Description_AdvertHouseMustHaveDescription(CreateAdvertHouseRequestDto createAdvertHouseRequestDto)
        {
            var message = "É obrigatório informar a descrição deste anúncio";

            if (string.IsNullOrEmpty(createAdvertHouseRequestDto.Description))
                this.summary.AddError("AdvertRequest", message);
        }

        private void Address_AdvertHouseMustHaveAddress(CreateAdvertHouseRequestDto createAdvertHouseRequestDto)
        {
            var message = "É obrigatório informar o endereço deste anúncio";

            if (createAdvertHouseRequestDto.Address == null)
                this.summary.AddError("AdvertRequest", message);
        }

        private void AdvertStatus_AdvertMustBeOnPublishedStatus(Guid advertHouseId)
        {
            var message = "Este anúncio nao pode mais ser vendido";
            var advertHouse = this.AdvertHouseService.GetById(advertHouseId);

            if (advertHouse.StatusId != Guid.Parse(PUBLISHED))
                this.summary.AddError("AdvertRequest", message);
        }
    }
}