using Module.Repository.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model.Advertiser
{
    [Table("contact")]
    public class ContactModel : BaseIdentityModel<Guid>
    {
        [Column("phone")]
        public string Phone { get; set; }

        [Column("mail")]
        public string Mail { get; set; }

        [Column("cellphone")]
        public string Cellphone { get; set; }
    }
}