using AutoMapper;
using Module.Dto.Sell;
using Module.Repository.Model.Sell;

namespace Module.IoC.Mapper
{
    public partial class ObjectConverter
    {
        /// <summary>
        /// Configurações de mapeamento para objetos de venda realizada do imovel
        /// </summary>
        /// <param name="mapperConfigExpression">Interface de configuração mapper</param>
        public void ConfigureSellMapper(ref IMapperConfigurationExpression mapperConfigExpression)
        {
            // Venda do imóvel
            mapperConfigExpression.CreateMap<SellDto, SellModel>();
            mapperConfigExpression.CreateMap<SellModel, SellDto>();

            // Requisição de contato do imovel
            mapperConfigExpression.CreateMap<ContactRequestDto, ContactRequestModel>();
            mapperConfigExpression.CreateMap<ContactRequestModel, ContactRequestDto>();
        }
    }
}