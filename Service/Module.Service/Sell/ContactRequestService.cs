using Module.Dto.Sell;
using Module.Repository.Interface.Sell;
using Module.Repository.Model.Sell;
using Module.Service.Base;
using Module.Service.Interface.Sell;
using Module.Service.Validation.Interface.Sell;
using System;

namespace Module.Service.Sell
{
    public class ContactRequestService : BaseEntityService<ContactRequestModel, ContactRequestDto, Guid, IContactRequestRepository, IContactRequestValidation>, IContactRequestService
    {
        public override IContactRequestRepository CrudRepository { get; set; }
        public override IContactRequestValidation CrudValidation { get; set; }
    }
}