using Module.Repository.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model
{
    [Table("picture")]
    public class PictureModel : BaseIdentityModel<Guid>
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("array")]
        public byte[] Array { get; set; }
    }
}