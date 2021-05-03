using Module.Dto.Advert;
using Module.Dto.Base;
using Module.Repository.Interface.Advert;
using Module.Service.Base;
using Module.Service.Interface.Advert;
using System.Collections.Generic;

namespace Module.Service.Advert.AdvertHouse
{
    public class AdvertHouseListViewService : BaseService, IAdvertHouseListViewService
    {
        public IAdvertHouseRepository AdvertHouseRepository { get; set; }
        public IAdvertGoalService AdvertGoalService { get; set; }
        public IHouseTypeService HouseTypeService { get; set; }

        /// <summary>
        /// Obtém lista de imóveis anunciados por filtro
        /// </summary>
        /// <param name="advertHouseFilter">Filtro lista de anúncios</param>
        /// <returns>Lista de imóveis anunciados por filtro</returns>
        public IEnumerable<AdvertHouseListItemDto> GetAdvertHouseList(AdvertHouseFilterDto advertHouseFilter)
        {
            var result = this.AdvertHouseRepository.GetAdvertHouseList(advertHouseFilter);

            return result;
        }

        /// <summary>
        /// Obtém dados para a tela de lista de anúncios
        /// </summary>
        /// <returns>Dados para tela de lista de anúncios</returns>
        public AdvertHouseListViewDto GetAdvertHouseListView()
        {
            var result = new AdvertHouseListViewDto()
            {
                AdvertGoalSelectList = this.AdvertGoalService.GetSelection(),
                HouseTypeSelectList = this.HouseTypeService.GetSelection(),
                OrderBySelectList = new List<BaseGenericSelectDto<string>>()
                {
                    new BaseGenericSelectDto<string>() { Text="Título", Value="advert_house.title" },
                    new BaseGenericSelectDto<string>() { Text="Preço", Value="advert_house.price" }
                }
            };

            return result;
        }
    }
}