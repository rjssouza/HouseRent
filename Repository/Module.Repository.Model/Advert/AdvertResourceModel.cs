using Module.Repository.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model.Advert
{
    [Table("advert_resource")]
    public class AdvertResourceModel : BaseIdentityModel<Guid>
    {
        [Column("description")]
        public string Description { get; set; }

        [Column("advert_house_id")]
        public Guid AdvertHouseId { get; set; }
    }
}