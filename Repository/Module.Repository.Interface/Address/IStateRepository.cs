using Module.Dto.Base;
using Module.Repository.Interface.Base;
using Module.Repository.Model.Address;
using System.Collections.Generic;

namespace Module.Repository.Interface.Address
{
    public interface IStateRepository : IBaseCrudRepository<StateModel>
    {
        IEnumerable<BaseGenericSelectDto<string>> GetSelection();
    }
}