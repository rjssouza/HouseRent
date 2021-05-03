using Module.Dto.Advertiser;
using Module.Repository.Interface.Advertiser;
using Module.Repository.Model.Advertiser;
using Module.Service.Base;
using Module.Service.Interface.Advertiser;
using Module.Service.Validation.Interface.Advertiser;
using System;

namespace Module.Service.Advertiser
{
    public class AdvertiserService : BaseEntityService<AdvertiserModel, AdvertiserDto, Guid, IAdvertiserRepository, IAdvertiserValidation>, IAdvertiserService
    {
        public override IAdvertiserRepository CrudRepository { get; set; }
        public override IAdvertiserValidation CrudValidation { get; set; }

        public AdvertiserDto GetByUserId(Guid userId)
        {
            var model = this.CrudRepository.GetFirstEntityByDynamicFilter(new { user_id = userId });
            var result = this.ObjectConverterFactory.ConvertTo<AdvertiserDto>(model);

            return result;
        }
    }
}