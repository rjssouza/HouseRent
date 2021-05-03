using Module.Dto.Advert;
using Module.Service.Interface.Base;
using System.Collections.Generic;

namespace Module.Service.Interface.Advert
{
    public interface IAdvertHouseListViewService : IBaseService
    {
        /// <summary>
        /// Obtém lista de imóveis anunciados por filtro
        /// </summary>
        /// <param name="advertHouseFilter">Filtro lista de anúncios</param>
        /// <returns>Lista de imóveis anunciados por filtro</returns>
        IEnumerable<AdvertHouseListItemDto> GetAdvertHouseList(AdvertHouseFilterDto advertHouseFilter);

        /// <summary>
        /// Obtém dados para a tela de lista de anúncios
        /// </summary>
        /// <returns>Dados para tela de lista de anúncios</returns>
        AdvertHouseListViewDto GetAdvertHouseListView();
    }
}