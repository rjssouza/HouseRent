using Module.Dto.Advert;
using Module.Repository.Interface.Advert;
using Module.Repository.Model.Advert;
using Module.Service.Base;
using Module.Service.Interface.Advert;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Module.Service.Advert
{
    public class AdvertResourceService : BaseEntityService<AdvertResourceModel, AdvertResourceDto, Guid, IAdvertResourceRepository>, IAdvertResourceService
    {
        public override IAdvertResourceRepository CrudRepository { get; set; }

        public IEnumerable<AdvertResourceDto> GetAdvertHouseResourceList(Guid adverHouseId)
        {
            var resultModel = this.CrudRepository.GetByDynamicFilter(new { });
            var result = resultModel.Select(t => this.ObjectConverterFactory.ConvertTo<AdvertResourceDto>(t));

            return result;
        }
    }
}