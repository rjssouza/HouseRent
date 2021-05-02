using AutoMapper;
using Module.Dto;
using Module.Dto.Address;
using Module.Repository.Model.Address;

namespace Module.IoC.Mapper
{
    public partial class ObjectConverter
    {
        /// <summary>
        /// Configurações de mapeamento para objetos de entidade e dto do endereço de anúncio do imóvel
        /// </summary>
        /// <param name="mapperConfigExpression">Mapper configuration expression</param>
        public void ConfigureAddressMapper(ref IMapperConfigurationExpression mapperConfigExpression)
        {
            // Mapeamento de endereço
            mapperConfigExpression.CreateMap<AddressDto, AddressModel>();
            mapperConfigExpression.CreateMap<AddressModel, AddressDto>();
            mapperConfigExpression.CreateMap<ViaCepResponseDto, AddressDto>();

            // Mapeamento cidade
            mapperConfigExpression.CreateMap<CountyDto, CountyModel>();
            mapperConfigExpression.CreateMap<CountyModel, CountyDto>();

            // Mapeamento estado
            mapperConfigExpression.CreateMap<StateDto, StateModel>();
            mapperConfigExpression.CreateMap<StateModel, StateDto>();
        }
    }
}