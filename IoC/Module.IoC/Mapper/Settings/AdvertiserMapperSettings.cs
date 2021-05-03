using AutoMapper;
using Module.Dto.Advertiser;
using Module.Dto.User.Security;
using Module.Repository.Model.Advertiser;
using Module.Repository.Model.User;

namespace Module.IoC.Mapper
{
    public partial class ObjectConverter
    {
        /// <summary>
        /// Configurações de mapeamento do anunciante
        /// </summary>
        /// <param name="mapperConfigExpression">Interface de configuração mapper</param>
        public void ConfigureAdvertiserMapper(ref IMapperConfigurationExpression mapperConfigExpression)
        {
            // Mapeamento anunciante
            mapperConfigExpression.CreateMap<AdvertiserDto, AdvertiserModel>();
            mapperConfigExpression.CreateMap<AdvertiserModel, AdvertiserDto>();
            mapperConfigExpression.CreateMap<AdvertiserUserDto, AdvertiserDto>();

            // Mapeamento dados de contato
            mapperConfigExpression.CreateMap<ContactDto, ContactModel>();
            mapperConfigExpression.CreateMap<ContactModel, ContactDto>();

            // Mapeamento usuario de login
            mapperConfigExpression.CreateMap<UserLoginDto, UserLoginModel>();
            mapperConfigExpression.CreateMap<UserLoginModel, UserLoginDto>();
        }
    }
}