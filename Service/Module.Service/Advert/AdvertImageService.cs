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
    public class AdvertImageService : BaseEntityService<AdvertImageModel, AdvertImageDto, Guid, IAdvertImageRepository>, IAdvertImageService
    {
        public override IAdvertImageRepository CrudRepository { get; set; }

        public IEnumerable<AdvertImageDto> GetAdvertHousePictureList(Guid advertHouseId)
        {
            var resultModel = this.CrudRepository.GetByDynamicFilter(new { advert_house_id = advertHouseId });
            var result = resultModel.Select(t => this.ObjectConverterFactory.ConvertTo<AdvertImageDto>(t));

            return result;
        }
    }
}