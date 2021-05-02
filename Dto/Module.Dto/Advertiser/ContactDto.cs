using Module.Dto.Base;

namespace Module.Dto.Advertiser
{
    public class ContactDto : BaseDto
    {
        public string Phone { get; set; }

        public string Mail { get; set; }

        public string Cellphone { get; set; }
    }
}