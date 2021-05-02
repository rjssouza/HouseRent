using Module.Dto.Base;

namespace Module.Dto.Address
{
    /// <summary>
    /// Dados da cidade
    /// </summary>
    public class CountyDto : BaseDto
    {
        /// <summary>
        /// Identificador da cidade
        /// </summary>
        public new int Id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Código ibge
        /// </summary>
        public string IbgeCode { get; set; }

        /// <summary>
        /// Unidade federativa que a cidade faz parte
        /// </summary>
        public string Uf { get; set; }
    }
}