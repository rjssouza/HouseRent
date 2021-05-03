using Module.Repository.Model.Advert;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface.Advert;
using System;

namespace Module.Service.Validation.Advert
{
    public class AdvertResourceValidation : BaseCrudValidation<AdvertResourceModel>, IAdvertResourceValidation
    {
        public override void ValidateUpdate(AdvertResourceModel model)
        {
            base.ValidateUpdate(model);

            this.AdvertHouseId_ImageMustHaveAdvertHouseId(model);
            this.Description_AdvertResourceMustHaveDescription(model);

            this.OnValidated();
        }

        public override void ValidateInsert(AdvertResourceModel model)
        {
            base.ValidateInsert(model);

            this.AdvertHouseId_ImageMustHaveAdvertHouseId(model);
            this.Description_AdvertResourceMustHaveDescription(model);

            this.OnValidated();
        }

        private void AdvertHouseId_ImageMustHaveAdvertHouseId(AdvertResourceModel model)
        {
            var message = "O recurso deve ser associado a um anuncio";
            if (model.AdvertHouseId == Guid.Empty)
                this.summary.AddError("AdvertResource", message);
        }

        private void Description_AdvertResourceMustHaveDescription(AdvertResourceModel model)
        {
            var message = "O recurso extra deste imóvel deve ser informado";
            if (string.IsNullOrEmpty(model.Description))
                this.summary.AddError("AdvertResource", message);
        }
    }
}