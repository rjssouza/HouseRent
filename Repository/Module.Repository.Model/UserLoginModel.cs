using Module.Repository.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.Repository.Model.User
{
    [Table("user_login")]
    public class UserLoginModel : BaseIdentityModel<Guid>
    {
        [Column("login")]
        public string Login { get; set; }

        [Column("password_hash")]
        public string PasswordHash { get; set; }
    }
}