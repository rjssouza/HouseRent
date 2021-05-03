using Module.Repository.Model.Sell;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface.Sell;
using Module.Util;

namespace Module.Service.Validation.Sell
{
    public class ContactRequestValidation : BaseCrudValidation<ContactRequestModel>, IContactRequestValidation
    {
        public override void ValidateInsert(ContactRequestModel model)
        {
            base.ValidateInsert(model);
            this.Phone_ContactMustPhone(model);
            this.Cellphone_ContactMustCellphone(model);
            this.Mail_ContactMustHaveMail(model);
            this.Mail_MailMustBeValid(model);

            this.OnValidated();
        }

        public override void ValidateUpdate(ContactRequestModel model)
        {
            base.ValidateUpdate(model);
            this.Phone_ContactMustPhone(model);
            this.Cellphone_ContactMustCellphone(model);
            this.Mail_ContactMustHaveMail(model);
            this.Mail_MailMustBeValid(model);

            this.OnValidated();
        }

        private void Phone_ContactMustPhone(ContactRequestModel model)
        {
            var message = "É obrigatório informar o telefone para requisição de contato";
            if (string.IsNullOrEmpty(model.Phone))
                this.summary.AddError("ContactRequestModel", message);
        }

        private void Cellphone_ContactMustCellphone(ContactRequestModel model)
        {
            var message = "É obrigatório informar o celular para requisição de contato";
            if (string.IsNullOrEmpty(model.Cellphone))
                this.summary.AddError("ContactRequestModel", message);
        }

        private void Mail_ContactMustHaveMail(ContactRequestModel model)
        {
            var message = "É obrigatório informar o email para requisição de contato";
            if (string.IsNullOrEmpty(model.Mail))
                this.summary.AddError("ContactRequestModel", message);
        }

        private void Mail_MailMustBeValid(ContactRequestModel model)
        {
            var message = "Este email é inválido";

            if (Utils.IsFakeMail(model.Mail))
                this.summary.AddError("ContactRequestModel", message);
        }
    }
}