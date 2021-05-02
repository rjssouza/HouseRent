using Module.Dto.Base;

namespace Module.Dto.User
{
    public class UserLoginDto : BaseDto
    {
        public string Login { get; set; }

        public string PasswordHash { get; set; }
    }
}