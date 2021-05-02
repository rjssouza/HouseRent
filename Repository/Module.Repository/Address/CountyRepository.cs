using Dapper;
using Module.Dto.Address;
using Module.Dto.Base;
using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Address;
using Module.Repository.Model.Address;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module.Repository.Address
{
    public class CountyRepository : BaseCrudRepository<CountyModel>, ICountyRepository
    {
        public CountyRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }

        /// <summary>
        /// Obter seleção municipios 
        /// </summary>
        /// <returns>Id do estado</returns>
        public IEnumerable<GenericIntSelectDto> GetSelection(string uf)
        {
            var sql = new StringBuilder("select id as Value, name as Text from county where uf = @uf ");
            var param = new DynamicParameters();
            param.Add("uf", uf);
            var result = this.Select<GenericIntSelectDto>(sql.ToString(), param);

            return result;
        }
    }
}