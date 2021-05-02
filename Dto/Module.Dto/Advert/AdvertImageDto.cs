using Module.Dto.Base;
using System;

namespace Module.Dto.Advert
{
    public class AdvertImageDto : BaseDto
    {
        public Guid ImageId { get; set; }

        public Guid AdvertHouseId { get; set; }

        public int Order { get; set; }
    }
}