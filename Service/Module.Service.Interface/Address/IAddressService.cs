using Module.Dto.Address;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Address
{
    public interface IAddressService : IBaseEntityService<AddressDto, Guid>
    {
        AddressDto GetAdressByZipCode(string cep);
    }
}