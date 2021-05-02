using Module.Dto.Base;
using System;

namespace Module.Dto.Advertiser
{
    /// <summary>
    /// Dados do anunciante
    /// </summary>
    public class AdvertiserDto : NameBaseDto
    {
        /// <summary>
        /// Identificador do contato do anunciante
        /// </summary>
        public Guid ContactId { get; set; }

        /// <summary>
        /// Foto do anunciante
        /// </summary>
        public Guid? PictureId { get; set; }

        /// <summary>
        /// Dados para contato
        /// </summary>
        public ContactDto Contato { get; set; }

        /// <summary>
        /// Usuario de segurança associado ao anunciante para login
        /// </summary>
        public Guid UserId { get; set; }
    }
}