using Module.Dto.Advertiser;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Advertiser
{
    public interface IContactService : IBaseEntityService<ContactDto, Guid>
    {
    }
}