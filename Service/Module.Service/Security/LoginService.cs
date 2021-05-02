using Module.Dto.Security;
using Module.Service.Base;
using Module.Service.Interface.Security;
using System;

namespace Module.Service.Security
{
    /// <summary>
    /// Serviço para login e acesso ao sistema
    /// </summary>
    public class LoginService : BaseService, ILoginService
    {
        /// <summary>
        /// Efetua o login do anunciante
        /// </summary>
        /// <param name="loginRequestDto">Requisição com usuário e senha preenchido</param>
        /// <returns>Token de acesso</returns>
        public string DoLogin(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}