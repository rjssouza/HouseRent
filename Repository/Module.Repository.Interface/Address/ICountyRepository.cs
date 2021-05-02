using Module.Dto.Address;
using Module.Dto.Base;
using Module.Repository.Interface.Base;
using Module.Repository.Model.Address;
using System.Collections.Generic;

namespace Module.Repository.Interface.Address
{
    public interface ICountyRepository : IBaseCrudRepository<CountyModel>
    {
        /// <summary>
        /// Obter seleção municipios 
        /// </summary>
        /// <returns>Id do estado</returns>
        IEnumerable<GenericIntSelectDto> GetSelection(int stateId);
    }
}