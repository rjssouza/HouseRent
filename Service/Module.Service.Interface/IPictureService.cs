using Module.Dto;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface
{
    public interface IPictureService : IBaseEntityService<PictureDto, Guid>
    {
    }
}