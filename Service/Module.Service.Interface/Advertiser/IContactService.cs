using Module.Dto.Advertiser;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Advertiser
{
    public interface IContactService : IBaseService
    {
        ContactDto GetById(Guid id);

        void Insert(ContactDto contactDto);

        void Update(ContactDto contactDto);

        void Delete(Guid id);
    }
}