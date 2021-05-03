using Module.Repository.Model.User;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface.Security;
using Module.Util;

namespace Module.Service.Validation.Security
{
    public class UserLoginValidation : BaseCrudValidation<UserLoginModel>, IUserLoginValidation
    {
        public override void ValidateInsert(UserLoginModel model)
        {
            base.ValidateInsert(model);
            this.Login_UserLoginMustBeInformed(model);
            this.Login_MailMustBeValid(model);
            this.Password_UserLoginMustHavePassword(model);

            this.OnValidated();
        }

        public override void ValidateUpdate(UserLoginModel model)
        {
            base.ValidateUpdate(model);
            this.Login_UserLoginMustBeInformed(model);
            this.Login_MailMustBeValid(model);
            this.Password_UserLoginMustHavePassword(model);

            this.OnValidated();
        }

        private void Login_UserLoginMustBeInformed(UserLoginModel model)
        {
            var message = "É obrigatório informar o nome do anunciante";
            if (string.IsNullOrEmpty(model.Login))
                this.summary.AddError("UserLogin", message);
        }

        private void Login_MailMustBeValid(UserLoginModel model)
        {
            var message = "Este email é inválido";

            if (Utils.IsFakeMail(model.Login))
                this.summary.AddError("ContactModel", message);
        }

        private void Password_UserLoginMustHavePassword(UserLoginModel model)
        {
            var message = "É obrigatório informar uma senha para o usuário";
            if (string.IsNullOrEmpty(model.PasswordHash))
                this.summary.AddError("UserLogin", message);
        }
    }
}