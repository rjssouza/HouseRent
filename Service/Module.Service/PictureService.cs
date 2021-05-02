using Module.Dto;
using Module.Repository.Interface;
using Module.Repository.Model;
using Module.Service.Base;
using Module.Service.Interface;
using System;

namespace Module.Service
{
    //TODO implementar regras
    public class PictureService : BaseEntityService<PictureModel, PictureDto, Guid, IPictureRepository>, IPictureService
    {
        public override IPictureRepository CrudRepository { get; set; }
    }
}