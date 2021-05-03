using Module.Dto.Advert;
using Module.Repository.Interface.Base;
using Module.Repository.Model.Advert;
using System.Collections.Generic;

namespace Module.Repository.Interface.Advert
{
    public interface IAdvertHouseRepository : IBaseCrudRepository<AdvertHouseModel>
    {
        /// <summary>
        /// Obtém lista de imóveis anunciados por filtro
        /// </summary>
        /// <param name="advertHouseFilter">Filtro lista de anúncios</param>
        /// <returns>Lista de imóveis anunciados por filtro</returns>
        IEnumerable<AdvertHouseListItemDto> GetAdvertHouseList(AdvertHouseFilterDto advertHouseFilter);
    }
}