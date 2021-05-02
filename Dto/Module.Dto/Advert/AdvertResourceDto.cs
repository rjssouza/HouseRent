using Module.Dto.Base;
using System;

namespace Module.Dto.Advert
{
    public class AdvertResourceDto : BaseDto
    {
        public string Description { get; set; }

        public Guid AdvertHouseId { get; set; }
    }
}