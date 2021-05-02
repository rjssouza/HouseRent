using Module.Dto.Advert;
using Module.Service.Interface.Base;
using System;

namespace Module.Service.Interface.Advert
{
    /// <summary>
    /// Serviço para CRUD de anúncio de locação de imoveis 
    /// </summary>
    public interface IAdvertHouseService : IBaseEntityService<AdvertHouseDto, Guid>
    {

    }
}