using Module.Repository.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model.Address
{
    [Table("state")]
    public class StateModel : BaseModel
    {
        [Key]
        [Column("uf")]
        public string Uf { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("area_code")]
        public string AreaCode { get; set; }
    }
}