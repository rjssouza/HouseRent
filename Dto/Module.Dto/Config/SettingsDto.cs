using Module.Dto.Base;

namespace Module.Dto.Config
{
    /// <summary>
    /// Objeto de configurações do sistema (acessado por todas as camadas)
    /// </summary>
    public class SettingsDto : BaseDto
    {
        private const string PRIVATE_SECRET = "fedaf7d8863b48e197b9287d492b708e";

        /// <summary>
        /// Segredo para chave JWT token
        /// </summary>
        public static string Secret => PRIVATE_SECRET;

        /// <summary>
        /// Conexões com banco de dados
        /// </summary>
        public DbSettingsDto DbConnection { get; set; }

        /// <summary>
        /// Endereços de api de integração externa
        /// </summary>
        public ExternalApiSettingsDto ApiServicesUrl { get; set; }
    }
}