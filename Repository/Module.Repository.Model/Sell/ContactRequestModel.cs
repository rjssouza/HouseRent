using Module.Repository.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model.Sell
{
    [Table("contact_request")]
    public class ContactRequestModel : BaseIdentityModel<Guid>
    {
        [Column("advert_house_id")]
        public Guid AdvertHouseId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("cellphone")]
        public string Cellphone { get; set; }

        [Column("mail")]
        public string Mail { get; set; }
    }
}