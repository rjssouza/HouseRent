using Module.Repository.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model.Advertiser
{
    [Table("advertiser")]
    public class AdvertiserModel : BaseIdentityModel<Guid>
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("contact_id")]
        public Guid? ContactId { get; set; }

        [Column("picture_id")]
        public Guid? PictureId { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }
    }
}