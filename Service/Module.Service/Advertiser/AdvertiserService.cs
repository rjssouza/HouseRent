using Module.Dto.Advertiser;
using Module.Repository.Interface.Advertiser;
using Module.Repository.Model.Advertiser;
using Module.Service.Base;
using Module.Service.Interface.Advertiser;
using System;

namespace Module.Service.Advertiser
{
    public class AdvertiserService : BaseEntityService<AdvertiserModel, AdvertiserDto, Guid, IAdvertiserRepository>, IAdvertiserService
    {
        public override IAdvertiserRepository CrudRepository { get; set; }
    }
}