using Module.Dto.Sell;
using Module.Repository.Interface.Sell;
using Module.Repository.Model.Sell;
using Module.Service.Base;
using System;

namespace Module.Service.Sell
{
    public class SellService : BaseEntityService<SellModel, SellDto, Guid, ISellRepository>
    {
        public override ISellRepository CrudRepository { get; set; }
    }
}