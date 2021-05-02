﻿using Module.Dto.Advert;
using Module.Dto.Base;
using Module.Service.Interface.Base;
using System;
using System.Collections.Generic;

namespace Module.Service.Interface.Advert
{
    public interface IAdvertGoalService : IBaseService
    {
        IEnumerable<GenericGuidSelectDto> GetSelection();

        AdvertGoalDto GetById(Guid id);
    }
}