using Module.Dto.Base;

namespace Module.Dto.Address
{
    /// <summary>
    /// Endereço do anúncio de locação de imóvel
    /// </summary>
    public class AddressDto : BaseDto
    {
        /// <summary>
        /// Cep do imóvel
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Logradouro do imóvel
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Bairro do imóvel
        /// </summary>
        public string Neighborhood { get; set; }

        /// <summary>
        /// Número do imóvel
        /// </summary>
        public string AdressNumber { get; set; }

        /// <summary>
        /// Complemento do endereço
        /// </summary>
        public string Complement { get; set; }

        /// <summary>
        /// Cidade do imóvel
        /// </summary>
        public int CountyId { get; set; }

        /// <summary>
        /// Municipio do endereço
        /// </summary>
        public CountyDto CountyDto { get; set; }
    }
}