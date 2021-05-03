using Module.Dto.Security;
using Module.Service.Base;
using Module.Service.Interface.Security;
using Module.Service.Validation.Interface.Security;
using System;

namespace Module.Service.Security
{
    /// <summary>
    /// Serviço para login e acesso ao sistema
    /// </summary>
    public class LoginService : BaseService, ILoginService
    {
        public ILoginValidation LoginValidation { get; set; }

        /// <summary>
        /// Efetua o login do anunciante
        /// </summary>
        /// <param name="loginRequestDto">Requisição com usuário e senha preenchido</param>
        /// <returns>Token de acesso</returns>
        public string DoLogin(LoginRequestDto loginRequestDto)
        {
            this.LoginValidation.ValidateLogin(loginRequestDto);

            throw new NotImplementedException();
        }
    }
}