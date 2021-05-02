using Module.Dto.Address;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Address
{
    public interface IAddressService : IBaseService
    {
        AddressDto GetAdressByZipCode(string cep);

        AddressDto GetById(Guid id);

        void Insert(AddressDto addressDto);

        void Update(AddressDto addressDto);

        void Delete(Guid id);
    }
}