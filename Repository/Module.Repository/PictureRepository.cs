using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface;
using Module.Repository.Model;

namespace Module.Repository
{
    public class PictureRepository : BaseCrudRepository<PictureModel>, IPictureRepository
    {
        public PictureRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }
    }
}