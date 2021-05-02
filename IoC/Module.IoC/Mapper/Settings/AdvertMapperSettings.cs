using AutoMapper;
using Module.Dto.Advert;
using Module.Repository.Model.Advert;

namespace Module.IoC.Mapper
{
    public partial class ObjectConverter
    {
        /// <summary>
        /// Configurações de mapeamento para objetos de entidade e dto do anúncio de imóvel
        /// </summary>
        /// <param name="mapperConfigExpression">Interface de configuração mapper</param>
        public void ConfigureAdvertMapper(ref IMapperConfigurationExpression mapperConfigExpression)
        {
            // Anuncio de imovel
            mapperConfigExpression.CreateMap<AdvertHouseDto, AdvertHouseModel>();
            mapperConfigExpression.CreateMap<AdvertHouseModel, AdvertHouseDto>();

            // Finalidade do anúncio
            mapperConfigExpression.CreateMap<AdvertGoalDto, AdvertGoalModel>();
            mapperConfigExpression.CreateMap<AdvertGoalModel, AdvertGoalDto>();

            // Finalidade do anúncio
            mapperConfigExpression.CreateMap<AdvertImageDto, AdvertImageModel>();
            mapperConfigExpression.CreateMap<AdvertImageModel, AdvertImageDto>();

            // Recursos extras que o imovel possui
            mapperConfigExpression.CreateMap<AdvertResourceDto, AdvertResourceModel>();
            mapperConfigExpression.CreateMap<AdvertResourceModel, AdvertResourceDto>();

            // Status do anuncio de imovel
            mapperConfigExpression.CreateMap<AdvertStatusDto, AdvertStatusModel>();
            mapperConfigExpression.CreateMap<AdvertStatusModel, AdvertStatusDto>();

            // Tipo do imóvel
            mapperConfigExpression.CreateMap<HouseTypeDto, HouseTypeModel>();
            mapperConfigExpression.CreateMap<HouseTypeModel, HouseTypeDto>();
        }
    }
}