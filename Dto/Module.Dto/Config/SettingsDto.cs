using Module.Dto.Base;

namespace Module.Dto.Config
{
    /// <summary>
    /// Objeto de configurações do sistema (acessado por todas as camadas)
    /// </summary>
    public class SettingsDto : BaseDto
    {
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