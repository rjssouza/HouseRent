using Module.Dto.Advert;
using Module.Repository.Interface.Advert;
using Module.Repository.Model.Advert;
using Module.Service.Base;
using Module.Service.Interface.Address;
using Module.Service.Interface.Advert;
using System;

namespace Module.Service.Advert.AdvertHouse
{
    //TODO implementar regras
    public class AdvertHouseService : BaseEntityService<AdvertHouseModel, AdvertHouseDto, Guid, IAdvertHouseRepository>, IAdvertHouseService
    {
        public IAdvertResourceService AdvertResourceService { get; set; }
        public IAdvertImageService AdvertImageService { get; set; }
        public IAddressService AddressService { get; set; }
        public IAdvertGoalService AdvertGoalService { get; set; }
        public IHouseTypeService HouseTypeService { get; set; }
        public IAdvertStatusService AdvertStatusService { get; set; }
        public override IAdvertHouseRepository CrudRepository { get; set; }

        public override AdvertHouseDto GetById(Guid id)
        {
            var result = base.GetById(id);
            result.AdvertHousePictureList = this.AdvertImageService.GetAdvertHousePictureList(result.Id);
            result.HouseType = this.HouseTypeService.GetById(result.HouseTypeId);
            result.Status = this.AdvertStatusService.GetById(result.StatusId);
            result.AdvertGoal = this.AdvertGoalService.GetById(result.GoalId);

            return result;
        }
    }
}