using Module.Dto.Base;
using System;

namespace Module.Dto.Sell
{
    public class SellDto : BaseDto
    {
        public Guid AdvertHouseId { get; set; }

        public Decimal Price { get; set; }

        public string Description { get; set; }
        public string ContactRequestId { get; set; }
    }
}