using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Module.Dto.Security;
using Module.Service.Interface.Security;

namespace WebApi.Controller
{
    /// <summary>
    /// Controller para login para área do anúnciante
    /// </summary>
    [Route("api/login")]
    [ApiController]
    [AllowAnonymous]
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// Serviço de login
        /// </summary>
        public ILoginService LoginService { get; set; }

        /// <summary>
        /// Requisição para token de acesso de login para utilizar os serviços de área do anunciante
        /// </summary>
        /// <param name="loginRequestDto">Requisição de login</param>
        /// <returns>Token de acesso</returns>
        [HttpPost]
        [ProducesResponseType(typeof(string), 200)]
        public IActionResult Post([FromBody] LoginRequestDto loginRequestDto)
        {
            var accessToken = this.LoginService.DoLogin(loginRequestDto);

            return Ok(accessToken);
        }
    }
}