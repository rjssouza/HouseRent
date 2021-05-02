using Module.Dto.Base;
using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Address;
using Module.Repository.Model.Address;
using System.Collections.Generic;
using System.Text;

namespace Module.Repository.Address
{
    public class StateRepository : BaseCrudRepository<StateModel>, IStateRepository
    {
        public StateRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }

        public IEnumerable<BaseGenericSelectDto<string>> GetSelection()
        {
            var sql = new StringBuilder("select uf as Value, name as Name from state ");
            var result = this.Select<BaseGenericSelectDto<string>>(sql.ToString());

            return result;
        }
    }
}