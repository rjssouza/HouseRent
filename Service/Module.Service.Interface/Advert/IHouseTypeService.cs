using Module.Dto.Advert;
using Module.Dto.Base;
using Module.Service.Interface.Base;
using System;
using System.Collections.Generic;

namespace Module.Service.Interface.Advert
{
    public interface IHouseTypeService : IBaseService
    {
        IEnumerable<GenericGuidSelectDto> GetSelection();

        HouseTypeDto GetById(Guid id);
    }
}