using Module.Dto.Base;
using System;

namespace Module.Dto.Advertiser
{
    public class AdvertiserDto : BaseDto
    {
        public string Name { get; set; }

        public Guid ContactId { get; set; }

        public Guid? PictureId { get; set; }

        public Guid UserId { get; set; }
    }
}