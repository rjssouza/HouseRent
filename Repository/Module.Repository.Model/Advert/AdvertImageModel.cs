using Module.Repository.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model.Advert
{
    [Table("advert_image")]
    public class AdvertImageModel : BaseIdentityModel<Guid>
    {
        [Column("image_id")]
        public Guid ImageId { get; set; }

        [Column("advert_house_id")]
        public Guid AdvertHouseId { get; set; }

        [Column("order")]
        public int Order { get; set; }
    }
}