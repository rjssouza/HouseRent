using Module.Dto.Base;

namespace Module.Dto.Advertiser
{
    /// <summary>
    /// Objeto para requisição de cadastro para novo anunciante
    /// </summary>
    public class AdvertiserUserDto : NameBaseDto
    {
        /// <summary>
        /// Email de do anunciante
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Senha 
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Confirmação de senha
        /// </summary>
        public string PassowrdConfirm { get; set; }

        /// <summary>
        /// Informações de contato
        /// </summary>
        public ContactDto ContactInfo { get; set; }

        /// <summary>
        /// Foto do anunciante em base 64
        /// </summary>
        public byte[] Picture { get; set; }
    }
}