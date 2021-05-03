using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Module.Dto.Advert;
using Module.Service.Interface.Advert;
using System.Collections.Generic;
using WebApi.Base;

namespace WebApi.Controller
{
    /// <summary>
    /// Controller para lista de anúncio
    /// </summary>
    [Route("api/advert-house-list")]
    [ApiController]
    [AllowAnonymous]
    public class AdvertHouseListController : ServiceController
    {
        /// <summary>
        /// Serviço para lista de anúncio de imóveis
        /// </summary>
        public IAdvertHouseListViewService AdvertHouseListViewService { get; set; }

        /// <summary>
        /// Obtém dados para a tela de lista de anúncios
        /// </summary>
        /// <returns>Dados para tela de lista de anúncios</returns>
        [HttpGet]
        [ProducesResponseType(typeof(AdvertHouseListViewDto), 200)]
        public IActionResult Get()
        {
            var advertHouseListView = this.AdvertHouseListViewService.GetAdvertHouseListView();

            return Ok(advertHouseListView);
        }

        /// <summary>
        /// Obtém lista de imóveis anunciados por filtro
        /// </summary>
        /// <param name="advertHouseFilter">Filtro lista de anúncios</param>
        /// <returns>Lista de imóveis anunciados por filtro</returns>
        [HttpPost]
        [ProducesResponseType(typeof(IEnumerable<AdvertHouseListItemDto>), 200)]
        public IActionResult Post([FromBody] AdvertHouseFilterDto advertHouseFilter)
        {
            var advertHouseListView = this.AdvertHouseListViewService.GetAdvertHouseList(advertHouseFilter);

            return Ok(advertHouseListView);
        }
    }
}