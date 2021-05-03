using Module.Dto.Base;
using System.ComponentModel;

namespace Module.Dto.Address
{
    /// <summary>
    /// Dados estado
    /// </summary>
    public class StateDto : NameBaseDto
    {
        /// <summary>
        /// Identificador do estado
        /// </summary>
        /// <example>31</example>
        public new int Id { get; set; }

        /// <summary>
        /// Unidade federativa
        /// </summary>
        /// <example>MG</example>
        public string Uf { get; set; }

        /// <summary>
        /// Código de área
        /// </summary>
        /// <example>31</example>
        public string AreaCode { get; set; }
    }
}