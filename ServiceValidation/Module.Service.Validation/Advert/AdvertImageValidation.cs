using Module.Repository.Model.Advert;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface.Advert;
using System;

namespace Module.Service.Validation.Advert
{
    public class AdvertImageValidation : BaseCrudValidation<AdvertImageModel>, IAdvertImageValidation
    {
        public override void ValidateInsert(AdvertImageModel model)
        {
            base.ValidateInsert(model);

            this.AdvertHouseId_ImageMustHaveAdvertHouseId(model);
            this.ImageId_ImageMustHaveImageId(model);

            this.OnValidated();
        }

        public override void ValidateUpdate(AdvertImageModel model)
        {
            base.ValidateUpdate(model);

            this.AdvertHouseId_ImageMustHaveAdvertHouseId(model);
            this.ImageId_ImageMustHaveImageId(model);

            this.OnValidated();
        }

        private void AdvertHouseId_ImageMustHaveAdvertHouseId(AdvertImageModel model)
        {
            var message = "Esta imagem deve ser associada a um anuncio";
            if (model.AdvertHouseId == Guid.Empty)
                this.summary.AddError("AdvertHouse", message);
        }

        private void ImageId_ImageMustHaveImageId(AdvertImageModel model)
        {
            var message = "Esta imagem precisa ter um arquivo associado";
            if (model.ImageId == Guid.Empty)
                this.summary.AddError("AdvertHouse", message);
        }
    }
}