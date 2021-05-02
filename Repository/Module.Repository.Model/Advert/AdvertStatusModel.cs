using Module.Repository.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model.Advert
{
    [Table("advert_status")]
    public class AdvertStatusModel : BaseIdentityModel<Guid>
    {
        [Column("name")]
        public string Name { get; set; }
    }
}