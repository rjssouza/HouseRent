using Module.Dto.Base;
using System.Collections.Generic;

namespace Module.Dto.Advert
{
    /// <summary>
    /// Objeto auxiliar para construção da camada de visão para tela de edição ou cadastro de novo anúncio para locação de imóvel
    /// </summary>
    public class AdvertHouseViewDto : BaseDto
    {
        /// <summary>
        /// Anúncio de locação de imóvel existente
        /// </summary>
        public AdvertHouseDto AdvertHouse { get; set; }

        /// <summary>
        /// Lista para seleção do tipo de imóvel
        /// </summary>
        public IEnumerable<GenericGuidSelectDto> HouseTypeSelectList { get; set; }

        /// <summary>
        /// Lista para seleção do objetivo do anúncio
        /// </summary>
        public IEnumerable<GenericGuidSelectDto> AdvertGoalSelectList { get; set; }
    }
}