using Module.Dto;
using Module.Integration.Interface.Base;

namespace Module.Integration.Interface
{
    /// <summary>
    /// Integração via cep
    /// </summary>
    public interface IViaCepIntegration : IBaseIntegration
    {
        /// <summary>
        /// Efetua chamada externa ao serviço via cep e obtem o retorno
        /// </summary>
        /// <param name="cep">Cep</param>
        /// <returns>Via cep response</returns>
        ViaCepResponseDto GetByCep(string cep);
    }
}