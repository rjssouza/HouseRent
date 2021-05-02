using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Module.Dto.Address;
using WebApi.Base;

namespace WebApi.Controller
{
    /// <summary>
    /// Controller de teste de template
    /// </summary>
    [Route("api/values")]
    [ApiController]
    [AllowAnonymous]
    public class ValuesController : ServiceController
    {
        /// <summary>
        /// Obter informação de saúde da api
        /// </summary>
        /// <returns>Mensagem indicando o status da api</returns>
        [HttpGet]
        [ProducesResponseType(typeof(StateDto), 200)]
        public IActionResult Get()
        {
            var resultado = new StateDto()
            {
                Id = 31
            };
            return Ok(resultado);
        }
    }
}