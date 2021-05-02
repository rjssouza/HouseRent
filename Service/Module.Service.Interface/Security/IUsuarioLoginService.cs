﻿using Module.Dto.User.Security;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Security
{
    public interface IUsuarioLoginService : IBaseEntityService<UserLoginDto, Guid>
    {
    }
}