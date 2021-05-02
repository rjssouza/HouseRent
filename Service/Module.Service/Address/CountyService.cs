using Module.Dto.Address;
using Module.Dto.Base;
using Module.Repository.Interface.Address;
using Module.Repository.Model.Address;
using Module.Service.Base;
using Module.Service.Interface.Address;
using System.Collections.Generic;

namespace Module.Service.Address
{
    public class CountyService : BaseEntityService<CountyModel, CountyDto, int, ICountyRepository>, ICountyService
    {
        public IStateRepository StateRepository { get; set; }
        public override ICountyRepository CrudRepository { get; set; }

        public CountyDto GetByIbgeCode(string ibgeCode)
        {
            var countyModel = this.CrudRepository.GetFirstEntityByDynamicFilter(new { ibge_code = ibgeCode });
            var countyDto = this.ObjectConverterFactory.ConvertTo<CountyDto>(countyModel);
            countyDto.State = this.GetCountyState(countyDto.Uf);

            return countyDto;
        }

        public IEnumerable<GenericIntSelectDto> GetSelection(string uf)
        {
            var result = this.CrudRepository.GetSelection(uf);

            return result;
        }

        private StateDto GetCountyState(string uf)
        {
            var stateModel = this.StateRepository.GetEntityById<string>(uf);
            var resultado = this.ObjectConverterFactory.ConvertTo<StateDto>(stateModel);

            return resultado;
        }
    }
}