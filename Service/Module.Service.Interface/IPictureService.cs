using Module.Dto;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface
{
    public interface IPictureService : IBaseService
    {
        PictureDto GetById(Guid id);

        Guid Insert(PictureDto pictureDto);

        void Update(PictureDto pictureDto);

        void Delete(Guid id);
    }
}