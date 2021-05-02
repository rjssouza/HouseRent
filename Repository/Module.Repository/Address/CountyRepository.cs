using Module.Dto.Address;
using Module.Dto.Base;
using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Address;
using Module.Repository.Model.Address;
using System;
using System.Collections.Generic;

namespace Module.Repository.Address
{
    public class CountyRepository : BaseCrudRepository<CountyModel>, ICountyRepository
    {
        public CountyRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }

        public IEnumerable<GenericIntSelectDto> GetSelection(int stateId)
        {
            throw new System.NotImplementedException();
        }
    }
}