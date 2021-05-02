using Module.Dto.Address;
using Module.Dto.Base;
using Module.Service.Interface.Base;
using System.Collections.Generic;

namespace Module.Service.Interface.Address
{
    /// <summary>
    /// Serviço de municipios
    /// </summary>
    public interface ICountyService : IBaseReadEntityService<CountyDto, int>
    {
        /// <summary>
        /// Retorna o municipio correspondente ao código ibge informado
        /// </summary>
        /// <param name="ibgeCode">Código Ibge</param>
        /// <returns>Municipio</returns>
        CountyDto GetByIbgeCode(string ibgeCode);

        /// <summary>
        /// Obter seleção municipios
        /// </summary>
        /// <returns>Id do estado</returns>
        IEnumerable<GenericIntSelectDto> GetSelection(string uf);
    }
}