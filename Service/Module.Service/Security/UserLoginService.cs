using Module.Dto.User.Security;
using Module.Repository.Interface;
using Module.Repository.Model.User;
using Module.Service.Base;
using Module.Service.Interface.Security;
using Module.Service.Validation.Interface.Security;
using System;

namespace Module.Service.Security
{
    public class UserLoginService : BaseEntityService<UserLoginModel, UserLoginDto, Guid, IUserLoginRepository, IUserLoginValidation>, IUserLoginService
    {
        public override IUserLoginRepository CrudRepository { get; set; }
        public override IUserLoginValidation CrudValidation { get; set; }

        public UserLoginDto GetByMail(string mail)
        {
            var model = this.CrudRepository.GetFirstEntityByDynamicFilter(new { login = mail });
            var userLoginDto = this.ObjectConverterFactory.ConvertTo<UserLoginDto>(model);

            return userLoginDto;
        }
    }
}