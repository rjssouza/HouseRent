using Module.Dto.Base;

namespace Module.Dto.Advertiser
{
    /// <summary>
    /// Dados para contato 
    /// </summary>
    public class ContactDto : BaseDto
    {
        /// <summary>
        /// Telefone fixo ou empresarial
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Email 
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Celular
        /// </summary>
        public string Cellphone { get; set; }
    }
}