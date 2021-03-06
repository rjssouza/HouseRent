using Module.Dto.Security;
using Module.Service.Interface.Base;

namespace Module.Service.Interface.Security
{
    /// <summary>
    /// Serviço para login e acesso ao sistema
    /// </summary>
    public interface ILoginService : IBaseService
    {
        /// <summary>
        /// Efetua o login do anunciante
        /// </summary>
        /// <param name="loginRequestDto">Requisição com usuário e senha preenchido</param>
        /// <returns>Token de acesso</returns>
        string DoLogin(LoginRequestDto loginRequestDto);
    }
}