using Module.Dto.Base;
using System;

namespace Module.Dto.Advert
{
    /// <summary>
    /// Filtro para anuncios de imóveis
    /// </summary>
    public class AdvertHouseFilterDto : FilterBaseDto
    {
        /// <summary>
        /// Filtro por palavra chave do anúncio de imóvel (Título, Endereço ou Nome do Anunciante)
        /// </summary>
        public override string Keyword { get => base.Keyword; set => base.Keyword = value; }

        /// <summary>
        /// Identificador do tipo de imóvel anunciado
        /// 88CFDF0C-03AD-42EA-A003-5795D0ACEFAF - Casa
        /// 8DFF6055-BED8-48C2-A19B-807EA92EC97E - Lote
        /// 651D9E0D-1F55-4B3E-A750-DD26B62B27E9 - Apartamento
        /// </summary>
        /// <example>88CFDF0C-03AD-42EA-A003-5795D0ACEFAF</example>
        public Guid HouseTypeId { get; set; }
    }
}