using Module.Factory.Interface.Conexao;
using Module.Repository.Base;
using Module.Repository.Interface.Sell;
using Module.Repository.Model.Sell;

namespace Module.Repository.Sell
{
    public class ContactRequestRepository : BaseCrudRepository<ContactRequestModel>, IContactRequestRepository
    {
        public ContactRequestRepository(IDbConnectionFactory dbService) : base(dbService)
        {
        }
    }
}