using Module.Dto.Base;
using System;
using System.ComponentModel;

namespace Module.Dto.Sell
{
    /// <summary>
    /// Objeto para venda do imóvel
    /// </summary>
    public class SellDto : BaseDto
    {
        /// <summary>
        /// Identificador de anuncio de locação de imóvel
        /// </summary>
        public Guid AdvertHouseId { get; set; }

        /// <summary>
        /// Preço combinado
        /// </summary>
        public Decimal Price { get; set; }

        /// <summary>
        /// Descrição da venda
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Requisição de contato que gerou a venda
        /// </summary>
        public string ContactRequestId { get; set; }
    }
}