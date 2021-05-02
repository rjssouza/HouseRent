using Module.Dto.Base;
using System;

namespace Module.Dto.Sell
{
    /// <summary>
    /// Objeto de requisição de contato
    /// </summary>
    public class ContactRequestDto : BaseDto
    {
        /// <summary>
        /// Identificador do anuncio do imóvel
        /// </summary>
        public Guid AdvertHouseId { get; set; }

        /// <summary>
        /// Nome do solicitador
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Telefone do solicitador
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Celular do solicitador
        /// </summary>
        public string Cellphone { get; set; }

        /// <summary>
        /// Email do solicitador
        /// </summary>
        public string Mail { get; set; }
    }
}