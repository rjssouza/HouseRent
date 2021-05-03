using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Module.Dto.Address;
using Module.Service.Interface.Address;
using WebApi.Base;

namespace WebApi.Controller
{
    /// <summary>
    /// Controller de endereço
    /// </summary>
    [Route("api/address")]
    [ApiController]
    [AllowAnonymous]
    public class AddressController : ServiceController
    {
        /// <summary>
        /// Serviço de endereço
        /// </summary>
        public IAddressService AddressService { get; set; }

        /// <summary>
        /// Obtém dados de endereço a partir do cep
        /// </summary>
        /// <param name="zipCode">Cep do endereço</param>
        /// <returns>Endereço preenchido</returns>
        [HttpGet]
        [Route("{zipCode}")]
        [ProducesResponseType(typeof(AddressDto), 200)]
        public IActionResult GetAdressByZipCode(string zipCode)
        {
            var result = this.AddressService.GetAdressByZipCode(zipCode);

            return Ok(result);
        }
    }
}