using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Advert;
using Module.Repository.Model.Advert;

namespace Module.Repository.Advert
{
    public class AdvertImageRepository : BaseCrudRepository<AdvertImageModel>, IAdvertImageRepository
    {
        public AdvertImageRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }
    }
}