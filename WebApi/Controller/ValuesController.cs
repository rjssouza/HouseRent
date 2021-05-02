using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Get()
        {
            return Ok("Estou bem");
        }
    }
}