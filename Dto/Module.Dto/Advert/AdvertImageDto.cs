using Module.Dto.Base;
using System;

namespace Module.Dto.Advert
{
    /// <summary>
    /// Foto do imóvel
    /// </summary>
    public class AdvertImageDto : BaseDto
    {
        /// <summary>
        /// Identificador da imagem no repositorio
        /// </summary>
        public Guid ImageId { get; set; }

        /// <summary>
        /// Identificador do anúncio
        /// </summary>
        public Guid AdvertHouseId { get; set; }

        /// <summary>
        /// Ordem de exibição das fotos
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Imagem do anuncio em base 64
        /// </summary>
        public byte[] ImageArray { get; set; }
    }
}