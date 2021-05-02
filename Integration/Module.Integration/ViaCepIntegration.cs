using Module.Dto;
using Module.Integration.Base;
using Module.Integration.Interface;
using System.Net.Http;

namespace Module.Integration
{
    /// <summary>
    /// Integração via cep
    /// </summary>
    public class ViaCepIntegration : BaseIntegration, IViaCepIntegration
    {
        public ViaCepIntegration(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        protected override string ApiAddress => this.Settings.ApiServicesUrl.ViaCepApiUrl;

        protected override string Name => "ViaCep";

        /// <summary>
        /// Efetua chamada externa ao serviço via cep e obtem o retorno
        /// </summary>
        /// <param name="cep">Cep</param>
        /// <returns>Via cep response</returns>
        public ViaCepResponseDto GetByCep(string cep)
        {
            var result = this.Get<ViaCepResponseDto>($"/{cep}/json/");

            return result;
        }
    }
}