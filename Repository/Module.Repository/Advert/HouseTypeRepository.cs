using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Advert;
using Module.Repository.Model.Advert;

namespace Module.Repository.Advert
{
    public class HouseTypeRepository : BaseCrudRepository<HouseTypeModel>, IHouseTypeRepository
    {
        public HouseTypeRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }
    }
}