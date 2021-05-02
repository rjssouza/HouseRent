using Module.Dto.Address;
using Module.Integration.Interface;
using Module.Repository.Interface.Address;
using Module.Repository.Model.Address;
using Module.Service.Base;
using Module.Service.Interface.Address;
using System;

namespace Module.Service.Address
{
    public class AddressService : BaseService, IAddressService
    {
        public IAddressRepository AddressRepository { get; set; }
        public IViaCepIntegration ViaCepIntegration { get; set; }
        public ICountyService CountyService { get; set; }

        public void Delete(Guid id)
        {
            var addressModel = this.AddressRepository.GetEntityById(id);
            this.OpenTransaction();
            this.AddressRepository.Delete(addressModel);

            this.Commit();
        }

        public AddressDto GetAdressByZipCode(string cep)
        {
            var viaCepResult = this.ViaCepIntegration.GetByCep(cep);
            var countyDto = this.CountyService.GetByIbgeCode(viaCepResult.IbgeCode);
            var result = this.ObjectConverterFactory.ConvertTo<AddressDto>(viaCepResult);
            result.CountyDto = countyDto;
            result.CountyId = countyDto.Id;

            return result;
        }

        public AddressDto GetById(Guid id)
        {
            var addressModel = this.AddressRepository.GetEntityById(id);
            var addressDto = this.ObjectConverterFactory.ConvertTo<AddressDto>(addressModel);

            return addressDto;
        }

        public void Insert(AddressDto addressDto)
        {
            var addressModel = this.ObjectConverterFactory.ConvertTo<AddressModel>(addressDto);
            this.OpenTransaction();
            this.AddressRepository.Insert(addressModel);

            this.Commit();
        }

        public void Update(AddressDto addressDto)
        {
            var addressModel = this.ObjectConverterFactory.ConvertTo<AddressModel>(addressDto);
            this.OpenTransaction();
            this.AddressRepository.Update(addressModel);

            this.Commit();
        }
    }
}