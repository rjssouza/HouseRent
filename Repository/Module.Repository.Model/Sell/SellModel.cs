using Module.Repository.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model.Sell
{
    [Table("sell")]
    public class SellModel : BaseIdentityModel<Guid>
    {
        [Column("advert_house_id")]
        public Guid AdvertHouseId { get; set; }

        [Column("price")]
        public Decimal Price { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("contact_request_id")]
        public Guid ContactRequestId { get; set; }
    }
}