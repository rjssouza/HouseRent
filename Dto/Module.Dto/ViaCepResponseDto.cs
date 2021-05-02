using Module.Dto.Base;
using Newtonsoft.Json;

namespace Module.Dto
{
    /// <summary>
    /// Retorno via cep
    /// </summary>
    public class ViaCepResponseDto : BaseDto
    {
        /// <summary>
        /// Cep 
        /// </summary>
        [JsonProperty("cep")]
        public string ZipCode { get; set; }

        /// <summary>
        /// Logradouro do endereço
        /// </summary>
        [JsonProperty("logradouro")]
        public string Street { get; set; }

        /// <summary>
        /// Complemento do endereço
        /// </summary>
        [JsonProperty("complemento")]
        public string Complement { get; set; }

        /// <summary>
        /// Bairro 
        /// </summary>
        [JsonProperty("bairro")]
        public string Neighborhood { get; set; }

        /// <summary>
        /// Municipio 
        /// </summary>
        [JsonProperty("localidade")]
        public string CountyName { get; set; }

        /// <summary>
        /// Unidade federativa endereço
        /// </summary>
        [JsonProperty("uf")]
        public string Uf { get; set; }

        /// <summary>
        /// Código ibge
        /// </summary>
        [JsonProperty("ibge")]
        public string IbgeCode { get; set; }
    }
}