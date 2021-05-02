using Module.Dto.Base;
using System;

namespace Module.Dto.Advert
{
    /// <summary>
    /// Anúncio para locação ou venda de imóvel
    /// </summary>
    public class AdvertHouseListItemDto : BaseDto
    {
        /// <summary>
        /// Nome do anunciante
        /// </summary>
        public string AdvertiserName { get; set; }

        /// <summary>
        /// Título do anúncio
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Descrição do anúncio de locação
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Tipo do imóvel anunciado (Lote, Terreno, Etc)
        /// </summary>
        public string HouseTypeName { get; set; }

        /// <summary>
        /// Endereço do imóvel formatado
        /// </summary>
        public string FormattedAddress { get; set; }

        /// <summary>
        /// Objetivo do anuncio
        /// </summary>
        public string AdvertGoalName { get; set; }

        /// <summary>
        /// Preço para efetuar a compra ou locação do imóvel no anúncio
        /// </summary>
        public Decimal Price { get; set; }

        /// <summary>
        /// Quantidade de banheiros
        /// </summary>
        public int QtdBathrooms { get; set; }

        /// <summary>
        /// Quantidade de quartos
        /// </summary>
        public int QtdBedromms { get; set; }

        /// <summary>
        /// Quantidade de salas
        /// </summary>
        public int QtdRooms { get; set; }

        /// <summary>
        /// Quantidade de suite
        /// </summary>
        public int QtdSuite { get; set; }

        /// <summary>
        /// Quantidade de garagem
        /// </summary>
        public int QtdGarage { get; set; }

        /// <summary>
        /// Primeira foto do anúncio do imóvel (principal)
        /// </summary>
        public byte[] AdvertFirstPicture { get; set; }
    }
}