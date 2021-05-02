using Module.Repository.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model.Address
{
    [Table("address")]
    public class AddressModel : BaseIdentityModel<Guid>
    {
        [Column("zipcode")]
        public string ZipCode { get; set; }

        [Column("street")]
        public string Street { get; set; }

        [Column("neighborhood")]
        public string Neighborhood { get; set; }

        [Column("adress_number")]
        public string AdressNumber { get; set; }

        [Column("complement")]
        public string Complement { get; set; }

        [Column("county_id")]
        public int CountyId { get; set; }
    }
}