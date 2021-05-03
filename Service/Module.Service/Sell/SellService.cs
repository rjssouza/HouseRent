using Module.Dto.Sell;
using Module.Repository.Interface.Sell;
using Module.Repository.Model.Sell;
using Module.Service.Base;
using Module.Service.Interface.Sell;
using Module.Service.Validation.Interface.Sell;
using System;

namespace Module.Service.Sell
{
    public class SellService : BaseEntityService<SellModel, SellDto, Guid, ISellRepository, ISellValidation>, ISellService
    {
        public override ISellRepository CrudRepository { get; set; }
        public override ISellValidation CrudValidation { get; set; }
    }
}