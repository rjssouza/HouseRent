using Module.Dto.Base;

namespace Module.Dto
{
    /// <summary>
    /// Imagem de repositorio 
    /// </summary>
    public class PictureDto : NameBaseDto
    {
        /// <summary>
        /// Objeto base 64 do objeto para exibição no cliente
        /// </summary>
        public byte[] Array { get; set; }
    }
}