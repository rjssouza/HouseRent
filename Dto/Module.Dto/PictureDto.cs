using Module.Dto.Base;

namespace Module.Dto
{
    public class PictureDto : BaseDto
    {
        public string Name { get; set; }

        public byte[] Array { get; set; }
    }
}