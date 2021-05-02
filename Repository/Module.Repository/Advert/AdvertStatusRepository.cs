using Module.Dto.Base;
using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Advert;
using Module.Repository.Model.Advert;
using System.Collections.Generic;
using System.Text;

namespace Module.Repository.Advert
{
    public class AdvertStatusRepository : BaseCrudRepository<AdvertStatusModel>, IAdvertStatusRepository
    {
        public AdvertStatusRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }

        public IEnumerable<GenericGuidSelectDto> GetSelection()
        {
            var sql = new StringBuilder("select id as Value, name as Text from status  ");
            var result = this.Select<GenericGuidSelectDto>(sql.ToString());

            return result;
        }
    }
}