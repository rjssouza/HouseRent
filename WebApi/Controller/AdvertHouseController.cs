using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Module.Dto.Advert;
using Module.Dto.Advert.AdvertHouse;
using Module.Dto.Sell;
using Module.Service.Interface.Advert;
using System;
using WebApi.Base;

namespace WebApi.Controller
{
    /// <summary>
    /// Controller para lista de anúncio
    /// </summary>
    [Route("api/advert-house")]
    [ApiController]
    [Authorize]
    public class AdvertHouseController : ServiceController
    {
        /// <summary>
        /// Serviço para visualizar e gerenciar anuncio
        /// </summary>
        public IAdvertHouseManagerViewService AdvertHouseManagerViewService { get; set; }

        /// <summary>
        /// Obtém dados para obter dados para view de cadastro de um novo anúncio de imóvel para locação ou compra
        /// </summary>
        /// <returns>Dados para cadastro de novo anúncio</returns>
        [HttpGet]
        [ProducesResponseType(typeof(AdvertHouseViewDto), 200)]
        [AllowAnonymous]
        public IActionResult Get()
        {
            var advertHouseListView = this.AdvertHouseManagerViewService.GetAdvertView();

            return Ok(advertHouseListView);
        }

        /// <summary>
        /// Obtém dados para a view de edição ou visualização do anúncio de imóvel para locação ou compra
        /// </summary>
        /// <param name="advertHouseId">Identificador do anúncio</param>
        /// <returns>Dados para edição ou visão de novo anúncio</returns>
        [HttpGet("{advertHouseId}")]
        [ProducesResponseType(typeof(AdvertHouseViewDto), 200)]
        [AllowAnonymous]
        public IActionResult Get(Guid advertHouseId)
        {
            var advertHouseListView = this.AdvertHouseManagerViewService.GetAdvertView(advertHouseId);

            return Ok(advertHouseListView);
        }

        /// <summary>
        /// Chamada para salvar informações do anúncio
        /// </summary>
        /// <param name="createAdvertHouseRequestDto">Requisição para salvar anúncio</param>
        /// <returns>Http Resposta 200</returns>
        [HttpPost()]
        [ProducesResponseType(200)]
        public IActionResult Post([FromBody] CreateAdvertHouseRequestDto createAdvertHouseRequestDto)
        {
            this.AdvertHouseManagerViewService.CreateAdvertHouse(createAdvertHouseRequestDto);

            return Ok();
        }

        /// <summary>
        /// Chamada para editar informações do anúncio
        /// </summary>
        /// <param name="createAdvertHouseRequestDto">Requisição para salvar anúncio</param>
        /// <returns>Http Resposta 200</returns>
        [HttpPut()]
        [ProducesResponseType(200)]
        public IActionResult Put([FromBody] CreateAdvertHouseRequestDto createAdvertHouseRequestDto)
        {
            this.AdvertHouseManagerViewService.UpdateAdvertHouse(createAdvertHouseRequestDto);

            return Ok();
        }

        /// <summary>
        /// Eftua a venda ou locação de um imóvel a partir de um contato
        /// </summary>
        /// <param name="advertHouseId">Identificador do anúncio</param>
        /// <param name="contactRequestId">Identificador do contato</param>
        /// <returns></returns>
        [HttpGet("/sell/{advertHouseId}/{contactRequestId}")]
        [ProducesResponseType(200)]
        public IActionResult Sell(Guid advertHouseId, Guid contactRequestId)
        {
            this.AdvertHouseManagerViewService.SellAdvert(advertHouseId, contactRequestId);

            return Ok();
        }

        /// <summary>
        /// Envia requisição para contato a partir de um anúncio
        /// </summary>
        /// <param name="contactRequestDto">Requisição de contato</param>
        /// <returns>Http Resposta 200</returns>
        [HttpPost("/request-contact")]
        [ProducesResponseType(200)]
        [AllowAnonymous]
        public IActionResult SendContactRequest([FromBody] ContactRequestDto contactRequestDto)
        {
            this.AdvertHouseManagerViewService.SendContactRequest(contactRequestDto);

            return Ok();
        }
    }
}