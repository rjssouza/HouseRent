﻿using Module.Dto.Base;
using Module.Repository.Interface.Base;
using Module.Repository.Model.Advert;
using System.Collections.Generic;

namespace Module.Repository.Interface.Advert
{
    public interface IHouseTypeRepository : IBaseCrudRepository<HouseTypeModel>
    {
        IEnumerable<GenericGuidSelectDto> GetSelection();
    }
}