using Module.Dto.Advertiser;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface.Advertiser;

namespace Module.Service.Validation.Advertiser
{
    public class AdvertiserManagerValidation : BaseValidation, IAdvertiserManagerValidation
    {
        public void ValidateRequest(AdvertiserUserDto advertiserUserDto)
        {
            this.Password_AdvertiserUserMustHavePassword(advertiserUserDto);
            this.OnValidated();

            this.Password_PasswordAndConfirmPasswordMustBeSame(advertiserUserDto);
            this.OnValidated();
        }

        private void Password_AdvertiserUserMustHavePassword(AdvertiserUserDto model)
        {
            var message = "É obrigatório informar uma senha para o usuário";
            if (string.IsNullOrEmpty(model.Password))
                this.summary.AddError("AdvertiserUserDto", message);
        }

        private void Password_PasswordAndConfirmPasswordMustBeSame(AdvertiserUserDto model)
        {
            var message = "É obrigatório informar uma senha para o usuário";
            if (model.Password != model.PassowrdConfirm)
                this.summary.AddError("AdvertiserUserDto", message);
        }
    }
}