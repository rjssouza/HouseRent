using Module.Dto.Advertiser;
using Module.Dto.Base;
using System.Text.Json.Serialization;

namespace Module.Dto.User.Security
{
    /// <summary>
    /// Entidade de acesso
    /// </summary>
    public class UserLoginDto : BaseDto
    {
        /// <summary>
        /// Dados de login (email)
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Senha criptografada
        /// </summary>
        [JsonIgnore]
        public string PasswordHash { get; set; }

        /// <summary>
        /// Anunciante associado ao login
        /// </summary>
        public AdvertiserDto Advertiser { get; set; }
    }
}