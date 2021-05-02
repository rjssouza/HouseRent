using Module.Dto.Advert;
using Module.Dto.Base;
using Module.Service.Interface.Base;
using System;
using System.Collections.Generic;

namespace Module.Service.Interface.Advert
{
    public interface IHouseTypeService : IBaseReadEntityService<HouseTypeDto, Guid>
    {
        IEnumerable<GenericGuidSelectDto> GetSelection();
    }
}