using Module.Repository.Model.Advertiser;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface.Advertiser;
using System;

namespace Module.Service.Validation.Advertiser
{
    public class AdvertiserValidation : BaseCrudValidation<AdvertiserModel>, IAdvertiserValidation
    {
        public override void ValidateInsert(AdvertiserModel model)
        {
            base.ValidateInsert(model);

            this.Name_AdvertHouseMustHaveName(model);
            this.UserId_AdvertHouseMustHaveUserId(model);

            this.OnValidated();
        }

        public override void ValidateUpdate(AdvertiserModel model)
        {
            base.ValidateUpdate(model);

            this.Name_AdvertHouseMustHaveName(model);
            this.UserId_AdvertHouseMustHaveUserId(model);

            this.OnValidated();
        }

        private void Name_AdvertHouseMustHaveName(AdvertiserModel model)
        {
            var message = "É obrigatório informar o nome do anunciante";
            if (string.IsNullOrEmpty(model.Name))
                this.summary.AddError("Advertiser", message);
        }

        private void UserId_AdvertHouseMustHaveUserId(AdvertiserModel model)
        {
            var message = "É obrigatório associar o anuciante a um login";
            if (model.UserId == Guid.Empty)
                this.summary.AddError("Advertiser", message);
        }
    }
}