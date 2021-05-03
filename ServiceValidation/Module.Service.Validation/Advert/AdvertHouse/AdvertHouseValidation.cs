using Module.Repository.Model.Advert;
using Module.Service.Interface.Advert;
using Module.Service.Interface.Sell;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface.Advert.AdvertHouse;
using System;

namespace Module.Service.Validation.Advert.AdvertHouse
{
    public class AdvertHouseValidation : BaseCrudValidation<AdvertHouseModel>, IAdvertHouseValidation
    {
        private const string PUBLISHED = "9E37FB70-3EC7-4E60-8BF3-1BD4E942C7DE";

        public IContactRequestService ContactRequestService { get; set; }
        public ISellService SellService { get; set; }
        public IAdvertHouseService AdvertHouseService { get; set; }

        public override void ValidateDeletion(AdvertHouseModel model)
        {
            base.ValidateDeletion(model);

            this.StatusId_AdvertMustBePublishedToDelete(model);
            
            this.OnValidated();
        }

        public override void ValidateInsert(AdvertHouseModel model)
        {
            base.ValidateInsert(model);

            this.Title_AdvertHouseMustHaveTitle(model);
            this.Description_AdvertHouseMustHaveDescription(model);
            this.HouseTypeId_AdvertHouseMustHaveHouseTypeId(model);
            this.AdressId_AdvertHouseMustHaveHouseAdressId(model);
            this.GoalId_AdvertHouseMustHaveGoalId(model);
            this.StatusId_AdvertHouseMustHaveStatusId(model);
            this.Price_AdvertHouseMustHavePrice(model);
            this.AdvertiserId_AdvertHouseMustHaveAdvertiserId(model);

            this.OnValidated();
        }

        public override void ValidateUpdate(AdvertHouseModel model)
        {
            base.ValidateUpdate(model);

            this.Title_AdvertHouseMustHaveTitle(model);
            this.Description_AdvertHouseMustHaveDescription(model);
            this.HouseTypeId_AdvertHouseMustHaveHouseTypeId(model);
            this.AdressId_AdvertHouseMustHaveHouseAdressId(model);
            this.GoalId_AdvertHouseMustHaveGoalId(model);
            this.StatusId_AdvertHouseMustHaveStatusId(model);
            this.Price_AdvertHouseMustHavePrice(model);
            this.AdvertiserId_AdvertHouseMustHaveAdvertiserId(model);
            this.StatusId_AdvertMustBePublishedToUpdate(model);

            this.OnValidated();
        }

        private void Title_AdvertHouseMustHaveTitle(AdvertHouseModel model)
        {
            var message = "É obrigatório informar o título deste anúncio";
            if (string.IsNullOrEmpty(model.Title))
                this.summary.AddError("AdvertHouse", message);
        }

        private void Description_AdvertHouseMustHaveDescription(AdvertHouseModel model)
        {
            var message = "É obrigatório informar o título deste anúncio";
            if (string.IsNullOrEmpty(model.Description))
                this.summary.AddError("AdvertHouse", message);
        }

        private void HouseTypeId_AdvertHouseMustHaveHouseTypeId(AdvertHouseModel model)
        {
            var message = "É obrigatório informar um tipo de imóvel para este anúncio";
            if (model.HouseTypeId == Guid.Empty)
                this.summary.AddError("AdvertHouse", message);
        }

        private void AdressId_AdvertHouseMustHaveHouseAdressId(AdvertHouseModel model)
        {
            var message = "É obrigatório associar um anunciante a este anúncio";
            if (model.AddressId == Guid.Empty)
                this.summary.AddError("AdvertHouse", message);
        }

        private void GoalId_AdvertHouseMustHaveGoalId(AdvertHouseModel model)
        {
            var message = "É obrigatório informar o objetivo deste anúncio";
            if (model.GoalId == Guid.Empty)
                this.summary.AddError("AdvertHouse", message);
        }

        private void StatusId_AdvertHouseMustHaveStatusId(AdvertHouseModel model)
        {
            var message = "É obrigatório informar o status deste anúncio";
            if (model.StatusId == Guid.Empty)
                this.summary.AddError("AdvertHouse", message);
        }

        private void Price_AdvertHouseMustHavePrice(AdvertHouseModel model)
        {
            var message = "É obrigatório informar o preço deste anúncio";
            if (model.Price <= 0)
                this.summary.AddError("AdvertHouse", message);
        }

        private void AdvertiserId_AdvertHouseMustHaveAdvertiserId(AdvertHouseModel model)
        {
            var message = "É obrigatório informar o anunciante deste anúncio";
            if (model.AdvertiserId == Guid.Empty)
                this.summary.AddError("AdvertHouse", message);
        }

        private void StatusId_AdvertMustBePublishedToUpdate(AdvertHouseModel model)
        {
            var advertDto = this.AdvertHouseService.GetById(model.Id);
            var message = "Este anúncio não pode ser atualizado pois ja se encontra vendido";

            if (advertDto.StatusId != Guid.Parse(PUBLISHED))
                this.summary.AddError("StatusId", message);
        }

        private void StatusId_AdvertMustBePublishedToDelete(AdvertHouseModel model)
        {
            var advertDto = this.AdvertHouseService.GetById(model.Id);
            var message = "Este anúncio não pode ser deletado pois ja se encontra vendido";

            if (advertDto.StatusId != Guid.Parse(PUBLISHED))
                this.summary.AddError("StatusId", message);
        }
    }
}