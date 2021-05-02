using Module.Dto.Advert;
using Module.Dto.Base;
using Module.Repository.Interface.Advert;
using Module.Repository.Model.Advert;
using Module.Service.Base;
using Module.Service.Interface.Advert;
using System;
using System.Collections.Generic;

namespace Module.Service.Advert
{
    public class AdvertStatusService : BaseEntityService<AdvertStatusModel, AdvertStatusDto, Guid, IAdvertStatusRepository>, IAdvertStatusService
    {
        public override IAdvertStatusRepository CrudRepository { get; set; }

        public IEnumerable<GenericGuidSelectDto> GetSelection()
        {
            var result = this.CrudRepository.GetSelection();

            return result;
        }
    }
}