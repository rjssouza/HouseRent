using Module.Dto.Address;
using Module.Dto.Base;
using Module.Repository.Interface.Address;
using Module.Service.Base;
using Module.Service.Interface.Address;
using System.Collections.Generic;

namespace Module.Service.Address
{
    public class CountyService : BaseService, ICountyService
    {
        public ICountyRepository CountyRepository { get; set; }
        public IStateRepository StateRepository { get; set; }

        public CountyDto GetByIbgeCode(string ibgeCode)
        {
            var countyModel = this.CountyRepository.GetFirstEntityByDynamicFilter(new { ibge_code = ibgeCode });
            var countyDto = this.ObjectConverterFactory.ConvertTo<CountyDto>(countyModel);
            countyDto.State = this.GetCountyState(countyDto.Uf);

            return countyDto;
        }

        public CountyDto GetById(int id)
        {
            var model = this.CountyRepository.GetEntityById<int>(id);
            var resultado = this.ObjectConverterFactory.ConvertTo<CountyDto>(model);

            return resultado;
        }

        public IEnumerable<GenericIntSelectDto> GetSelection(int stateId)
        {
            var result = this.CountyRepository.GetSelection(stateId);

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