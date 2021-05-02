using Module.Dto.Sell;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Sell
{
    public interface ISellService : IBaseService
    {
        SellDto GetById(Guid id);

        void Insert(SellDto sellDto);

        void Update(SellDto sellDto);

        void Delete(Guid id);
    }
}