using Module.Repository.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model.Advert
{
    [Table("advert_house")]
    public class AdvertHouseModel : BaseIdentityModel<Guid>
    {
        [Column("advertiser_id")]
        public Guid AdvertiserId { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("house_type_id")]
        public Guid HouseTypeId { get; set; }

        [Column("address_id")]
        public Guid AdressId { get; set; }

        [Column("goal_id")]
        public Guid GoalId { get; set; }

        [Column("status_id")]
        public Guid StatusId { get; set; }

        [Column("internal_area_size")]
        public Decimal? InternalAreaSize { get; set; }

        [Column("external_area_size")]
        public Decimal? ExternalAreaSize { get; set; }

        [Column("price")]
        public Decimal Price { get; set; }

        [Column("qtd_bathrooms")]
        public int QtdBathrooms { get; set; }

        [Column("qtd_bedrooms")]
        public int QtdBedromms { get; set; }

        [Column("qtd_rooms")]
        public int QtdRooms { get; set; }

        [Column("qtd_suite")]
        public int QtdSuite { get; set; }

        [Column("qtd_garage")]
        public int QtdGarage { get; set; }
    }
}