using Module.Dto.Base;

namespace Module.Dto.Address
{
    public class AddressDto : BaseDto
    {
        public string ZipCode { get; set; }

        public string Street { get; set; }

        public string Neighborhood { get; set; }

        public string AdressNumber { get; set; }

        public string Complement { get; set; }

        public int CountyId { get; set; }
    }
}