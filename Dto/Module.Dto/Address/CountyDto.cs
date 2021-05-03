using Module.Dto.Base;

namespace Module.Dto.Address
{
    /// <summary>
    /// Dados da cidade
    /// </summary>
    public class CountyDto : NameBaseDto
    {
        /// <summary>
        /// Identificador da cidade
        /// </summary>
        /// <example>2310</example>
        public new int Id { get; set; }

        /// <summary>
        /// Código ibge
        /// </summary>
        /// <example>3106200</example>
        public string IbgeCode { get; set; }

        /// <summary>
        /// Unidade federativa que a cidade faz parte
        /// </summary>
        /// <example>MG</example>
        public string Uf { get; set; }

        /// <summary>
        /// Estado do municipio
        /// </summary>
        public StateDto State { get; set; }
    }
}