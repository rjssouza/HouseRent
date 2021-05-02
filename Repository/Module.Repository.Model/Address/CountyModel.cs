using Module.Repository.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model.Address
{
    [Table("county")]
    public class CountyModel : BaseIdentityModel<int>
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("ibge_code")]
        public string IbgeCode { get; set; }

        [Column("uf")]
        public string Uf { get; set; }
    }
}