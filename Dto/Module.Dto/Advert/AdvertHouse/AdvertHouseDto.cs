using Module.Dto.Address;
using Module.Dto.Base;
using System;
using System.Collections.Generic;

namespace Module.Dto.Advert
{
    /// <summary>
    /// Anúncio para locação ou venda de imóvel
    /// </summary>
    public class AdvertHouseDto : BaseDto
    {
        /// <summary>
        /// Identificador do anunciante
        /// </summary>
        public Guid AdvertiserId { get; set; }

        /// <summary>
        /// Título do anúncio (será exibido no cabeçalho da pagina do anúncio)
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Descrição do anúncio de locação
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Tipo do imóvel anunciado (Lote, Terreno, Etc)
        /// </summary>
        public Guid HouseTypeId { get; set; }

        /// <summary>
        /// Identificador do endereço do imóvel
        /// </summary>
        public Guid AdressId { get; set; }

        /// <summary>
        /// Identificador da inteção para este anúncio (Locação ou Venda)
        /// </summary>
        public Guid GoalId { get; set; }

        /// <summary>
        /// Status do anúncio
        /// </summary>
        public Guid StatusId { get; set; }

        /// <summary>
        /// Tamanho da área interna
        /// </summary>
        public Decimal? InternalAreaSize { get; set; }

        /// <summary>
        /// Tamanho da área externa
        /// </summary>
        public Decimal? ExternalAreaSize { get; set; }

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
        /// Lista de fotos do imóvel anunciado para locação ou compra
        /// </summary>
        public IEnumerable<AdvertImageDto> AdvertHousePictureList { get; set; }

        /// <summary>
        /// Lista de recursos extras que o imóvel anunciado possui
        /// </summary>
        public IEnumerable<AdvertResourceDto> AdvertResourceList { get; set; }

        /// <summary>
        /// Enereço do imóvel disponível para locação
        /// </summary>
        public AddressDto Address { get; set; }

        /// <summary>
        /// Intenção do anúncio (aluguel ou compra)
        /// </summary>
        public AdvertGoalDto AdvertGoal { get; set; }

        /// <summary>
        /// Tipo do imóvel (casa, apartamento, lote, etc..)
        /// </summary>
        public HouseTypeDto HouseType { get; set; }

        /// <summary>
        /// Status do anúncio (vendido, publicado)
        /// </summary>
        public AdvertStatusDto Status { get; set; }
    }
}