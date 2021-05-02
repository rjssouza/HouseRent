using Module.Dto.Base;

namespace Module.Dto.Address
{
    public class CountyDto : BaseDto
    {
        public new int Id { get; set; }
        public string Name { get; set; }

        public string IbgeCode { get; set; }

        public string Uf { get; set; }
    }
}