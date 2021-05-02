using Module.Dto.Base;
using System;

namespace Module.Dto.Advert
{
    public class AdvertHouseDto : BaseDto
    {
        public Guid AdvertiserId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Guid HouseTypeId { get; set; }

        public Guid AdressId { get; set; }

        public Guid GoalId { get; set; }

        public Guid StatusId { get; set; }

        public Decimal? InternalAreaSize { get; set; }

        public Decimal? ExternalAreaSize { get; set; }

        public Decimal Price { get; set; }

        public int QtdBathrooms { get; set; }

        public int QtdBedromms { get; set; }

        public int QtdRooms { get; set; }

        public int QtdSuite { get; set; }

        public int QtdGarage { get; set; }
    }
}