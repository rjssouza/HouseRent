using Module.Dto.Base;
using System;
using System.Collections.Generic;

namespace Module.Dto.Advert
{
    /// <summary>
    /// Anúncio para locação ou venda de imóvel
    /// </summary>
    public class AdvertHouseListViewDto : BaseDto
    {
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