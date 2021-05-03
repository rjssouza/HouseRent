using Module.Dto.Security;
using Module.Dto.User.Security;
using Module.Service.Interface.Security;
using Module.Service.Validation.Base;
using Module.Service.Validation.Interface.Security;

namespace Module.Service.Validation.Security
{
    public class LoginValidation : BaseValidation, ILoginValidation
    {
        public IUserLoginService UserLoginService { get; set; }

        public void ValidateLogin(LoginRequestDto loginRequestDto)
        {
            var userLogin = this.UserLoginService.GetByMail(loginRequestDto.Login);

            this.UserLogin_UserLoginMustExists(userLogin);
            this.OnValidated();

            this.Password_PasswordMustBeValid(userLogin, loginRequestDto);
            this.OnValidated();
        }

        private void UserLogin_UserLoginMustExists(UserLoginDto userLoginDto)
        {
            var message = "Usuário não encontrado";
            if (userLoginDto == null)
                this.summary.AddError("UserLogin", message);
        }

        private void Password_PasswordMustBeValid(UserLoginDto userLoginDto, LoginRequestDto loginRequestDto)
        {
            var message = "A senha informada está incorreta";
            bool verified = BCrypt.Net.BCrypt.Verify(loginRequestDto.Password, userLoginDto.PasswordHash);

            if (!verified)
                this.summary.AddError("UserLogin", message);
        }
    }
}