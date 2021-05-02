using Module.Dto.Base;
using System;

namespace Module.Dto.Advert
{
    public class AdvertHouseFilterDto : FilterBaseDto
    {
        public Guid HouseTypeId { get; set; }
    }
}