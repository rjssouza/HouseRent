using Module.Dto.Address;
using Module.Integration.Interface;
using Module.Repository.Interface.Address;
using Module.Repository.Model.Address;
using Module.Service.Base;
using Module.Service.Interface.Address;
using Module.Service.Validation.Interface.Address;
using System;

namespace Module.Service.Address
{
    public class AddressService : BaseEntityService<AddressModel, AddressDto, Guid, IAddressRepository, IAddressValidation>, IAddressService
    {
        public IViaCepIntegration ViaCepIntegration { get; set; }
        public ICountyService CountyService { get; set; }
        public override IAddressRepository CrudRepository { get; set; }
        public override IAddressValidation CrudValidation { get; set; }

        public AddressDto GetAdressByZipCode(string cep)
        {
            var viaCepResult = this.ViaCepIntegration.GetByCep(cep);
            var countyDto = this.CountyService.GetByIbgeCode(viaCepResult.IbgeCode);
            var result = this.ObjectConverterFactory.ConvertTo<AddressDto>(viaCepResult);
            result.CountyDto = countyDto;
            result.CountyId = countyDto.Id;

            return result;
        }

        public override AddressDto GetById(Guid id)
        {
            var result = base.GetById(id);
            result.CountyDto = this.CountyService.GetById(result.CountyId);

            return result;
        }
    }
}