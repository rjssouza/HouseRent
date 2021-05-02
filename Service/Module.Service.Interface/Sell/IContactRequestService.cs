using Module.Dto.Sell;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Sell
{
    public interface IContactRequestService : IBaseService
    {
        void Insert(ContactRequestDto contactRequest);

        void Update(ContactRequestDto contactRequest);

        ContactRequestDto GetById(Guid id);

        void Delete(Guid id);
    }
}