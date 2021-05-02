using Module.Dto.Base;
using System;

namespace Module.Dto.Advert
{
    /// <summary>
    /// Recurso extra que o imóvel possui
    /// </summary>
    public class AdvertResourceDto : NameBaseDto
    {

        /// <summary>
        /// Identificador do anúncio
        /// </summary>
        public Guid AdvertHouseId { get; set; }
    }
}