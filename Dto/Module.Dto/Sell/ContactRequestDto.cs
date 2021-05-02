using Module.Dto.Base;
using System;

namespace Module.Dto.Sell
{
    public class ContactRequestDto : BaseDto
    {
        public Guid AdvertHouseId { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Cellphone { get; set; }

        public string Mail { get; set; }
    }
}