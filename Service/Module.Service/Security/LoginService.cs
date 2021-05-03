using Microsoft.IdentityModel.Tokens;
using Module.Dto.Security;
using Module.Dto.User.Security;
using Module.Service.Base;
using Module.Service.Interface.Advertiser;
using Module.Service.Interface.Security;
using Module.Service.Validation.Interface.Security;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Module.Service.Security
{
    /// <summary>
    /// Serviço para login e acesso ao sistema
    /// </summary>
    public class LoginService : BaseService, ILoginService
    {
        public ILoginValidation LoginValidation { get; set; }
        public IUserLoginService UserLoginService { get; set; }
        public IAdvertiserService AdvertiserService { get; set; }

        /// <summary>
        /// Efetua o login do anunciante
        /// </summary>
        /// <param name="loginRequestDto">Requisição com usuário e senha preenchido</param>
        /// <returns>Token de acesso</returns>
        public string DoLogin(LoginRequestDto loginRequestDto)
        {
            this.LoginValidation.ValidateLogin(loginRequestDto);
            var userLogin = this.UserLoginService.GetByMail(loginRequestDto.Login);
            var tokenResult = this.GenerateToken(userLogin);

            return tokenResult;
        }

        /// <summary>
        /// Método para criar o token de acesso 
        /// </summary>
        /// <param name="userLogin">Entidade de login de usuário</param>
        /// <returns>Token de acesso</returns>
        private string GenerateToken(UserLoginDto userLogin)
        {
            var advertiserDto = this.AdvertiserService.GetByUserId(userLogin.Id);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Dto.Config.SettingsDto.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, advertiserDto.Name),
                    new Claim(ClaimTypes.HomePhone, advertiserDto.Contact?.Phone),
                    new Claim(ClaimTypes.Email, advertiserDto.Contact?.Mail),
                    new Claim(ClaimTypes.MobilePhone, advertiserDto.Contact?.Cellphone),
                    new Claim(ClaimTypes.Sid, advertiserDto.Id.ToString()),
                    new Claim(ClaimTypes.PrimarySid, userLogin.Id.ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}