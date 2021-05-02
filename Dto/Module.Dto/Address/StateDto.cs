using Module.Dto.Base;

namespace Module.Dto.Address
{
    public class StateDto : BaseDto
    {
        public new int Id { get; set; }
        public string Uf { get; set; }

        public string Name { get; set; }

        public string AreaCode { get; set; }
    }
}