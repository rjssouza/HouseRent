using Module.Dto.Sell;
using Module.Repository.Interface.Sell;
using Module.Repository.Model.Sell;
using Module.Service.Base;
using System;

namespace Module.Service.Sell
{
    public class ContactRequestService : BaseEntityService<ContactRequestModel, ContactRequestDto, Guid, IContactRequestRepository>
    {
        public override IContactRequestRepository CrudRepository { get; set; }
    }
}