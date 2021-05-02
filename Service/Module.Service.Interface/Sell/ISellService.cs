using Module.Dto.Sell;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Sell
{
    public interface ISellService : IBaseEntityService<SellDto, Guid>
    {
    }
}