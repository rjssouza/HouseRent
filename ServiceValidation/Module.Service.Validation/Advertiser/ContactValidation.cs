using Module.Repository.Model.Advertiser;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface.Advertiser;
using Module.Util;

namespace Module.Service.Validation.Advertiser
{
    public class ContactValidation : BaseCrudValidation<ContactModel>, IContactValidation
    {
        public override void ValidateInsert(ContactModel model)
        {
            base.ValidateInsert(model);
            this.Mail_ContactMustHaveMail(model);
            this.OnValidated();

            this.Mail_MailMustBeValid(model);
            this.OnValidated();
        }

        public override void ValidateUpdate(ContactModel model)
        {
            base.ValidateUpdate(model);
            this.Mail_ContactMustHaveMail(model);
            this.OnValidated();

            this.Mail_MailMustBeValid(model);
            this.OnValidated();
        }

        private void Mail_ContactMustHaveMail(ContactModel model)
        {
            var message = "É obrigatório informar o email de contato do anunciante";
            if (string.IsNullOrEmpty(model.Mail))
                this.summary.AddError("ContactModel", message);
        }

        private void Mail_MailMustBeValid(ContactModel model)
        {
            var message = "Este email é inválido";

            if (Utils.IsFakeMail(model.Mail))
                this.summary.AddError("ContactModel", message);
        }
    }
}