using Module.Dto.Base;
using System.ComponentModel;

namespace Module.Dto.Address
{
    /// <summary>
    /// Dados estado
    /// </summary>
    public class StateDto : BaseDto
    {
        /// <summary>
        /// Identificador do estado
        /// </summary>
        public new int Id { get; set; }

        /// <summary>
        /// Unidade federativa
        /// </summary>
        /// <example>MG</example>
        public string Uf { get; set; }

        /// <summary>
        /// Nome do estado
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Código de área
        /// </summary>
        public string AreaCode { get; set; }
    }
}