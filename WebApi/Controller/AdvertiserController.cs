using Microsoft.AspNetCore.Mvc;
using Module.Dto.Advertiser;
using Module.Service.Interface.Advertiser;

namespace WebApi.Controller
{
    /// <summary>
    /// Controller para cadastro de anunciante
    /// </summary>
    [Route("api/advertiser")]
    [ApiController]
    public class AdvertiserController : ControllerBase
    {
        /// <summary>
        /// Serviço para cadastro de anunciante
        /// </summary>
        public IAdvertiserManagerService AdvertiserManagerService { get; set; }

        /// <summary>
        /// Cadastrar anunciante, e gerar um login de acesso ao sistema
        /// </summary>
        /// <param name="advertiserUserDto">Objeto para requisição de cadastro para novo anunciante</param>
        /// <returns>Código Http 200</returns>
        [HttpPost]
        [ProducesResponseType(200)]
        public IActionResult Post([FromBody] AdvertiserUserDto advertiserUserDto)
        {
            this.AdvertiserManagerService.Register(advertiserUserDto);

            return Ok();
        }
    }
}