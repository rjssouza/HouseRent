using Module.Dto.Advertiser;
using Module.Repository.Interface.Advertiser;
using Module.Repository.Model.Advertiser;
using Module.Service.Base;
using Module.Service.Interface.Advertiser;
using System;

namespace Module.Service.Advertiser
{
    public class ContactService : BaseEntityService<ContactModel, ContactDto, Guid, IContactRepository>, IContactService
    {
        public override IContactRepository CrudRepository { get; set; }
    }
}