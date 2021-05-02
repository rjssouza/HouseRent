using Module.Repository.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model.Advert
{
    [Table("house_type")]
    public class HouseTypeModel : BaseIdentityModel<Guid>
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }
    }
}